using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzz:IFizzBuzz
    {
        public int Order
        {
            get { return 1; }
        }
        public string Descricao(int i)
        {
            return "FizzBuzz";
        }

        public bool Validar(int i)
        {
            return i % 3 == 0 && i % 5 == 0;
        }
    }
}
