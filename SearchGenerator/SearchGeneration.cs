using System.Collections.Generic;

namespace SearchGenerator
{
    public static class SearchGeneration
    {
        public static List<GeneratedFile> Generate()
        {
            var flags = new[]
            {
                new Flag {Name = "NonClosedOnly", Condition = "IsClosed"},
                new Flag {Name = "NoAnswerOnly", Condition = "AnswerCount > 0"},
                new Flag {Name = "BountiesOnly", Condition = "BountyAmount == 0"}
            };

            var list = new List<GeneratedFile> {SwitchGenerator.GenerateSwitch(flags)};
            list.AddRange(MatchersGenerator.Generate(flags));
            return list;
        }
    }
}
