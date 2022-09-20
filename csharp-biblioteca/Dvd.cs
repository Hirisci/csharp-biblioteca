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

        public override string printRecord()
        {
            return $"| Codice: {Code} | Titolo: {Title.PadLeft(30 - Title.Length, ' ')} | Autore: {Author.PadLeft(30 - Author.Length, ' ')} | Anno: {Year} | Durata(min): {Duration}| Posizione: {Sector.PadLeft(15 - Sector.Length, ' ')} - {Rack} |";


        }


    }
}