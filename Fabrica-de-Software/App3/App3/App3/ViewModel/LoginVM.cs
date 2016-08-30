using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace App3.ViewModel
{
   
    class LoginVM : ViewModelBase
    {
        private readonly ViewModel.Services.IMessageService _messageService;
        private readonly ViewModel.Services.INavigationService _inavigationService;
        private string email;        
        public string Email
        {
            get { return email; }
            set {
                email = value;
                Notify("Email");
            }
        }

        private string senha;

        public string Senha
        {
            get { return senha; }
            set {
                senha = value;
                Notify("Semha");
            }
        }

        public ICommand LoginComand
        {
            get;
            set;
        }
        public ICommand RegisterComand
        {
            get;
            set;
        }

        public LoginVM()
        {
            this.LoginComand = new Command(this.Login);
            this._messageService = DependencyService.Get<ViewModel.Services.IMessageService>();
            this._inavigationService = DependencyService.Get<ViewModel.Services.INavigationService>();
        }

        public void Login()
        {
            if (this.email.Equals("adm") && this.senha.Equals("123"))
            {
                this._inavigationService.NavigateToMain();
            }
            else
            {
                this._messageService.ShowAssinc("Email invalido");
            }
        }
    }
}
