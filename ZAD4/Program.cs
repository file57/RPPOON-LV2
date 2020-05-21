using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD4
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Die die = new Die(6);

            DiceRoller diceRoller1 = new DiceRoller();

            DiceRoller diceRoller2 = new DiceRoller(@"E:\file.txt");

            diceRoller1.InsertDie(die);
            diceRoller1.RollAllDice();
            diceRoller1.LogRollingResults();

            diceRoller2.InsertDie(die);
            diceRoller2.RollAllDice();
            diceRoller2.LogRollingResults();

        }
    }
}
