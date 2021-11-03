using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using AppProject.Models;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace AppProject
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            MainFram.Navigate(typeof(Pages.Home));
            var item1 = new MenuItem() { Name = "Home", MenuPage = "home", Icon = "\uEA8A" };
            var item2 = new MenuItem() { Name = "Eat-in", MenuPage = "eat", Icon = "\uED56" };
            var item3 = new MenuItem() { Name = "Collection", MenuPage = "collection", Icon = "\uEA5C" };
            var item4 = new MenuItem() { Name = "Delivery", MenuPage = "delivery", Icon = "\uEA5E" };
            var item5 = new MenuItem() { Name = "Take Away", MenuPage = "take", Icon = "\uF133" };
            var item6 = new MenuItem() { Name = "Drive Payment", MenuPage = "pay", Icon = "\uEC5C" };
            var item7 = new MenuItem() { Name = "Customers", MenuPage = "customer", Icon = "\uEA8C" };

            Menu.Items.Add(item1);
            Menu.Items.Add(item2);
            Menu.Items.Add(item3);
            Menu.Items.Add(item4);
            Menu.Items.Add(item5);
            Menu.Items.Add(item6);
            Menu.Items.Add(item7);

        }



        private void ListViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MenuItem selected = (MenuItem)Menu.SelectedItem;
            switch (selected.MenuPage)
            {
                case "home": MainFram.Navigate(typeof(Pages.Home)); break;
                case "eat": MainFram.Navigate(typeof(Pages.Eat_In)); break;
               
            }

        }

        private void IconClick_Tapped(object sender, TappedRoutedEventArgs e)
        {
            sp.IsPaneOpen = !sp.IsPaneOpen;

        }
    }
}
