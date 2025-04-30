using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Task__C
{
    internal class Student
    {
        //members
        private string name;
        private string id;
        private bool enrollmentStatus;

        //constructors
        public Student(string id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public Student(string id, string name, bool enrolled)
        {
            this.id = id;
            this.name = name;
            this.enrollmentStatus = enrolled;
        }

        //property(s)
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public bool IsEnrolled
        {
            get { return this.enrollmentStatus; }
            set { this.enrollmentStatus = value; }
        }
    }
}
