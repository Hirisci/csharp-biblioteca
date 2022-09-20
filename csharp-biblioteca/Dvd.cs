using System.Diagnostics.Metrics;

namespace csharp_biblioteca
{
    internal class Dvd : Product
    {
        private int Duration { get; set; }

        public Dvd(string prefixCode,string title, int year, int sector, bool isLoaned, int rack, string author, int duration) : base(prefixCode,title, year, sector, isLoaned, rack, author)
        {
            Duration = duration;
        }
        //mentre per i dvd la durata.

        protected override string randomCode(string prefix)
        {
            
            return base.randomCode(prefix);
        }


    }
}