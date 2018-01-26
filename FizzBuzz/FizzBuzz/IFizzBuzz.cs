using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public interface IFizzBuzz
    {
        bool Validar(int i);
        string Descricao(int i);
        int Order { get;}
    }
}
