using _10_GenericTypesCollections.Generics;
using _10_GenericTypesCollections.Managers;
using _10_GenericTypesCollections.Models;
using static System.Net.WebRequestMethods;

public class Program
{
    static void Main(string[] args)
    {
        Book b1 = new Book(1, "Martin Eden", "Jack London", 1909, 400);
        Book b2 = new Book(2, "1984", "George Orwell", 1949, 328);
        Book b3 = new Book(3, "Animal Farm", "George Orwell", 1945, 112);
        Book b4 = new Book(4, "Ağ Gəmi", "Cingiz Aytmatov", 1970, 200);
        Book b5 = new Book(5, "Qırıq Budaq", "Elçin", 1998, 350);

        Console.WriteLine(" ");

        b1.DisplayInfo();
        b2.DisplayInfo();
        b3.DisplayInfo();
        b4.DisplayInfo();
        b5.DisplayInfo();

        Console.WriteLine(" ");

        var lib = new Library<Book>("Milli Kitabxana");

        lib.Add(b1);
        lib.Add(b2);
        lib.Add(b3);
        lib.Add(b4);
        lib.Add(b5);

        Console.WriteLine("Count: " + lib.Count());

        Console.WriteLine(" ");


        lib.FindByIndex(0)?.DisplayInfo();
        lib.FindByIndex(2)?.DisplayInfo();

        foreach (var b in lib.GetAll())
        {
            b.DisplayInfo();
        }

        Console.WriteLine(" ");



        var members = new List<Member>
        {
            new Member(1,"Ali Memmedov", "ali@gmail.com"),
            new Member(2,"Leyla Hesenova", "leyla@gmail.com"),
            new Member(3, "Vuqar Eliyev", "vuqar@gmail.com")
        };

        Console.WriteLine(" ");


        var m = members[0];

        m.BorrowBook(b1); 
        m.BorrowBook(b2);
        m.DisplayBorrowedBooks();

        m.ReturnBook(1);
        m.DisplayBorrowedBooks();

        m.BorrowBook(b3);
        m.BorrowBook(b4);
        m.BorrowBook(b5);

        Console.WriteLine(" ");


        var manager = new BookManager();

        manager.AddBook(b1);
        manager.AddBook(b2);
        manager.AddBook(b3);
        manager.AddBook(b4);
        manager.AddBook(b5);

        foreach (var b in manager.GetBooksByAuthor("George Orwell"))
        {
            b.DisplayInfo();
        }

        manager.AddToWaitingQueue("Nigar");
        manager.AddToWaitingQueue("Resad");
        manager.AddToWaitingQueue("Sebine");

        Console.WriteLine("Xidmet edilir: " + manager.ServerNextInQueue());

        manager.ReturnBook(b1);
        manager.ReturnBook(b2);
        manager.ReturnBook(b3);

        Console.WriteLine("Son Kitab: ");
        manager.GetLastReturnedBook()?.DisplayInfo();

    }
}