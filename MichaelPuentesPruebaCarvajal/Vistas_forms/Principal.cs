using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MichaelPuentesPruebaCarvajal.Modelos;
using MichaelPuentesPruebaCarvajal.Controles;

namespace MichaelPuentesPruebaCarvajal
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            
            //var Milistad = cs_administrador.getAllFromBD();
            LB_usuarioActual.Text += ": " + cs_global.UsuarioActual.username;
            //TraerTodalAinfoDeVuelos
            //llenar ciudades y aerolineas
            CB_Aerolinea.DataSource = cs_Aerolinea.getAllFromBD();
            CB_Aerolinea.DisplayMember = cs_Aerolinea.DisplayName;
            var TodasLasCiudades = cs_Ciudades.getAllFromBD();
            CB_CiudadDestino.DataSource = TodasLasCiudades;
            CB_CiudadDestino.DisplayMember = cs_Ciudades.DisplayMember;

            CB_ciudadOrigen.BindingContext = new BindingContext(); //to avoid duplicade in memory
            CB_ciudadOrigen.DataSource = TodasLasCiudades;
            CB_ciudadOrigen.DisplayMember = cs_Ciudades.DisplayMember;
            var misVuelos = cs_vuelosSalientes.getAllFromBD();
            DGV_Vuelos.DataSource = misVuelos;
            CB_EstadoVuelo.DataSource = Enum.GetNames(typeof(Numeradores.EstadoVuelo));
            actualizarTabla();

        }

        private void BTN_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CB_CiudadDestino_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CB_ciudadOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Ingresar_Click(object sender, EventArgs e)
        {
            string FormatTime = "HH:mm:ss";
            int EstadoVelo = (int)(Numeradores.EstadoVuelo)Enum.Parse(typeof(Numeradores.EstadoVuelo), CB_EstadoVuelo.SelectedItem.ToString());
            //int EstadoDeVuelo = (int)(Numeradores.EstadoVuelo)CB_EstadoVuelo.SelectedItem;
            cs_vuelosSalientes.IngresarVuelo(((cs_Ciudades)CB_ciudadOrigen.SelectedItem).Id_ciudad,
                ((cs_Ciudades)CB_CiudadDestino.SelectedItem).Id_ciudad, DT_Fecha.Value,
                DT_HoraSalida.Value.ToString(FormatTime), DT_HoraLlegada.Value.ToString(FormatTime), TB_NumeroVuelo.Text, 
                ((cs_Aerolinea)CB_Aerolinea.SelectedItem).Id_Aerolinea, EstadoVelo);
            actualizarTabla();
        }
        private void actualizarTabla()
        {
            try
            {
                DataTable scores = new DataTable();
                scores.Columns.Add("Ciudad Origen", typeof(string));
                scores.Columns.Add("Ciudad Destino", typeof(string));
                scores.Columns.Add("Fecha", typeof(string));
                scores.Columns.Add("Hora Salida", typeof(string));
                scores.Columns.Add("Hora Llegada", typeof(string));
                scores.Columns.Add("Numero de Vuelo", typeof(string));
                scores.Columns.Add("Aerolinea", typeof(string));
                scores.Columns.Add("Estado del Vuelo", typeof(string));

                foreach (cs_vuelosSalientes gp in cs_vuelosSalientes.getAllFromBD())
                {
                    DataRow nRow = scores.NewRow();

                    //cs_productos prod = gp.get_producto();
                    nRow["Ciudad Origen"] = gp.CiudadOrigen.NombreCiudad;
                    nRow["Ciudad Destino"] = gp.CiudadDestino.NombreCiudad;
                    nRow["Fecha"] = gp.Fecha.ToString("D");
                    nRow["Hora Salida"] = gp.HoraSalida;
                    nRow["Hora Llegada"] = gp.HoraLlegada;
                    nRow["Numero de Vuelo"] = gp.NumeroVuelo;
                    nRow["Aerolinea"] = gp.Aerolinea.NombreAerolinea;
                    nRow["Estado del Vuelo"] = ((Numeradores.EstadoVuelo)gp.EstadoVuelo).ToString();
                    scores.Rows.Add(nRow);
                }

                DGV_Vuelos.DataSource = scores;

                foreach (DataGridViewColumn c in DGV_Vuelos.Columns)
                {
                    c.ReadOnly = true;
                    c.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
            catch (Exception ex)
            {
                cs_Logger.Log(string.Format("Excepcion: {0}", ex), (int)cs_Logger.LogerLevel.ERROR);
            }
        }
    }
}
