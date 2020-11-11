using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using static WebApiUsingCore.Models.FIHRApi;

namespace WebApiUsingCore.Controllers
{
    public class FIHRApiController : Controller
    {
        public async Task<IActionResult> Index()
        
        {
            List<Example> root =new List<Example>();
            string url = string.Format("https://api.1up.health/connect/system/clinical?client_id=a0dd6db688f9437ca948c0d9d7584bfe&client_secret=KNDssaX8qXmDsPsZYXltPErcvZD07ybG");


            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString(url);
                root = JsonConvert.DeserializeObject<List<Example>>(json);

                 //var a = jsonstring.locations;

                return View(root);
            }


        }
    }
}
