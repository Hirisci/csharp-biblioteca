using System.Diagnostics.Metrics;

namespace csharp_biblioteca
{
    internal class Dvd : Product
    {
        private int Duration { get; set; }

        public Dvd(string title, int year, int sector, bool isLoaned, int rack, string author, int duration) : base(title, year, sector, isLoaned, rack, author)
        {
            Duration = duration;
        }
        //mentre per i dvd la durata.

        protected override string randomCode()
        {
            Random rnd = new Random();
            return "333" + Convert.ToString(rnd.Next(1000)).PadLeft(10, '0');
        }


    }
}