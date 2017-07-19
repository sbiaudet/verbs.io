using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sprache;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace verbs.shared.tests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void ConjugateAvoir()
        {
            var conjugator = new Conjugator().UseFrenchGrammar();
            var form = conjugator.Conjugate("IndicatifPasseCompose", "je", "avoir");
            Assert.AreEqual(form.Pronoun, "je");
            Assert.AreEqual(form.Auxiliar, "ai");
            Assert.AreEqual(form.Verb, "eu");
        }

        [TestMethod]
        public void ConjugateFullAimer()
        {
            var conjugator = new Conjugator().UseFrenchGrammar();
            var forms = new List<FormResult>(conjugator.Conjugate("aimer"));
            Assert.AreEqual(forms[0].Verb, "aime");
        }

        
    }
}
