using EnglishGrammarTrainer.Shared.Enum;
using EnglishGrammarTrainer.Shared.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishGrammarTrainer.Shared.Entity
{
    public struct ConstraintSegment 
    { 
        SentenceParts SentencePart { get; set; }
        Structure Structure { get; set; }
    } 

    public class Constraint
    {
        public  IReadOnlyList<ConstraintSegment> LinkedStructs { get => _linkedStructs; }
        List<ConstraintSegment> _linkedStructs { get; set; }

        public Constraint() { }

        public Constraint(params ConstraintSegment[] structures) 
        { 
            _linkedStructs = structures.ToList();
        }
    }
}
