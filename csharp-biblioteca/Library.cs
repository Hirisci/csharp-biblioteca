using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Library
    {
        public List<Person> users = new List<Person>();
        ArrayList storage = new ArrayList();


        public Library(List<Book> book, List<Dvd> dvd)
        {
            storage.AddRange(book);
            storage.AddRange(dvd);
        }

        public void showStorage()
        {
            foreach (Product item in storage)
            {
                Console.WriteLine(item.printRecord());
            }
        }

        


    
    
    
    
    }

    



}
