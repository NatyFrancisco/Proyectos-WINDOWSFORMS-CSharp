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
    public partial class gUsuarios : Form
    {
        //CONEXION
        SqlConnection Conexion = new SqlConnection(@"Data Source=DESKTOP-3IAQ8PH;Initial Catalog=inventario;Integrated Security=True");
        SqlCommand Accion = new SqlCommand();

        public gUsuarios()
        {
            InitializeComponent();
        }

        private void gUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conexion.Open();
            SqlDataAdapter adap = new SqlDataAdapter("SELECT * FROM registroUsuario", Conexion);
            DataSet dsDatos = new DataSet();
            adap.Fill(dsDatos, "registroUsuario");
            dataGridView1.DataMember = "registroUsuario";
            dataGridView1.DataSource = dsDatos;
        }
    }
}
