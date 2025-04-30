using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_A
{
    internal class Student
    {
        // Members
        private string name;
        private string id;
        private int age;

        // constructor
        public Student(string name, string id, int age)
        {
            this.name = name;
            this.id = id;
            this.age = age;
        }

        // property(s)
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        // Method
        public string GetInformation()
        {
            string info;
            info = $"Student name: {this.Name} \nID: {this.Id} \nAge: {this.Age}\n";
            return info;
        }
    }
}
