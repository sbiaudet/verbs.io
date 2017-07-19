using System;
using System.Collections.Generic;
using System.Text;

namespace verbs.shared
{
    public interface IConjugable
    {

        string Name { get; }

        bool IsMatch(string verb);

        string GetRadical(string verb);

        IEnumerable<FormResult> Conjugate(string verb);
        IEnumerable<FormResult> Conjugate(string tense, string verb);
        FormResult Conjugate(string tense, string pronoun, string verb);
    }
}
