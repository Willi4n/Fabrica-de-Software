using App3.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App3
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            DependencyService.Register<ViewModel.Services.IMessageService, View.Services.MessageService>();
            DependencyService.Register<ViewModel.Services.INavigationService, View.Services.NavigationService>();
            MainPage = new NavigationPage(new Login());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
