using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PowerTable.Models;

namespace PowerTable.Controllers
{
    public class HomeController : Controller
    {
        public List<double> MaxList { get; set; }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Result(NumberTable numTable)
        {

            for(int i=0; i >= numTable.UserMax; i++)
            {
                MaxList.Add(i);
            }
            return View(numTable);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
