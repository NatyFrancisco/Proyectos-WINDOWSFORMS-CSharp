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
    public partial class Mantenimiento_Empleado : Form
    {
        //CONEXION
        SqlConnection Conexion = new SqlConnection(@"Data Source=DESKTOP-3IAQ8PH;Initial Catalog=inventario;Integrated Security=True");
        SqlCommand Accion = new SqlCommand();

        public Mantenimiento_Empleado()
        {
            InitializeComponent();
        }

        private void registrar_Click(object sender, EventArgs e)
        {
            //Evento guardar
            Accion.Connection = Conexion;
            Accion.CommandText = "INSERT INTO registroEmpleado (nombres, apellidos, cedula" +
                ", edad, fecha_nacimiento, direccion, email)VALUES(" +
                "'" + tNombre.Text + "','" + tApellido.Text + "','" + tCedula.Text + "', '" 
                + tEdad.Text + "','"
                + tFecha.Text + "','" + tDireccion.Text + "','" + tEmail.Text + "')";


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

        private void modificar_Click(object sender, EventArgs e)
        {

            Accion.Connection = Conexion;
            Accion.CommandText = @"UPDATE registroEmpleado SET 
              nombres       = '" + tNombre.Text + " '," +
                       " cedula      = '" + tCedula.Text + " '," +
                        " apellidos    = '" + tApellido.Text + " ' " +


                        " WHERE cedula = '" + tCedula.Text + " ' " + "";

            Conexion.Open();
            Accion.ExecuteNonQuery();
            Conexion.Close();


            ////////////////////////////////////////////////
            Accion.Connection = Conexion;
            Accion.CommandText = @"UPDATE registroEmpleado SET 
            edad      = '" + tEdad.Text + " ' " +

                " WHERE cedula = '" + tCedula.Text + " ' " + "";

            Conexion.Open();
            Accion.ExecuteNonQuery();
            Conexion.Close();


            ////////////////////////////////////////
            Accion.Connection = Conexion;
            Accion.CommandText = @"UPDATE registroEmpleado SET 

             fecha_nacimiento = '" + tFecha.Text + " ' " +



                " WHERE cedula = '" + tCedula.Text + " ' " + "";

            Conexion.Open();
            Accion.ExecuteNonQuery();
            Conexion.Close();


            ////////////////////////////////
            Accion.Connection = Conexion;
            Accion.CommandText = @"UPDATE registroEmpleado SET 
            direccion       = '" + tDireccion.Text + " '," +
                       
                        " email    = '" + tEmail.Text + " ' " +




            " WHERE cedula = '" + tCedula.Text + " ' " + "";

            Conexion.Open();
            Accion.ExecuteNonQuery();
            MessageBox.Show("Registros actualizados");
            Conexion.Close();
           
            




        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta Seguro que Desea Salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question,


      MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            Accion.Connection = Conexion;
            Accion.CommandText = "DELETE FROM registroEmpleado WHERE cedula  = " + "'" + tCedula.Text + "'";
            Conexion.Open();
            Accion.ExecuteNonQuery();
            MessageBox.Show("Registro eliminado");
            Conexion.Close();
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            Mantenimiento_Empleado a = new Mantenimiento_Empleado();
            a.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void Mantenimiento_Empleado_Load(object sender, EventArgs e)
        {
            lblfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tNombre.Clear();
            tApellido.Clear();
            tCedula.Clear();
            tEdad.Clear();
            tDireccion.Clear();
            tEmail.Clear();
        }
    }
}
