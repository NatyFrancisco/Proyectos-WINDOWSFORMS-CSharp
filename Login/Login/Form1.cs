using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string user= "Naty";
            string password = "123";


            if(user != textBox1.Text || password != textBox2.Text)
            {
                MessageBox.Show("User or password incorrect");
            }
            else
            {
                MessageBox.Show("Bienvenid@!!");
            }
        }

    }
}
