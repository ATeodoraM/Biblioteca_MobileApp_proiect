using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Biblioteca_MobileApp.Pages;
using Biblioteca_MobileApp.Data;
using System.IO;

//[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Biblioteca_MobileApp
{
    public partial class App : Application
    {
        static BookDatabase database;
        public static BookDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new
                    BookDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
                   LocalApplicationData), "Library.db3"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
