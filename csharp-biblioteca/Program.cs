// See https://aka.ms/new-console-template for more information
using System.Runtime.ConstrainedExecution;
using System;
using csharp_biblioteca;

//Gli utenti si possono registrare al sistema
//Gli utenti registrati possono effettuare dei prestiti sui documenti che sono di vario tipo (libri, DVD)
//L’utente deve poter eseguire delle ricerche per codice o per titolo e, eventualmente, effettuare dei prestiti registrando il periodo (Dal/Al) del prestito e il documento.
//Deve essere possibile effettuare la ricerca dei prestiti dato nome e cognome di un utente.


// Lista libri
Book book = new Book("97888", "Star Wars I", 1990, "Fantascenza", 12, "George Lucas", 600);
Book book1 = new Book("97888", "Storia Mussolini", 2022, "Storie di vita", 12, "Aldo Cazzullo", 360);
Book book2 = new Book("97888", "La signora in giallo", 1990, "Giallo", 9, "test Test", 222);
Book book3 = new Book("97888", "Diario di Anna Frank", 1947, "Biografia", 8, "Anna Frank", 300);
Book book4 = new Book("97888", "Libro", 2020, "biografia", 12, "Maccio Capatonda", 222);
Book book5 = new Book("97888", "Il Signore degli Anelli", 1954, "Fantasy", 12, "J. R. R. Tolkien", 500);
Book book6 = new Book("97888", "Lo Hobbit", 1937, "Fantasy", 1, "J. R. R. Tolkien", 384);
Book book7 = new Book("97888", "A sud del confine, a ovest del sole", 2016, "Narrativa", 2, "Haruki Murakami", 204);
Book book8 = new Book("97888", "La casa degli spiriti Condividi", 2019, "Narrativa", 8, "Isabel Allende", 476);
Book book9 = new Book("97888", "Il signore delle mosche", 2016, "Narrativa", 12, "William Golding", 100);
List<Book> listBook = new List<Book> { book, book1, book2, book3, book4, book5, book6, book7, book8, book9};

Dvd dvd = new Dvd("55588", "test", 1990, "Storico", 12, "test Test", 100);
Dvd dvd0 = new Dvd("55588", "test", 1990, "Storico", 12, "test Test", 100);
Dvd dvd1 = new Dvd("55588", "test", 1990, "Storico", 12, "test Test", 100);
Dvd dvd2 = new Dvd("55588", "test", 1990, "Storico", 12, "test Test", 100);
Dvd dvd3 = new Dvd("55588", "test", 1990, "Storico", 12, "test Test", 100);
Dvd dvd4 = new Dvd("55588", "test", 1990, "Storico", 12, "test Test", 100);
Dvd dvd5 = new Dvd("55588", "test", 1990, "Storico", 12, "test Test", 100);
Dvd dvd6 = new Dvd("55588", "test", 1990, "Storico", 12, "test Test", 100);
Dvd dvd7 = new Dvd("55588", "test", 1990, "Storico", 12, "test Test", 100);
Dvd dvd8 = new Dvd("55588", "test", 1990, "Storico", 12, "test Test", 100);
Dvd dvd9 = new Dvd("55588", "test", 1990, "Storico", 12, "test Test", 100);
List<Dvd> listDvd = new List<Dvd> { dvd, dvd1, dvd2, dvd3, dvd4, dvd5, dvd6, dvd7, dvd8, dvd9 };



Library lib = new Library(listBook, listDvd);




bool status = true;
do
{
    Console.WriteLine("digita il numero della tua azione");
    Console.WriteLine("1) Registrati");
    Console.WriteLine("2) Consulta i libri in giacenza");

} while (status);