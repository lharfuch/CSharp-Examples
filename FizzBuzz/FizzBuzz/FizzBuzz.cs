using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzz : IFizzBuzz
    {
        public int Order
        {
            get { return 1; }
        }

        public int? Number { get; set; }

        public string Description()
        {
            return "FizzBuzz";
        }

        public bool Check()
        {
            return Number % 3 == 0 && Number % 5 == 0;
        }
    }
}
