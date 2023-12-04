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
    public partial class tarifMahsol : Form
    {
        public tarifMahsol()
        {
            InitializeComponent();
        }

        private void tarifMahsol_Load(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mahsol = textBox1.Text;
            string cod = textBox2.Text;
            string kol = mahsol + "،" + cod + "\n";
            File.WriteAllText("mahsol.csv", kol);
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
