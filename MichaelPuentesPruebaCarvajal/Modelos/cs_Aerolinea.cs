using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MichaelPuentesPruebaCarvajal.Modelos
{
    class cs_Aerolinea
    {
        #region NombreTablas
        public static string DisplayName = "NombreAerolinea";
        private static string tn_name = "Aerolineas";
        private static string tc_id_aerolinea = "Id_Aerolinea";
        private static string tc_NombreAerolinea = "NombreAerolinea";
        #endregion

        #region Constructor
        public int Id_Aerolinea { get; set; }
        public string NombreAerolinea { get; set; }

        public cs_Aerolinea(int id_Aerolinea, string nombreAerolinea)
        {
            Id_Aerolinea = id_Aerolinea;
            NombreAerolinea = nombreAerolinea;
        }

        private static List<cs_Aerolinea> MisAerolineas = new List<cs_Aerolinea>();
        #endregion


        /// <summary>
        /// Retorna todas las Aerolineas, solo carga una vez de la DB
        /// </summary>
        /// <returns>Lista de Aerolineas</returns>
        public static List<cs_Aerolinea> getAllFromBD()
        {

            string strSQL = "SELECT * FROM " + tn_name;

            //bool Rta = BDConexion.EjecutarBusqueda(strSQL, parameters);
            if (MisAerolineas.Count == 0)
            {
                using (SqlDataReader MATER = BDConexion.EjecutarLecturaR(strSQL, new Dictionary<string, object>()))
                {
                    while (MATER.Read() == true)
                    {
                        //del user
                        int BD_ID_AEROLINEA = MATER.GetInt32(MATER.GetOrdinal(tc_id_aerolinea));
                        string BD_NOMBREAEROLINEA = MATER.IsDBNull(MATER.GetOrdinal(tc_NombreAerolinea)) ? "MIKE" : MATER.GetString(MATER.GetOrdinal(tc_NombreAerolinea));

                        MisAerolineas.Add(new cs_Aerolinea(BD_ID_AEROLINEA, BD_NOMBREAEROLINEA));
                    }
                }
            }
            return MisAerolineas;
        }
    }
}
