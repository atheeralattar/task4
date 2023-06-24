using System;

namespace Task6
{
    class Q21
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String:");
            string input = Console.ReadLine();
            string withoutDuplicates = RemoveDuplicates(input);
            Console.WriteLine(withoutDuplicates);
        }

        static string RemoveDuplicates(string input)
        {
            string result = string.Empty;
            int Length = 0;

            foreach (char c in input)
            {
                if (result.IndexOf(c) == -1)
                {
                    result += c;
                    Length++;
                }
            }

            Console.WriteLine("Number of longest characters: " + Length);

            return result;
        }
    }
}
