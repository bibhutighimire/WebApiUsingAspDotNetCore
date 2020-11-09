using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using static WebApiUsingCore.Models.Weather;

namespace WebApiUsingCore.Controllers
{
    public class WeatherController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {

            return View();


        }
        [HttpPost]
        public async Task<IActionResult> IndexPost(Example e)
        {

            string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&units=metric&cnt=1&APPID=8113fcc5a7494b0518bd91ef3acc074f", e.name);


            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString(url);
                var jsonstring = JsonConvert.DeserializeObject<Example>(json);
                //var mainDetails=jsonstring.;
                return View(jsonstring);
            }
        }
    }
}
