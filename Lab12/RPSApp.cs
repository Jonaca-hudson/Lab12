using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class RPSApp
    {
        public RPSApp(RPSGenerator rps)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine(); 
            name = name.ToLower();
        }
        public string GameOn()
        {
            Console.WriteLine("Who would you like to play against, Lenny or Randy?");

            string players = Console.ReadLine();
            players = players.ToLower();

            if (players == "randy")
            {
                RPSGenerator rps = new RPSGenerator();
                Randy ra = new Randy(rps);
                Console.WriteLine(ra.GenerateRPS());
            }
            else if (players == "lenny")
            {
                RPSGenerator rps = new RPSGenerator();
                Rockstar r = new Rockstar(rps);
                Console.WriteLine(r.GenerateRPS());
            }
            else
            {
                Console.WriteLine("That is not a valid player.");
            }

            Console.WriteLine("Rock, Paper or Scissors? R/P/S");
            string gameAnswer = Console.ReadLine();
            gameAnswer = gameAnswer.ToLower();
            

            /*if (name == "r" && players == "paper")
            {
                Console.WriteLine(name + ": rock");
                Console.WriteLine(players + ": paper");
                Console.WriteLine(name + "wins!");
            }
            if (name == "p" && players == "paper")
            {
                Console.WriteLine(name + ": paper");
                Console.WriteLine(players + ": paper");
                Console.WriteLine("Issa draw!");
            }
            if (name == "s" && players == "paper")
            {
                Console.WriteLine(name + ": scissors");
                Console.WriteLine(players + ": paper");
                Console.WriteLine(players+ "wins!");
            }*/

                return players;
        }
        public virtual string GenerateRPS()
        {
            throw new NotImplementedException();
        }


    }
}
