using System.Collections.Generic;

namespace SearchGenerator
{
    public static class SearchGeneration
    {
        public static List<GeneratedFile> Generate()
        {
            var flags = new[]
            {
                new Flag {Name = c => c.NonClosedOnly, Condition = post => post.IsClosed},
                new Flag {Name = c => c.NoAnswerOnly, Condition = post => post.AnswerCount > 0},
                new Flag {Name = c => c.BountiesOnly, Condition = post => post.BountyAmount == 0}
            };

            var list = new List<GeneratedFile> { SwitchGenerator.GenerateSwitch(flags) };
            list.AddRange(MatchersGenerator.Generate(flags));
            return list;
        }
    }
}
