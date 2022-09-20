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

        public bool isRegistered(string name, string lastName, string pass)
        {
            var query = from Person user in users
                        where user.fullName() == $"{name} {lastName}" && user.Password == pass
                        select user;
            if(query.Count() > 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public Person takeUser(string name, string lastName, string pass)
        {
            var query = from Person user in users
                        where user.fullName() == $"{name} {lastName}" && user.Password == pass
                        select user;
            if (query.Count() > 0)
            {
                return query.First();
            }
            return null;
        }








    }

    



}
