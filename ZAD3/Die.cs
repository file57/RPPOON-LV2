using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD3
{
    class Die
    {
        private int numberOfSides;
        RandomGenerator randGenerator = RandomGenerator.GetInstance();
        public Die(int numberOfSides)
        {
            this.numberOfSides = numberOfSides;
        }
        public int Roll()
        {
            return randGenerator.NextInt(1, numberOfSides + 1);
        }
    }
}
