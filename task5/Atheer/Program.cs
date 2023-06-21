using System;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;

namespace Classes
{
    class Program
    {


        static string Trimmer(string inpStr, int frontTrim = 1)
        {
            var Length = inpStr.Length;

            if (frontTrim == 0)
            {
                return inpStr.Substring(1);
            }
            else
            {
                return inpStr.Substring(0, Length - 1);
            }
            
        }

        static string Reverser(string inpString)
        {
            var Arr = inpString.ToCharArray();
            Array.Reverse(Arr);
            return new String(Arr);
        }



        static void Main(string[] args)
        {

            
            Console.WriteLine("Input string:");
            var inpString = Console.ReadLine();
            Console.WriteLine(@"Original String: {0}
Reversed String: {1}
Initial palindrome check: {2}
Palindrome check after head trim : {3}
Palindrome check after tail trim : {4}", inpString, Reverser(inpString), 
                Reverser(inpString)==inpString, 
                Reverser(Trimmer(inpString)) == Trimmer(inpString),
                Reverser(Trimmer(inpString, 0)) == Trimmer(inpString, 0));

        }
        
    }
}