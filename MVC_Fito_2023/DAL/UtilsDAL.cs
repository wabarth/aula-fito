using System;
using MySqlConnector;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Fito_2023.DAL
{
    internal class UtilsDAL
    {
        // Métodp de conexão com BD
        public static MySqlConnection GetConnection()
        {
            // criar um obj builder contém dos dados da conexão
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                Database = "cad_usuarios",
                UserID = "root",
                Password = "",
            };

            // criar a conexão
            MySqlConnection connection = new MySqlConnection(builder.ConnectionString);

            connection.Open();

            return connection;
        }
    }
}
