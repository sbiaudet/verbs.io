using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace verbs.shared
{
    public static class FrenchGrammar
    {
        public static Dictionary<FrenchTense, string> FrenchTenseName = new Dictionary<FrenchTense, string>() {
            { FrenchTense.IndicatifPresent, "IndicatifPresent"},
            { FrenchTense.IndicatifPasseCompose, "IndicatifPasseCompose"},
            { FrenchTense.IndicatifImparfait, "IndicatifImparfait"},
            { FrenchTense.IndicatifPlusQueParfait, "IndicatifPlusQueParfait"},
            { FrenchTense.IndicatifPasseSimple, "IndicatifPasseSimple"},
            { FrenchTense.IndicatifPasseAnterieur, "IndicatifPasseAnterieur"},
            { FrenchTense.IndicatifFuturSimple, "IndicatifFuturSimple"},
            { FrenchTense.IndicatifFuturAntérieur, "IndicatifFuturAntérieur"},
            { FrenchTense.SubjonctifPresent, "SubjonctifPresent"},
            { FrenchTense.SubjonctifPasse, "SubjonctifPasse"},
            { FrenchTense.SubjonctifImparfait, "SubjonctifImparfait"},
            { FrenchTense.SubjonctifPlusQueParfait, "SubjonctifPlusQueParfait"},
            { FrenchTense.ConditionnelPresent, "ConditionnelPresent"},
            { FrenchTense.ConditionnelPasse1reForme, "ConditionnelPasse1reForme"},
            { FrenchTense.ConditionnelPasse2eforme, "ConditionnelPasse2eforme"},
            { FrenchTense.ImperatifPresent, "ImperatifPresent"},
            { FrenchTense.ImperatifPasse, "ImperatifPasse"}
        };

        public enum FrenchTense
        {
            IndicatifPresent,
            IndicatifPasseCompose,
            IndicatifImparfait,
            IndicatifPlusQueParfait,
            IndicatifPasseSimple,
            IndicatifPasseAnterieur,
            IndicatifFuturSimple,
            IndicatifFuturAntérieur,
            SubjonctifPresent,
            SubjonctifPasse,
            SubjonctifImparfait,
            SubjonctifPlusQueParfait,
            ConditionnelPresent,
            ConditionnelPasse1reForme,
            ConditionnelPasse2eforme,
            ImperatifPresent,
            ImperatifPasse,
            ParticipePresent,
            ParticipePasse,
            InfinitifPresent,
            InfinitifPasse,
            GerondifPresent,
            GerondifPasse
        }

        public enum FrenchForm
        {
            FirstSingular,
            SecondSingular,
            ThirdSingular,
            FirstPlural,
            SecondPlural,
            ThirdPlural
        }

        public static Dictionary<FrenchForm, string> FrenchPronoun = new Dictionary<FrenchForm, string>()
        {
            { FrenchForm.FirstSingular, "je"},
            { FrenchForm.SecondSingular, "tu"},
            { FrenchForm.ThirdSingular, "il"},
            { FrenchForm.FirstPlural, "nous"},
            { FrenchForm.SecondPlural, "vous"},
            { FrenchForm.ThirdPlural, "ils"}
        };

        public static Conjugator UseFrenchGrammar(this Conjugator conjugator)
        {
            conjugator
                .AddFirstGroup();

            return conjugator;
        }

        private static Conjugator AddFirstGroup(this Conjugator conjugator)
        {
            conjugator
                .ConstPattern("avoir", "", (p) =>
                {
                    p.AddForm(FrenchTense.IndicatifPresent, "ai", "as", "a", "avons", "avez", "ont");
                    p.AddForm(FrenchTense.IndicatifPasseCompose, "avoir", FrenchTenseName[FrenchTense.IndicatifPresent], "eu");
                    p.AddForm(FrenchTense.IndicatifImparfait, "avais", "avais", "avait", "avions", "aviez", "avaient");
                    p.AddForm(FrenchTense.IndicatifPlusQueParfait, "avoir", FrenchTenseName[FrenchTense.IndicatifImparfait], "eu");
                    p.AddForm(FrenchTense.IndicatifPasseSimple, "eus", "eus", "eut", "eûmes", "eûtes", "eûrent");
                    p.AddForm(FrenchTense.IndicatifPasseAnterieur, "avoir", FrenchTenseName[FrenchTense.IndicatifPasseSimple], "eu");
                    p.AddForm(FrenchTense.IndicatifFuturSimple, "aurai", "aura", "aura", "aurons", "aurez", "auront");
                    p.AddForm(FrenchTense.IndicatifFuturAntérieur, "avoir", FrenchTenseName[FrenchTense.IndicatifFuturSimple], "eu");
                    p.AddForm(FrenchTense.SubjonctifPresent, "aie", "aies", "ait", "ayons", "ayez", "aient");
                    p.AddForm(FrenchTense.SubjonctifPasse, "avoir", FrenchTenseName[FrenchTense.SubjonctifPresent], "eu");
                    p.AddForm(FrenchTense.SubjonctifImparfait, "eusse", "eusses", "eût", "eussions", "eussiez", "eussent");
                    p.AddForm(FrenchTense.SubjonctifPlusQueParfait, "avoir", FrenchTenseName[FrenchTense.SubjonctifImparfait], "eu");
                    p.AddForm(FrenchTense.ConditionnelPresent, "aurais", "aurais", "aurait", "aurions", "auriez", "auraient");
                    p.AddForm(FrenchTense.ConditionnelPasse1reForme, "avoir", FrenchTenseName[FrenchTense.ConditionnelPresent], "eu");
                    p.AddForm(FrenchTense.ImperatifPresent, "", "aie", "", "ayons", "ayez", "");
                    p.AddForm(FrenchTense.ImperatifPasse, "avoir", FrenchTenseName[FrenchTense.ImperatifPresent], "", "eu", "", "eu", "eu", "");
                })
                .ConstPattern("être", "", (p) =>
                {
                    p.AddForm(FrenchTense.IndicatifPresent, "suis", "es", "est", "sommes", "êtes", "sont");
                    p.AddForm(FrenchTense.IndicatifPasseCompose, "avoir", FrenchTenseName[FrenchTense.IndicatifPresent], "été");
                    p.AddForm(FrenchTense.IndicatifImparfait, "étais", "étais", "était", "étions", "étiez", "étaient");
                    p.AddForm(FrenchTense.IndicatifPlusQueParfait, "avoir", FrenchTenseName[FrenchTense.IndicatifImparfait], "été");
                    p.AddForm(FrenchTense.IndicatifPasseSimple, "fus", "fus", "fut", "fûmes", "fûtes", "fûrent");
                    p.AddForm(FrenchTense.IndicatifPasseAnterieur, "avoir", FrenchTenseName[FrenchTense.IndicatifPasseSimple], "été");
                    p.AddForm(FrenchTense.IndicatifFuturSimple, "serai", "sera", "sera", "serons", "serez", "seront");
                    p.AddForm(FrenchTense.IndicatifFuturAntérieur, "avoir", FrenchTenseName[FrenchTense.IndicatifFuturSimple], "été");
                    p.AddForm(FrenchTense.SubjonctifPresent, "sois", "sois", "soit", "soyons", "soyez", "soient");
                    p.AddForm(FrenchTense.SubjonctifPasse, "avoir", FrenchTenseName[FrenchTense.SubjonctifPresent], "été");
                    p.AddForm(FrenchTense.SubjonctifImparfait, "fusse", "fusses", "fût", "fussions", "fussiez", "fussent");
                    p.AddForm(FrenchTense.SubjonctifPlusQueParfait, "avoir", FrenchTenseName[FrenchTense.SubjonctifImparfait], "été");
                    p.AddForm(FrenchTense.ConditionnelPresent, "serais", "serais", "serait", "serions", "seriez", "seraient");
                    p.AddForm(FrenchTense.ConditionnelPasse1reForme, "avoir", FrenchTenseName[FrenchTense.ConditionnelPresent], "été");
                    p.AddForm(FrenchTense.ImperatifPresent, "", "sois", "", "soyons", "soyez", "");
                    p.AddForm(FrenchTense.ImperatifPasse, "avoir", FrenchTenseName[FrenchTense.ImperatifPresent], "", "éte", "", "été", "été", "");
                })
                .RegexPattern("aller", (p) => {
                })
                .RegexPattern("er$", (p) =>
                {
                    p.AddForm(FrenchTense.IndicatifPresent, "e", "es", "e", "ons", "ez", "ent");
                    p.AddForm(FrenchTense.IndicatifPasseCompose, "avoir", FrenchTenseName[FrenchTense.IndicatifPresent], "é");
                    p.AddForm(FrenchTense.IndicatifImparfait, "ais", "ais", "ait", "ions", "iez", "aient");
                    p.AddForm(FrenchTense.IndicatifPlusQueParfait, "avoir", FrenchTenseName[FrenchTense.IndicatifImparfait], "é");
                    p.AddForm(FrenchTense.IndicatifPasseSimple, "ai", "as", "a", "âmes", "âtes", "èrent");
                    p.AddForm(FrenchTense.IndicatifPasseAnterieur, "avoir", FrenchTenseName[FrenchTense.IndicatifPasseSimple], "é");
                    p.AddForm(FrenchTense.IndicatifFuturSimple, "erai", "eras", "era", "erons", "erez", "eront");
                    p.AddForm(FrenchTense.IndicatifFuturAntérieur, "avoir", FrenchTenseName[FrenchTense.IndicatifFuturSimple], "é");
                    p.AddForm(FrenchTense.SubjonctifPresent, "e", "es", "e", "ons", "ez", "ent");
                    p.AddForm(FrenchTense.SubjonctifPasse, "avoir", FrenchTenseName[FrenchTense.SubjonctifPresent], "é");
                    p.AddForm(FrenchTense.SubjonctifImparfait, "asse", "asses", "ât", "assions", "assiez", "assent");
                    p.AddForm(FrenchTense.SubjonctifPlusQueParfait, "avoir", FrenchTenseName[FrenchTense.SubjonctifImparfait], "é");
                    p.AddForm(FrenchTense.ConditionnelPresent, "e", "es", "e", "ons", "ez", "ent");
                    p.AddForm(FrenchTense.ConditionnelPasse1reForme, "avoir", FrenchTenseName[FrenchTense.ConditionnelPresent], "é");
                    p.AddForm(FrenchTense.ConditionnelPasse2eforme, "avoir", FrenchTenseName[FrenchTense.ConditionnelPresent], "é");
                    p.AddForm(FrenchTense.ConditionnelPresent, "e", "es", "e", "ons", "ez", "ent");
                    p.AddForm(FrenchTense.ImperatifPresent, "", "e", "", "ons", "ez", "");
                    p.AddForm(FrenchTense.ImperatifPasse, "avoir", FrenchTenseName[FrenchTense.ImperatifPresent], "", "é", "", "é", "é", "");
                });

            return conjugator;
        }

        private static Tense AddForm(this AbstractPattern pattern, FrenchTense frenchTense, string all)
        {
            return AddForm(pattern, frenchTense, all, all, all, all, all, all);
        }

        private static Tense AddForm(this AbstractPattern pattern, FrenchTense frenchTense, string auxiliarVerb, string auxiliarTense, string all)
        {
            return AddForm(pattern, frenchTense, auxiliarVerb, auxiliarTense, all, all, all, all, all, all);
        }

        private static Tense AddForm(this AbstractPattern pattern, FrenchTense frenchTense, string firstSingular, string secondSingular, string thirdSingular, string firstPlural, string secondPlural, string thirdPlural)
        {
            return AddForm(pattern, frenchTense, string.Empty, string.Empty, firstSingular, secondSingular, thirdSingular, firstPlural, secondPlural, thirdPlural);
        }

        private static Tense AddForm(this AbstractPattern pattern, FrenchTense frenchTense, string auxiliarVerb, string auxiliarTense, string firstSingular, string secondSingular, string thirdSingular, string firstPlural, string secondPlural, string thirdPlural)
        {

            var tenseName = FrenchTenseName[frenchTense];
            var tense = new Tense(tenseName);
            tense.Conjugator = pattern.Conjugator;
            tense.AuxiliarVerb = auxiliarVerb;
            tense.AuxiliarTense = auxiliarTense;

            pattern.Tenses.Add(tense);

            tense.Forms.Add(FrenchPronoun[FrenchForm.FirstSingular], (pronoun, radical, verb) => radical + firstSingular);
            tense.Forms.Add(FrenchPronoun[FrenchForm.SecondSingular], (pronoun, radical, verb) => radical + secondSingular);
            tense.Forms.Add(FrenchPronoun[FrenchForm.ThirdSingular], (pronoun, radical, verb) => radical + thirdSingular);
            tense.Forms.Add(FrenchPronoun[FrenchForm.FirstPlural], (pronoun, radical, verb) => radical + firstPlural);
            tense.Forms.Add(FrenchPronoun[FrenchForm.SecondPlural], (pronoun, radical, verb) => radical + secondPlural);
            tense.Forms.Add(FrenchPronoun[FrenchForm.ThirdPlural], (pronoun, radical, verb) => radical + thirdPlural);

            return tense;
        }
    }
}
