using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_inventario_0._1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta Seguro que Desea Salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question,


      MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void calculadoraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void excelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Excel.exe");
        }

        private void windwordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Winword");
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Mantenimiento_usuario a = new Mantenimiento_usuario();
            a.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hora_1.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            fecha_1.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Mantenimiento_Articulos a = new Mantenimiento_Articulos();
            a.Show();
        }

        private void proveedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Mantenimiento_Empleado a = new Mantenimiento_Empleado();
            a.Show();
        }

        private void proveedoresToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Mantenimiento_Proveedor a = new Mantenimiento_Proveedor();
            a.Show();
        }

        private void almacenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Almacen a = new Almacen();
            a.Show();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Factura a = new Factura();
            a.Show();
        }

        private void consultaGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gArticulos a = new gArticulos();
            a.Show();
        }

        private void consultaParametrizadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pArticulos a = new pArticulos();
            a.Show();
        }

        private void consultaGeneralToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            gUsuarios a = new gUsuarios();
            a.Show();
        }

        private void consultaParametrizadaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pUsuarios a = new pUsuarios();
            a.Show();
        }

        private void consiltaGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gEmpleados a = new gEmpleados();
            a.Show();
        }

        private void consultaParametrizadaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            pEmpleados a = new pEmpleados();
            a.Show();
        }

        private void consultaGeneralToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            gProveedores a = new gProveedores();
            a.Show();
        }

        private void consultaParametrizadaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            pProveedores a = new pProveedores();
            a.Show();
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte_Articulos a = new Reporte_Articulos();
            a.Show();
        }

        private void usuariosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Reporte_Usuarios a = new Reporte_Usuarios();
            a.Show();
        }

        private void proveedoresToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Reporte_Proveedores a = new Reporte_Proveedores();
            a.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte_Empleados a = new Reporte_Empleados();
            a.Show();
        }
    }
}
