using EnglishGrammarTrainer.Shared.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishGrammarTrainer.Shared.Extensions
{
    public static class EnumExtensions
    {
        public static string Name(this PartOfSpeach partOfSpeach)
        {
            return partOfSpeach.ToString();
        }
    }
}
