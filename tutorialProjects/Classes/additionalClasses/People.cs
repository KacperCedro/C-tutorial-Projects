using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.additionalClasses
{
    internal class People
    {
        int Id;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }

        private DateTime dateOfBirdth;

        public DateTime DateOfBirdth
        {
            get { return dateOfBirdth; }
            set { if(value < DateTime.Now)
                    dateOfBirdth = value;
                  else
                    dateOfBirdth = DateTime.Now;}
        }


        public People()
        {
            Id++;
        }
        public People(string firstName, string lastName)
        {
            Id++;
            FirstName = firstName;
            LastName = lastName;
        }
        public People(string firstName, string lastName, string description) : this(firstName,lastName)
        {
            Id++;
            Description = description;
        }
        public People(string firstName, string lastName, string description, DateTime dateOfBirdth) :this(firstName,lastName, description)
        {
            Id++;
            DateOfBirdth = dateOfBirdth;
        }

        public void SayHi()
        {
            Console.WriteLine($"Hi! I'm {FirstName} {LastName}, I was born in {DateOfBirdth} - so now I'am {DateTime.Now - DateOfBirdth}. There are some information about me: {Description}. For summary my id is {Id}");
        }
    }
}
