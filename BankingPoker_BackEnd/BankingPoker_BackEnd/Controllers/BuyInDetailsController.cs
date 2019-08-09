using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankingPoker_BackEnd.Entity;
using BankingPoker_BackEnd.Service.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BankingPoker_BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuyInDetailsController : ControllerBase
    {
        private readonly IBuyInDetailRepository buyInDetailRepository;
        private readonly ISumaryRepository sumaryRepository;


        public BuyInDetailsController(IBuyInDetailRepository buyInDetailRepository, ISumaryRepository sumaryRepository)
        {
            this.buyInDetailRepository = buyInDetailRepository;
            this.sumaryRepository = sumaryRepository;
        }

        // GET: api/BuyInDetails
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/BuyInDetails/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/BuyInDetails
        [HttpPost]
        public IActionResult CreateBuyInDetail([FromBody] BuyInDetail newBuyInDetail)
        {
            if (newBuyInDetail == null)
            {
                return BadRequest();
            }
            buyInDetailRepository.CreateBuyInDetail(newBuyInDetail);
            if (!buyInDetailRepository.Save())
            {
                throw new Exception("Create new Buyin detail failed on save");
            }
            else
            {
                sumaryRepository.UpdateSumary(newBuyInDetail.NumberAdd, newBuyInDetail.PlayerId);
                if (!sumaryRepository.Save())
                {
                    throw new Exception("Update sumary failed on save");
                }
            }

            return Ok();
        }

        // PUT: api/BuyInDetails/5
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
