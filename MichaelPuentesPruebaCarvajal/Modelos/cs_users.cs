using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MichaelPuentesPruebaCarvajal.Modelos
{
    class cs_users
    {
        #region NombreTablas
        internal static string tn_name_usuarios = "Usuarios";
        internal static string tc_username = "username";
        internal static string tc_password = "password";
        internal static string tc_id_user = "ID_users";
        #endregion

        #region Contructores
        public int ID_user { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        public cs_users(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        public cs_users(int ID_user, string username, string password)
        {
            this.ID_user = ID_user;
            this.username = username;
            this.password = password;
        }
        #endregion

        /// <summary>
        /// Registrar Nuevo Usuario
        /// </summary>
        /// <param name="username">Nombre de usuario</param>
        /// <param name="password">Contraseña</param>
        /// <returns></returns>
        public static bool IngresarUsuario(string username,string password)
        {
            string QUERY = "INSERT INTO " + tn_name_usuarios + " (" + tc_username + "," + tc_password + ") VALUES " +
                " (@" + tc_username + ",@" + tc_password + ")";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@" + tc_username, username);
            parameters.Add("@" + tc_password, password);
            bool Rta = BDConexion.EjecutarBusqueda(QUERY, parameters);
            long catId = BDConexion.getLastIndex();
            return Rta;
        }

        /// <summary>
        /// Verificar Login con usuario y pass
        /// </summary>
        /// <param name="username">Nombre de usuario</param>
        /// <param name="password">Password</param>
        /// <returns>Lista de usuarios</returns>
        public static List<cs_users> getAllFromBD(string username, string password=null)
        {
            
            string strSQL = "SELECT * FROM " + tn_name_usuarios;
            if (password != null)
                strSQL += " WHERE " + tc_username + " = @" + tc_username + " AND " + tc_password + " = @" + tc_password;
            else
                strSQL += " WHERE " + tc_username + " = @" + tc_username;
            //paso como parametros para no permitir SQL Injection
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@" + tc_username, username);
            if (password!=null)
                parameters.Add("@" + tc_password, password);
            //bool Rta = BDConexion.EjecutarBusqueda(strSQL, parameters);


            List<cs_users> ListaUserc = new List<cs_users>();

            using (SqlDataReader MATER = BDConexion.EjecutarLecturaR(strSQL, parameters))
            {
                while (MATER.Read() == true)
                {
                    //del user
                    int BD_ID_USER = MATER.GetInt32(MATER.GetOrdinal(tc_id_user));
                    string BD_USERNAME = MATER.IsDBNull(MATER.GetOrdinal(tc_username)) ? "MIKE" : MATER.GetString(MATER.GetOrdinal(tc_username));
                    string BD_PASS = MATER.GetString(MATER.GetOrdinal(tc_password));//already MD5

                    ListaUserc.Add(new cs_users(BD_ID_USER, BD_USERNAME, BD_PASS));
                }

            }
            return ListaUserc;

        }

    }
}
