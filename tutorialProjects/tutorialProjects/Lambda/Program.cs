using Lambda.Classes;

namespace Lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>() 
            {
                new Person("David","Macaronii",17,"JS"),
                new Person("Kacper","Mau",20,"electician"),
                new Person("Mikolaj","Dau",39,"builder"),
                new Person("Damian","Maxim",28,"monter"),
                new Person("Jakub","Mandimoni",19,"c#"),
                new Person("Wiktor","Konnelango",16,"manager"),
                new Person("Marcell","Maximonni",21,"worker"),
                new Person("Kamil","Terrymoni",47,"swift")
            };

            List<Person> adults = list.FindAll(p => p.Age >=18);
            Console.WriteLine("adults:");
            foreach (var person in adults)
            {
                person.SayHi();
            }
            int oldest = list.Max(person => person.Age);
            int youngest = list.Min(person => person.Age);

            Person kamil = list.FirstOrDefault(p => p.FirstName == "Kamil");
        }
    }
}