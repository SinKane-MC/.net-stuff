using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeViewCheckedListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkedListBox1.CheckOnClick = true;
        }

        private void btnTreeView_Click(object sender, EventArgs e)
        {
            treeView1.BeginUpdate();
            treeView1.Nodes.Add("Parent");
            treeView1.Nodes[0].Nodes.Add("Child 1");
            treeView1.Nodes[0].Nodes.Add("Child 2");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("Grandchild");
            treeView1.Nodes[0].Nodes[1].Nodes[0].Nodes.Add("Great Grandchild");
            treeView1.Nodes[0].Nodes[1].Nodes[0].Nodes[0].Nodes[1].Nodes[0].Nodes.Add("Great Grandchild");
            treeView1.EndUpdate();
        }

        private void btnCheckedListBox_Click(object sender, EventArgs e)
        {
            string[] myFruit = { "Apples", "Oranges", "Tomato", "Bananas", "Coconuts", "Mangos", "Papaya" };
            checkedListBox1.Items.AddRange(myFruit);
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCheckedItems.Text = checkedListBox1.CheckedItems.Count.ToString();
        }
    }
}
