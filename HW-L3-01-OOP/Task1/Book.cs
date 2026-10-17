 using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    internal class Book
    {
        public string Title {  get; set; }
        public string ISBN {  get; set; }
        public string Author {  get; set; }
        public bool IsAvailable {  get; set; }
        public Book(string title, string isbn , string author)
        {
            Title = title;
            ISBN = isbn;
            Author = author;
            IsAvailable = true;
        }
    }
}
