using CarsApp;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase
    {
        private static readonly List<Car> carList = new List<Car>
        {
            CarsContext.
            new Car {Id = 6, Name = "Range Rover", Color = Colors.Black, Type = Types.Sedan, Year = 2019, Price = 5000000},
            new Car {Id = 6, Name = "Dodge", Color = Colors.White, Type = Types.Sedan, Year = 2013, Price = 2000000}
        };
        [HttpGet]
        public IEnumerable<Car> GetCars()
        {
            return carList;
        }
    }
}
