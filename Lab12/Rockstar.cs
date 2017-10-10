using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Rockstar :Player
    {
        public Rockstar(RPSGenerator r) : base(r)
        {
            name = "Lenny";
        }
        public override string GenerateRPS()
        {
            return rpsList.GetByIndex(0);
        }
    }
}
