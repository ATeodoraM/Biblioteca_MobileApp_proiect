using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Biblioteca_MobileApp.Models;
namespace Biblioteca_MobileApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonAdmin : ContentPage
    {
        public PersonAdmin()
        {
            InitializeComponent();
        }
        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var slist = (Person)BindingContext;
            await App.Database.SavePersonAsync(slist);
            await Navigation.PopAsync();
        }
        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var slist = (Person)BindingContext;
            await App.Database.DeletePersonAsync(slist);
            await Navigation.PopAsync();
        }
    }
}