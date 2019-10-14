using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob3
{
    class Student
    {
        private string YourName;
        private int Id;

        #region fields
        // this method or field GetName() simply returns the value of YourName from the method SetName
        //()
        public string GetName() { return YourName; }

        // SetName method or field with a parameter string name, it's value will be transfer over to 
        // YourName from above.
        public void SetName(string name)
        {
            YourName = name;
        }

        #endregion

        #region properties
        // this property called IdNum has a get and set keyword that returns a value set by the 
        // user
        public int IdNum
        {
            get { return Id; }

            set
            {
                // this validates the value of IdNum to a condition, meaning if the value is less than
                // 100000 or ( what || means) greater than 999999, it'll execute the code below
                if (value < 100000 || value > 999999)
                {
                    // this'll throw in a new Exception in a form of a message if the conditions above
                    // are true
                    throw new Exception("Value of Id has exceed our limits. Try entering a new value");
                }
                // if the value of IdNum doesn't follow the conditions of the above if statement,
                // it'll go to the else where the object Id becomes the value of IdNum
                else Id = IdNum;
            }
        }

        #endregion

        #region constructors

        public double GPA { get; set; }

        // master construtors
        // the master constructor has three parameters that are preset by the user depending 
        // on what they enter as parameters the moment this method is called
        public Student(string Name, int ID, double gpa)
        {
            // the this keyword is another way of referring to Student(string Name, int ID, double gpa)
            // or itself. The parameters Name, ID and gpa are the values that was determined by the 
            // user.
            this.YourName = Name;
            this.Id = ID;
            this.GPA = gpa;
        }

        // this 'default' constructor will assignment a default set of values as parameters.
        // the keyword this is another way of referring to Student() or itself.
        public Student() : this("nothing", 0, 0.0) { }

        // this custom constructor has a parameter of string name meaning it'll take in a value
        // it was given as a parameter when this method is called. The this keyword is another
        // way of referring to Student(string name) or itself
        public Student(string name) : this(name, 0, 0.0) { }

        #endregion

        // we created a method called PrintState() 
        public void PrintState()
        {
            // this method when called will print out some text as well as
            // the values of YourName, Id, and GPA which are assigned to them
            // depending on the constructor which called this method
            Console.WriteLine("Your name:\t{0}", YourName);
            Console.WriteLine("Your id number:\t{0}", Id);
            Console.WriteLine("Your gpa:\t{0}", GPA);
        }

        
    }
}
