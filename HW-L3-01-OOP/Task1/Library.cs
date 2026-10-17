using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    internal class Library
    {
        List<Book> books = new List<Book>();


        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"{book.Title} ba movafaghiat ezafe shod ");
        }
        public void BorrowBook(string title)
        {
            foreach (Book book in books)
            {
                if (book.Title == title && book.IsAvailable == true)
                {
                    book.IsAvailable = false;
                    Console.WriteLine($"{book.Title} gharz dade shod  ");
                }
                else
                {
                    Console.WriteLine("ketabi ba in moshakhasat nist ya ghablan gharz dade shode ");
                }
            }
        }
        public void ReturnBook(string title)
        {
            Console.WriteLine("if u want to return book to libraray plz write book name u want  ");
            title = Console.ReadLine();
            foreach (Book book in books)
            {
                if (book.Title == title && book.IsAvailable == false)
                {
                    book.IsAvailable = true;
                    Console.WriteLine($"{book.Title} pas gerefte shod ");
                }
                else
                {
                    Console.WriteLine(" ketabi dade nashode bood ya ba in moshakhasat ketabi nist");
                }
            }
        }

    }
}
