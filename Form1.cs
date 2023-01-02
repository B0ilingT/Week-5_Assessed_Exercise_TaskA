using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_5_Task_A
{
    public partial class Form1 : Form
    {
        Graph<int> intGraph;
        public Form1()
        {
            InitializeComponent();
            intGraph = new Graph<int>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            countLabel.Text = "Count: " + intGraph.NumNodesGraph().ToString();
        }

        private void nodeAddButton_Click(object sender, EventArgs e)
        {
            if (addNodeTextBox.Text != "")
            {
                intGraph.AddNode(Convert.ToInt32(addNodeTextBox.Text));
                countLabel.Text = "Count: " + intGraph.NumNodesGraph().ToString();
                addNodeTextBox.Clear();
                addNodeOutputLabel.Text = "Inserted";
            }
            else { addNodeOutputLabel.Text = "Entry Field is Empty"; }
        }
        private void addEdgeButton_Click(object sender, EventArgs e)
        {
            if (addEdgeTextBox1.Text != "" && addEdgeTextBox2.Text != "")
            {
                if (intGraph.ContainsGraph(Convert.ToInt32(addEdgeTextBox1.Text)) == true && intGraph.ContainsGraph(Convert.ToInt32(addEdgeTextBox2.Text)) == true)
                {
                    intGraph.AddEdge(Convert.ToInt32(addEdgeTextBox1.Text), Convert.ToInt32(addEdgeTextBox2.Text));
                    addEdgeOutputLabel.Text = "Submitted";
                }
                else
                    addEdgeOutputLabel.Text = "Nodes do not exist";
                addEdgeTextBox1.Clear();
                addEdgeTextBox2.Clear();
            }
            else { addEdgeOutputLabel.Text = "Entry Field is Empty"; }
        }

        private void adjCheckButton_Click(object sender, EventArgs e)
        {
            if (adjCheckTextBox1.Text != "" && adjCheckTextBox2.Text != "")
            {
                if (intGraph.IsAdjacent(intGraph.GetNodeByID(Convert.ToInt32(adjCheckTextBox1.Text)), intGraph.GetNodeByID(Convert.ToInt32(adjCheckTextBox2.Text))) == true)
                    checkAdjOutputLabel.Text = adjCheckTextBox1.Text + " is Adjacent to: " + adjCheckTextBox2.Text;
                    
                else
                    checkAdjOutputLabel.Text = adjCheckTextBox1.Text + " is not Adjacent to: " + adjCheckTextBox2.Text;
                adjCheckTextBox1.Clear();
                adjCheckTextBox2.Clear();
            }
            else { checkAdjOutputLabel.Text = "Entry Field is Empty"; }
        }

        
    }
}
