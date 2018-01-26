using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    /// <summary>
    /// if (theNumber is divisible by 3) then
	/// print "Fizz"
    /// else if (theNumber is divisible by 5) then
    /// print "Buzz"
    /// else /* theNumber is not divisible by 3 or 5 */
	/// print theNumber
    /// end if
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            IList<string> classes = GetAllConcretNamesFizzBuzz<IFizzBuzz>();
            IList<IFizzBuzz> instances = GetConcretClasses<IFizzBuzz>(classes);

            for (int i = 1; i <= 100; i++)
            {
                foreach (var item in instances.OrderBy(x => x.Order))
                {
                    if (DoTheJob(item, i))
                        break;
                }
            }
            Console.ReadLine();
        }

        static bool DoTheJob(IFizzBuzz obj, int i)
        {
            IWriter w = null;
            string description = string.Empty;
            obj.Number = i;
            if (obj.Check())
            {
                w = new WriteOnConsole(obj);
                w.Write();
                return true;
            }
            return false;
        }

        static IList<string> GetAllConcretNamesFizzBuzz<T>()
        {
            return AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes())
                 .Where(x => typeof(T).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
                 .Select(x => x.FullName).ToList();
        }

        static IList<T> GetConcretClasses<T>(IList<string> classes)
        {
            List<T> instances = new List<T>();
            string assemblyName = System.Reflection.Assembly.GetEntryAssembly().GetName().Name;
            System.Reflection.Assembly assembly = System.Reflection.Assembly.Load(assemblyName);

            Type typeClass = null;

            foreach (var item in classes)
            {
                typeClass = assembly.GetType(item);
                T instance = (T)Activator.CreateInstance(typeClass);
                instances.Add(instance);
            }
            return instances;
        }
    }
}
