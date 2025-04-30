using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_A
{
    internal class Program
    {
        static int integerCount(int num)
            // A method that returns the lenght of a number
        {
            int count = 0; // Initialize a counter variable
            while (num > 0) // while the number is greeater than 0
            {
                num /= 10; // dividing the number  by 10
                count++; // count increases by 1
            }
            return count;

        }
        static void Main(string[] args)
        {
            //Create and add students details
            Student[] students = new Student[10];
            for (int i = 0; i < students.Length; i++)
            {
                string studentName, studentID;
                int studentAge;
                Console.Write($"Add Student {i} Name: ");
                studentName = Console.ReadLine();

                Console.Write($"Add Student {i} ID: ");
                studentID = Console.ReadLine();
                //using the lenght of my student id as a basis for the maximum lenght of digits(8)

                while (studentID.Length != 8)
                {
                    Console.WriteLine($"{studentID} is not of maximum length [8]");
                    Console.WriteLine("Re-Enter student ID");
                    studentID = Console.ReadLine();
                }

                Console.Write($"Add Student {i} Age: ");
                studentAge = Convert.ToInt32(Console.ReadLine());

                while (integerCount(studentAge) != 2)
                {
                    Console.WriteLine($"{studentAge} is not of maximum length [2]");
                    Console.WriteLine("Re-Enter student Age");
                    studentAge = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();

                students[i] = new Student(studentName, studentID, studentAge);
            }

            // Display all students and their details
            int x = 0;
            Console.WriteLine("Sudent Information:");
            while (x < students.Length)
            {
                
                Console.WriteLine(students[x].GetInformation());
                x++;
            }

            
        }
    }
}
