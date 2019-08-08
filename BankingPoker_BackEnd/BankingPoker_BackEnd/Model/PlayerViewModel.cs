using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingPoker_BackEnd.Model
{
    public class PlayerViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int SumAdd { get; set; }
    }
}
