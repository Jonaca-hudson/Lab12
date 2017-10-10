using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Randy : Player
    {
        public Randy(RPSGenerator ra) : base(ra)
        {
            name = "Randy";
        }
        public override string GenerateRPS()
        {
            int i = 0;

            Random rndm = new Random();
            i = rndm.Next(0, 3);
            string rndmChoice = rpsList.GetByIndex(i);

            return rndmChoice;
        }
    }
}
