using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FruitsAPIController : ControllerBase
    {
        public List<string> fruits = new List<string>()
        {
            "Apple",
            "Banana",
            "Mango",
            "Cherry",
            "Grapes",

        };

        [HttpGet]
        public List<string> GetFruits()
        { return fruits; 
        }

        [HttpGet("{id}")]
        public string GetFruitsByIndex(int id)
        {
            return fruits.ElementAt(id);
        }


        [HttpPost]
        public ActionResult<List<string>> AddFruit([FromBody] string newFruit)
        {
            if (string.IsNullOrWhiteSpace(newFruit))
                return BadRequest("Fruit name cannot be empty");

            fruits.Add(newFruit);
            return Ok(fruits); 
        }

        
        [HttpPut("{id}")]
        public ActionResult<List<string>> UpdateFruit(int id, [FromBody] string updatedFruit)
        {
            if (id < 0 || id >= fruits.Count)
                return NotFound("Fruit not found");

            if (string.IsNullOrWhiteSpace(updatedFruit))
                return BadRequest("Fruit name cannot be empty");

            fruits[id] = updatedFruit;
            return Ok(fruits);
        }

        
        [HttpDelete("{id}")]
        public ActionResult<List<string>> DeleteFruit(int id)
        {
            if (id < 0 || id >= fruits.Count)
                return NotFound("Fruit not found");

            fruits.RemoveAt(id);
            return Ok(fruits);
        }

    }
}
