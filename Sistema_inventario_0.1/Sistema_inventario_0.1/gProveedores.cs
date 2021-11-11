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
    public partial class gProveedores : Form
    {
        //CONEXION
        SqlConnection Conexion = new SqlConnection(@"Data Source=DESKTOP-3IAQ8PH;Initial Catalog=inventario;Integrated Security=True");
        SqlCommand Accion = new SqlCommand();

        public gProveedores()
        {
            InitializeComponent();
        }

        private void gProveedores_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conexion.Open();
            SqlDataAdapter adap = new SqlDataAdapter("SELECT * FROM registroProveedor", Conexion);
            DataSet dsDatos = new DataSet();
            adap.Fill(dsDatos, "registroProveedor");
            dataGridView1.DataMember = "registroProveedor";
            dataGridView1.DataSource = dsDatos;
        }
    }
}
