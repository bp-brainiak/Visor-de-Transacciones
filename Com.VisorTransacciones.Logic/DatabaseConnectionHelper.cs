using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Com.VisorTransacciones.Logic
{
    public class DatabaseConnectionHelper
    {
        public string Server { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string Database { get; set; }
        public bool ConnectionStatus { get; set; }
        public List<String> Databases { get; set; }

        public string RetornaCadenaConexionMasterDatabase()
        {
            //Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password = myPassword;
            var connectionBuilder = new SqlConnectionStringBuilder();
            connectionBuilder.Add("Server", Server);
            connectionBuilder.Add("Database", "Master");
            connectionBuilder.Add("User Id", User);
            connectionBuilder.Add("Password", Password);
            return connectionBuilder.ToString();
        }
        public string RetornaCadenaConexionMasterDatabase(string dataBase)
        {
            //Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password = myPassword;
            var connectionBuilder = new SqlConnectionStringBuilder();
            connectionBuilder.Add("Server", Server);
            connectionBuilder.Add("Database", dataBase);
            connectionBuilder.Add("User Id", User);
            connectionBuilder.Add("Password", Password);
            return connectionBuilder.ToString();
        }
         
        public void ConectarAlServidor()
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
    }
}
