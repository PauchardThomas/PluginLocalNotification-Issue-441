using PluginLocalNotification_Issue_441.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace PluginLocalNotification_Issue_441.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}