using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppProject.Models.Entity;
namespace AppProject.Models
{
    class MenuItem
    {
        public string Name { set; get; }
        public string MenuPage { set; get; }
        public string Icon { set; get; }
        public Category Category { get; set; }
    }
}
