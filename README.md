# **Library Book Manager**

## **Overview**
The Library Book Manager is a simple C# program that demonstrates the principles of Object-Oriented Programming (OOP), specifically **Encapsulation**. The program allows users to manage library books by adding book details, borrowing books, and returning them, while maintaining the integrity of the book's availability status.

---

## **Features**
- Add a new book with details such as:
  - Title
  - Author
  - ISBN number
- Borrow a book:
  - Marks the book as checked out if it’s available.
  - Displays an error message if the book is already borrowed.
- Return a book:
  - Marks the book as available when returned.
  - Displays an error message if the book is already available.
- Display all details of a book, including its availability status.

---

## **Technologies Used**
- Programming Language: **C#**

---

## **Concepts Demonstrated**
1. **Encapsulation**:
   - Private fields and controlled access using methods (`BorrowBook`, `ReturnBook`).
   - Ensures that the availability status is managed only through predefined methods.

---

## **How to Use**
1. Run the program in a C# development environment (e.g., Visual Studio, VS Code).
2. Follow the prompts to:
   - Enter the title, author, and ISBN number of a book.
   - View the book details.
   - Borrow the book and check its status.
   - Return the book and check its status.

---

## **Example Usage**

### **Input**
```
Enter the title of the book:
C# Programming Basics
Enter the name of the author:
John Doe
Enter the ISBN number of the book:
1234567890
```

### **Output**
```
Book Details:
Title: C# Programming Basics, Author: John Doe, ISBN: 1234567890, Status: Available

Attempting to borrow the book...
The book 'C# Programming Basics' has been borrowed.

Book Details After Borrowing:
Title: C# Programming Basics, Author: John Doe, ISBN: 1234567890, Status: Checked Out

Attempting to return the book...
The book 'C# Programming Basics' has been returned and is now available.

Book Details After Returning:
Title: C# Programming Basics, Author: John Doe, ISBN: 1234567890, Status: Available
```

---

## **Future Enhancements**
- Add functionality to manage multiple books.
- Include search options for finding books by title or author.
- Implement a graphical user interface (GUI).
- Add persistent storage to save book details across sessions.

---

## **Author**
This program was created as a beginner-friendly project to learn and apply OOP principles in C#.

