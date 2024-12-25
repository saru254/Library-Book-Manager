using System;

class LibraryBook
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBNnumber { get; set; }
    private bool Availability { set; get; }

    //constructor
    public LibraryBook (string title, string author, string isbn)
    {
        Title = title;
        Author = author;
        ISBNnumber = isbn;
        Availability = true;
    }

    //method to borrow the book
    public bool IsAvailable()
    {
        return Availability;
    }

    // method to borrow the book
    public void BorrowBook()
    {
        if (Availability)
        {
            Availability = false;
            Console.WriteLine($"The book '{Title}' has been borrowed.");

        }
        else
        {
            Console.WriteLine($"The book '{Title}' is already borrowed and not available");
        }
    }

    //method to return the Book
    public void ReturnBook()
    {
        if (!Availability)
        {
            Availability = true;
            Console.WriteLine($"The book '{Title}' has been returned and is now available.");
        }
        else
        {
            Console.WriteLine($"The book '{Title}' is already available in the library");
        }
    }

    //method to display book details
    public void DisplayDetails()
    {
        string status = Availability ? "Available" : "Checked Out";
        Console.WriteLine($"Title: {Title}, Author: {Author}, ISBN: {ISBNnumber}, Status: {status}");

    }
}

class Program
{
    static void Main()
    {
        // prompt user to enter book details.
        Console.WriteLine("Enter the name of Author");
        string author = Console.ReadLine();

        
        Console.WriteLine("Enter the title of the Book");
        string title = Console.ReadLine();

        Console.WriteLine("Enter the ISBNnumber of the Book");
        string ISBNnumber = Console.ReadLine();

        // Create a LibraryBook object using the user's input
        LibraryBook book = new LibraryBook(title, author, ISBNnumber);

        // Display book details
        Console.WriteLine("\nBook Details:");
        book.DisplayDetails();

        // Borrow the book
        Console.WriteLine("\nAttempting to borrow the book...");
        book.BorrowBook();

        // Display book details after borrowing
        Console.WriteLine("\nBook Details After Borrowing:");
        book.DisplayDetails();

        // Return the book
        Console.WriteLine("\nAttempting to return the book...");
        book.ReturnBook();

        // Display book details after returning
        Console.WriteLine("\nBook Details After Returning:");
        book.DisplayDetails();

    }
}