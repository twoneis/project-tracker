using Microsoft.AspNetCore.Mvc;

namespace project_tracker.Controllers
{
    public class PrivacyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
