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
using AppProject.Adapters;
using AppProject.Models;
using AppProject.Services;
using AppProject.Models.Enity;







// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace AppProject.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Eat_In : Page
    {
        public Eat_In()
        {
            this.InitializeComponent();
            RenderEat();
        }

        public async void RenderEat()
        {
            // chi viec goi object cuar ApiService vao dung
            ApiService apiService = new ApiService();
            Eats eats = await apiService.GetEat();
            if (eats != null)
            {
                foreach (var c in eats.data)
                {
                    Eat.Items.Add(new Eat() { Name = c.name, Icon = c.icon,Id = c.id});
                }
            }
        }
    }
}
