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
        private string Code { get;} 
        //titolo,
        private string Title { get; set; }
        //anno,
        private int Year { get; set; }
        //settore(storia, matematica, economia, …),
        private int Sector { get; set; }
        //stato(In Prestito, Disponibile),
        private bool IsLoaned { get; set; }
        //uno scaffale in cui è posizionato,
        private int Rack { get; set; }
        //un autore (Nome, Cognome).
        private string Author { get; set; }
    
        public Product(string title, int year, int sector, bool isLoaned, int rack, string author)
        {
            Code = randomCode();
            Title = title;
            Year = year;
            Sector = sector;
            IsLoaned = isLoaned;
            Rack = rack;
            Author = author;
        }

        protected virtual string randomCode()
        {
            Random rnd = new Random();
            return Convert.ToString(rnd.Next(1000)).PadLeft(13,'0');
        }


    
    }


 
}
