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
    public partial class pArticulos : Form
    {
      

        public pArticulos()
        {
            InitializeComponent();
        }

        private void pArticulos_Load(object sender, EventArgs e)
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
            consulta = "Select * From registroArticulos WHERE codigo = " + "'" + textBox1.Text + "'";

            //LLENAR DATAGRIDVIEW
            SqlDataAdapter data_adap_articulo = new SqlDataAdapter(consulta, Rutaconexion);
            DataTable data_tbl_articulo = new DataTable();
            data_adap_articulo.Fill(data_tbl_articulo);
            dataGridView1.DataSource = data_tbl_articulo;

        }
    }
}
