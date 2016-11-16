using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RogueForumDLL;
using RogueForumDAO;

namespace RogueForumUnitTest
{
    /// <summary>
    /// Description résumée pour UnitTest1
    /// </summary>
    [TestClass]
    public class UnitTestRubrique
    {
        

        [TestMethod]
        public void TestCreationRubrique()
        {
            string expectedString = "Ma Rubrique de test";
            Rubrique rubrique = new Rubrique(1,"Ma Rubrique de test");
            Assert.AreEqual(rubrique.Libelle, expectedString);
        }
        [TestMethod]
        public void TestGetRubriqueByID()
        {
            string expectedString = "Développement";
            Rubrique rubrique = Controller.GetRubriqueByID(1);
            Assert.AreEqual(rubrique.Libelle, expectedString);
        }
    }
}
