using Microsoft.AspNetCore.Mvc;

namespace _8may.Areas.Admin.Controllers
{
    public class FeatureController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
