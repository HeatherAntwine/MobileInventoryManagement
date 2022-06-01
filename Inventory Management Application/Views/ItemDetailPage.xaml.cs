using Inventory_Management_Application.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Inventory_Management_Application.Views
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