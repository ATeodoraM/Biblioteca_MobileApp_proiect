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
    public partial class CrudBorrowedBook : ContentPage
    {
        public CrudBorrowedBook()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await App.Database.GetBorrowedBookAsync();
        }
        async void OnShopListAddedClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BorrowedBookAdmin
            {
                BindingContext = new BorrowedBook()
            });
        }
        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new BorrowedBookAdmin
                {
                    BindingContext = e.SelectedItem as BorrowedBook
                });
            }
        }
    }
}