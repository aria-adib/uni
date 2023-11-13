using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uni_project._3
{
    public partial class listMahsol : Form
    {
        public listMahsol()
        {
            InitializeComponent();
        }

        private void listMahsol_Load(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("mahsol.csv");

            for (int i = 0; i < lines.Length; i++)
            {
                listBox1.Items.Add(lines[i] + "\n");

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
