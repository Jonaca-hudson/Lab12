using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab12
{
    abstract class Player
    {
        protected string name;
        protected RPSGenerator rpsList;

        public Player(RPSGenerator r)
        {
            rpsList = r;
        }
        
        public string GetName()
        {
            return name;
        }
        //making it abstract ensures that the children use this method
        public abstract string GenerateRPS();
        
        
    }
}
