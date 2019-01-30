using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class Student //class name is a data type. treat it as int, double, etc.
    {
        //Instances:
        public int SoonerID { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsOnProbation { get; set; }
        public double GPA { get; set; }
        private double BursarBalance; //Doesn't really matter if we have getter and setter here!

        /// <summary>
        /// Default constructor for the student class.
        /// Sets all the instance variables to their default values.
        /// </summary>
        public Student()
        {
            SoonerID = 0;
            FirstName = "";
            LastName = "";
            IsOnProbation = false;
            GPA = 0.0;
            BursarBalance = 0.0;
        }

        /// <summary>
        /// This is a Constructor because the name of the method is the same as constructor's and no return type.
        /// This is the overloaded constructor for student class that accepts SoonerID, FirstName, LastName,
        /// BursarBalance.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fName"></param>
        /// <param name="lName"></param>
        /// <param name="BursarBalance"></param>
        public Student( int id, string fName, string lName, double BursarBalance)
        {
            SoonerID = id;
            FirstName = fName;
            LastName = lName;
            this.BursarBalance = BursarBalance;
        }

        public void MakePayment (double amount)
        {
            if (amount > 0)
            {
                if (BursarBalance > 0)
                {
                    BursarBalance = BursarBalance - amount;
                }
            }
        }

        public double CheckBalance()
        {
            return BursarBalance;
        }

    }
}
