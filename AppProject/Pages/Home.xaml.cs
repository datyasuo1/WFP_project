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
using Windows.UI.Xaml.Media.Imaging;
using AppProject.Models;
using AppProject.Services;
using  AppProject.Models.Enity;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace AppProject.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Home : Page
    {
        public Home()
        {
            this.InitializeComponent();
            //var p1 = new HomeCate() { Name = "quan ao thoi trang thu dong", Price = 200000, Des = "haha", Img = new BitmapImage(new Uri("https://massageishealthy.com/wp-content/uploads/2019/06/hinh-anh-do-an-hinh-anh-mon-an-thuc-an-ngon-dep-viet-nam-the-gioi-4.png")) };
            //lấy ảnh từ trong thư mục 
            //var p2 = new HomeCate() { Name = "quan ao thoi trang thu dong", Price = 200000, Des = "haha", Img = new BitmapImage(new Uri("ms-appx:///Assets/StoreLogo.png")) };
            //Homes.Items.Add(p1);
            //Homes.Items.Add(p2);
            RenderSpecial();
        }

        public async void RenderSpecial()
        {
            // chi viec goi object cuar ApiService vao dung
            ApiService apiService = new ApiService();
            todaySpecial food = await apiService.GetTodaySpecial();
            if (food != null)
            {
                foreach (var c in food.data)
                {
                    Homes.Items.Add(new Product() { Name = c.name, Des = c.description, ID = c.id, Img = c.image, Price = c.price });
                }
            }
        }

        private void Button_Tapped(object sender, RoutedEventArgs e)
        {

        }
    }

    }

