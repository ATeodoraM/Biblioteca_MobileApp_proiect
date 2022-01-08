using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Biblioteca_MobileApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        private void Loginbtn_Clicked(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(Username.Text) || string.IsNullOrEmpty(Password.Text))
                DisplayAlert("Username/parola invalide", "Introduceti username si parola valide", "OK");
            else
            {
                if (Username.Text == "administrator" && Password.Text == "1234.qwer")
                {
                    DisplayAlert("Logat cu succes", "", "Ok");
                   
                    Navigation.PushAsync(new WelcomePageAdmin());
                }
                else if (Username.Text == "student" && Password.Text == "123456")
                {
                    DisplayAlert("Logat cu succes", "", "Ok");
                  
                    Navigation.PushAsync(new WelcomePageStudent());
                }
                else
                    DisplayAlert("Logare esuata", "Username/parola invalide", "OK");
            }
        }
    }
}