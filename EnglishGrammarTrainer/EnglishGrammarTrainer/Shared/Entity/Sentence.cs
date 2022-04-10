using EnglishGrammarTrainer.Shared.Enum;
using EnglishGrammarTrainer.Shared.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishGrammarTrainer.Shared.Entity
{
    public class Sentence
    {
        internal Dictionary<SentenceParts, List<Structure>> SentenceParts { get; set; }
        internal List<Constraint> Constraints { get; set; }  

        public Sentence()
        {
            SentenceParts = new Dictionary<SentenceParts, List<Structure>>();
        }

        protected virtual Structure[] GenerateParts(params PartOfSpeach[] partsOfSpeach)
        {
            return partsOfSpeach.SelectArray(x => new Structure() { Tag = x });
        }
    }
}
