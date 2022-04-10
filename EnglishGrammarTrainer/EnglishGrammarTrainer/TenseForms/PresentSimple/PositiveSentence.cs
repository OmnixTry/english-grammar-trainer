using EnglishGrammarTrainer.Shared.Entity;
using EnglishGrammarTrainer.Shared.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishGrammarTrainer.TenseForms.PresentSimple
{
    internal class PositiveSentence : Sentence
    {
        public PositiveSentence(): base()
        {
            // predicate
            var subject = GenerateParts(PartOfSpeach.NN, PartOfSpeach.NNS, PartOfSpeach.NNP, PartOfSpeach.NNPS, PartOfSpeach.PRP);
            var predicate = GenerateParts(PartOfSpeach.VB, PartOfSpeach.VBP, PartOfSpeach.VBZ);
        }
    }
}
