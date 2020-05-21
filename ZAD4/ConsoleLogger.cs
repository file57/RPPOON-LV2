using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD4
{
    class ConsoleLogger : ILogger
    { 
        public void Log(string message)
        {
            Console.WriteLine(message);  
        }
    }
}
