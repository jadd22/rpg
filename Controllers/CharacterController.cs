using Microsoft.AspNetCore.Mvc;
using RPG.Models;

namespace Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    { 
        private static Character Strength = new Character();
        

        public IActionResult Get()
        {
            return NotFound(Strength);
        }

    }
}