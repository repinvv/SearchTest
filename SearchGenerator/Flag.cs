using System;
using System.Linq.Expressions;
using SearchTypes;

namespace SearchGenerator
{
    public class Flag
    {
        public Expression<Func<SearchCriteria, bool>>  Name { get; set; }

        public Expression<Func<Post, bool>>  Condition { get; set; }
    }
}
