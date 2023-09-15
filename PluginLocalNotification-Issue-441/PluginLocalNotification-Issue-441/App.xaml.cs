using PluginLocalNotification_Issue_441.Services;
using PluginLocalNotification_Issue_441.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PluginLocalNotification_Issue_441
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
