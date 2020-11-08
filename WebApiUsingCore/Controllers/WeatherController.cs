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
        public async Task<IActionResult> Index()
        {
            
        string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q=edmonton&units=metric&cnt=1&APPID=8113fcc5a7494b0518bd91ef3acc074f");

                   
        using (WebClient client = new WebClient())
        {
            string json = client.DownloadString(url);
            var jsonstring = JsonConvert.DeserializeObject<Example>(json);   
            return View(jsonstring);
        }
            
          
        }
    }
}
