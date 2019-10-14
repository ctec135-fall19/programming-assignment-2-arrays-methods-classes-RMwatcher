/*
Author: Richard Mora
Date: 10/11/2019
CTEC 135: Microsoft Software Development with C#

Module 3, Programming Assignment 2, Problem 1

    Arrays

region array of strings: Create an array of strings ("one" through "ten") and output them 
                using a foreach loop
    
    Methods

region array of ints: Create an array of ints that has the size of 10 elements
                that has the output of multiples of 10s

    Class

region array of 2-D array: Create a 2-D array that has 12 rows and 12 columns that showcase a multiplcation table of 12 formatted for readability.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            #region array of strings
            // string array called FirstArray that have strings "one" through "ten" inside of it.
            // with a total of 10 elements
            string[] FirstArray = new string[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };

            // use a foreach loop to print out each element inside FirstArray
            foreach (string element in FirstArray)
            {
                Console.WriteLine(element);
            }

            #endregion

            // Input: Create a int array that has a size of 10 elements

            // Output: Print out array one element having their own line using a for loop. 
            // Each int element inside the array will have a multiple of ten starting from (1 + 0) * 10 = 10
            // all the way to the end of the array.

            // Behavior: Using a for loop I add each element's index (starts at 0) add 1 to it's value and multiple it by 10. The second for loop will print out each element of SecondArray each having their own line.
            #region array of ints
            // created a int array named SecondArray that has a size of 10 elements
            int[] SecondArray = new int[10];

            // using a for loop, I created int i = 0. As long as i is less than the size
            // of SecondArray, I'll execute the code below
            for (int i = 0; i < SecondArray.Length; i++)
            {
                // this takes each element based on their index, add 1 to each to them
                // and multiple it by 10 thus giving them each element a new value.
                SecondArray[i] = (i + 1) * 10;
            }
            Console.WriteLine();

            // this for loop is similar to the first one above but instead of i we use j 
            // as a placeholder
            for (int j = 0; j < SecondArray.Length; j++)
            {
                // this just prints out each element in SecondArray in their own line
                // except instead of the initial value before the first for loop it has
                // a new value and display those instead.
                Console.WriteLine(SecondArray[j]);
            }
            #endregion

            #region array of 2-D array
            // input: Create a 2-D int array that has 12 rows and 12 columns with a total of
            // 144 elements

            // output: Print out a 12 by 12 table multiplcation table where each row is multiply
            // by each column until it reaches the last row and column
            
            // behavior: two nested loops where the first nested loop assign each row with a value 
            // starting with ( i + 1 ) where i is equal 0 and acts as the rows while j is also equals
            // to zero and acts as a column. First nested loop adds each index (i and j) adding one 
            // and multipling both together while the second nested loop prints out each number
            // in a special format.

            // creating a 2-D int array called ThirdArray with 12 rows and columns
            int[,] ThirdArray = new int[12, 12];

            // creating int 1 = 0 to select index in the array and execute the code below it
            // as long as i is less than 12.
            for (int i = 0; i < 12; i++)
            {
                // nested for loop similar to the first for loop above where int j = 0 refers to 
                // the index of the array and again execute code as long as j is less than 12.
                for (int j = 0; j < 12; j++) 
                {
                    // this take i and j, add one to each and multiple them together to get a new value
                    ThirdArray[i, j] = (i + 1) * (j + 1);
                }
            }
            Console.WriteLine();

            // the following two lines of code is used with formatting to make it easier 
            // to read when it prints out
            Console.Write("\t1.\t2.\t3.\t4.\t5.\t6.\t7.\t8.\t9.\t10.\t11.\t12.\t\n");
            Console.Write("\t--\t--\t--\t--\t--\t--\t--\t--\t--\t--\t--\t--\n");
            // similar to the for loop above, it selects each element in the row section of the array
            // and as long as the condition is true, it'll keep executing the code below
            for (int row = 0; row < 12; row++)
            {
                // The following three codes are for making it easier to read the tables and which
                // number it starts with
                Console.Write("\n");
                Console.Write(row + 1);
                Console.Write(".\t");
                // this nested loop is the same as the outter loop from above
                for (int col = 0; col < 12; col++)
                {
                    // this takes each row element and column element and displays them in a 
                    // 12 by 12 fashion
                    Console.Write("{0}\t", ThirdArray[row,col]);
                }
            }Console.Write("\n\n");
            #endregion
        }
    }
}
