using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BankingPoker_BackEnd.Entity
{
    public class Sumary
    {
        [Key]
        public Guid Id { get; set; }
        public Guid PlayerId { get; set; }
        public int SumAdd { get; set; }
        public int SumCutOut { get; set; }
        public int Profit { get; set; }
        public DateTime Date { get; set; }
    }
}
