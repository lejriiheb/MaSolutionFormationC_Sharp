using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODDO.Domain
{
    public class Compte
    {
        public string Numero { get; set; }  //Auto-implemented (prop+tab,tab)
        public string Proprietaire { get; set; }
        public decimal Solde { get; set; }

        public void Débiter(decimal montant)
        {
            Solde -= montant;
        }
        public void Créditer(decimal montant)
        {
            Solde += montant;
        }

        public override string ToString()
        {
            return "Compte : ["+ Numero +" - "+ Proprietaire + " - "+ Solde +" ]";
        }
    }
}
