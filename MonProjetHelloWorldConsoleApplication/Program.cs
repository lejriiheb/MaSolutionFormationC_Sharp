using ODDO.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODDO.Clients.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Bienvenue dans C#");
            // Object initializer since C# 3
            Compte c = new Compte { Numero = "C1000", Proprietaire = "Zakaria", Solde = 1000 };
            System.Console.WriteLine(c);
        }
    }
}
