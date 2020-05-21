using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD4
{
    class FileLogger : ILogger
    {
        private string filePath;
        public FileLogger(string filePath)
        {
            this.filePath = filePath;
        }
        public void Log(string message)
        {
            using (System.IO.StreamWriter writer =
                new System.IO.StreamWriter(this.filePath))
            {
                writer.WriteLine(message);
            }
        }
    }
}
