using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("No bugs found! :)");

    Author a1 = new Author("jazzy", "joe");
    Author a2 = new Author("jarvis", "landry");
    a1.DisplayInfo();
    a2.DisplayInfo();

    Book b1 = new Book("1111", "book1", null);
    Book b2 = new Book("2222", "book2", null);
    Book b3 = new Book("3333", "book3", null);
    
    Book b4 = new Book("4444", "book4", null, new DateTime(2014, 4, 24), "abc books");
    Book b5 = new Book("5555", "book5", null, new DateTime(2015, 5, 15), "book-r-us");
    Book b6 = new Book("6666", "book6", null, new DateTime(2016, 6, 06), "cleanbooks");

    a1.AddBook(b1);
    a1.AddBook(b3);
    a1.AddBook(b5);
    a1.DisplayBooks();

    a2.AddBook(b2);
    a2.AddBook(b4);
    a2.AddBook(b6);
    a2.DisplayBooks();
    
    a1.RemoveBook("1111");
    a1.DisplayBooks();
  }
}