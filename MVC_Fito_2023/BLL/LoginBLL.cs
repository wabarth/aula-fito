using MVC_Fito_2023.DAL;
using MVC_Fito_2023.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Fito_2023.BLL
{
    internal class LoginBLL
    {
        public bool GetLoginBLL(LoginDTO loginDTO)
        {
            // criar um obj DAL
            LoginDAL loginDAL = new LoginDAL();

            // chamar a DAL
            return loginDAL.GetLoginDAL(loginDTO);
        }
    }
}
