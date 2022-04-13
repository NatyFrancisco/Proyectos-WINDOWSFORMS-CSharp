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
    public partial class pUsuarios : Form
    {
       
      

        public pUsuarios()
        {
            InitializeComponent();
        }

        private void pUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            //INSTANCIAS
            String Rutaconexion = null;
            SqlConnection Conexion;
            string consulta = null;

            //CONEXION
            Rutaconexion = @"Data Source=DESKTOP-3IAQ8PH;Initial Catalog=inventario;Integrated Security=True";
            Conexion = new SqlConnection(Rutaconexion);

            //CONSULTA PARAMETRIZADA
            consulta = "Select * From registroUsuario WHERE cedula = " + "'" + textBox1.Text + "'";

            //LLENAR DATAGRIDVIEW
            SqlDataAdapter data_adap_usuario = new SqlDataAdapter(consulta, Rutaconexion);
            DataTable data_tbl_usuario = new DataTable();
            data_adap_usuario.Fill(data_tbl_usuario);
            dataGridView1.DataSource = data_tbl_usuario;

        }
    }
}
