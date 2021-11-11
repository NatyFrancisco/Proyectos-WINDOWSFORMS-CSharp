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
    public partial class Reporte_Empleados : Form
    {
        //CONEXION
        SqlConnection Conexion = new SqlConnection(@"Data Source=DESKTOP-3IAQ8PH;Initial Catalog=inventario;Integrated Security=True");
        SqlCommand Accion = new SqlCommand();

        public Reporte_Empleados()
        {
            InitializeComponent();
        }

        private void Reporte_Empleados_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conexion.Open();
            SqlDataAdapter adap = new SqlDataAdapter("SELECT * FROM registroEmpleado", Conexion);
            DataSet dsDatos = new DataSet();
            adap.Fill(dsDatos, "registroEmpleado");
            dataGridView1.DataMember = "registroEmpleado";
            dataGridView1.DataSource = dsDatos;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
