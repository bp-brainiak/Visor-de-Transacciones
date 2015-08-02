using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Com.VisorTransacciones.Logic
{
    public static class DatabaseConnectionHelper
    {
        public static string Server { get; set; }
        public static string User { get; set; }
        public static string Password { get; set; }
        public static string Database { get; set; }
        public static bool ConnectionStatus { get; set; }
        static List<String> Databases;

        public static string RetornaCadenaConexionMasterDatabase()
        {
            //Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password = myPassword;
            var connectionBuilder = new SqlConnectionStringBuilder();
            connectionBuilder.Add("Server", Server);
            connectionBuilder.Add("Database", "Master");
            connectionBuilder.Add("User Id", User);
            connectionBuilder.Add("Password", Password);
            return connectionBuilder.ToString();
        }
        public static string RetornaCadenaConexionMasterDatabase(string dataBase)
        {
            //Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password = myPassword;
            var connectionBuilder = new SqlConnectionStringBuilder();
            connectionBuilder.Add("Server", Server);
            connectionBuilder.Add("Database", dataBase);
            connectionBuilder.Add("User Id", User);
            connectionBuilder.Add("Password", Password);
            return connectionBuilder.ToString();
        }
         
        public static void ConectarAlServidor()
        {
            string cadenaConexiion = RetornaCadenaConexionMasterDatabase();
            Databases = new List<string>();
            using (var conexion = new SqlConnection(cadenaConexiion))
            {
                using (var sqlComando = new SqlCommand("sp_databases", conexion)) {
                    sqlComando.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        conexion.Open();
                        using (var reader = sqlComando.ExecuteReader()) {
                            while (reader.Read()) {
                                Databases.Add(reader["DATABASE_NAME"].ToString());
                            }
                        }
                    }
                    catch
                    {
                    }
                    finally {
                        conexion.Close();
                    }
                }
            }
        }

        public List<string> GetDataBases() {
            return Databases;
        }
    }
}
