using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDelegates
{
    class Program
    {
        delegate void Operation(int x, int y); // Forme de delegation
        static void Main(string[] args)
        {
            //Subscription
            //Operation delegue1 = CalculUtils.Additionner;
            Action<int,int> delegue1 = CalculUtils.Additionner;
            //Another subscription
            delegue1 += CalculUtils.Multiplier;

            //Another subscription using an anonymous delegate
            //delegue1 += delegate (int a, int b)
            //{
            //    Console.WriteLine($"La soustraction de {a} et {b} est égale à : {a - b}");
            //};

            //Expression Lambda
            //delegue1 += (a,b) => 
            //{
            //    Console.WriteLine($"La soustraction de {a} et {b} est égale à : {a - b}");
            //};

            //Notification
            delegue1(11, 22);
        }

    }
}
