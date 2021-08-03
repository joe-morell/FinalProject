using System;
using System.Collections.Generic;

class Author : Person {
  private List<Book> Books;


  public Author() : base() {

    Books = new List<Book>();
  }
  public Author(string fname, string lname) : base(fname, lname) {

    Books = new List<Book>();
  }


  public void DisplayInfo() {

    Console.WriteLine($"Name:{FirstName} {LastName}/Email:{Email}");
  }

  public void DisplayBooks() {

    foreach (var book in Books) {
      book.Display();
    }
  }

  public void AddBook(Book book) {
    book.AuthorInfo = this;
    Books.Add(book);
  }

  public void RemoveBook(string ISBN) {
      
    Books.Remove(Books.Find(book => book.ISBN == ISBN));
  }
}
