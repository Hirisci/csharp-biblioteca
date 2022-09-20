using System.Diagnostics.Metrics;

namespace csharp_biblioteca
{
    internal class Dvd : Product
    {
        private int Duration { get; set; }

        public Dvd(string prefixCode,string title, int year, string sector, int rack, string author, int duration) : base(prefixCode,title, year, sector, rack, author)
        {
            Duration = duration;
        }
        //mentre per i dvd la durata.

        protected override string randomCode(string prefix)
        {
            
            return base.randomCode(prefix);
        }

        public override void printRecord()
        {
            Console.WriteLine($"| Codice: {Code} | Titolo: {Title.PadRight(30 - Title.Length, ' ')} | Autore: {Author.PadRight(30 - Author.Length, ' ')} | Anno: {Year} | Durata(min): {Duration}| Posizione: {Sector.PadRight(15 - Sector.Length, ' ')} - {Rack} |");
        }


    }
}