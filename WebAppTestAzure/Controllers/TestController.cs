using Microsoft.AspNetCore.Mvc;

namespace WebAppTestAzure.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
