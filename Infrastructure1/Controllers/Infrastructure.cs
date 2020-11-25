using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Infrastructure1.Models;
using Microsoft.AspNetCore.Http;

namespace Infrastructure1.Controllers
{
    public class Infrastructure : Controller
    {
        public IActionResult Get(string path = "")
        {

            return View();
        }
    }
}
