using EnglishGrammarTrainer.Shared.Contract;
using EnglishGrammarTrainer.Shared.Entity;
using EnglishGrammarTrainer.Shared.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishGrammarTrainer.Shared.Impl
{
    public class StringStructure: Structure
    {
        public virtual string[] Texts { get; }

        public StringStructure(PartOfSpeach partOfSpeach, params string[] texts): base(partOfSpeach)
        {
            if (texts.Any())
            {
                Texts = texts;
            }
        }

        public override string DisplayText()
        {
            return String.Concat(Texts);
        }

        public override bool DoesFit(IStructure structure)
        {
            if(structure is StringStructure)
            {
                if (!base.DoesFit(structure))
                {
                    return false;
                }

                foreach (var item in (structure as StringStructure).Texts)
                {
                    if (!Texts.Contains(item))
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
    }
}
