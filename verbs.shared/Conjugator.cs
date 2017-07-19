using System;
using Sprache;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace verbs.shared
{
    public class Conjugator
    {
        public IList<IConjugable> Conjugables = new List<IConjugable>();

        public IEnumerable<FormResult> Conjugate(string verb)
        {
            foreach (var item in Conjugables)
            {
                foreach (var form in item.Conjugate(verb))
                {
                    yield return form;
                }
            }
        }

        public FormResult Conjugate(string tense, string pronoun, string verb)
        {
            return Conjugables.Where(c => c.IsMatch(verb)).FirstOrDefault().Conjugate(tense, pronoun, verb);
        }
    }
}
