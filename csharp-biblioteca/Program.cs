// See https://aka.ms/new-console-template for more information
using System.Runtime.ConstrainedExecution;
using System;
using csharp_biblioteca;

Console.WriteLine("Hello, World!");


//Esercizio:
//Si vuole progettare un sistema per la gestione di una biblioteca. Gli utenti si possono registrare al sistema, fornendo:

//Gli utenti registrati possono effettuare dei prestiti sui documenti che sono di vario tipo (libri, DVD). I documenti sono caratterizzati da:
//
//
//L’utente deve poter eseguire delle ricerche per codice o per titolo e, eventualmente, effettuare dei prestiti registrando il periodo (Dal/Al) del prestito e il documento.
//Deve essere possibile effettuare la ricerca dei prestiti dato nome e cognome di un utente.


// Prodotto
//libro
//dvd
// User
// Libreria


Product p = new Product("", "test", 1990, "test", 12, "test Test");
Book book = new Book("97888", "test", 1990, "Fantascenza", 12, "test Test", 100);
Dvd dvd = new Dvd("55588", "test", 1990, "Storico", 12, "test Test", 100);
Console.WriteLine(p.printRecord());
Console.WriteLine(book.printRecord());
Console.WriteLine(dvd.printRecord());

Person person = new Person("Alan", "Bruno", "test@libero.com", "1234", "333 4511265");
Console.WriteLine(person.info());