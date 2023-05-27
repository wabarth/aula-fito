using MVC_Fito_2023.BLL;
using MVC_Fito_2023.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC_Fito_2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // criar o obj DTO e receber dados do form
            LoginDTO loginDTO = new LoginDTO
            {
                Email = txtEmail.Text,
                Senha = txtSenha.Text,
            };

            // criar obj da BLL
            LoginBLL loginBLL = new LoginBLL();

            // chamar a BLL
           bool retorno = loginBLL.GetLoginBLL(loginDTO);

            // tratar o retorno
            if (retorno)
            {
                MessageBox.Show("Login OK");
            }
            else
            {
                MessageBox.Show("Não foi possível logar");
            }


        }
    }
}
