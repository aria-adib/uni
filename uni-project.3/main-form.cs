using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uni_project._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tarifMoshtary tarifMoshtary = new tarifMoshtary();
            tarifMoshtary.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listMoshtary lm = new listMoshtary();
            lm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tarifMahsol tm = new tarifMahsol();
            tm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listMahsol lm = new listMahsol();
            lm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            gozaresh gozaresh = new gozaresh();
            gozaresh.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            showSql sql = new showSql();
            sql.Show();
          
           

        }

    }
}
