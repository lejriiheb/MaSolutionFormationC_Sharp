using BankingApp.L0.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.L1.DataAccess.Facade
{
    public interface ICompteRepository
    {
        void OuvrirCompte(Compte c);
        Compte FindById(string id);
        IEnumerable<Compte> FindAll();
        void Update(Compte c);
        void Delete(string id);
    }
}
