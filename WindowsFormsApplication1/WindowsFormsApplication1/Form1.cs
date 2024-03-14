using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if  ((textBox1.Text.ToLower())== "manager" && textBox2.Text == "mpass")
                MessageBox.Show("Manager Logged In!");
            if ((textBox1.Text.ToLower()) == "employee" && textBox2.Text == "epass")
                MessageBox.Show("Employee Logged In!");
            else
                MessageBox.Show("Incorrect Username or Password");
        }
    }
}
