using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class Fizz : IFizzBuzz
    {
        public int Order
        {
            get { return 2; }
        }
        public int? Number { get; set; }
        public string Description()
        {
            return "Fizz";
        }

        public bool Check()
        {
            return Number % 3 == 0;
        }
    }
}
