using System;
using System.Globalization;

/*1.Write C# Sharp program to demonstrate that the Compare(String, String, Boolean) method is equivalent to using ToUpper or ToLower when comparing strings.
Expected Output :

Comparing 'QRS' and 'qrs':

The Strings are equal when capitalized? true

The Strings are equal when case is ignored? true

2. Write a C# Sharp program to demonstrate how culture affects comparisons.
Note : In Czech – Czech Republic culture, "ch" is a single character that is greater than "d". However, in English - United States culture, "ch" consists of two characters, and "c" is less than "d".

Expected Output :

For en-US: change < dollar

For cs-CZ: change > dollar

3.Write a C# Sharp program to compare two strings in following three different ways produce three different results.
a. using linguistic comparison for the en-US culture;

b. using linguistic case-sensitive comparison for the en-US culture;

c. using an ordinal comparison.It illustrates how the three methods of comparison

Expected Output :

'sister' comes before 'Sister'.

'sister' is the same as 'Sister'.

'sister' comes after 'Sister'.

4. Write a C# Sharp program to compare three versions of the letter "I". The results are affected by culture choice, whether the case is ignored, and whether an ordinal comparison is performed.
Expected Output :

Compare three versions of the letter I using different values of StringComparison.

The current culture is en-US.

StringComparison.CurrentCulture:

LATIN SMALL LETTER I (U+0069) is less than LATIN SMALL LETTER DOTLESS I (U+0131)

LATIN SMALL LETTER I (U+0069) is less than LATIN CAPITAL LETTER I (U+0049)

LATIN SMALL LETTER DOTLESS I (U+0131) is greater than LATIN CAPITAL LETTER I (U+0

5. Write a C# Sharp program to demonstrate that you compare ordinals and compare using different sort orders.
Expected Output :

CompareOrdinal("xyz"[1], "XYZ"[1]):

'y' is greater than 'Y'

Compare("xyz"[1], "XYZ"[1]):

'y' is less than 'Y'

6.Write a C# Sharp program to perform an ordinal comparison of two strings that only differ in case.
Expected Output :

Compare the numeric values of the corresponding Char objects in each string.

str1 = 'JAVA', str2 = 'python'

String 'JAVA' is less than String 'python'.

7. Write a C# Sharp program to compare a given string with a set of strings.
Expected Output :

Bad argument: TestClass(type TestClass)

Comparing 'some text' with 'TestClass': -1

Bad argument: 123(type Int32)

Comparing 'some text' with '123': 1

Comparing 'some text' with 'some text': 0

Comparing 'some text' with 'Some Text': -1*/

namespace task6
{

    
    class Program
    {

        public static void Q1()
        {
            /*1.Write C# Sharp program to demonstrate that the Compare(String, String, Boolean) method is equivalent to using ToUpper or ToLower when comparing strings.
                Expected Output:

            Comparing 'QRS' and 'qrs':

            The Strings are equal when capitalized? true

            The Strings are equal when case is ignored ? true*/

            Console.WriteLine("Enter string1:");
            var Inp1 = Console.ReadLine();
            Console.WriteLine("Enter string2:");
            var Inp2 = Console.ReadLine();

            Console.WriteLine("The Strings are equal when capitalized?{0}", Convert.ToBoolean(string.Compare(Inp1, Inp2, true)));
            Console.WriteLine("The Strings are equal when case is ignored?{0}", Convert.ToBoolean(string.Compare(Inp1, Inp2, false)));

        }


        public static void Q2()
        {
            /*2. Write a C# Sharp program to demonstrate how culture affects comparisons.
            Note : In Czech – Czech Republic culture, "ch" is a single character that is 
            greater than "d". However, in English - United States culture, "ch" consists 
            of two characters, and "c" is less than "d".
            */

            var cz = new System.Globalization.CultureInfo("cs");
            var en = new System.Globalization.CultureInfo("en-US");
            Console.WriteLine("Enter string1:");
            var Inp1 = Console.ReadLine();
            Console.WriteLine("Enter string2:");
            var Inp2 = Console.ReadLine();
            int ResultCz = String.Compare(Inp1, Inp2, cz, System.Globalization.CompareOptions.None);
            int ResultEn = String.Compare(Inp1, Inp2, en, System.Globalization.CompareOptions.None);
            Console.WriteLine($"Comparing in {cz.Name} returns {ResultCz}.");
            Console.WriteLine($"Comparing in {en.Name} returns {ResultEn}.");
            
        }

        public static void Q3()
        {

            /*3.Write a C# Sharp program to compare two strings in following three different ways produce three different results.
            a. using linguistic comparison for the en-US culture;

            b. using linguistic case-sensitive comparison for the en-US culture;

            c. using an ordinal comparison.It illustrates how the three methods of comparison
            */

            var en = new System.Globalization.CultureInfo("en-US");
            Console.WriteLine("Enter string1:");
            var Inp1 = Console.ReadLine();
            Console.WriteLine("Enter string2:");
            var Inp2 = Console.ReadLine();
            int ResultEn = String.Compare(Inp1, Inp2, en, CompareOptions.None);
            Console.WriteLine($"Comparing in {en.Name} returns {ResultEn}.");
            int ResultEnCaseSenstive = String.Compare(Inp1, Inp2, StringComparison.InvariantCulture);
            Console.WriteLine($"Comparing in {en.Name} returns {ResultEnCaseSenstive}.");
            int ResultEnOrdinal = String.Compare(Inp1, Inp2, StringComparison.Ordinal);
            Console.WriteLine($"Comparing in {en.Name} returns {ResultEnOrdinal}.");
        }

        public static void Q4()
        {
            /*4. Write a C# Sharp program to compare three versions of the letter "I".
             The results are affected by culture choice, whether the case is ignored, 
            and whether an ordinal comparison is performed.Expected Output :Compare 
            three versions of the letter I using different values of StringComparison.*/

            var en = new System.Globalization.CultureInfo("en-US");
            var Inp1 = Convert.ToString('i');
            var Inp2 = Convert.ToString('I'); 
            int ResultEn = String.Compare(Inp1, Inp2, en, CompareOptions.None);
            Console.WriteLine($"Comparing in {en.Name} returns {ResultEn}.");
            int ResultEnCaseSenstive = String.Compare(Inp1, Inp2, StringComparison.InvariantCulture);
            Console.WriteLine($"Comparing in {en.Name} returns {ResultEnCaseSenstive}.");
            int ResultEnOrdinal = String.Compare(Inp1, Inp2, StringComparison.Ordinal);
            Console.WriteLine($"Comparing in {en.Name} returns {ResultEnOrdinal}.");

        }



        public static void Q5()
        {
            /*5. Write a C# Sharp program to demonstrate that you compare ordinals
             and compare using different sort orders.Expected Output :
            CompareOrdinal("xyz"[1], "XYZ"[1]):
            */

            var en = new System.Globalization.CultureInfo("en-US");
            var Inp1 = "xyz";
            var Inp2 = "XYZ";
            int ResultEn = String.Compare(Inp1, Inp2, en, CompareOptions.Ordinal);

            switch (Math.Sign(ResultEn))
            {
                case 1:
                    Console.WriteLine("{0}<{1}", Inp1, Inp2);
                    break;
                case 0:
                    Console.WriteLine("{0}={1}", Inp1, Inp2);
                    break;
                case -1:
                    Console.WriteLine("{0}>{1}", Inp1, Inp2);
                    break;
            }


        }


        public static void Q6()
        {
            /*6.Write a C# Sharp program to perform an ordinal comparison of two strings that only differ in case.
            Expected Output :*/

            var en = new System.Globalization.CultureInfo("en-US");
            var Inp1 = "JAVA";
            var Inp2 = "python";
            int ResultEn = String.Compare(Inp1, Inp2, en, CompareOptions.Ordinal);

            switch (Math.Sign(ResultEn))
            {
                case 1:
                    Console.WriteLine("{0}<{1}", Inp1, Inp2);
                    break;
                case 0:
                    Console.WriteLine("{0}={1}", Inp1, Inp2);
                    break;
                case -1:
                    Console.WriteLine("{0}>{1}", Inp1, Inp2);
                    break;
            }
        }

        static void Main(string[] args)
        {
            Q1();
            Q2();
            Q3();
            Q4();
            Q5();
            Q6();


            


        }
    }
}
