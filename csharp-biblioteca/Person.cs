using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Person
    {
        public Person(string name, string lastName, string email, string pass, string number)
        {
            LastName = lastName;
            FirstName = name;
            Email = email;
            Password = pass;
            Number = number;
        }

        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Number { get; set; }
        
        public string fullName()
        {
            return LastName + " " + FirstName;
        }

        public string info()
        {
            return $"Nome: {fullName().PadLeft(30 - fullName().Length, ' ')} | Email: {Email.PadLeft(30,' ')} | Number {Number.PadLeft(20, ' ')} ";
        }
       
    }

}
