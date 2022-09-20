namespace csharp_biblioteca
{
    internal class Book : Product
    {
        private int NumPage { get; set; }

        public Book(string prefixCode, string title, int year, int sector, bool isLoaned, int rack, string author, int numPage) : base(prefixCode,title, year, sector, rack, author)
        {
            
            NumPage = numPage;
        }

        protected override string randomCode(string prefix)
        {

            return base.randomCode(prefix);
        }
    }

 
}
