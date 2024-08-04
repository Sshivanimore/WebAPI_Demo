using Microsoft.AspNetCore.Mvc;
using WebAPI_Demo.Model;
using WebAPI_Demo.Model.Repositories;

namespace WebAPI_Demo.Controllers
{
    [ApiController] //Attribute that defines the controller is an API type
    [Route("api/[Controller]")] //common URL 
    public class ShirtsController : ControllerBase
    {

      

        [HttpGet] //Action method 
        public string GetShirts()
        {
            return "Reading all the shirts";
        }

        //[HttpGet("{id}/{color}")] //Action method with multiple parameter Route
        //public string GetShirtByID(int id, string color)
        //{
        //    return $"Reading all the shirts : {id} , color {color} ";
        //}
        
        //[HttpGet("{id}")] //Action method with parameter from Query string
        //public string GetShirtByID(int id,  [FromQuery] string color)
        //{
        //    return $"Reading all the shirts : {id} , color {color} ";
        //}

        //[HttpGet("{id}")] //Action method with parameter using Header
        //public string GetShirtByID(int id,  [FromHeader(Name = "color")] string color)
        //{
        //    return $"Reading all the shirts : {id} , color {color} ";
        //}
        
        //[HttpGet("{id}")] //Action method with parameter
        //public string GetShirtByID(int id)
        //{
        //    return $"Reading all the shirts : {id}";
        //}
        
        [HttpGet("{id}")] //Action method with parameter
        public IActionResult GetShirtByID(int id)
        {
            if(id <= 0)
            {
                return BadRequest();
            }

            var shirt = ShirtRepository.GetShirtById(id);
            if (shirt == null)
            {
                return NotFound();
            }

            return Ok(shirt);
        }

        //[HttpPost]
        //public string CreateShirt([FromForm] ShirtsModel shirts)
        //{
        //    return "Creating a shirt";
        //}
        
        //[HttpPost]
        //public string CreateShirt([FromBody] ShirtsModel shirts)
        //{
        //    return "Creating a shirt";
        //}
        
        [HttpPost]
        public string CreateShirt([FromBody] ShirtsModel shirts)
        {
            return "Creating a shirt";
        }

        [HttpPut("{id}")]
        public string UpdateShirt(int id) 
        {
            return $"Updating the shirt : {id}";
        }

        [HttpDelete("{id}")]        
        public string DeleteShirt(int id)
        {
            return $"Deleting a shirt : {id}";
        }
    }
}
