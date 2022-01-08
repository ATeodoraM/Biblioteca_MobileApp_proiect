using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Biblioteca_MobileApp;

namespace Biblioteca_MobileApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Motivatie : ContentPage
    {
        INotificationManager notificationManager;
        int notificationNumber = 0;

        public Motivatie()
        {
            InitializeComponent();

            notificationManager = DependencyService.Get<INotificationManager>();
            notificationManager.NotificationReceived += (sender, eventArgs) =>
            {
                var evtData = (NotificationEventArgs)eventArgs;
                ShowNotification(evtData.Title, evtData.Message);
            };
        }

        void OnSendClick(object sender, EventArgs e)
        {
            notificationNumber++;
            string title = $"Noi carti te asteapta";
            string message = $"Calatoreste si citeste";
            notificationManager.SendNotification(title, message);
        }

        void OnScheduleClick(object sender, EventArgs e)
        {
            notificationNumber++;
            string title = $"Noi carti te asteapta";
            string message = $"Calatoreste si citeste";
            notificationManager.SendNotification(title, message, DateTime.Now.AddHours(24));
        }

        void ShowNotification(string title, string message)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                var msg = new Label()
                {
                    Text = $"Notification Received:\nTitle: {title}\nMessage: {message}"
                };
                stackLayout.Children.Add(msg);
            });
        }
    }
}