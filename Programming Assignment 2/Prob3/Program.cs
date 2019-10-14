/*
Author: Richard Mora
Date: 10/11/2019
CTEC 135: Microsoft Software Development with C#

Module 3, Programming Assignment 2, Problem 3

    Class

    Student.region fields: Create Accessors and Mutators or getters and 
        setters where we set an object with a value and assign that value with ever
        the user chooses

    Student.region properties: Similar to fields, properties retrieves a value 
    that was given by user imput. Create a validation process using a if statement 
    where if that value is outside a certain range, 'throw' a exception that gives 
    out a message, otherwisee set whatever the value is to be used for later. Also 
    create an automattic properties where C# it set and retrieves a value all without 
    us doing anything

    Student.region constructors: Create three methods that'll take in values whether its from
    a method that has no parameters or default constructor, a method with one parameter that'll be 
    used as one of the values or custom constructor, and a method where it has three parameters
    where all values are determined by the user and given values or master constructor.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob3
{
    class Program
    {
        static void Main(string[] args)

        {

            // Default constructor where it creates a new student object called stud1.
            // This give stud1 a 'default' value that was created ahead of time.
            Student stud1 = new Student();
            // the method PrintState() which is from the Student class prints out the values
            // it was assigned to it
            stud1.PrintState();
            Console.WriteLine();

            // a custom constructor where it creates a new student object called stud2 that has a 
            // string as a parameter where it'll be used as one of its values instead of a 'default'
            // value.
            Student stud2 = new Student("Richard Mora");
            // again PrintState from the Student class prints out the values it was assigned 
            // including the string "Richard Mora" as a value we give this object.
            stud2.PrintState();
            Console.WriteLine();

            // this master constructor creates a new Student object called stud3 which has
            // three parameters meaning this new object will have values assign to them by the user.
            Student stud3 = new Student("Richard Mora", 100100, 3.5);

            // we use a try/catch statement to check if a certain value is within our conditions 
            // we set up ahead of time. 
            try
            {
                // if the int value of IdNum doesn't match our conditions we set up, catch will throw
                // a new exception in a form of a personal message
                stud3.IdNum = stud3.IdNum;
                
            }

            // if it doesn't follow our conditions, the catch statement 
            // will 'catch' it and displays an exception in a form of a message we made.
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // again PrintState from the Student class prints out the values it was assigned 
            // including the string "Richard Mora", 100100, and 3.5 as a value we give this object.
            stud3.PrintState();
            Console.WriteLine();

        }
    }
}
