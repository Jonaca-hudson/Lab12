﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab12
{
    class RPSGenerator
    {
        List<string> rps = new List<string>();

        public RPSGenerator()
        {
            rps.Add("rock");
            rps.Add("paper");
            rps.Add("sissors");
            
        }
        public string GetByString(string input)
        {
            if(input == "r")
            {
                return rps[0];
            }
            else if (input == "p")
            {
                return rps[1];
            }
            else if (input=="s")
            {
                return rps[2];
            }
            return "-1";
        }
        public string GetByIndex(int i)
        {
            string output;
            try
            {
                output = rps[i];
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("That was not a valid index in the rps lists");
                output = "-1";
            }
            return output;
        }
    }
}
