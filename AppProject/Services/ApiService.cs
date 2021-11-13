using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppProject.Models.Entity;
using System.Net.Http;
using System.Net;
using Newtonsoft.Json;
using AppProject.Adapters;
namespace AppProject.Services
{
    class ApiService
    {
        public async Task<Categories> GetCategories()
        {
            HttpClient client = new HttpClient();//lo viec ket noi api va lay du lieu ve 
            ApiURL uRL = ApiURL.GetInstance();

            var rs = await client.GetAsync(uRL.GetApiCategories()); // lấy data từ api về
            if (rs.StatusCode == HttpStatusCode.OK)
            {
                var rsContent = await rs.Content.ReadAsStringAsync();//Chuyen du lieu thanh 1 string 
                //tim cac convert string o tren thanh 1 object Categories
                Categories categories = JsonConvert.DeserializeObject<Categories>(rsContent);
                return categories;
            }
            return null;
        }
        public async Task<Foods> GetFoods()
        {
            HttpClient client1 = new HttpClient();
            ApiURL uRL = ApiURL.GetInstance();
            var rd = await client1.GetAsync(uRL.GetApiTodaySpecial());
            if (rd.StatusCode == HttpStatusCode.OK)
            {
                var rsContent = await rd.Content.ReadAsStringAsync();
                Foods foods = JsonConvert.DeserializeObject<Foods>(rsContent);
                return foods;
            }
            return null;
        }

        public async Task<CategoryDetail> CategoryDetail(Category category)
        {
            HttpClient client = new HttpClient();
            ApiURL uRL = ApiURL.GetInstance();
            var rs = await client.GetAsync(uRL.GetApiCategoryDetail(category.id)); 
            if (rs.StatusCode == HttpStatusCode.OK)
            {
                string rsContent = await rs.Content.ReadAsStringAsync();                                                                       
                CategoryDetail detail = JsonConvert.DeserializeObject<CategoryDetail>(rsContent);
                return detail;
            }
            return null;
        }
    }
}
