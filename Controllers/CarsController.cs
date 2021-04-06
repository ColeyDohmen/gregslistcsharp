using System.Collections.Generic;
using gregslistcsharp.DB.cs;
using gregslistcsharp.Models.cs;
using Microsoft.AspNetCore.Mvc;

namespace gregslistcsharp.Controllers
{


    [ApiController]
    [Route("api/[controller]")]
    public class CarsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Car>> Get()
        {
            try
            {
                return Ok(FakeDB.Cars);
            }
            catch (System.Exception err)
            {

                return BadRequest(err.Message);
            }
        }

        [HttpPost]
        public ActionResult<Car> Create([FromBody] Car newCar)
        {
            try
            {
                FakeDB.Cars.Add(newCar);
                return Ok(newCar);
            }
            catch (System.Exception err)
            {

                return BadRequest(err.Message);
            }
        }


    }

}