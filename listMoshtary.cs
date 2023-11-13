using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uni_project._3
{
    public partial class listMoshtary : Form
    {
        public listMoshtary()
        {
            InitializeComponent();
        }

        private void listMoshtary_Load(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("moshtary.csv");

            for (int i = 0; i < lines.Length; i++)
            {
                listBox1.Items.Add(lines[i] + "\n");
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
