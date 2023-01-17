using System;
using System.Globalization;

namespace CSharpFundamental
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Challenge 1 */
            string text = "this is a text to be converted to an upper case";
            string newText = toTitleCase(text);
            Console.WriteLine(newText); // expect to see "This Is A Text"

            // /* Challenge 2 */
            // int[,] arrayA = { { 3, 5, 4, 6 }, { 3, 7, 8, 3 } };
            // int[,] arrayB = { { 5, 1 }, { 8, 4 }, { 2, 9 }, { 2, 3 } };
            // int[,] result = matrixMultiply(arrayA, arrayB);
            // Console.WriteLine(result); //share your findings to Slack
        }
        static string toTitleCase(string input)
        {
            /* Write your code here */
            // // First version 
            // char[] array = input.ToCharArray(); 
            // if (array.Length >= 1)
            // {
            //     if (char.IsLower(array[0]))
            //     {
            //         array[0] = char.ToUpper(array[0]);
            //     }
            // } 
            // for (int i = 1; i < array.Length; i++)
            // {
            //     if (array[i - 1] == ' ')
            //     {
            //         if (char.IsLower(array[i]))
            //         {
            //             array[i] = char.ToUpper(array[i]);
            //         }
            //     }
            // }
            // return new string(array);
            // if (string.IsNullOrEmpty(input))
            // {
            //     return string.Empty;
            // }
           
           // Second version
            var wordInSentence = input.Split(' ');
            var stringText = "";
            foreach (var sentence in wordInSentence)
            {
                stringText += char.ToUpper(sentence[0]) + sentence.Substring(1) + ' ';
            }
            return stringText.Trim();
        }
        
        // static int[,] matrixMultiply(int[,] array1, int[,] array2)
        // {
        //     /* Write your code here */
        // }
    }
}
