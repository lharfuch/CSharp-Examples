using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public interface IFizzBuzz
    {
        bool Check();
        string Description();
        int Order { get;}
        int? Number { get; set; }
    }
}
