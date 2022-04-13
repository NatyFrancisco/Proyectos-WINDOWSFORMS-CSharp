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
    public partial class pProveedores : Form
    {
       

        public pProveedores()
        {
            InitializeComponent();
        }

        private void pProveedores_Load(object sender, EventArgs e)
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
            consulta = "Select * From registroProveedor WHERE cedula = " + "'" + textBox1.Text + "'";

            //LLENAR DATAGRIDVIEW
            SqlDataAdapter data_adap_proveedor = new SqlDataAdapter(consulta, Rutaconexion);
            DataTable data_tbl_proveedor = new DataTable();
            data_adap_proveedor.Fill(data_tbl_proveedor);
            dataGridView1.DataSource = data_tbl_proveedor;

        }
    }
}
