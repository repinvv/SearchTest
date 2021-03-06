﻿namespace SearchTest.Search.NaiveSolution
{
    public class Matcher : SearchCriteria, IMatcher
    {
        public Matcher(SearchCriteria criteria)
        {
            NonClosedOnly = criteria.NonClosedOnly;
            NoAnswerOnly = criteria.NoAnswerOnly;
            BountiesOnly = criteria.BountiesOnly;
        }

        public bool Match(ref Post post)
        {
            if (NonClosedOnly && post.IsClosed) return false;
            if (NoAnswerOnly && post.AnswerCount > 0) return false;
            if (BountiesOnly && post.BountyAmount == 0) return false;
            if (NewFlag1 && post.NewFlagValue1 != 4) return false;
            if (NewFlag2 && post.NewFlagValue2 != 5) return false;
            return true;
        }
    }
}
