using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercisesReviewCS
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = { "John", "Mary", "Sue", "Greg", "Yolanda", "Jose", "Bill" };
            foreach (string nombre in nombres)
            {
                Console.WriteLine(" Hello {0}", nombre);
            }
            Console.WriteLine();
            //Console.ReadKey();

            // class PersonModel
            PersonModel person1 = new PersonModel("Tim", "Corey");
            PersonModel person2 = new PersonModel("Bill", "McCoy");
            PersonModel person3 = new PersonModel("Mary", "Jones");
            PersonModel person4 = new PersonModel("Sue", "Smith");
            Console.WriteLine(" Hello {0} {1}", person1.FirstName, person1.LastName);
            Console.WriteLine(" Hello {0} {1}", person2.FirstName, person2.LastName);
            Console.WriteLine(" Hello {0} {1}", person3.FirstName, person3.LastName);
            Console.WriteLine(" Hello {0} {1}", person4.FirstName, person3.LastName);

            // Keep the console open in debug mode.
            //Console.WriteLine("Press any key to exit.");
            Console.ReadKey();


        }
    }

    /*
     * Person person1 = new Person("Leopold", 6);
        Console.WriteLine("person1 Name = {0} Age = {1}", person1.Name, person1.Age);

        // Declare new person, assign person1 to it.
        Person person2 = person1;

        // Change the name of person2, and person1 also changes.
        person2.Name = "Molly";
        person2.Age = 16;

        Console.WriteLine("person2 Name = {0} Age = {1}", person2.Name, person2.Age);
        Console.WriteLine("person1 Name = {0} Age = {1}", person1.Name, person1.Age);

        // Keep the console open in debug mode.
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
     * 
     * */


}
