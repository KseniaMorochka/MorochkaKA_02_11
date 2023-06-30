using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace MorochkaKA_02_01
{
    public partial class MainPage :ContentPage
    {
        public MainPage ()
        {
            InitializeComponent();
            log.Text = Preferences.Get("login", "");
            pass.Text = Preferences.Get("password", "");
        }

        private async void Button_Clicked (object sender, EventArgs e)
        {
            if(log.Text != "ects" || pass.Text != "ects123")
            {
                await DisplayAlert("Ошибка", "Заполните поля", "ok");
            } 
            else
            {
                Preferences.Set("login", $"{log.Text}");
                Preferences.Set("password", $"{pass.Text}");
            }
            await Navigation.PushAsync(new SecondAcrivity());
        }
    }
}
