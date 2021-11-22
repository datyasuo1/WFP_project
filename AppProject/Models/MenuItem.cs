using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppProject.Models.Enity;

namespace AppProject.Models
{
    class MenuItem
    {
        public string Name { get; set; }
        public string MenuPage { get; set; }
        public string Icon { get; set; }
        public Category Category { get; set; }

    }
}
