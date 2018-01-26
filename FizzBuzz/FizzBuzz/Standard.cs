using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class Standard : IFizzBuzz
    {
        public int Order
        {
            get { return 99; }
        }
        public int? Number { get; set; }
        public string Description()
        {
            return Number.ToString();
        }

        public bool Check()
        {
            return !(Number % 3 == 0 && Number % 5 == 0);
        }
    }
}
