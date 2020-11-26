using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _08_StringReplacement
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrimaryChallemge();
            BonusChallenge();
        }

        private static void PrimaryChallemge()
        {
            List<string> primaryLines = File.ReadAllLines(@"C:\Users\byfra\Documents\CFGS2\SPDVI\1. avaluació\1. Topic\Visual Studio\exercisesReviewCS\exercisesReviewCS\08_StringReplacement\bin\Debug\arxiu.txt").ToList();
            Console.Write("Please give me the text to replace: ");
            string toReplace = Console.ReadLine();
            Console.Write("Please give me the replacement text: ");
            string replacementText = Console.ReadLine();
            for(int i = 0; i < primaryLines.Count; i++)
            {
                primaryLines[i] = primaryLines[i].Replace(toReplace, replacementText);
            }
            File.WriteAllLines(@"C:\Users\byfra\Documents\CFGS2\SPDVI\1. avaluació\1. Topic\Visual Studio\exercisesReviewCS\exercisesReviewCS\08_StringReplacement\bin\Debug\arxiu.txt", primaryLines);
            Console.WriteLine("The text file has been updated");
        }
        private static void BonusChallenge()
        {
            string bonusText = File.ReadAllText(@"C:\Users\byfra\Documents\CFGS2\SPDVI\1. avaluació\1. Topic\Visual Studio\exercisesReviewCS\exercisesReviewCS\08_StringReplacement\bin\Debug\arxiu.txt");

            var results = Regex.Matches(bonusText, @"{[^{}]+}")
                .Cast<Match>()
                .Select(x => x.Value.Substring(1, x.Value.Length - 2))
                .ToHashSet();

            foreach(var result in results)
            {
                Console.Write($"Please give me the value for { result }: ");
                bonusText = bonusText.Replace("{" + result + "}", Console.ReadLine());
            }
            File.WriteAllText(@"C:\Users\byfra\Documents\CFGS2\SPDVI\1. avaluació\1. Topic\Visual Studio\exercisesReviewCS\exercisesReviewCS\08_StringReplacement\bin\Debug\arxiu.txt", bonusText);
        }
    }
}
