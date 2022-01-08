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
    public partial class BorrowedBookAdmin : ContentPage
    {
        public BorrowedBookAdmin()
        {
            InitializeComponent();
        }
        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var slist = (BorrowedBook)BindingContext;
            await App.Database.SaveBorrowedBookAsync(slist);
            await Navigation.PopAsync();
        }
        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var slist = (BorrowedBook)BindingContext;
            await App.Database.DeleteBorrowedBookAsync(slist);
            await Navigation.PopAsync();
        }
    }
}