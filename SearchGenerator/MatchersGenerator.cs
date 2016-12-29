using System;
using System.Collections.Generic;
using System.Linq;

namespace SearchGenerator
{
    internal static class MatchersGenerator
    {
        private static bool BitIsSet(int b, int pos)
        {
            return (b & (1 << pos)) != 0;
        }

        public static IEnumerable<GeneratedFile> Generate(Flag[] flags)
        {
            var totalMatchers = Math.Pow(2, flags.Length);
            for (int i = 0; i < totalMatchers; i++)
            {
                var content = new Matcher(FilterFlags(flags, i), i).Execute();
                yield return new GeneratedFile
                {
                    Name = $"GenMatcher{i}.cs",
                    Content = content
                };
            }
        }

        private static Flag[] FilterFlags(Flag[] flags, int matcherId)
        {
            return flags.Where((flag, index) => BitIsSet(matcherId, index)).ToArray();
        }
    }
}
