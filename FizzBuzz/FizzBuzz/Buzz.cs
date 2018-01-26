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
        public string Descricao(int i)
        {
            return "Buzz";
        }

        public bool Validar(int i)
        {
            return i % 5 == 0;
        }
    }
}
