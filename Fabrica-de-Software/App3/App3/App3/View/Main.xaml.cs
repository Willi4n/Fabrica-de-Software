using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App3.View
{
    public partial class Main : ContentPage
    {
        public Main()
        {
            InitializeComponent();
            this.BindingContext = new ViewModel.LoginVM();
        }
    }
}
