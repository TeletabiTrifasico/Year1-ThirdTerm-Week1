using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    internal class YahtzeeGame
    {
        Dice[] dices = new Dice[5];
        Random rand;
        public YahtzeeGame()
        {
            rand = new Random();
            for (int i = 0; i < dices.Length; i++)
            {
                dices[i] = new Dice(rand);
            }
        }
        public void Throw()
        {
            for(int i = 0; i < dices.Length; i++)
            {
                dices[i].Throw();
            }
        }
        public void DisplayValues()
        {
            for (int i = 0; i < dices.Length; i++)
            {
                dices[i].DisplayValue();
            }
            Console.WriteLine();
        }
        public bool Yahtzee()
        {
            int first = dices[0].value;
            for (int i = 1; i < dices.Length; i++)
            {
                if (dices[i].value != first)
                { 
                    return false; 
                }
            }
            return true;
        }
    }
}
