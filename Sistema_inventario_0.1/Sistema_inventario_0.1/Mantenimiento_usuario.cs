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
    public partial class Mantenimiento_usuario : Form
    {
        //CONEXION
        SqlConnection Conexion = new SqlConnection(@"Data Source=DESKTOP-3IAQ8PH;Initial Catalog=inventario;Integrated Security=True");
        SqlCommand Accion = new SqlCommand();

        public Mantenimiento_usuario()
        {
            InitializeComponent();
        }

        private void Mantenimiento_usuario_Load(object sender, EventArgs e)
        {
            lblfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void registrar_Click(object sender, EventArgs e)
        {
            //Evento guardar
            Accion.Connection = Conexion;
            Accion.CommandText = "INSERT INTO registroUsuario (nombres, apellidos, cedula,usuario, contrasena, rol, email)VALUES(" +
                "'" + tNombre.Text + "','" + tApellido.Text + "','" + tCedula.Text + "', '" + tUsuario.Text + "','"
                + tContrasena.Text + "','" + tRol.Text + "','" + tEmail.Text + "')";


            Conexion.Open();
            Accion.ExecuteNonQuery();
            MessageBox.Show("Datos Registrados");
            Conexion.Close();

        }

        private void modificar_Click(object sender, EventArgs e)
        {

            Accion.Connection = Conexion;
            Accion.CommandText = @"UPDATE registroUsuario SET 
            cedula = '" + tCedula.Text + " ' " +
                    

                        " WHERE cedula = '" + tCedula.Text + " ' " + "";


            Conexion.Open();
            Accion.ExecuteNonQuery();
            Conexion.Close();

            ////////////////////////////////////////

            Accion.Connection = Conexion;
            Accion.CommandText = @"UPDATE registroUsuario SET 
            nombres = '" + tNombre.Text + " '," +
                     " apellidos    = '" + tApellido.Text + " '  " +

                        " WHERE cedula = '" + tCedula.Text + " ' " + "";


            Conexion.Open();
            Accion.ExecuteNonQuery();
            Conexion.Close();

            //////////////////////////////////////////


            Accion.Connection = Conexion;
            Accion.CommandText = @"UPDATE registroUsuario SET 
          usuario = '" + tUsuario.Text + " '," +

                     " contrasena    = '" + tContrasena.Text + " ' " +


                        " WHERE cedula = '" + tCedula.Text + " ' " + "";


            Conexion.Open();
            Accion.ExecuteNonQuery();
            Conexion.Close();

         

            /////////////////////////////////////

            Accion.Connection = Conexion;
            Accion.CommandText = @"UPDATE registroUsuario SET 
  
                          email      = '" + tEmail.Text + " ' " +
                        

                        " WHERE cedula = '" + tCedula.Text + " ' " + "";


            Conexion.Open();
            Accion.ExecuteNonQuery();
            Conexion.Close();


            /////////////////////////

            Accion.Connection = Conexion;
            Accion.CommandText = @"UPDATE registroUsuario SET 
  
          
                          rol      = '" + tRol.Text + " ' " +

                        " WHERE cedula = '" + tCedula.Text + " ' " + "";


            Conexion.Open();
            Accion.ExecuteNonQuery();
            MessageBox.Show("Registros actualizados");
            Conexion.Close();

        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            Accion.Connection = Conexion;
            Accion.CommandText = "DELETE FROM registroUsuario WHERE cedula = " + "'" + tCedula.Text + "'";
            Conexion.Open();
            Accion.ExecuteNonQuery();
            MessageBox.Show("Registro Eliminado");
            Conexion.Close();
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            Mantenimiento_usuario a = new Mantenimiento_usuario();
            a.Show();
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

        private void button2_Click(object sender, EventArgs e)
        {
            tNombre.Clear();
            tApellido.Clear();
            tCedula.Clear();
            tUsuario.Clear();
            tContrasena.Clear();
            tRol.Clear();
            tEmail.Clear();
        }
    }
}
