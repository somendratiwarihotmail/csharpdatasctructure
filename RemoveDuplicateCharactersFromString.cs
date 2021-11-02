//The string may have two or more same characters in it but we want it to have only one. So let’s look at an example to understand it better.
// Required input and output
// Input: Csharpstar
// Output: Csharpt

// Input: Google
// Output: Gogle

// Input: Yahoo
// Output: Yaho

// Input: CNN
// Output: CN

//The essential logic in removing duplicate characters is to check all the chars that have been encountered and avoid adding further characters that have been encountered already.

using System;

namespace csharpdatasctructure
{
 public class RemoveDuplicateCharactersFromString
    {
        public static void  Runner()
        {
            Console.WriteLine("Start: RemoveDuplicateCharactersFromString");

            RemoveDuplicateChars("Csharpstar");
            RemoveDuplicateChars("Google");
            RemoveDuplicateChars("Yahoo");
            RemoveDuplicateChars("CNN");
            RemoveDuplicateChars("Line1\nLine2\nLine3");

            Console.WriteLine("End: RemoveDuplicateCharactersFromString");
        }

        static void RemoveDuplicateChars(string key){
            
            string resultKey="";
            foreach(char item in key){
                if(resultKey.IndexOf(item)==-1){
                    resultKey +=item;
                }
            }
            Console.WriteLine("Input: {0}",key);
            Console.WriteLine("Output: {0}",resultKey);
        }
    }
}
