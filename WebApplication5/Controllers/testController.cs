using Microsoft.AspNetCore.Mvc;

namespace WebApplication5.Controllers
{
    public class testController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
