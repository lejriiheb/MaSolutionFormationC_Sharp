using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDelegates
{
    class CalculUtils
    {
        internal static void Additionner(int a, int b)
        {
            Console.WriteLine($"La somme de {a} et {b} est égale à : {a + b}");
        }

        internal static void Multiplier(int a, int b)
        {
            Console.WriteLine($"Le produit de {a} et {b} est égale à : {a * b}");
        }
    }
}
