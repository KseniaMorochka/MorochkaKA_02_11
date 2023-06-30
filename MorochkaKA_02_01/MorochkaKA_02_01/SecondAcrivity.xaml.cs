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
    public partial class SecondAcrivity :ContentPage
    {
        public SecondAcrivity ()
        {
            InitializeComponent();
        }


        private async void Button_Clicked (object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FierdActivity());
        }

        private void pic_SelectedIndexChanged (object sender, EventArgs e)
        {
            if(pic.SelectedIndex == 0)
            {
                img.Source = "circle";
            }
            else if(pic.SelectedIndex == 1)
            {
                img.Source = "perim_treug";
            } 
            else
            {
                img.Source = "circle";
            }
        }
    }
}