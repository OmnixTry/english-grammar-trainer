using EnglishGrammarTrainer.Shared.Enum;
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

        
    }
}
