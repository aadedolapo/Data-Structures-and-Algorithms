using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_B
{
    public partial class Form1 : Form
    {
        private CustomerQueue customer = new CustomerQueue();
        public Form1()
        {
            
            InitializeComponent();
            CountQueue();
        }
        
        // Displacy all customers in the queue
        private void DisplayCustomers()
        {
            var names = customer.Store;
            customerslist.Items.Clear();
            foreach (var name in names.Where(name => name != null))
            {
                customerslist.Items.Add($"{name}");
            }
        }

        // Counts thenumber of customers in the queue
        private void CountQueue()
        {
            label1.Text = $"Total number of customers in queue: {customer.Count()}";
        }

        // Enqueue buttom
        private void btn_enqueue_Click(object sender, EventArgs e)
        {
            if (customer.IsFull())
            {
                MessageBox.Show("Queue is Full", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Text = "";
            }           
            else
            {
                customer.Enqeue(textBox1.Text.Trim());
                textBox1.Text = "";
                DisplayCustomers();
                CountQueue();
            }            
        }
    // Dequeue buttonn
        private void btn_dequeue_Click(object sender, EventArgs e)
        {
            if (customer.IsEmpty() != true)
            {
                customer.Dequeue();
                DisplayCustomers();
                CountQueue();
            }
            else
            {
                MessageBox.Show("Queue is Empty", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
