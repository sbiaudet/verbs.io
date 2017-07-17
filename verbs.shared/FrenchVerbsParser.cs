using System;
using Sprache;
using System.Linq;
using System.Text.RegularExpressions;

namespace verbs.shared
{
    public static class FrenchVerbsParser
    {
        public static void ParseVerb(string verb){
            
        }

        private const string ThirdGroupFirstSubGroupList = "tenir - s'abstenir - appartenir - contenir - détenir - entretenir - maintenir - obtenir - retenir - soutenir - venir - avenir - advenir - bienvenir - circonvenir - contrevenir - convenir - devenir - disconvenir - intervenir - obvenir - parvenir - prévenir - provenir - redevenir - se ressouvenir - revenir - se souvenir - subvenir - survenir - acquérir - conquérir - s'enquérir - quérir - reconquérir - requérir - sentir - consentir - pressentir - ressentir - mentir - démentir - partir - départir - repartir - se repentir - sortir - - désassortir - rassortir - ressortir - vêtir - dévêtir - revêtir - survêtir - ouvrir - couvrir - découvrir - redécouvrir - recouvrir - entrouvrir - rentrouvrir - rouvrir - offrir - souffrir - cueillir - accueillir - recueillir - assaillir - saillir - tressalllir - défaillir - faillir - bouillir - débouillir - dormir - endormir - rendormir - courir - accourir - concourir - discourir - encourir - parcourir - recourir - secourir - mourir - servir - desservir - resservir - fuir - s'enfuir - gésir - tressaillir - racabouillir - issir - ouïr - férir";
        private static readonly Parser<bool> FirstGroup = Parse.Regex("er$").Token().Return(true);
        private static readonly Parser<bool> SecondGroup = Parse.Regex("ir$").Token().Return(false);

        private static readonly string[] ThirdGroupFirstSubGroup = Regex.Split(ThirdGroupFirstSubGroup, @"\s[-]\s");



    }
}
