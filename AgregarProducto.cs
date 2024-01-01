using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace HEYDA
{
    public partial class AgregarProducto : Form
    {
        string MyConnection2 = "server=localhost; port=5432; user id= postgres; password=123; database=heyda;";
        public AgregarProducto()
        {
            InitializeComponent();
        }

        //Muestra todos los productos en el DataGridView
        private void AgregarProducto_Load(object sender, EventArgs e)
        {
            string Query = "SELECT id_producto, producto.nombre, categoria, stock, precio_venta, precio_proveedor, proveedor.nombre FROM producto, proveedor WHERE proveedor.id_proveedor = producto.id_proveedor;";
            NpgsqlConnection MyConn2 = new NpgsqlConnection(MyConnection2);
            NpgsqlCommand MyCommand2 = new NpgsqlCommand(Query, MyConn2);
            MyConn2.Open();
            NpgsqlDataAdapter MyAdapter = new NpgsqlDataAdapter();
            MyAdapter.SelectCommand = MyCommand2;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
            dgvProductos.DataSource = dTable;
            MyConn2.Close();
        }

        //Filtro de busqueda
        private void txtBuscarProducto__TextChanged(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM producto WHERE nombre LIKE '" + txtBuscarProducto.Texts + "%';";
            NpgsqlConnection MyConn2 = new NpgsqlConnection(MyConnection2);
            NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter(consulta, MyConn2);
            MyConn2.Open();
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgvProductos.DataSource = dt;
            MyConn2.Close();
        }

        //Pasa los datos del producto a los textBox
        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RegistrarPedidos menupedidos = Owner as RegistrarPedidos;
            menupedidos.txtIdProducto.Texts = dgvProductos.CurrentRow.Cells[0].Value.ToString();
            menupedidos.txtNombre.Texts = dgvProductos.CurrentRow.Cells[1].Value.ToString();
            menupedidos.txtPrecio.Texts = dgvProductos.CurrentRow.Cells[4].Value.ToString();
            menupedidos.txtStock.Texts = dgvProductos.CurrentRow.Cells[3].Value.ToString();
            this.Close();
        }

        private void txtBuscarProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("En este recuadro sólo se aceptan letras.\nIntenta de nuevo.");
                e.Handled = true;
                return;
            }
        }
    }
}
