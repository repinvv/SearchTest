namespace SearchTest.Search.GeneratedSolution
{
    using Search.NaiveSolution;
    using System;

    public static class Switch
    {
        public static IMatcher GetMatcher(SearchCriteria criteria)
        {
            int matcherId = 0;
            if(criteria.NonClosedOnly)
            {
                matcherId += 1;
            }

            if(criteria.NoAnswerOnly)
            {
                matcherId += 2;
            }

            if(criteria.BountiesOnly)
            {
                matcherId += 4;
            }

            if(criteria.NewFlag1)
            {
                matcherId += 8;
            }

            if(criteria.NewFlag2)
            {
                matcherId += 16;
            }

            switch(matcherId)
            {
                case 31:
                    return new GenMatcher31(criteria);
                case 30:
                    return new GenMatcher30(criteria);
                case 29:
                    return new GenMatcher29(criteria);
                case 28:
                    return new GenMatcher28(criteria);
                case 27:
                    return new GenMatcher27(criteria);
                case 26:
                    return new GenMatcher26(criteria);
                case 25:
                    return new GenMatcher25(criteria);
                case 24:
                    return new GenMatcher24(criteria);
                case 23:
                    return new GenMatcher23(criteria);
                case 22:
                    return new GenMatcher22(criteria);
                case 21:
                    return new GenMatcher21(criteria);
                case 20:
                    return new GenMatcher20(criteria);
                case 19:
                    return new GenMatcher19(criteria);
                case 18:
                    return new GenMatcher18(criteria);
                case 17:
                    return new GenMatcher17(criteria);
                case 16:
                    return new GenMatcher16(criteria);
                case 15:
                    return new GenMatcher15(criteria);
                case 14:
                    return new GenMatcher14(criteria);
                case 13:
                    return new GenMatcher13(criteria);
                case 12:
                    return new GenMatcher12(criteria);
                case 11:
                    return new GenMatcher11(criteria);
                case 10:
                    return new GenMatcher10(criteria);
                case 9:
                    return new GenMatcher9(criteria);
                case 8:
                    return new GenMatcher8(criteria);
                case 7:
                    return new GenMatcher7(criteria);
                case 6:
                    return new GenMatcher6(criteria);
                case 5:
                    return new GenMatcher5(criteria);
                case 4:
                    return new GenMatcher4(criteria);
                case 3:
                    return new GenMatcher3(criteria);
                case 2:
                    return new GenMatcher2(criteria);
                case 1:
                    return new GenMatcher1(criteria);
                case 0:
                    return new GenMatcher0(criteria);
                default: 
                    throw new Exception("should never happen");
            }
        }
    }
}
