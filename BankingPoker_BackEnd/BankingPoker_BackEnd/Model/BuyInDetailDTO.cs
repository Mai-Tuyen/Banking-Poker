using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingPoker_BackEnd.Model
{
    public class BuyInDetailDTO
    {
        public Guid Id { get; set; }

        public Guid PlayerId { get; set; }
        public int NumberAdd { get; set; }
        public DateTime TimeAdd { get; set; }
    }
}
