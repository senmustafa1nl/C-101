// Person.cs
using System;

namespace SchoolApp
{
    public class Person
    {
        // Public properties for Name, Surname, and BirthDate
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        // Constructor to initialize Person object
        public Person(string firstName, string lastName, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }

        // Method to display the person's information
        public void DisplayInfo()
        {
            Console.WriteLine($"Ad: {FirstName} {LastName}");
            Console.WriteLine($"Doğum Tarihi: {BirthDate.ToShortDateString()}");
        }
    }
}
