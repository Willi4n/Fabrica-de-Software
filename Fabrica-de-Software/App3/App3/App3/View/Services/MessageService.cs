using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3.View.Services
{
    class MessageService : ViewModel.Services.IMessageService
    {
        public async Task ShowAssinc(string message)
        {
            await App3.App.Current.MainPage.DisplayAlert("APP", message, "OK");
        }

        public MessageService()
        {

        }
    }
}
