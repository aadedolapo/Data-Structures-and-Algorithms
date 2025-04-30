using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task__B
{
    public partial class Form1 : Form
    {
        Graph myGraph = new Graph();
        public Form1()
        {
            InitializeComponent();
            label5.Text = $"Number of Nodes: {myGraph.NumNodesGraph()}";
            label6.Text = $"Number of Edges: {myGraph.NumEdgesGraph()}";
        }

        private void btn_add_person_Click(object sender, EventArgs e)
        {
            string person = textBox1.Text;
            myGraph.AddNode(person);
            textBox1.Text = "";
        }

        private void btn_add_direct_edge_Click(object sender, EventArgs e)
        {
            string persons = textBox1.Text.Trim();
            string person1, person2;
            person1 = persons.Split(',')[0];
            person2 = persons.Split(',')[1];
            myGraph.AddEdge(person1, person2);
            textBox1.Text = "";
        }

        private void DisplayGraph()
        {
            foreach (string i in myGraph.DisplayGraph())
            {
                listBox1.Items.Add(i);
            }
        }

        private void DisplayDirectFriends()
        {
            string inputName = textBox2.Text.Trim();
            foreach (string i in myGraph.DisplayAdjNodes(inputName))
            {
                listBox1.Items.Add(i);
            }
            textBox2.Text = "";
        }

        private void btn_display_all_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            DisplayGraph();
            label5.Text = $"Number of Nodes: {myGraph.NumNodesGraph()}";
            label6.Text = $"Number of Edges: {myGraph.NumEdgesGraph()}";
        }

        private void btn_direct_friends_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            DisplayDirectFriends();
        }
    }
}
