using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Majoncho_6439059
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            double majonchocost;
            int cantidadmajonchos;
            double totalmajonchocost;



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            majonchocost = Convert.ToDouble(textBox3
              .Text);
            cantidadmajonchos = Convert.ToInt32(textBox1.Text);
            totalmajonchocost = majonchocost * cantidadmajonchos;
            textBox3.Text = "$" + Convert.ToInt32(totalmajonchocost);
        }
    }
}
