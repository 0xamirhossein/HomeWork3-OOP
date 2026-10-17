namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("shahname","123","ferdowsi");
            Book book2 = new Book("ghese khoob bara bacheye khoob "," 1235"," mehdi azaryazdi");
            Library newLibrary = new Library();
            newLibrary.AddBook(book1);
            newLibrary.AddBook(book2);
            Console.WriteLine("BOROWWING");
            Console.WriteLine("-----------------------");
            newLibrary.BorrowBook("shahname");

            Console.WriteLine("RETURNING");
            Console.WriteLine("-----------------------");
            newLibrary.ReturnBook("shahname");
        }
    }
}
