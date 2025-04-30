using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_C
{
    internal class Customer
    {
        // members
        private string name;
        private int age;

        // Constructors
        public Customer(string name, int age)
        {
            this.name = name;       
            this.age = age;
        }

        // properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        //  Methods
        //public void DisplayCustomer()
        //{
        //    Console.WriteLine($"Name: {this.Name}, Age: {this.Age}");
        //}
    }
}
