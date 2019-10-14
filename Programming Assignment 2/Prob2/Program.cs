/*
Author: Richard Mora
Date: 10/11/2019
CTEC 135: Microsoft Software Development with C#

Module 3, Programming Assignment 2, Problem 2

    Methods

region demo of call by value: Takes values from int data types objects display their values, 
        change their value inside a method and showcase how the initial value 
        isn't change afterwards.

region demo of call by reference: Takes an string object and int object, display their values, 
    change their values inside a method and show their new value while the method is running
    and after the method is executed.

region overloading: Create two methods that have the same name and performs the same actions
    except each take in different data types and print out thier results
*/ 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2
{
    class Program
    {
        static void Main(string[] args)
        {
            // I created two int data types, a string array and a int array each having their
            // own initial value
            string[] FullName = new string[] { "Richard", "Milly", "John" };
            int DistanceTravel = 30;
            int TotalDistance = 150;
            int[] MilesTogo = new int[] { 10, 20 };

            #region demo of call by value
            // the following three codes print out some texts as well as the value of the 
            // selected object
            Console.WriteLine("Values before method is called for value:\n");
            Console.WriteLine("Distance traveled is: {0}", DistanceTravel);
            Console.WriteLine("Total distance left is: {0}\n", TotalDistance);

            // this calls the Prob2Method1 method with DistanceTravel and TotalDistance objects
            // as parameters
            Prob2Method1(DistanceTravel, TotalDistance);
            
            // these codes display the values of DistanceTravel and TotalDistance objects after
            // the Prob2Method1 method is called.
            Console.WriteLine("Values after method is called:\n");
            Console.WriteLine("Distance traveled is: {0}", DistanceTravel);
            Console.WriteLine("Total distance left is: {0}\n", TotalDistance);
            Console.WriteLine("-----------------------\n");
            #endregion

            #region demo of call by reference
            Console.WriteLine("Values before method is called for reference\n");
            Console.WriteLine("List of names");
            // this uses a foreach loop that uses the string array FullName and prints out their 
            // element one line at a time
            foreach (string name in FullName)
            {
                Console.WriteLine(name);
            }
            
            Console.WriteLine("Distance traveled is: {0}", DistanceTravel);
            Console.WriteLine("Total distance left is: {0}", TotalDistance);
            Console.WriteLine("How many miles to go");
            // this uses a foreach loop that similar to the first one eariler takes the int array
            // MilesTogo and prints out their element one line at a time
            foreach (int num in MilesTogo)
            {
                Console.WriteLine(num);
            }

            // this calls the method Prob2Method with FullName, DistanceTravel, and MilesTogo 
            // as parameters
            Prob2Method(FullName, DistanceTravel, MilesTogo);

            Console.WriteLine("Values after method is called\n");
            Console.WriteLine("List of names");
            // uses a foreach loop to print out the value of FullName array one line at a time
            foreach (string name in FullName)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Distance traveled is: {0}", DistanceTravel);
            Console.WriteLine("Total distance left is: {0}", TotalDistance);
            Console.WriteLine("How many miles to go");

            // uses a foreach loop to print out the value of MilesTogo array one line at a time
            foreach (int num in MilesTogo)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("\n");
            Console.WriteLine("-----------------\n");
            #endregion

            #region overloading
            // int
            // this calls the Multiple method using DistanceTravel and TotalDistance objects 
            // as parameters. The calling of this method is happening inside Console.WriteLine.
            // What this does is prints out the value of the two objects 
            Console.WriteLine(Multiple(DistanceTravel, TotalDistance));

            // double
            // this calls the Multiple method using 12.50 and 10.25 as parameters. The calling
            // of this method is happening inside Console.WriteLine. What this doees is prints
            // out the value of the two objects
            Console.WriteLine(Multiple(12.50, 10.25)); 
            #endregion
        }

        // reference
        // this method which is called Prob2Method that takes a string array, a int and a int array 
        // as parameters
        static void Prob2Method(string[] name, int miles, int[] total)
        {
            // first I create 5 objects: two string arrays, one int, and two int arrays data types 
            // each having their own values.
            name[1] = "Robert";
            name[0] = "Dave";
            miles = 100;
            total[0] = 150;
            total[1] = 300;

            // the following lines of code simply adds text and the values of each object above
            Console.WriteLine("Values during method is called:\n");
            Console.WriteLine("List of names");
            Console.WriteLine("{0} {1}",name[1], name[0]);
            Console.WriteLine("Distance traveled is: {0}", total[0]);
            Console.WriteLine("Total distance left is: {0}", total[1]);
            Console.WriteLine("How many miles to go {0}\n", miles);
            
        }

        // overloading
        // the following two methods each have the same name and performs the same thing except
        // each taking in a different data type. Each Multiple method takes in two data types, multiplies them and return the resulted value back to main.

        // this takes in the data type of int
        static int Multiple (int a, int b)
        {
            return a * b;
        }

        // this takes in the double data type
        static double Multiple (double a, double b)
        {
            return a * b;
        }

        // value
        // this method takes in the parameters of two int data types and assign it a value
        // that should be different from when this method is called from Main();
        static void Prob2Method1(int x, int y)
        {
            x = 100;
            y = 300;

            // this takes text and prints it out when called.
            Console.WriteLine("Value during method is called:\n");
            Console.WriteLine("Distance traveled is: {0}", x);
            Console.WriteLine("Total distance left is: {0}\n", x);
        }
    }
}
