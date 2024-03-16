using Mapster;
using Microsoft.AspNetCore.Mvc;
using transferObject.Dtos;
using transferObject.Models;

namespace transferObject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharactersController : Controller
    {
        private static readonly List<Character> Characters = new List<Character>
        {
            new Character
            {
                Name = "Frodo",
                Class = "Warrior",
                Level = 1,
                Inventory = new List<Item>
                {
                    new Item
                    {
                        Name = "Stick",
                        Type = "Weapon",
                        Power = 10
                    }
                }
            },

            new Character
            {
                Name = "Gandalf",
                Class = "Mage",
                Level = 99,
                Inventory = new List<Item>
                {
                    new Item
                    {
                        Name = "Glamdring",
                        Type = "Sword",
                        Power = 100
                    }
                }
            }
        };


        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var characters = Characters.Adapt<List<CharacterDto>>();
            return Ok(characters);
        }
    }
}
