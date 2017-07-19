using System;
using System.Collections.Generic;
using System.Text;

namespace verbs.shared
{
    public class FormResult
    {
        public string TenseName { get; set; }
        public string Pronoun { get; set; }
        public string Auxiliar { get; set; }
        public string Verb { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
