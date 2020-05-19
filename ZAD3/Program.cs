using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD3
{
    class Program
    {
        static void Main(string[] args)
        {
            DiceRoller diceRoller = new DiceRoller();
            Die[] dieArray = new Die[20];
            
            for (int i = 0; i < dieArray.Length; i++)
            {
                
                dieArray[i] = new Die(6);
            }

            foreach (Die die in dieArray)
            {
                diceRoller.InsertDie(die);

            }

            diceRoller.RollAllDice();
            Console.WriteLine("Broj kockica = {0}", diceRoller.DiceCount);
            Console.WriteLine("-------------------");

            for (int i = 0; i < dieArray.Length; i++)
            {
                Console.WriteLine("Kockica {0} = {1}", i + 1, diceRoller.GetRollingResults()[i]);
            }
        }
    }
}
