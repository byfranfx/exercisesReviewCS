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
            string[] nombres = { "Alberto", "Andrés", "Antonio" };
            foreach (string nombre in nombres)
            {
                Console.WriteLine("Hello {0}", nombre);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
