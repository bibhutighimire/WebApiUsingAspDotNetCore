using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using static WebApiUsingCore.Models.Employees;

namespace WebApiUsingCore.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            string url = string.Format("https://emplistapi-258220.appspot.com");
            List<MyArray> emp = null;
            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString(url);
                emp = (new JavaScriptSerializer()).Deserialize<List<EmployeeViewModel>>(json);

            }
            return View(emp);
        }
    }
}
