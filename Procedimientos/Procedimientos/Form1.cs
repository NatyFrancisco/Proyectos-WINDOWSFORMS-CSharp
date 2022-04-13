using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Procedimientos
{
    public partial class Form1 : Form
    {

        int desde;
        int hasta;
        int cod;

        public Form1()
        {
            InitializeComponent();
        }

        private void procesoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.procesoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.procedimientosDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'procedimientosDataSet.proceso' Puede moverla o quitarla según sea necesario.
            this.procesoTableAdapter.Fill(this.procedimientosDataSet.proceso);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cod = Convert.ToInt32(textBox1.Text);
                this.procesoTableAdapter.FillBy(this.procedimientosDataSet.proceso, cod, textBox2.Text);

                MessageBox.Show("Contraseña correcta");

                Form2 abrir = new Form2();
                abrir.Show();
                    }
            catch
            { 
                MessageBox.Show("Contraseña incorrecta. Intentalo de nuevo");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            desde = Convert.ToInt32(textBox1.Text);
            hasta = Convert.ToInt32(textBox2.Text);
            this.procesoTableAdapter.FillBy1(this.procedimientosDataSet.proceso, desde, hasta);

        }
    }
}
