using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BankingPoker_BackEnd.Entity
{
    public class BuyInDetail
    {
        [Key]
        public Guid Id { get; set; }

        public Guid PlayerId { get; set; }
        public int NumberAdd { get; set; }
        public DateTime TimeAdd { get; set; }
        public Player MyProperty { get; set; }

    }
}
