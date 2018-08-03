using System;
using BankingApp.L0.Domain;
using BankingApp.L1.DataAccess.Implementations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.L1.DataAccess.Tests
{
    [TestClass]
    public class UnitTestComptesRepositoryImpl_EF
    {
        [TestMethod]
        public void TestOuvrirCompte()
        {
            //ARRANGE
            var c = new Compte
            {
                Numero = "C100",
                Proprietaire = "Mohamed Amin",
                Solde = 100M
            };
            var underTest = new ComptesRepositoryImpl_EF();

            //ACT
            underTest.OuvrirCompte(c);

            //ASSERT
            //SI on arrive ici avec succès, c'est que c'est bon ..
        }

        [TestMethod]
        public void TestFindById()
        {
            var id = "C100";
            //ARRANGE
            var expected = new Compte
            {
                Numero = "C100",
                Proprietaire = "Mohamed Amin",
                Solde = 100M
            };
            var underTest = new ComptesRepositoryImpl_EF();

            //ACT
            var actual = underTest.FindById(id);

            //ASSERT
            Assert.AreEqual(expected, actual);
        }
    }
}
