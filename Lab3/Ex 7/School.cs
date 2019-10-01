using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_7
{
    class School:IComparable<School>
    {
        private string schoolName;

        public string SchoolName
        {
            get { return schoolName;}
            set { schoolName = value; }

        }

        private int numStudents;

        public int NumberStudents
        {
            get { return numStudents; }
            set { numStudents = value; }
        }

        public School(string name,int numstudents)
        {
            SchoolName = name;
            NumberStudents = numstudents;
        }
        public int CompareTo(School sc)
        {
            int returnVal;
            if (this.numStudents > sc.numStudents)
                returnVal = 1;
            else if (this.numStudents < sc.numStudents)
                returnVal = -1;
            else
                returnVal = 0;

            return returnVal;
        }

       


    }
}
