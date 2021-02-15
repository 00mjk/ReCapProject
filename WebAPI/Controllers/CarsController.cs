using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{

    [Route("[controller]")]
    [ApiController]

    public class CarsController : ControllerBase
    {
        ICarService _carsService;

        public CarsController(ICarService carsService)
        {
            _carsService = carsService;
        }

        //[HttpGet]
        //public IActionResult GetAll()
        //{
        //    var result = _carsService.GetAll();
        //    if (result.Success)
        //    {
        //        return Ok(result);

        //    }
        //    return BadRequest(result);
        //}
        [HttpGet("carDetails")]

        public IActionResult GetCarDetails()
        {
            var result = _carsService.GetCarDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("Add")]

        public IActionResult Add(Car car)
        {
            var result = _carsService.Add(car);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("GetByCarId")]
        public IActionResult GetByCarId(int id)
        {
            var result = _carsService.GetCarId(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
    }
}
