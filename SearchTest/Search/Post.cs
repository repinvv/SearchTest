namespace SearchTest.Search
{
    
    public unsafe struct Post
    {
        public int Id { get; set; }

        public bool IsClosed { get; set; }

        public int AnswerCount { get; set; }

        public int BountyAmount { get; set; }

        public fixed char Dummy [20]; // simulate structure size
    }
}
