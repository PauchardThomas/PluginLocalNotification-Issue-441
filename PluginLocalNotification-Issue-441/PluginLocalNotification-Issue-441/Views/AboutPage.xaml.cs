using Plugin.LocalNotification;
using Plugin.LocalNotification.EventArgs;
using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PluginLocalNotification_Issue_441.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            InitNotif();

        }

        public async Task InitNotif()
        {
            if (await LocalNotificationCenter.Current.AreNotificationsEnabled() == false)
            {
                await LocalNotificationCenter.Current.RequestNotificationPermission();
            }

            LocalNotificationCenter.Current.NotificationReceiving = (request) =>
            {
                var isWeekend = DateTime.Now.DayOfWeek == DayOfWeek.Sunday || DateTime.Now.DayOfWeek == DayOfWeek.Saturday;
                return Task.FromResult(new NotificationEventReceivingArgs
                {
                    Handled = isWeekend,
                    Request = request
                });
            };

            var notification = new NotificationRequest
            {
                NotificationId = 100,
                Title = "My Title",
                Description = $"My description",
                Schedule =
                    {
                        RepeatType = NotificationRepeat.Daily
                    }
            };

            await LocalNotificationCenter.Current.Show(notification);
        }
    }
}