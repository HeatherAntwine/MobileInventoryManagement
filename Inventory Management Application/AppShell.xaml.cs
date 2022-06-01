using Inventory_Management_Application.ViewModels;
using Inventory_Management_Application.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Inventory_Management_Application
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
