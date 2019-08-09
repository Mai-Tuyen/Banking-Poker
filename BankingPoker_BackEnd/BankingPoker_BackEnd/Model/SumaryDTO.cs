using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingPoker_BackEnd.Model
{
    public class SumaryDTO
    {
        public Guid Id { get; set; }
        public Guid PlayerId { get; set; }
        public int SumAdd { get; set; }
        public int SumCutOut { get; set; }
        public int Profit { get; set; }
        public DateTime Date { get; set; }
    }
}
