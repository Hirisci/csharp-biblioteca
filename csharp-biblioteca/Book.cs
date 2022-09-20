namespace csharp_biblioteca
{
    internal class Book : Product
    {
        private int NumPage { get; set; }

        public Book(string prefixCode, string title, int year, string sector, int rack, string author, int numPage) : base(prefixCode,title, year, sector, rack, author)
        {
            
            NumPage = numPage;
        }

        protected override string randomCode(string prefix)
        {

            return base.randomCode(prefix);
        }

        public override string printRecord()
        {
            return $"| Codice: {Code} | Titolo: {Title.PadLeft(30 - Title.Length, ' ')} | Autore: {Author.PadLeft(30 - Author.Length, ' ')} | Anno: {Year} | Pagine: {Convert.ToString(NumPage).PadLeft(5,' ')}| Posizione: {Sector.PadLeft(15 - Sector.Length, ' ')} - {Rack} |";
        }
    }

 
}
