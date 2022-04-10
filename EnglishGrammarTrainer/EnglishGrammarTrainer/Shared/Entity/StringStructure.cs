using EnglishGrammarTrainer.Shared.Contract;
using EnglishGrammarTrainer.Shared.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishGrammarTrainer.Shared.Impl
{
    public class StringStructure: Structure
    {
        public string Text { get; set; }

        public override string DisplayText()
        {
            return Text;
        }
    }
}
