using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using static verbs.shared.Tense;

namespace verbs.shared
{
    public static class ConjugatorExtensions
    {

        public static RegexPattern RegexPattern(this Conjugator conjugator, string pattern)
        {
            var res = new RegexPattern(pattern);
            conjugator.Conjugables.Add(res);
            res.Conjugator = conjugator;
            return res;
        }

        public static Conjugator RegexPattern(this Conjugator conjugator, string pattern, Action<RegexPattern> action)
        {
            action(RegexPattern(conjugator, pattern));
            return conjugator;
        }

        public static ConstPattern ConstPattern(this Conjugator conjugator, string pattern, string radical)
        {
            var res = new ConstPattern(pattern, radical);
            conjugator.Conjugables.Add(res);
            res.Conjugator = conjugator;
            return res;
        }

        public static Conjugator ConstPattern(this Conjugator conjugator, string pattern, string radical, Action<ConstPattern> action)
        {
            action(ConstPattern(conjugator, pattern, radical));
            return conjugator;
        }

        public static Conjugator ConstPattern(this Conjugator conjugator, string[] patternList, string radical, Action<ConstPattern> action)
        {
            foreach (var pattern in patternList)
            {
                action(ConstPattern(conjugator, pattern, radical));
            }

            return conjugator;
        }

        public static Tense Tense(this AbstractPattern Pattern, string name)
        {
            var res = new Tense(name);
            Pattern.Tenses.Add(res);
            return res;
        }


        public static Conjugator AddForm(this Conjugator conjugator, Tense tense, Expression<Func<Tense, formConjugateDelegate>> form, formConjugateDelegate action)
        {
            throw new NotImplementedException();
        }
    }
}
