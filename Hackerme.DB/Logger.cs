using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerme.DB
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Debug.WriteLine("{0} {1} {2}", DateTime.Now, Environment.UserName, message); ;
        }
    }


    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            Debug.WriteLine("FILE ______  {0} {1} {2}", DateTime.Now, Environment.UserName, message); ;
        }
    }
}
