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
using AppProject.Models.Enity;
using AppProject.Services;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace AppProject.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Categories : Page
    {
        public Categories()
        {
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            Category category = e.Parameter as Category;
            // Da co category -> lay api du lieu ve
            RenderFoods(category);
        }

        private async void RenderFoods(Category category)
        {
            ApiService service = new ApiService();
            CategoryDetail categoryDetail = await service.CategoryDetail(category);
            if (categoryDetail != null)
            {
                foreach (var f in categoryDetail.data.foods)
                {
                    Products.Items.Add(f);
                }
            }
        }
    }
}
