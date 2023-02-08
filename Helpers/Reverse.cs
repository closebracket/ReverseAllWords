using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReverseAllWords.Helpers;
namespace ReverseAllWords.Helpers
{

    class Reverse
    {
        public static void SingleTextMethod(string inputToReverse)
        {
            char[] charsToReverse = inputToReverse.ToCharArray();
            Array.Reverse(charsToReverse);
            Globals.outputReversed = new string(charsToReverse);
        }
        //public static void MultipleTextMethod(string inputToReverse, string anotherInputToReverse)
        //{
        //    char[] charsToReverse = inputToReverse.ToCharArray();
        //    char[] moreCharsToReverse = anotherInputToReverse.ToCharArray();
            
        //    Array.Reverse(charsToReverse);
        //    Array.Reverse(moreCharsToReverse);

        //    Globals.outputReversed = new string(charsToReverse);
        //}
    }
}
