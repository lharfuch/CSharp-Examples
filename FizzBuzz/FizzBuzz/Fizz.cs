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
        public string Descricao(int i)
        {
            return "Fizz";
        }

        public bool Validar(int i)
        {
            return i % 3 == 0;
        }
    }
}
