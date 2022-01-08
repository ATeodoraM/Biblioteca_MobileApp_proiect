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
    public partial class CrudBook : ContentPage
    {
        public CrudBook()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await App.Database.GetBookAsync();
        }
        async void OnShopListAddedClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BookAdmin
            {
                BindingContext = new Book()
            });
        }
        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new BookAdmin
                {
                    BindingContext = e.SelectedItem as Book
                });
            }
        }
    }
}