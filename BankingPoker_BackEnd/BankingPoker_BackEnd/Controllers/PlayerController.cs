using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankingPoker_BackEnd.Entity;
using BankingPoker_BackEnd.Model;
using BankingPoker_BackEnd.Service.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BankingPoker_BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly IPlayerRepository playerRepository;
        private readonly ISumaryRepository sumaryRepository;
        public PlayerController(IPlayerRepository playerRepository, ISumaryRepository sumaryRepository)
        {
            this.playerRepository = playerRepository;
            this.sumaryRepository = sumaryRepository;
        }
        // GET: api/Player
        [HttpGet]
        public IActionResult GetListPlayer()
        {
            return Ok(playerRepository.GetListPlayer());
        }

        //// GET: api/Player/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/Player
        [HttpPost]
        public IActionResult CreatePlayer([FromBody] Player newPlayer)
        {
            if (newPlayer == null)
            {
                return BadRequest();
            }

            if (playerRepository.CheckExistPlayerName(newPlayer.Name))
            {
                return BadRequest();
            }

            playerRepository.CreatePlayer(newPlayer);
            if (!playerRepository.Save())
            {
                throw new Exception("Create a new player failed on save");
            }
            else
            {
                var playerSumary = new Sumary()
                {
                    PlayerId = newPlayer.Id,
                    SumAdd = 0,
                    SumCutOut = 0,
                    Date = DateTime.Now,
                    Profit = 0
                };

                sumaryRepository.CreateSumary(playerSumary);
                if (!sumaryRepository.Save())
                {
                    throw new Exception("Create a new player sumary failed on save");
                }
            }


            return Ok(new PlayerDTO() { Id = newPlayer.Id, Name = newPlayer.Name, SumAdd = 0 });
        }

        // PUT: api/Player/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
