using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Product
    {
        // un codice identificativo di tipo stringa(ISBN per i libri, numero seriale per i DVD),
        public string Code { get; set; }
        private string prefixCode = "";
        //titolo,
        public string Title { get; set; }
        //anno,
        public int Year { get; set; }
        //settore(storia, matematica, economia, …),
        public int Sector { get; set; }
        //stato(In Prestito, Disponibile),
        public bool IsLoaned { get; set; }
        //uno scaffale in cui è posizionato,
        public int Rack { get; set; }
        //un autore (Nome, Cognome).
        public string Author { get; set; }
    
        public Product(string title, int year, int sector, int rack, string author)
        {
            Code = randomCode(prefixCode);
            Title = title;
            Year = year;
            Sector = sector;
            IsLoaned = false;
            Rack = rack;
            Author = author;
        }

        public Product(string prefixCode,string title, int year, int sector, int rack, string author)
        {
            Code = randomCode(prefixCode);
            Title = title;
            Year = year;
            Sector = sector;
            IsLoaned = false;
            Rack = rack;
            Author = author;
        }

        protected virtual string randomCode(string prefix)
        {
            Random rnd = new Random();
            return prefix + Convert.ToString(rnd.Next(1000)).PadLeft(13 - prefix.Length, '0');
        }



    }


 
}
