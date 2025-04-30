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

        Graph myGraph = new Graph();
        public Form1()
        {
            InitializeComponent();
            label3.Text = $"Number of Nodes: {myGraph.NumNodesGraph()}";
            label6.Text = $"Number of Edges: {myGraph.NumEdgesGraph()}";
        }
        private static List<string> TraverseDFS(Graph graph, string search)
        {
            List<string> visited = new List<string>();
            graph.DepthFirstTraverse(search, ref visited);
            return visited;
        }
        public void DisplayAll()
        {
            string search = textBox2.Text.Trim();
            if (search != "")
            {
                List<string> visited = TraverseDFS(myGraph, search);
                foreach (var item in visited)
                {
                    listBox1.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("StartID field is empty");
            }
        }

        private void DisplayGraph()
        {
            foreach (string i in myGraph.DisplayGraph())
            {
                listBox1.Items.Add(i);
            }
        }
        private void btn_add_person_Click(object sender, EventArgs e)
        {
            string person = textBox1.Text.Trim();
            if (person!="")
            {
                myGraph.AddNode(person);
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Person field is empty");
            }
        }

        private void btn_display_all_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            DisplayGraph();
            label3.Text = $"Number of Nodes: {myGraph.NumNodesGraph()}";
            label6.Text = $"Number of Edges: {myGraph.NumEdgesGraph()}";
        }

        private void btn_add_direct_edge_Click_1(object sender, EventArgs e)
        {
            string persons = textBox1.Text.Trim();
            string person1, person2;
            person1 = persons.Split(',')[0];
            person2 = persons.Split(',')[1];
            myGraph.AddEdge(person1, person2);
            textBox1.Text = "";
        }

        private void btn_direct_indirect_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            DisplayAll();
            label3.Text = $"Number of Nodes: {myGraph.NumNodesGraph()}";
            label6.Text = $"Number of Edges: {myGraph.NumEdgesGraph()}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void RemovePerson()
        {
            string person = textBox2.Text.Trim();
            myGraph.RemoveNode(person);
            textBox2.Text = "";
        }
        private void DisplayDirectFriends()
        {
            string inputName = textBox2.Text.Trim();
            foreach (string i in myGraph.DisplayAdjNodes(inputName))
            {
                listBox1.Items.Add(i);
            }
        }
        private void btn_remove_person_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            RemovePerson();
            label3.Text = $"Number of Nodes: {myGraph.NumNodesGraph()}";
            label6.Text = $"Number of Edges: {myGraph.NumEdgesGraph()}";

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_direct_friends_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            DisplayDirectFriends();
        }
    }
}
