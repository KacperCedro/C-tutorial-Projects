using Classes.additionalClasses;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            People david = new People("David", "Moal");
            People cristian = new People("Creistian", "Duevo", "Yes, that's my last name");
            People mark = new People("Mark", "Davis", "That's it", DateTime.Parse("1999.12.12 12:12:12"));

            List<People> list = new List<People>() 
            { 
                david, cristian, mark
            };
            foreach (var person in list)
            {
                person.SayHi();
            }
        }
    }
}