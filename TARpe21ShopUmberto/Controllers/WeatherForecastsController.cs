using Microsoft.AspNetCore.Mvc;

namespace TARpe21ShopUmberto.Controllers
{
    public class WeatherForecastsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
