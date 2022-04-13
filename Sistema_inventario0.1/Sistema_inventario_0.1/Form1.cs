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
    public partial class Form1 : Form
    {
        //INSTANCIAS//
        
        String Rutaconexion = null;
        SqlConnection Conexion;
        SqlCommand sqlCmd;
        string consulta = null;


     

        public Form1()
        {
            InitializeComponent();
        }

        //Evento cancelar
        

        private void acceder_Click(object sender, EventArgs e)
        {



            //CONEXION

             Rutaconexion = @"Data Source=DESKTOP-3IAQ8PH;Initial Catalog=inventario;Integrated Security=True";
              Conexion = new SqlConnection(Rutaconexion);


              //CONSULTA
              consulta = "Select * From registroUsuario WHERE usuario = " + "'" + textBox1.Text + "'and contrasena= " + "'" + textBox2.Text + "'";

              try
              {
                  // SI ES VERDADERA LA CONSULTA
                  Conexion.Open();
                  sqlCmd = new SqlCommand(consulta, Conexion);
                  SqlDataReader sqlReader = sqlCmd.ExecuteReader();

                  if (sqlReader.Read())
                  {
                      SqlDataAdapter adaptadorNivel = new SqlDataAdapter(consulta, Rutaconexion);
                      DataTable dataTableNivel = new DataTable();
                      adaptadorNivel.Fill(dataTableNivel);


                   

                            Form2 a = new Form2();
                              a.Show();
                            


                  }

                  //SI ES FALSO
                  else
                  {
                      MessageBox.Show("USUARIO O CONTRASEÑA INCORRECTOS INTENTAR DE NUEVO");

                  }
              }
              catch (Exception ex)
              {
                  MessageBox.Show(ex.StackTrace);
              }

          

        }

        //EVENTO DEL TEXTBOX
        private void textBox1_Validated(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Debe completar el campo usuario");
                textBox1.Focus();
            }

        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("Debe completar el campo contraseña");
                textBox2.Focus();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblusuario_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
