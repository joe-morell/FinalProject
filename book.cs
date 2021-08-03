using System;

class Book{
  public string ISBN;
  public string Title;
  public Author AuthorInfo;
  public DateTime PublishedOn;
  public string PublishedBy;

  public Book(string isbn, string title, Author authorInfo):this(isbn, title, authorInfo, DateTime.Now,"Unknown") {
    Console.WriteLine("Book constructor 1");
  }

  public Book(string isbn, string title, Author authorInfo, DateTime publishedOn, string publishedBy) {
    ISBN = isbn;
    Title = title;
    AuthorInfo = authorInfo;
    PublishedOn = publishedOn;
    PublishedBy = publishedBy;

    Console.WriteLine("Book constructor 2");
  }

  public void Display() {

    Console.WriteLine(string.Format("Book '{0}' was written by {1} {2} and published on {3}", Title, AuthorInfo.FirstName, AuthorInfo.LastName, PublishedOn.ToString("MM/dd/yyyy")));
  }



}