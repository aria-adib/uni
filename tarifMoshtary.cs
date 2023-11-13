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
    public partial class tarifMoshtary : Form
    {
        public tarifMoshtary()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = textBox1.Text;
            string family = textBox2.Text;
            string tel = textBox3.Text;
            string email = textBox4.Text;
            string pas = textBox5.Text;
            string total = name + "،" + family + "،" + tel + "،" + email + "،" + pas + "\n";
            File.AppendAllText("moshtary.csv", total);
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tarifMoshtary_Load(object sender, EventArgs e)
        {

        }
    }
}
