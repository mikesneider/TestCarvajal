using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Data;

namespace MichaelPuentesPruebaCarvajal.Modelos
{
    class cs_vuelosSalientes
    {

        #region NombreTablas
        private static string tn_name = "VuelosSalientes";
        private static string tc_id_VuelosSalientes = "Id_VuelosSalientes";
        private static string tc_CityOrigen = "CiudadOrigen";
        private static string tc_CityDestino = "CiudadDestino";
        private static string tc_fecha = "Fecha";
        private static string tc_HoraSalida = "HoraSalida";
        private static string tc_HoraLlegada = "HoraLlegada";
        private static string tc_NumeroVuelo = "NumeroVuelo";
        private static string tc_Aerolinea = "Aerolinea";
        private static string tc_EstadoVuelo = "EstadoVuelo";
        #endregion

        #region Constructor
        public int vuelosSalientes { get; set; }
        public cs_Ciudades CiudadOrigen { get; set; }
        public cs_Ciudades CiudadDestino { get; set; }
        public DateTime Fecha { get; set; }
        public string HoraSalida { get; set; }
        public string HoraLlegada { get; set; }
        public string NumeroVuelo { get; set; }
        public cs_Aerolinea Aerolinea { get; set; }
        public int EstadoVuelo { get; set; }

        public cs_vuelosSalientes(int vuelosSalientes, cs_Ciudades ciudadOrigen, cs_Ciudades ciudadDestino, DateTime fecha, string horaSalida, string horaLlegada, string numeroVuelo, cs_Aerolinea aerolinea, int estadoVuelo)
        {
            this.vuelosSalientes = vuelosSalientes;
            CiudadOrigen = ciudadOrigen;
            CiudadDestino = ciudadDestino;
            Fecha = fecha;
            HoraSalida = horaSalida;
            HoraLlegada = horaLlegada;
            NumeroVuelo = numeroVuelo;
            Aerolinea = aerolinea;
            EstadoVuelo = estadoVuelo;
        }
        #endregion

        /// <summary>
        /// Funcion para Ingresar Nuevos Vuelos
        /// </summary>
        /// <param name="CiudadOrigen">Ciudad de Origen</param>
        /// <param name="CiudadDestino">Ciduad de Destino</param>
        /// <param name="Fecha">Fecha</param>
        /// <param name="HoraSalida">Hora de Salida</param>
        /// <param name="HoraLlegada">Hora de Llegada</param>
        /// <param name="NumeroVuelo">Numero de Vuelo</param>
        /// <param name="Aerolinea">Aerolinea</param>
        /// <param name="EstadoVuelo">Estado del Vuelo</param>
        /// <returns>True si el ingreso fue correcto</returns>
        public static bool IngresarVuelo(int CiudadOrigen, int CiudadDestino, DateTime Fecha,
            string HoraSalida, string HoraLlegada, string NumeroVuelo, int Aerolinea,
            int EstadoVuelo)
        {
            
            string QUERY = "INSERT INTO " + tn_name + " (" + tc_Aerolinea + "," + tc_CityDestino + "," + tc_CityOrigen + "," + tc_EstadoVuelo + "," + tc_fecha+ ","+tc_HoraLlegada+ ","+tc_HoraSalida+ ","+ tc_NumeroVuelo+ ") VALUES " +
                " (@" + tc_Aerolinea + ",@" + tc_CityDestino + ",@" + tc_CityOrigen + ",@" + tc_EstadoVuelo + ",@" + tc_fecha + ",@" + tc_HoraLlegada + ",@" + tc_HoraSalida + ",@" + tc_NumeroVuelo + ")";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@" + tc_Aerolinea, Aerolinea);
            parameters.Add("@" + tc_CityDestino, CiudadDestino);
            parameters.Add("@" + tc_CityOrigen, CiudadOrigen);
            parameters.Add("@" + tc_EstadoVuelo, EstadoVuelo);
            parameters.Add("@" + tc_fecha, Fecha);
            parameters.Add("@" + tc_HoraLlegada, HoraLlegada);
            parameters.Add("@" + tc_HoraSalida, HoraSalida);
            parameters.Add("@" + tc_NumeroVuelo, NumeroVuelo);
            bool Rta = BDConexion.EjecutarBusqueda(QUERY, parameters);
            long catId = BDConexion.getLastIndex();
            return Rta;

        }


        /// <summary>
        /// Retornar todos los vuelos salientes
        /// </summary>
        /// <param name="where">Incluir un query condicional</param>
        /// <param name="parameters">Parametros para el query</param>
        /// <returns>Listado de Vuelos Salientes</returns>
        public static List<cs_vuelosSalientes> getAllFromBD(string where = "", Dictionary<string, object> parameters = null)
        {

            string strSQL = "SELECT * FROM " + tn_name;
            //strSQL += " WHERE " + tc_username + " = @" + tc_username + " AND " + tc_password + " = @" + tc_password;
            //paso como parametros para no permitir SQL Injection
            


            List<cs_vuelosSalientes> ListaUserc = new List<cs_vuelosSalientes>();

            using (SqlDataReader MATER = BDConexion.EjecutarLecturaR(strSQL, parameters))
            {
                while (MATER.Read() == true)
                {
                    //del user
                    int BD_ID_VUELOSALIENTE = MATER.GetInt32(MATER.GetOrdinal(tc_id_VuelosSalientes));
                    int BD_CIUDADORIGEN = MATER.GetInt32(MATER.GetOrdinal(tc_CityOrigen));
                    int BD_CIUDADDESSTINO = MATER.GetInt32(MATER.GetOrdinal(tc_CityDestino));
                    DateTime BD_FECHA = MATER.GetDateTime(MATER.GetOrdinal(tc_fecha));
                    string BD_HORASALIDA = MATER.GetString(MATER.GetOrdinal(tc_HoraSalida));
                    string BD_HORALLEGADA = MATER.GetString(MATER.GetOrdinal(tc_HoraLlegada));
                    string BD_NUMEROVUELO = MATER.GetString(MATER.GetOrdinal(tc_NumeroVuelo));
                    int BD_AEROLINEA = MATER.GetInt32(MATER.GetOrdinal(tc_Aerolinea));
                    int BD_ESTADOVUELO = MATER.GetInt32(MATER.GetOrdinal(tc_EstadoVuelo));


                    cs_Ciudades CiudadOrigen = cs_Ciudades.getAllFromBD().Find(x => x.Id_ciudad == BD_CIUDADORIGEN);
                    cs_Ciudades CiudadDestino = cs_Ciudades.getAllFromBD().Find(x => x.Id_ciudad == BD_CIUDADDESSTINO);
                    cs_Aerolinea Aerolinea = cs_Aerolinea.getAllFromBD().Find(x => x.Id_Aerolinea == BD_AEROLINEA);

                    ListaUserc.Add(new cs_vuelosSalientes(BD_ID_VUELOSALIENTE, CiudadOrigen, CiudadDestino, BD_FECHA, BD_HORASALIDA, BD_HORALLEGADA, BD_NUMEROVUELO, Aerolinea, BD_ESTADOVUELO));

                }

            }
            return ListaUserc;

        }
        





    }
}
