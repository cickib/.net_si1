using System;

namespace SortString
{
    class Program
    {
        static void Main(string[] args)
        {

            string randomString = "The word 'word' supposed to come last when sorted. Such a random string.";
            string[] stringArr = randomString.Split(' ');
            Array.Sort(stringArr);
            string result = string.Join(" ", stringArr);
            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
