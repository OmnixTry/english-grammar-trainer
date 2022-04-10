using EnglishGrammarTrainer.Shared.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishGrammarTrainer.Shared.Contract
{
    public interface IStructure
    {
        PartOfSpeach Tag { get; set;  }

        bool DoesFit(IStructure structure);
    }
}
