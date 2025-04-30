using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_C
{
    public partial class Form1 : Form
    {
        private CustomerQueue customerqueue = new CustomerQueue();
        public Form1()
        {
            InitializeComponent();
            CountQueue();
        }
        // COunt all customers in the queue
        private void CountQueue()
        {
            label1.Text = $"Total number of customers in queue {customerqueue.Count()}";
        }
        
        // Enqueue button
        private void btn_enqueue_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            int age = Convert.ToInt32(textBox2.Text);
            Customer customer = new Customer(name, age);
            if (customerqueue.IsFull())
            {
                MessageBox.Show("Queue is Full", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else
            {
                customerqueue.Enqeue(customer);
                textBox1.Text = "";
                textBox2.Text = "";
                DisplayCustomers();
                CountQueue();
            }
        }

        // Dequque button
        private void btn_dequeue_Click(object sender, EventArgs e)
        {
            if (customerqueue.IsEmpty() != true)
            {
                customerqueue.Dequeue();
                DisplayCustomers();
                CountQueue();
            }
            else
            {
                MessageBox.Show("Queue is Empty", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Display all customer method
        private void DisplayCustomers()
        {
            var names = customerqueue.Store;
            customerslist.Items.Clear();
            foreach (var name in names.Where(name => name != null))
            {
                customerslist.Items.Add($"Name: {name.Name}, Age: {name.Age}");
            }
        }
        // Reverse button
        private void btn_reverse_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(textBox3.Text);
            customerqueue.Reverse(number);
            DisplayCustomers();
            textBox3.Text = "";
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
