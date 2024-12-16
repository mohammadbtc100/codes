using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryFile
{
    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class BinaryFileExample
        {
            // Write a Person object to a binary file
            public static void WriteToBinaryFile(string filePath, Person person)
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
                {
                    writer.Write(person.Name);
                    writer.Write(person.Age);
                }

                Console.WriteLine("Data written to binary file successfully.");
            }

            // Read a Person object from a binary file
            public static Person ReadFromBinaryFile(string filePath)
            {
                using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
                {
                    Person person = new Person
                    {
                        Name = reader.ReadString(),
                        Age = reader.ReadInt32()
                    };

                    return person;
                }
            }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Microsoft Resources");
            string filePath = "person.dat";

            // Create a new Person object
            Person personToWrite = new Person
            {
                Name = "John Doe",
                Age = 30
            };

            // Write the Person object to a binary file
            BinaryFileExample.WriteToBinaryFile(filePath, personToWrite);

            // Read the Person object from the binary file
            Person personRead = BinaryFileExample.ReadFromBinaryFile(filePath);

            // Display the read person's details
            Console.WriteLine($"Name: {personRead.Name}, Age: {personRead.Age}");

            Console.ReadKey();
        }
    }

}
