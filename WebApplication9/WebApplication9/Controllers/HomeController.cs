using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Win32;
using Newtonsoft.Json;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        
        public  IActionResult Index()
        {
           
            return View();
        }
        
        [HttpPost]
        public async Task<JsonResult> ShowDisplay()
        {
            EmployeeData emp = new EmployeeData();
            try
            {
                int draw = Convert.ToInt32(Request.Form["draw"].FirstOrDefault());
                int start = Convert.ToInt32(Request.Form["start"].FirstOrDefault());
                var name1 = Request.Form["txt1"];
                int recordscount = Convert.ToInt32(Request.Form["length"].FirstOrDefault());
                if (recordscount == 0)
                    recordscount = 10;
                List<Employee> reservationList = new List<Employee>();
                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.GetAsync("http://localhost:61555/api/Reservation/Display"))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        reservationList = JsonConvert.DeserializeObject<List<Employee>>(apiResponse);
                    }
                }
                
                emp.draw = draw;
                emp.recordsFiltered = reservationList.Count();
                emp.recordsTotal = reservationList.Count();
                emp.data = reservationList.Skip(start).Take(recordscount).ToList<Employee>();
                

            }
            catch (Exception ex)
            {

            }
            return Json(emp);
        }

        [HttpPost]
        public IActionResult TestData()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string StartLocation { get; set; }
        public string EndLocation { get; set; }
    }
    public class EmployeeData
    {
        public int draw { get; set; }
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public List<Employee> data { get; set; }
    }
}
