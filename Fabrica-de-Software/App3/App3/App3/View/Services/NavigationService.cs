using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3.View.Services
{
    class NavigationService : ViewModel.Services.INavigationService
    {

        public async Task NavigateToRegister()
        {
            await App3.App.Current.MainPage.Navigation.PushAsync(new View.Register());
        }

        public async Task NavigateToMain()
        {
            await App3.App.Current.MainPage.Navigation.PushAsync(new View.Main());
        }

        public async Task NavigateToLogin()
        {
            await App3.App.Current.MainPage.Navigation.PushAsync(new View.Login());
        }
    }
}
