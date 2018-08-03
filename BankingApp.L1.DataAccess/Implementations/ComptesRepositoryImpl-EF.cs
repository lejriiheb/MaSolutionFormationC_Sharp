using BankingApp.L0.Domain;
using BankingApp.L1.DataAccess.Facade;
using BankingApp.L1.DataAccess.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.L1.DataAccess.Implementations
{
    public class ComptesRepositoryImpl_EF : ICompteRepository
    {
        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Compte> FindAll()
        {
            using (var ctxt = new BanqueContexte())
            {
                return ctxt.Comptes.ToList();
            }
        }

        public Compte FindById(string id)
        {
            using (var ctxt = new BanqueContexte())
            {
                return ctxt.Comptes.FirstOrDefault(c => c.Numero.Equals(id));
            }
        }

        public void OuvrirCompte(Compte c)
        {
            using (var ctxt = new BanqueContexte())
            {
                ctxt.Comptes.Add(c);
                ctxt.SaveChanges();
            }
        }

        public void Update(Compte c)
        {
            throw new NotImplementedException();
        }
    }
}
