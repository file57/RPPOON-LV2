using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD2
{
    class Die
    {
        private int numberOfSides;
        private Random randomGenerator;
        public Die(int numberOfSides, Random randomGenerator)
        {
            this.numberOfSides = numberOfSides;
            this.randomGenerator = randomGenerator;
        }
        public int Roll()
        {
            return randomGenerator.Next(1, numberOfSides + 1);
        }
    }
}
