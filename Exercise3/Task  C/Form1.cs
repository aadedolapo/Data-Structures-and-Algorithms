using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Task__C
{
    public partial class Form1 : Form
    {
        Dictionary<string, Student> stdlibrary = new Dictionary<string, Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            string id = idtextbox.Text;
            string name = nametextbox.Text;
            if ((id.Length == 0) || (name.Length == 0))
            {
                MessageBox.Show("Student Id/Student Name is missing", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                idtextbox.Clear();
                nametextbox.Clear();
                return;
                
            }
            Student student = new Student(id, name, true);
            if (stdlibrary.ContainsKey(id))
            {
                MessageBox.Show("Student Id already exists", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                stdlibrary.Add(id, student);
            }
            idtextbox.Clear();
            nametextbox.Clear();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            enrollmentStatus.Items.Clear();
            stdlibrary.Remove(idtextbox.Text);
            idtextbox.Text = "";
        }

        private void DisplayAllEnrolledStudents()
        {
            foreach(KeyValuePair<string, Student> stu in stdlibrary)
            {
                Student student = stu.Value;
                if (student.IsEnrolled)
                {
                    var person = $"ID: {student.Id}, Name: {student.Name}";
                    DisplayAllStudents.Items.Add(person);
                }
            }
        }

        private void displayEnrollmentStatus()
        {
            string id = idtextbox.Text;
            if (!stdlibrary.ContainsKey(id))
            {
                MessageBox.Show("Student Id does not exist", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (stdlibrary.TryGetValue(id, out Student student))
            {
                if (student.IsEnrolled)
                {
                    enrollmentStatus.Items.Add("The student is Enrolled");
                }
                else
                {
                    enrollmentStatus.Items.Add("The student is not Enrolled");
                }
            }
            idtextbox.Text = "";
        }

        private void DisplayStudentInfo()
        {
            string name = nametextbox.Text;
            if (name!="")
            {
                foreach (KeyValuePair<string, Student> stu in stdlibrary)
                {
                    Student student = stu.Value;
                    if (student.Name.ToLower().Contains(name.ToLower()))
                    {
                        var person = $"ID: {student.Id}, Enrollment Status: {student.IsEnrolled}";
                        DisplayAllStudents.Items.Add(person);
                    }
                }
            }
            nametextbox.Text = "";


        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string id = idtextbox.Text;
            if (stdlibrary.TryGetValue(id, out Student student))
            {
                if (student.IsEnrolled)
                {
                    student.IsEnrolled = false;
                }
                else
                {
                    student.IsEnrolled = true;
                }
            }
            idtextbox.Text = "";
        }
        private void DisplayButton_Click(object sender, EventArgs e)
        {
            enrollmentStatus.Items.Clear();
            displayEnrollmentStatus();

        }

        private void displaysStudentButton_Click(object sender, EventArgs e)
        {
            DisplayAllStudents.Items.Clear();
            DisplayAllEnrolledStudents();
        }

        private void displayinfo_Click(object sender, EventArgs e)
        {
            DisplayAllStudents.Items.Clear();
            DisplayStudentInfo();

        }
    }
}
