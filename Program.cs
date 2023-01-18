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

            /* Challenge 2 */
            int[,] arrayA = { 
                { 3, 5, 4, 6 }, 
                { 3, 7, 8, 3 } 
                }; // 4D2
            int[,] arrayB = { 
                { 5, 1 }, 
                { 8, 4 }, 
                { 2, 9 }, 
                { 2, 3 } 
                }; // 2D4
            int[,] result = matrixMultiply(arrayA, arrayB);
            Console.WriteLine(result); //share your findings to Slack
            {
                int arrayARows = result.GetLength(0);
                int arrayBCols = result.GetLength(1);

                for (int i = 0; i < arrayARows; i++)
                {
                    for (int j = 0; j < arrayBCols; j++)
                    {
                        Console.Write($" {result[i, j]} ");
                    }
                    Console.Write(Environment.NewLine);
                }
            }
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

        static int[,] matrixMultiply(int[,] array1, int[,] array2)
        {
            /* Write your code here */
            var array1Rows = array1.GetLength(0);
            var array1Cols = array1.GetLength(1);
            var array2Rows = array2.GetLength(0);
            var array2Cols = array2.GetLength(1);

            if (array1Cols != array2Rows)
            {
                throw new ArgumentException("This array must have the same length");
            }
           int[,] result = new int[array1Rows, array2Cols];
            for (int i = 0; i < array1Rows; i++)
            {
                for (int j = 0; j < array1Cols; j++)
                {
                    for (int k = 0; k < array2Cols; k++)
                    {
                        result[i, k] += array1[i, j] * array2[j, k];
                    }
                }
            }
            return result;
        }
    }
}
