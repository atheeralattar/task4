using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Methode
{
    public class Methodes
    {

        public  bool RebratedStrint(string Repeatedsent)
        {
            var RebeatedChar = new HashSet<char>();
            foreach (char item in Repeatedsent)
            {
                if (RebeatedChar.Contains(item))
                {
                    return true;
                }
                RebeatedChar.Add(item);
            }
            return false;

        }

        // methode used to concatinate strings 
        public  void ConcatenateStrings(params string[] strings)
        {
            string concatenatedString = String.Concat(strings);
            Console.WriteLine($"{strings[0]} --> {concatenatedString}");
        }
        //Methode to delete specific cahr 
        public  string DeleteSpecifcChar(string input)
        {
            StringBuilder NewString = new StringBuilder();
            foreach (char c in input)
            {
                if (char.IsWhiteSpace(c) || char.IsLetterOrDigit(c))
                {
                    NewString.Append(c);
                }
            }
            return NewString.ToString();
        }




    }
  
}
