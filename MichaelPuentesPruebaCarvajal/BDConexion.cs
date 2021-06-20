using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MichaelPuentesPruebaCarvajal
{
    class BDConexion
    {
        static private string DireccionBD;
        static private string PathDB = ConfigurationSettings.AppSettings["PathDB"];
        static private string NombreDB = ConfigurationSettings.AppSettings["NombreDB"];

        static private SqlConnection getConexion;


        static public void SetDireccionBD(string dirBD)
        {
            cs_Logger.Log(string.Format("dirBD = {0}", dirBD), (int)Numeradores.LogerLevel.INFO);
            DireccionBD = dirBD;
        }

        static public void conectar()
        {
            try
            {
               
                getConexion = new SqlConnection(GetConnectionString(PathDB,NombreDB)); 
                getConexion.Open();
                //MessageBox.Show("Genial! habemus conexion", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception H)
            {
                MessageBox.Show("Hay un error en la conexión a la BD");
            }
        }
        static private string GetConnectionString(string DataSource, string Catalog)
        {
            // To avoid storing the connection string in your code,
            // you can retrieve it from a configuration file.
            return string.Format("Data Source = {0}; " +
                "Initial Catalog = {1}; " +
                "Integrated Security = True; " +
                "Connect Timeout = 30; " +
                "Encrypt = False; " +
                "TrustServerCertificate = False; " +
                "ApplicationIntent = ReadWrite; " +
                "MultiSubnetFailover = False",DataSource,Catalog);
            
        }
        
        static public void desconectar()
        {
            getConexion.Close();
            getConexion.Dispose();
        }

        static public long EjecutarEscalar(string SQL)
        {
            try
            {
                //cs_Logger.Log(string.Format("string SQL = {0}", SQL), (int)Numeradores.LogerLevel.INFO);
                SqlCommand Secuencia_Bus; //secuencia de busqueda a ejecutar
                Secuencia_Bus = new SqlCommand(SQL, getConexion);
                Secuencia_Bus.CommandType = CommandType.Text;
                return Convert.ToInt64(Secuencia_Bus.ExecuteScalar());
            }
            catch (Exception ex)
            {
                //cs_Logger.Log(string.Format("Excepcion: {0}", ex), (int)Numeradores.LogerLevel.ERROR);
                return -1;
            }
        }

        static public long getLastIndex()
        {
            return EjecutarEscalar("SELECT @@IDENTITY;");
        }


        static public bool EjecutarBusqueda(string SQL)
        {
            try
            {
                //cs_Logger.Log(string.Format("string SQL = {0}", SQL), (int)Numeradores.LogerLevel.INFO);
                 SqlCommand Secuencia_Bus; //secuencia de busqueda a ejecutar
                Secuencia_Bus = new SqlCommand(SQL, getConexion);
                Secuencia_Bus.CommandType = CommandType.Text;
                Secuencia_Bus.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                //cs_Logger.Log(string.Format("Excepcion: {0}", ex), (int)Numeradores.LogerLevel.ERROR);
                return false;
            }
        }

        static SqlDbType GetDBType(object o)
        {
            switch (o.GetType().ToString())
            {
                case "System.Int32": return SqlDbType.Int;
                case "System.Int64": return SqlDbType.BigInt;
                case "System.Double": return SqlDbType.Decimal;
                case "System.String": return SqlDbType.VarChar;
                case "System.DateTime": return SqlDbType.Date;
                case "System.Boolean": return SqlDbType.Bit;
                default: return SqlDbType.Char;
            }
        }

        static public bool EjecutarBusqueda(string SQL, Dictionary<string, object> dict)
        {
            try
            {
                //cs_Logger.Log(string.Format("string SQL = {0}", SQL), (int)Numeradores.LogerLevel.INFO);
                SqlCommand Secuencia_Bus; //secuencia de busqueda a ejecutar
                Secuencia_Bus = new SqlCommand(SQL, getConexion);
                dict.ToList().ForEach(kv => {
                    Secuencia_Bus.Parameters.Add(new SqlParameter(kv.Key, GetDBType(kv.Value)));
                    Secuencia_Bus.Parameters[kv.Key].Value = kv.Value;
                    //Secuencia_Bus.Parameters.AddWithValue(kv.Key, kv.Value);
                });
                Secuencia_Bus.CommandType = CommandType.Text;
                Secuencia_Bus.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                //cs_Logger.Log(string.Format("Excepcion: {0}", ex), (int)Numeradores.LogerLevel.ERROR);
                return false;
            }
        }


        static public SqlDataReader EjecutarLecturaR(string SQL, Dictionary<string, object> dict)
        {
            try
            {
                //cs_Logger.Log(string.Format("string SQL = {0}", SQL), (int)Numeradores.LogerLevel.INFO);
                //conectar();
                SqlCommand Secuencia_Bus;
                Secuencia_Bus = new SqlCommand(SQL, getConexion);
                if (dict != null)
                {
                    dict.ToList().ForEach(kv =>
                    {
                        Secuencia_Bus.Parameters.Add(new SqlParameter (kv.Key, GetDBType(kv.Value)));
                        Secuencia_Bus.Parameters[kv.Key].Value = kv.Value;
                    });
                }
                 SqlDataReader Leer = Secuencia_Bus.ExecuteReader();
                return Leer;
            }
            catch (Exception ex)
            {
                cs_Logger.Log(string.Format("Excepcion: {0}", ex), (int)Numeradores.LogerLevel.ERROR);
                // desconectar();
                return null;
            }
        }


        static public DataTable EjecutarLectura(string SQL, Dictionary<string, object> dict)
        {
            try
            {
                cs_Logger.Log(string.Format("string SQL = {0}", SQL), (int)Numeradores.LogerLevel.INFO);
                //conectar();
                SqlCommand Secuencia_Bus = new SqlCommand(SQL, getConexion);
                if (dict != null)
                {
                    dict.ToList().ForEach(kv =>
                    {
                        Secuencia_Bus.Parameters.Add(new SqlParameter(kv.Key, GetDBType(kv.Value)));
                        Secuencia_Bus.Parameters[kv.Key].Value = kv.Value;
                    });
                }
                SqlDataAdapter canal = new SqlDataAdapter(Secuencia_Bus);
                DataTable t = new DataTable();
                canal.Fill(t);
                //desconectar();
                return t;
            }
            catch (Exception ex)
            {
                cs_Logger.Log(string.Format("Excepcion: {0}", ex), (int)Numeradores.LogerLevel.ERROR);
                //desconectar();
                return null;
            }
        }

        static public DataView EjecutarLectura(string SQL, string stabla)
        {
            try
            {
                cs_Logger.Log(string.Format("string SQL = {0}", SQL), (int)Numeradores.LogerLevel.INFO);

                //conectar();
                 SqlDataAdapter canal = new SqlDataAdapter(SQL, getConexion);
                DataSet DS = new DataSet();
                canal.Fill(DS, stabla);
                //desconectar();
                return DS.Tables[stabla].DefaultView;
            }
            catch (Exception ex)
            {
                cs_Logger.Log(string.Format("Excepcion: {0}", ex), (int)Numeradores.LogerLevel.ERROR);
                //desconectar();
                return null;
            }
        }

        static public DataTable EjecutarLectura(string SQL)
        {
            try
            {
                cs_Logger.Log(string.Format("string SQL = {0}", SQL), (int)Numeradores.LogerLevel.INFO);
                //conectar();
                SqlDataAdapter canal = new SqlDataAdapter(SQL, getConexion);
                DataTable t = new DataTable();
                canal.Fill(t);
                //desconectar();
                return t;
            }
            catch (Exception ex)
            {
                cs_Logger.Log(string.Format("Excepcion: {0}", ex), (int)Numeradores.LogerLevel.ERROR);
                //desconectar();
                return null;
            }
        }

        static public SqlDataReader EjecutarLecturaR(string SQL, string stabla)
        {
            try
            {
                cs_Logger.Log(string.Format("string SQL = {0}", SQL), (int)Numeradores.LogerLevel.INFO);
                //conectar();
                SqlCommand Secuencia_Bus;
                Secuencia_Bus = new SqlCommand(SQL, getConexion);
                SqlDataReader Leer = Secuencia_Bus.ExecuteReader();
                return Leer;
            }
            catch (Exception ex)
            {
                cs_Logger.Log(string.Format("Excepcion: {0}", ex), (int)Numeradores.LogerLevel.ERROR);
                // desconectar();
                return null;
            }
        }

        static public SqlDataAdapter EjecutarLecturaRR(string SQL)
        {
            cs_Logger.Log(string.Format("string SQL : {0}", SQL), (int)Numeradores.LogerLevel.INFO);
            SqlDataAdapter adp = new SqlDataAdapter(SQL, getConexion);
            return adp;
        }
    }
}
