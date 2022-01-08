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
    public partial class WelcomePageAdmin : ContentPage
    {
        public WelcomePageAdmin()
        {
            InitializeComponent();
        }

        private void Crudbook_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CrudBook());
        }

        private void Crudstudenti_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CrudStudenti());
        }


        private void Crudborrowedbook_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CrudBorrowedBook());

        }
    private void Logout_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }

    }
}