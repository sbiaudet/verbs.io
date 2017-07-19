using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace verbs.shared
{
    public class RegexPattern : AbstractPattern
    {
        private readonly Regex pattern;

        public RegexPattern(string pattern)
        {
            this.pattern = new Regex(pattern);
        }

        public override string GetRadical(string verb)
        {
            if (IsMatch(verb))
            {
                return pattern.Replace(verb, "");
            }

            return "";
        }

        public override bool IsMatch(string verb)
        {
            return pattern.IsMatch(verb);
        }


    }
}
