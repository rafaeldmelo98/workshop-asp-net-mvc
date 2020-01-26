using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SalesWebMVC.Controllers
{
    public class SalesRecordsController : Controller
    {
        private readonly SalesRecordsService _salesRecordsService;

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> SimplesSearch(DateTime? minDate, DateTime? maxDate)
        {
            return View();
        }

        public IActionResult GroupSearch()
        {
            return View();
        }
    }
}