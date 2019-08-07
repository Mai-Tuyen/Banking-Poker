using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BankingPoker_BackEnd.Entity
{
    public class BuyInDetail
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("Player")]
        public Guid PlayerId { get; set; }
        public int NumberAdd { get; set; }
        public DateTime TimeAdd { get; set; }
        public Player Player { get; set; }

    }
}
