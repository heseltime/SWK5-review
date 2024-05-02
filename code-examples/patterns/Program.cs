using System;

namespace MyApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a new Person object
            var person = new Person
            {
                Name = "John Doe",
                Address = new Address { Country = "USA", City = "New York" }
            };

            // Use pattern matching to check the person's address
            if (person is { Address: { Country: "USA", City: var city } })
            {
                Console.WriteLine($"Lives in USA, city: {city}");
            }
        }
    }

    // Definition of the Person class
    public class Person
    {
        public string Name { get; set; }
        public Address Address { get; set; }
    }

    // Definition of the Address class
    public class Address
    {
        public string Country { get; set; }
        public string City { get; set; }
    }
}
