using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TARpe21ShopUmberto.Core.Domain;
using TARpe21ShopUmberto.Core.Dto;

namespace TARpe21ShopUmberto.Core.ServiceInterface
{
    public interface ICarServices
    {
        Task<Car> GetAsync(Guid id);
        Task<Car> Create(CarDto dto);
        Task<Car> Update(CarDto dto);
        Task<Car> Delete(Guid id);
    }
}
