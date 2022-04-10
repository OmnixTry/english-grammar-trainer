using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishGrammarTrainer.Shared.Contract
{
    public interface ITerminalStructure : IStructure
    {
        string TerminalValue { get; }

        ITerminalStructure[] GetStructure() { return new[] { this }; }
    }
}
