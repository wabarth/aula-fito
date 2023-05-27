using MVC_Fito_2023.DTO;
using MySqlConnector;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC_Fito_2023.DAL
{
    internal class LoginDAL
    {
        public bool GetLoginDAL(LoginDTO loginDTO)
        {
            /*if (loginDTO.Email == "admin@admin.com" && loginDTO.Senha == "1234")
            {
                return true;
            }*/

            // conexão com o BD
            MySqlConnection conn = UtilsDAL.GetConnection();

            try
            {
                // verificar se a conexão ocorreu
                if (conn.State == ConnectionState.Open)
                {
                    // pesquisar se o usuario existe no BD
                    string query =  $"SELECT * FROM usuarios WHERE " +
                                    $"email = '{loginDTO.Email}' " +
                                    $"AND senha = '{loginDTO.Senha}'";
                    
                    MySqlCommand querySelect = new MySqlCommand(query, conn);
                    MySqlDataReader reader = querySelect.ExecuteReader();

                    if (reader.Read())
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao logar..." + ex.Message);
            }
            finally { conn.Close(); }

            return false;













































































































































        }
    }
}
