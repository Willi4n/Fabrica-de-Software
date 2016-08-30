using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3.ViewModel
{
   
    class LoginVM
    {
        private string email;        
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string senha;

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }


        public LoginVM()
        {

        }

        public void LoginComand(object a, EventArgs e)
        {
            this.Email = "tesdfsd";
        }
    }
}
