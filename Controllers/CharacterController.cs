using Microsoft.AspNetCore.Mvc;
using RPG.Models;

namespace Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    { 
        private static Character Strength = new Character();
        

        [HttpGet]
        public ActionResult<Character> Get()
        {
            return Ok(Strength);
        }

    }
}