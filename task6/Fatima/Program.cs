using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Security.Cryptography.X509Certificates;
using System.Globalization;
using Methode;

namespace @string
{
    public  class Program
    {
        

        static void Main(string[] args)


        {
            Methodes x = new Methodes();
            // define all variable 
            Console.WriteLine("please enter the first string :");
            string Str1 = Console.ReadLine();
            Console.WriteLine("please enter the second string : ");
            string Str2 = Console.ReadLine();
            Console.WriteLine("enter the third  string ");
            string Str3 = Console.ReadLine();
            string[] Str4 = { "Helow", "welcome ", "to", "c#", "Create ", "Window", "Client", "application" };
            object Obj1 = "Fatima";
            object Obj2 = "2000-7";
            object Obj3 = "Mohammad";
            string variable = "Hello";
            string[] arry = { "I", "solved", "Task 6" };
            string Target = "Å";
            string MainString = "abcЙࠉ";
            string SubString1;

            string SubString2 = "C#";


            /* Q7 - Write a C# Sharp program to compare a given string with a set of strings.*/
            int result = string.Compare(Str1, Str2);
            Console.WriteLine("Comparing {0} with {1} equal :{2}", Str1, Str2, result);

            //----------------------------------------------------------
            /* Q8- Write a C# Sharp program to compare the current string instance with another string.*/
            int ComparasionResult = string.Compare(Str1, Str2, StringComparison.Ordinal);
            if (ComparasionResult == 0)
            {
                Console.WriteLine("first string {0}is in the same order with the second string {1}", Str1, Str2);
            }
            else if (ComparasionResult > 0)
            {
                Console.WriteLine("The first string {0} follow the second {1} in the sort order", Str1, Str2);
            }
            else { Console.WriteLine("The first string {0} precedes  the second {1} in the sort order. ", Str1, Str2); }

            /*---------------------------------------------------------------------
             * Q11- Write a C# Sharp program to concatenate three strings and display the result.
             */
            Console.WriteLine(string.Concat(Str1, Str2, Str3));
            /*--------------------------------------------------------------------
             * Q12-Write a C# Sharp program to concatenate string array values.
             *  Expected Output:
             *  hello welcome to C# Sharp create Windows client applications 
             *  hello applicationsC# Sharp client create to welcome Windows
             */
            string.Concat(Str4);
            Console.WriteLine(string.Join(" ", Str4));
            string NewOrder = string.Join(" ", Str4[0], Str4[7], Str4[3], Str4[6], Str4[4], Str4[2], Str4[1], Str4[5]);
            Console.WriteLine(NewOrder);
            /*----------------------------------------------------------
             * Q10- Write a C# Sharp program to concatenate a list of variable parameter:
             * Expected Output : abcd --> cadb 

             */

            x.ConcatenateStrings("abcd", "c", "a", "db");
            x.ConcatenateStrings("efgh", "h", "g", "ef");
            x.ConcatenateStrings("ijkl", "l", "ki", "j");
            x.ConcatenateStrings("mnop", "nm", "p", "o");

            /*9. Write a C# Sharp program to concatenate three objects, objects with a variable and a 3-element object array.*/
            //concatenate 3 objects 
            Console.WriteLine(String.Join("  ", Obj1.ToString() + Obj3.ToString() + " my BD IS " + Obj2.ToString()));
            // concat variable with objet
            Console.WriteLine(Obj1.ToString() + string.Join(" ", variable));
            // concat object with array
            Console.WriteLine(Obj1.ToString() + string.Join(" ", arry));
            Console.WriteLine("Search for the target string" + Target + "in the string" + MainString);

            CultureInfo CultInfo = new CultureInfo("en-GB");
            bool isEndWith = Target.EndsWith(MainString, false, CultInfo);
            Console.WriteLine(" The string to search ends with the target string:", isEndWith);
            /*--------------------------------------------------------
             Q*/
            Console.WriteLine("ENTER  THE STRING to seatch weather c# word incloude or not :");
            SubString1 = Console.ReadLine();
            var isCExistAtEnteredString = SubString2.Contains(SubString1);
            if (isCExistAtEnteredString)
            {
                Console.WriteLine("C# document found");
            }
            else
            {
                Console.Write("C# document not found");
            }
            /*-------------------------------------------------------------------------
             * * q/ write c# program to check if repeated occurance in string  
             */
            Console.WriteLine("please enter the phrase to check if it's contain duplicated word or not :");
            string phrse = Console.ReadLine();
            Console.WriteLine(x.RebratedStrint(phrse));


            /*-----------------------------------------------
             * Q: delete specific atring char and return the new string 
             */
            Console.WriteLine("please enter a test contain characters , sypoles,dashes and etc");
            string NewString= Console.ReadLine();
            Console.Write(x.DeleteSpecifcChar(NewString));

        }
        // Methode used to search about specific caracters in array
        
    }
}


