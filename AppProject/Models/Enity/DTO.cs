using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProject.Models.Enity
{


    public class Category
    {
        public int id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
    }

    public class Categories
    {
        public string message { get; set; }
        public List<Category> data { get; set; }
    }

    public class Eats
    {
        public string message { get; set; }
        public List<Category> data { get; set; }
    }


    public class Food
    {
        public int id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public string description { get; set; }
        public int price { get; set; }
    }

    public class FoodsOfCategory
    {
        public Category category { get; set; }
        public List<Food> foods { get; set; }
    }

    public class CategoryDetail
    {
        public string message { get; set; }
        public FoodsOfCategory data { get; set; }
    }
    public class todaySpecial
    {
        public string message { get; set; }
        public List<Food> data { get; set; }
    }
    public class FoodList
    {
        public string message { get; set; }
        public Food data { get; set; }

        public static implicit operator FoodList(CategoryDetail v)
        {
            throw new NotImplementedException();
        }
    }
}

