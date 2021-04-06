using System.Collections.Generic;
using gregslistcsharp.DB.cs;
using gregslistcsharp.Models.cs;
using Microsoft.AspNetCore.Mvc;

namespace gregslistcsharp.Controllers
{


    [ApiController]
    [Route("api/[controller]")]
    public class HousesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<House>> Get()
        {
            try
            {
                return Ok(FakeDB.Houses);
            }
            catch (System.Exception err)
            {

                return BadRequest(err.Message);
            }
        }

        [HttpPost]
        public ActionResult<House> Create([FromBody] House newHouse)
        {
            try
            {
                FakeDB.Houses.Add(newHouse);
                return Ok(newHouse);
            }
            catch (System.Exception err)
            {

                return BadRequest(err.Message);
            }
        }

        [HttpGet("{houseId}")]
        public ActionResult<House> GetHouse(string houseId)
        {
            try
            {
                House houseFound = FakeDB.Houses.Find(c => c.Id == houseId);
                if (houseFound == null)
                {
                    throw new System.Exception("House does not exist");
                }
                return Ok(houseFound);
            }
            catch (System.Exception err)
            {

                return BadRequest(err.Message);
            }
        }

        [HttpDelete("{houseId}")]
        public ActionResult<string> DeleteHouse(string houseId)
        {
            try
            {
                House houseToDelete = FakeDB.Houses.Find(c => c.Id == houseId);
                if (FakeDB.Houses.Remove(houseToDelete))
                {
                    return Ok("House Removed");
                }
                else
                {
                    throw new System.Exception("This house does not exist yo.");
                }
            }
            catch (System.Exception err)
            {

                return BadRequest(err.Message);
            }
        }

    }

}