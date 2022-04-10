using EnglishGrammarTrainer.Shared.Contract;
using EnglishGrammarTrainer.Shared.Enum;
using EnglishGrammarTrainer.Shared.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishGrammarTrainer.Shared.Entity
{
    public class Structure : IStructure
    {
        public PartOfSpeach Tag { get; set; }

        public Structure(PartOfSpeach partOfSpeach)
        {
            Tag = partOfSpeach;
        }

        public virtual string DisplayText()
        {
            return '<' + Tag.Name() + '>';
        }

        public virtual bool DoesFit(IStructure structure)
        {
            return Tag == structure.Tag;
        }
    }
}
