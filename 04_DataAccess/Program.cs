using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_DataAccess
{
    static class Program
    {
        static void Main()
        {
            String filePath = @"C:\Users\byfra\Documents\CFGS2\SPDVI\1. avaluació\1. Topic\Visual Studio\exercisesReviewCS\exercisesReviewCS\04_DataAccess\Test.txt";

            List<Person> people = new List<Person>();
            List<string> lines = File.ReadAllLines(filePath).ToList(); 
            foreach (var line in lines)
            {
                string[] entries = line.Split(',');
                Person newPerson = new Person();

                newPerson.FirstName = entries[0];
                newPerson.LastName = entries[1];
                newPerson.Url = entries[2];

                people.Add(newPerson);
            }

            Console.WriteLine("Read from text file.");
            foreach(var person in people)
            {
                Console.WriteLine($"{ person.FirstName } { person.LastName } { person.Url }");
            }
            people.Add(new Person { FirstName = "Greg", LastName = "Jones", Url = "www.test..." });
            List<string> output = new List<string>();
           foreach(var person in people)
            {
                output.Add($"{ person.FirstName }, { person.LastName }, { person.Url }");
            }
            Console.WriteLine("Writing to text file");
            File.WriteAllLines(filePath, output);
            Console.WriteLine("All entries written");
            Console.ReadLine();
        }
    }
}
