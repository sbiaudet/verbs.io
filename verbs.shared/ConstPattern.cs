using System;
using System.Collections.Generic;
using System.Text;

namespace verbs.shared
{
    public class ConstPattern : AbstractPattern
    {
        private readonly string str;
        private readonly string radical;

        public ConstPattern(string str, string radical)
        {
            this.str = str;
            this.radical = radical;
        }

        public override string GetRadical(string verb)
        {
            return radical;
        }

        public override bool IsMatch(string verb)
        {
            return verb == this.str;
        }
    }
}
