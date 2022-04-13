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
    public partial class Factura : Form
    {

        //CONEXION
        SqlConnection Conexion = new SqlConnection(@"Data Source=DESKTOP-3IAQ8PH;Initial Catalog=inventario;Integrated Security=True");
        SqlCommand Accion = new SqlCommand();

        public Factura()
        {
            InitializeComponent();
        }

        string[,] ListaVenta = new string[200, 5];
        int Fila = 0;

        private void Factura_Load(object sender, EventArgs e)
        {
            fecha_1.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void hora_1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hora_1.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void cargarLista_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigo.Text != "" && txtDescripcion.Text != "" && Precio.Text != "" && Cantidad.Text != "")
                {
                    ListaVenta[Fila,0 ] = txtCodigo.Text;
                    ListaVenta[Fila, 1] = txtDescripcion.Text;
                    ListaVenta[Fila, 2] = Precio.Text;
                    ListaVenta[Fila, 3] = Cantidad.Text;
                    ListaVenta[Fila, 4] = (float.Parse(Precio.Text)*float.Parse(Cantidad.Text)).ToString();

                    dgvLista.Rows.Add(ListaVenta[Fila, 0], ListaVenta[Fila, 1], ListaVenta[Fila, 2], ListaVenta[Fila, 3], ListaVenta[Fila, 4]);
                    Fila++;
                    txtCodigo.Text = txtDescripcion.Text = Precio.Text = Cantidad.Text = "";

                   txtCodigo.Focus();
                }
            }
            catch 
            {
                
            }
            CostoApagar();
        }

        public void CostoApagar()
        {
            float costoTotal = 0;
            int conteo = 0;

            conteo = dgvLista.RowCount;

            for (int i = 0; i<conteo; i++)
            {
                costoTotal += float.Parse(dgvLista.Rows[i].Cells[4].Value.ToString());
            }
            costoPagar.Text = costoTotal.ToString();
        }

       

        private void vender_Click(object sender, EventArgs e)
        {
        clsFuncion.CreaTicket Ticket1 = new clsFuncion.CreaTicket();

            Ticket1.TextoCentro("Empresa xxxxx "); //imprime una linea de descripcion
            Ticket1.TextoCentro("**********************************");

            Ticket1.TextoIzquierda("Dirc: xxxx");
            Ticket1.TextoIzquierda("Tel:xxxx ");
            Ticket1.TextoIzquierda("Rnc: xxxx");
            Ticket1.TextoIzquierda("");
            Ticket1.TextoCentro("Factura de Venta"); //imprime una linea de descripcion
            Ticket1.TextoIzquierda("No Fac:");
            Ticket1.TextoIzquierda("Fecha:" + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
            Ticket1.TextoIzquierda("Le Atendio: xxxx");
            Ticket1.TextoIzquierda("");
            clsFuncion.CreaTicket.LineasGuion();

            clsFuncion.CreaTicket.EncabezadoVenta();
            clsFuncion.CreaTicket.LineasGuion();
            foreach (DataGridViewRow r in dgvLista.Rows)
            {
                // Articulo                     //Precio                                    cantidad                            Subtotal
                Ticket1.AgregaArticulo(r.Cells[1].Value.ToString(), double.Parse(r.Cells[2].Value.ToString()), int.Parse(r.Cells[3].Value.ToString()), double.Parse(r.Cells[4].Value.ToString())); //imprime una linea de descripcion
            }


            clsFuncion.CreaTicket.LineasGuion();
            Ticket1.AgregaTotales("Sub-Total", double.Parse("0")); // imprime linea con Subtotal
            Ticket1.AgregaTotales("Menos Descuento", double.Parse("0")); // imprime linea con decuento total
            Ticket1.AgregaTotales("Mas ITBIS", double.Parse("0")); // imprime linea con ITBis total
            Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Total", double.Parse(costoPagar.Text)); // imprime linea con total
            Ticket1.TextoIzquierda(" ");

            Ticket1.AgregaTotales("Efectivo Entregado:", float.Parse(efectivo.Text));//
            Ticket1.AgregaTotales("Efectivo Devuelto:", float.Parse(devolucion.Text));


            // Ticket1.LineasTotales(); // imprime linea 

            Ticket1.TextoIzquierda(" ");
            Ticket1.TextoCentro("**********************************");
            Ticket1.TextoCentro("*     Gracias por preferirnos    *");

            Ticket1.TextoCentro("**********************************");
            Ticket1.TextoIzquierda(" ");
            string impresora = "Microsoft XPS Document Writer";
            Ticket1.ImprimirTiket(impresora);




            Fila = 0;
            while (dgvLista.RowCount > 0)//limpia el dgv
            { dgvLista.Rows.Remove(dgvLista.CurrentRow); }
            //LBLIDnuevaFACTURA.Text = ClaseFunciones.ClsFunciones.IDNUEVAFACTURA().ToString();

            txtCodigo.Text = txtDescripcion.Text = Cantidad.Text = efectivo.Text ="";
            costoPagar.Text = devolucion.Text = Precio.Text = "0";
            txtCodigo.Focus();
            MessageBox.Show("Gracias por preferirnos");

        }

        private void efectivo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                devolucion.Text = (float.Parse(efectivo.Text) - float.Parse(costoPagar.Text)).ToString();
            }
            catch
            {
                devolucion.Text = "0.00";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Factura a = new Factura();
            a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Accion.Connection = Conexion;
            Accion.CommandText = "DELETE FROM registroArticulos WHERE codigo  = " + "'" + txtCodigo.Text + "'";
            Conexion.Open();
            Accion.ExecuteNonQuery();
            MessageBox.Show("Registro eliminado");
            Conexion.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void costoPagar_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void devolucion_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

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
    }
}
