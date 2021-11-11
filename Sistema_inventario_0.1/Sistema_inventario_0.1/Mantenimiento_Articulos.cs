using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sistema_inventario_0._1
{
    public partial class Mantenimiento_Articulos : Form
    {
        //CONEXION
        SqlConnection Conexion = new SqlConnection(@"Data Source=DESKTOP-3IAQ8PH;Initial Catalog=inventario;Integrated Security=True");
        SqlCommand Accion = new SqlCommand();

        public Mantenimiento_Articulos()
        {
            InitializeComponent();
        }

        //Evento guardar
        private void registrar_Click(object sender, EventArgs e)
        {
            //Evento guardar
            Accion.Connection = Conexion;
            Accion.CommandText = "INSERT INTO registroArticulos (articulo, codigo, categoria, cantidad, precio, proveedor, fecha_ingreso)VALUES(" +
                "'" + tArticulo.Text + "','" + tCodigo.Text + "','" + tCategoria.Text + "', '" + tCantidad.Text + "','"
                + tPrecio.Text + "','" + tProveedor.Text + "','" + tFecha.Text + "')";


            Conexion.Open();
            Accion.ExecuteNonQuery();
            MessageBox.Show("Datos Registrados");
            Conexion.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 a = new Form2();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta Seguro que Desea Salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question,


      MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        
    }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void Mantenimiento_Articulos_Load(object sender, EventArgs e)
        {
            lblfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            Mantenimiento_Articulos a = new Mantenimiento_Articulos();
            a.Show();
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            Accion.Connection = Conexion;
            Accion.CommandText = @"UPDATE registroArticulos SET 
              articulo       = '" + tArticulo.Text + " '," +
                       " codigo      = '" + tCodigo.Text + " '," +
                        " categoria    = '" + tCategoria.Text + " ' " +
                       

                        " WHERE codigo = '" + tCodigo.Text + " ' " + "";

            Conexion.Open();
            Accion.ExecuteNonQuery();
            Conexion.Close();

           
            ////////////////////////////////////////////////
            Accion.Connection = Conexion;
            Accion.CommandText = @"UPDATE registroArticulos SET 
            cantidad      = '" + tCantidad.Text + " '," +
    " precio    = '" + tPrecio.Text + " ' " +
     



                " WHERE codigo = '" + tCodigo.Text + " ' " + "";

            Conexion.Open();
            Accion.ExecuteNonQuery();
            Conexion.Close();


            ////////////////////////////////////////
            Accion.Connection = Conexion;
            Accion.CommandText = @"UPDATE registroArticulos SET 
             proveedor = '" + tProveedor.Text + " ' " +
    


                " WHERE codigo = '" + tCodigo.Text + " ' " + "";

            Conexion.Open();
            Accion.ExecuteNonQuery();   
            Conexion.Close();


            ////////////////////////////////
            Accion.Connection = Conexion;
            Accion.CommandText = @"UPDATE registroArticulos SET 
fecha_ingreso    = '" + tFecha.Text + " ' " +
" WHERE codigo = '" + tCodigo.Text + " ' " + "";

            Conexion.Open();
            Accion.ExecuteNonQuery();
            MessageBox.Show("Registros actualizados");
            Conexion.Close();

            

        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            Accion.Connection = Conexion;
            Accion.CommandText = "DELETE FROM registroArticulos WHERE codigo  = " + "'" + tCodigo.Text + "'";
            Conexion.Open();
            Accion.ExecuteNonQuery();
            MessageBox.Show("Registro eliminado");
            Conexion.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tArticulo.Clear();
            tCodigo.Clear();
            tCategoria.Clear();
            tCantidad.Clear();
            tPrecio.Clear();
            tProveedor.Clear();

            
        }
    }
}
