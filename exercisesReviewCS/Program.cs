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
            List<string> dinosaurs = new List<string>();

            dinosaurs.Add("John");
            dinosaurs.Add("Mary");
            dinosaurs.Add("Sue");
            dinosaurs.Add("Greg");
            dinosaurs.Add("Yolanda");
            dinosaurs.Add("Jose");
            dinosaurs.Add("Bill");

            foreach (string dinosaur in dinosaurs)
            {
                Console.WriteLine(" Hello {0}", dinosaur);
            }

            // Second list : PersonModel
            List<PersonModel> llistaPersonModel = new List<PersonModel>();
            llistaPersonModel.Add(new PersonModel() { FirstName = "Tim", LastName = "Corey" });
            llistaPersonModel.Add(new PersonModel() { FirstName = "Bill", LastName = "McCoy" });
            llistaPersonModel.Add(new PersonModel() { FirstName = "Mary", LastName = "Jones" });
            llistaPersonModel.Add(new PersonModel() { FirstName = "Sue", LastName = "Smith" });

            Console.WriteLine();
            foreach (PersonModel aPart in llistaPersonModel)
            {
                Console.WriteLine(aPart);
            }
            Console.ReadKey();


        }
    }
}
