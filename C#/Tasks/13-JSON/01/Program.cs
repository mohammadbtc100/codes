using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web.Script.Serialization;

namespace _01
{

    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }

    public class PhoneNumber
    {
        public string Type { get; set; }
        public string Number { get; set; }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }
        public List<PhoneNumber> PhoneNumbers { get; set; }
    }

    public class JsonExample
        {
            // Serialize a Person object to JSON and write to a file
            public static void SerializeToJson(string filePath, Person person)
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                string jsonString = serializer.Serialize(person);
                File.WriteAllText(filePath, jsonString);
                Console.WriteLine("Serialized JSON written to file successfully.");
            }

            // Deserialize JSON from a file back into a Person object
            public static Person DeserializeFromJson(string filePath)
            {
                string jsonString = File.ReadAllText(filePath);
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                Person person = serializer.Deserialize<Person>(jsonString);
                return person;
            }
        }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Microsoft Resources");
            string filePath = "person.json";

            // Create a new Person object
            Person person = new Person
            {
                FirstName = "John",
                LastName = "Doe",
                Age = 30,
                Address = new Address
                {
                    Street = "123 Main St",
                    City = "Springfield",
                    State = "IL",
                    Zip = "12345"
                },
                PhoneNumbers = new List<PhoneNumber>
            {
                new PhoneNumber { Type = "home", Number = "555-555-1234" },
                new PhoneNumber { Type = "work", Number = "555-555-5678" }
            }
            };

            // Serialize the Person object to JSON and save it to a file
            JsonExample.SerializeToJson(filePath, person);

            // Deserialize the JSON back into a Person object
            Person deserializedPerson = JsonExample.DeserializeFromJson(filePath);

            // Display the deserialized person's details
            Console.WriteLine($"First Name: {deserializedPerson.FirstName}");
            Console.WriteLine($"Last Name: {deserializedPerson.LastName}");
            Console.WriteLine($"Age: {deserializedPerson.Age}");
            Console.WriteLine($"Address: {deserializedPerson.Address.Street}, {deserializedPerson.Address.City}, {deserializedPerson.Address.State} {deserializedPerson.Address.Zip}");

            foreach (var phone in deserializedPerson.PhoneNumbers)
            {
                Console.WriteLine($"Phone ({phone.Type}): {phone.Number}");
            }
            Console.ReadKey();
        }
    }

}
