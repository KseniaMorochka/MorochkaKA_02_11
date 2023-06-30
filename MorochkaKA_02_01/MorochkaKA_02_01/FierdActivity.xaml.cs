using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MorochkaKA_02_01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FierdActivity :ContentPage
    {
        public FierdActivity ()
        {
            InitializeComponent();
        }

        private abstract void Button_Clicked (object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}