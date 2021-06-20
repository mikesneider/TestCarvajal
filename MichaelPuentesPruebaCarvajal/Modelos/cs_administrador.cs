using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace MichaelPuentesPruebaCarvajal.Modelos
{
    /// <summary>
    /// Clase para tabla administrador, Se utiliza Herencia con users en caso de necesitar adjuntar más perfiles
    /// </summary>
    class cs_administrador :cs_users
    {

        #region Nombre_de_tablas
        private static string tn_name_administrador = "Administradores";
        private static string tc_id = "Id_administradores";
        private static string tc_id_user_admin = "ID_users";
        private static string tc_cargo = "cargo";
        #endregion

        #region Contructor
        public cs_administrador(int ID_admon, int ID_user, string username, string password, string cargo) 
            : base(username, password)
        {
            this.cargo = cargo;
        }

        public string cargo { get; set; }
        #endregion


        /// <summary>
        /// Obtener los datos de la base de datos
        /// </summary>
        /// <param name="where">Query para que no traiga todos los datos</param>
        /// <param name="parameters">Para evitar SQL injection</param>
        /// <returns>Lista de administradores con la información de usuario</returns>
        public static List<cs_administrador> getAllFromBD(string where = "", Dictionary<string, object> parameters = null)
        {
            //Como es con herencia tengo que hacer un join
            string strSQL = "SELECT * FROM " + tn_name_administrador;
            strSQL += " INNER JOIN " + tn_name_usuarios + " ON " + tn_name_administrador + "." + tc_id_user_admin + " = " + tn_name_usuarios + "." + tc_id_user;
            if (where != "") strSQL += " WHERE " + where;
            
            List<cs_administrador> ListaAdministradores = new List<cs_administrador>();

            using (SqlDataReader MATER = BDConexion.EjecutarLecturaR(strSQL, parameters))
            {
                while (MATER.Read() == true)
                {
                    //del user
                    int BD_ID = MATER.GetInt32(MATER.GetOrdinal(tc_id));
                    int BD_ID_USER = MATER.GetInt32(MATER.GetOrdinal(tc_id_user_admin));
                    string BD_USERNAME = MATER.IsDBNull(MATER.GetOrdinal(tc_username)) ? "MIKE" : MATER.GetString(MATER.GetOrdinal(tc_username));
                    string BD_PASS = MATER.GetString(MATER.GetOrdinal(tc_password));//already MD5
                    string BD_CARGO = MATER.GetString(MATER.GetOrdinal(tc_cargo));
                    ListaAdministradores.Add(new cs_administrador(BD_ID, BD_ID_USER, BD_USERNAME, BD_PASS, BD_CARGO));
                }

            }
            return ListaAdministradores;
        }

    }
}
