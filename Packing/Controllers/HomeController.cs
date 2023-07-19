using Microsoft.AspNetCore.Mvc;
using Packing.Models;

namespace Packing.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index(){
            return View();
        }
    }
}

