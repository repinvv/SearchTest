namespace SearchTypes
{
    public struct Post
    {
        public int Id { get; set; }

        public bool IsClosed { get; set; }

        public int AnswerCount { get; set; }

        public int BountyAmount { get; set; }
    }
}
