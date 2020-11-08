using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using static WebApiUsingCore.Models.Employees;

namespace WebApiUsingCore.Controllers
{
    public class EmployeeController : Controller
    {
          
            public async Task<IActionResult> Index()
            {
                List<MyArray> employees = new List<MyArray>();
                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.GetAsync("https://emplistapi-258220.appspot.com"))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                    employees = JsonConvert.DeserializeObject<List<MyArray>>(apiResponse);
                    }
                }
                return View(employees);
            }
    }
}
