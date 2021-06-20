using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MichaelPuentesPruebaCarvajal.Modelos
{
    class cs_Ciudades
    {
        #region NombreTablas
        private static string tn_name = "Ciudades";
        private static string tc_ID_ciduad = "ID_Ciudad";
        private static string tc_NombreCiudad = "NombreCiudad";
        private static string tc_CodigoCiudad = "CodigoCiudad";
        #endregion

        #region Contructor
        public static string DisplayMember = "NombreCiudad";
        public int Id_ciudad { get; set; }
        public string NombreCiudad { get; set; }

        
        public cs_Ciudades(int id_ciudad, string nombreCiudad)
        {
            Id_ciudad = id_ciudad;
            NombreCiudad = nombreCiudad;
        }
        #endregion

        private static List<cs_Ciudades> MisCiudades = new List<cs_Ciudades>();

        public static bool IngresarCiudad(string codigoCiudad, string NombreCiudad)
        {
            string QUERY = "INSERT INTO " + tn_name + " (" + tc_CodigoCiudad + "," + tc_NombreCiudad + ") VALUES " +
                " (@" + tc_CodigoCiudad + ",@" + tc_NombreCiudad + ")";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@" + tc_CodigoCiudad, codigoCiudad);
            parameters.Add("@" + tc_NombreCiudad, NombreCiudad);
            bool Rta = BDConexion.EjecutarBusqueda(QUERY, parameters);
            long catId = BDConexion.getLastIndex();
            return Rta;
        }

        /// <summary>
        /// Retorna todas las ciudades, solo carga una vez de la DB
        /// </summary>
        /// <returns>Lista de ciudades</returns>
        public static List<cs_Ciudades> getAllFromBD()
        {

            string strSQL = "SELECT * FROM " + tn_name;

            //bool Rta = BDConexion.EjecutarBusqueda(strSQL, parameters);
            if (MisCiudades.Count == 0)
            {
                using (SqlDataReader MATER = BDConexion.EjecutarLecturaR(strSQL, new Dictionary<string, object>()))
                {
                    while (MATER.Read() == true)
                    {
                        //del user
                        int BD_ID_CIUDAD = MATER.GetInt32(MATER.GetOrdinal(tc_ID_ciduad));
                        string BD_NAMECIUDAD = MATER.IsDBNull(MATER.GetOrdinal(tc_NombreCiudad)) ? "MIKE" : MATER.GetString(MATER.GetOrdinal(tc_NombreCiudad));

                        MisCiudades.Add(new cs_Ciudades(BD_ID_CIUDAD, BD_NAMECIUDAD));
                    }
                }
            }
            return MisCiudades;
        }
    }
}
