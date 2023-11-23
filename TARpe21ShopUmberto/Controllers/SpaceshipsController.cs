using Microsoft.AspNetCore.Mvc;

namespace TARpe21ShopUmberto.Controllers
{
    public class SpaceshipsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
