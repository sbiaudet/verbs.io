using System;
using System.Collections.Generic;
using System.Text;

namespace verbs.shared
{
    public class Tense
    {

        public delegate string formConjugateDelegate(string pronoun, string verb, string radical);

        public Tense(string name)
        {
            this.Name = name;
        }

        public string Name { get; }

        public string AuxiliarVerb { get; internal set; }
        public string AuxiliarTense { get; internal set; }
        public Conjugator Conjugator { get; set; }

        public Dictionary<string, formConjugateDelegate> Forms = new Dictionary<string, formConjugateDelegate>();

        public IEnumerable<FormResult> Conjugate(IConjugable conjugable, string verb)
        {
            foreach (var item in Forms)
            {
                yield return Conjugate(conjugable, item.Key, verb, item.Value); 
            }
        }

        public FormResult Conjugate(IConjugable conjugable, string pronoun, string verb)
        {
            return Conjugate(conjugable, pronoun, verb, Forms[pronoun]);
        }

        private FormResult Conjugate(IConjugable conjugable, string pronoun, string verb, formConjugateDelegate del)
        {
            return new FormResult()
            {
                Pronoun = pronoun,
                TenseName = Name,
                Auxiliar = !string.IsNullOrEmpty(AuxiliarVerb) ? Conjugator.Conjugate(AuxiliarTense, pronoun, AuxiliarVerb).Verb : string.Empty,
                Verb = del.Invoke(pronoun, conjugable.GetRadical(verb), verb)
            };
        }

    }
}
