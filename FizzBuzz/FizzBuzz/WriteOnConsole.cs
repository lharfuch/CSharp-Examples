using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class WriteOnConsole : IWriter
    {
        IFizzBuzz _obj = null;
        public WriteOnConsole(IFizzBuzz obj)
        {
            _obj = obj;
        }

        public void Write()
        {
            Console.WriteLine(_obj.Description());
        }
    }
}
