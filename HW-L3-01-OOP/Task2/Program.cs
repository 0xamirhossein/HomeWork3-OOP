namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
        {
            new Student("Amir", "23", "40015741054", "Computer Engineering"),
            new Professor(" Prof. Gharib-khajeh", "45", "007483782", "Programming"),
            new Student("Rozhiak", "24", "40312348", "Civil Engineering"),
            new Professor("Prof. Tabatabaei", "38", "132892883", "Database")
        };

            foreach (Person person in people)
            {
            person.GetDetails();
            }
        }
    }
}