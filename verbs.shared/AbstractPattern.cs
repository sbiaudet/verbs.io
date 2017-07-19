using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace verbs.shared
{
    public class AbstractPattern : IConjugable
    {
        public Conjugator Conjugator { get; internal set; }

        public string Name => throw new NotImplementedException();

        public virtual IEnumerable<FormResult> Conjugate(string verb)
        {
            if (IsMatch(verb))
            {
                foreach (var tense in Tenses)
                {
                    foreach (var item in tense.Conjugate(this, verb))
                    {
                        yield return item;
                    };
                }
            }
        }

        public virtual string GetRadical(string verb)
        {
            throw new NotImplementedException();
        }

        public virtual bool IsMatch(string verb)
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<FormResult> Conjugate(string tenseName, string verb)
        {
            if (IsMatch(verb))
            {
                var tense = Tenses.Where(t => t.Name == tenseName).FirstOrDefault();
                return tense.Conjugate(this, verb);
            }

            return null;

        }

        public virtual FormResult Conjugate(string tenseName, string pronoun, string verb)
        {
            if (IsMatch(verb))
            {
                var tense = Tenses.Where(t => t.Name == tenseName).FirstOrDefault();
                return tense.Conjugate(this, pronoun, verb);
            }

            return null;

        }

        internal IList<Tense> Tenses = new List<Tense>();

    }
}
