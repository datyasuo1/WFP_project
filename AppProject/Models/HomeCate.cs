using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace AppProject.Models
{
    public class Product
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public string Img { set; get; }
        public string Des { set; get; }
        public int Price { set; get; }
    }

}

