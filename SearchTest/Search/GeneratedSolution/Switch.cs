namespace SearchTest.Search.GeneratedSolution
{
    using Search.NaiveSolution;
    using System;

    public static class Switch 
    {
        public static SearchResult Search(Post[] index, SearchCriteria criteria)
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
                    return Search31.Search(index);
                case 30:
                    return Search30.Search(index);
                case 29:
                    return Search29.Search(index);
                case 28:
                    return Search28.Search(index);
                case 27:
                    return Search27.Search(index);
                case 26:
                    return Search26.Search(index);
                case 25:
                    return Search25.Search(index);
                case 24:
                    return Search24.Search(index);
                case 23:
                    return Search23.Search(index);
                case 22:
                    return Search22.Search(index);
                case 21:
                    return Search21.Search(index);
                case 20:
                    return Search20.Search(index);
                case 19:
                    return Search19.Search(index);
                case 18:
                    return Search18.Search(index);
                case 17:
                    return Search17.Search(index);
                case 16:
                    return Search16.Search(index);
                case 15:
                    return Search15.Search(index);
                case 14:
                    return Search14.Search(index);
                case 13:
                    return Search13.Search(index);
                case 12:
                    return Search12.Search(index);
                case 11:
                    return Search11.Search(index);
                case 10:
                    return Search10.Search(index);
                case 9:
                    return Search9.Search(index);
                case 8:
                    return Search8.Search(index);
                case 7:
                    return Search7.Search(index);
                case 6:
                    return Search6.Search(index);
                case 5:
                    return Search5.Search(index);
                case 4:
                    return Search4.Search(index);
                case 3:
                    return Search3.Search(index);
                case 2:
                    return Search2.Search(index);
                case 1:
                    return Search1.Search(index);
                case 0:
                    return Search0.Search(index);
                default: 
                    throw new Exception("should never happen");
            }
        }
    }
}
