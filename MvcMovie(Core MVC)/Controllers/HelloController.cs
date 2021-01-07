using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace MvcMovie.Controllers
{
    public class HelloController : Controller
    {
        //we can return string, not create new view
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        // Uses HtmlEncoder.Default.Encode to protect the app from malicious input (namely JavaScript).
        //https://localhost:44373/hello/welcome?name=Rick&numtimes=4
        public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }

        public IActionResult Welcome1(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
