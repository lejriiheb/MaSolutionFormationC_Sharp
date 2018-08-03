using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDelegates
{
    class DemoLINQ
    {
        static void Main(string[] args)
        {
            var particiants =
              new List<string> {
                   "mohamed Amine" , "Khalil" , "Abdessalem" , "Othman" , "Oussama" , "Ahmed" };

            var filtres_extension_style = particiants.Where(p => p.StartsWith("A"));

            var filtres_query_style = from p in particiants where p.StartsWith("A") select p;
        }
    }
}
