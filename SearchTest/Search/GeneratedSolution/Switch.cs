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
                    return new GenMatcher31();
                case 30:
                    return new GenMatcher30();
                case 29:
                    return new GenMatcher29();
                case 28:
                    return new GenMatcher28();
                case 27:
                    return new GenMatcher27();
                case 26:
                    return new GenMatcher26();
                case 25:
                    return new GenMatcher25();
                case 24:
                    return new GenMatcher24();
                case 23:
                    return new GenMatcher23();
                case 22:
                    return new GenMatcher22();
                case 21:
                    return new GenMatcher21();
                case 20:
                    return new GenMatcher20();
                case 19:
                    return new GenMatcher19();
                case 18:
                    return new GenMatcher18();
                case 17:
                    return new GenMatcher17();
                case 16:
                    return new GenMatcher16();
                case 15:
                    return new GenMatcher15();
                case 14:
                    return new GenMatcher14();
                case 13:
                    return new GenMatcher13();
                case 12:
                    return new GenMatcher12();
                case 11:
                    return new GenMatcher11();
                case 10:
                    return new GenMatcher10();
                case 9:
                    return new GenMatcher9();
                case 8:
                    return new GenMatcher8();
                case 7:
                    return new GenMatcher7();
                case 6:
                    return new GenMatcher6();
                case 5:
                    return new GenMatcher5();
                case 4:
                    return new GenMatcher4();
                case 3:
                    return new GenMatcher3();
                case 2:
                    return new GenMatcher2();
                case 1:
                    return new GenMatcher1();
                case 0:
                    return new GenMatcher0();
                default: 
                    throw new Exception("should never happen");
            }
        }
    }
}
