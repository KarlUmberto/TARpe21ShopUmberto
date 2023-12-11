using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TARpe21ShopAljas.Models.Car;
using TARpe21ShopUmberto.Core.ServiceInterface;
using TARpe21ShopUmberto.Data;
using TARpe21ShopUmberto.Models.Car;
using TARpe21ShopUmberto.Models.RealEstate;

namespace TARpe21ShopUmberto.Controllers
{
    public class CarsController : Controller
    {
        private readonly ICarServices _cars;
        private readonly TARpe21ShopUmbertoContext _context;
        public CarsController
            (
            ICarServices cars,
            TARpe21ShopUmbertoContext context
            )
        {
            _cars = cars;
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var result = _context.Cars
                .OrderByDescending(x => x.CreatedAt)
                .Select(x => new CarIndexViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    DriveTrain = x.DriveTrain,
                    Transmission = x.Transmission,
                    Horsepower = x.Horsepower,
                    Previously_Owned = x.Previously_Owned,
                    ZeroToSixty = x.ZeroToSixty,
                    FuelType = x.FuelType,
                });
            return View(result);
        }

        [HttpGet]
        public IActionResult Create()
        {
            CarCreateUpdateViewModel vm = new();
            return View("CreateUpdate", vm);
        }

        [HttpGet]
        public async Task<IActionResult> Update(Guid id)
        {
            var car = await _cars.GetAsync(id);
            if (car == null)
            {
                return NotFound();
            }
            var images = await _context.FilesToApi
                .Where(x => x.CarId == id)
                .Select(y => new FileToApiViewModel
                {
                    FilePath = y.ExistingFilePath,
                    ImageId = y.Id
                }).ToArrayAsync();
            var vm = new CarCreateUpdateViewModel();

            vm.Id = car.Id;
            vm.Name = car.Name;
            vm.DriveTrain = car.DriveTrain;
            vm.Transmission = car.Transmission;
            vm.Horsepower = car.Horsepower;
            vm.Previously_Owned = car.Previously_Owned;
            vm.ZeroToSixty = car.ZeroToSixty;
            vm.FuelType = car.FuelType;
            vm.CreatedAt = DateTime.Now;
            vm.ModifiedAt = DateTime.Now;
            vm.FileToApiViewModels.AddRange(images);

            return View("CreateUpdate", vm);
        }
    }
}
