using System;
namespace HashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> smallDogs = new HashSet<string>();
            smallDogs.Add("Poodle");
            smallDogs.Add("Pug");
            smallDogs.Add("Dachshund");
            smallDogs.Add("Maltese");
            smallDogs.Add("Yorkie");

            HashSet<string> mediumDogs = new HashSet<string>();
            mediumDogs.Add("Beagle");
            mediumDogs.Add("Poodle");
            mediumDogs.Add("Bulldog");
            mediumDogs.Add("Portuguese Waterdog");
            mediumDogs.Add("Labadore");

            HashSet<string> largeDogs = new HashSet<string>();
            largeDogs.Add("Englist Mastiff");
            largeDogs.Add("Newfoundland");
            largeDogs.Add("Bernese Mountaindog");
            largeDogs.Add("Labadore");
            largeDogs.Add("St. Bernard");

            Console.WriteLine("Combines list of small and medium dogs");
            smallDogs.UnionWith(mediumDogs);
            foreach (string s in smallDogs)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

            Console.WriteLine("Dogs that are in both lists");
            HashSet<string> bothLists = new HashSet<string>();
            bothLists = smallDogs;
            bothLists.IntersectWith(largeDogs);
            foreach (string s in bothLists)
            {
                Console.WriteLine(s);
            }
        }
    }
}
