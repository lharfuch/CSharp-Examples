using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class Buzz : IFizzBuzz
    {
        public int Order
        {
            get { return 3; }
        }

        public int? Number { get; set; }

        public string Description()
        {
            return "Buzz";
        }

        public bool Check()
        {
            return Number % 5 == 0;
        }
    }
}
