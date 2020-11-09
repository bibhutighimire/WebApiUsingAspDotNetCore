using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApiUsingCore.Models;
using static WebApiUsingCore.Models.News;

namespace WebApiUsingCore.Controllers
{
    public class NewsController : Controller
    {
        public async Task<IActionResult> Index()
        {

            string url = string.Format("http://newsapi.org/v2/top-headlines?country=ca&category=health&apiKey=9c3bc0733617451fbff5f91e151dbd87");


            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString(url);
                var jsonstring = JsonConvert.DeserializeObject<Example>(json);

                var a = jsonstring.articles;
                //List<Article> lst = a;
                return View(a);
            }


        }
    }
}
