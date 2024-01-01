using System;
using Npgsql;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HEYDA
{
    public partial class Pedidos : Form
    {
        string MyConnection2 = "host=localhost port=5432 dbname=heyda user=postgres";
        public Pedidos()
        {
            InitializeComponent();
        }

        private void Pedidos_Load(object sender, EventArgs e)
        {
            txtIdProducto.Texts = "0";

        }
        //Limpiar los textbox
        private void limpiarProducto()
        {
            txtIdProducto.Texts = "0";
            txtNombre.Texts = "";
            txtPrecio.Texts = "";
            txtStock.Texts = "";
            dudCantidad.Value = 1;
        }

        //Buscar el producto con lupa
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            AgregarProducto ventana = new AgregarProducto();
            AddOwnedForm(ventana);
            ventana.Show();
        }

        //Buscar el producto solo metiendo el id
        private void txtIdProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string Query = "SELECT * FROM producto WHERE id_producto=" + txtIdProducto.Texts + ";";
                NpgsqlConnection MyConn2 = new NpgsqlConnection(MyConnection2);
                NpgsqlCommand MyCommand2 = new NpgsqlCommand(Query, MyConn2);
                NpgsqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                if (MyReader2.Read())
                {
                    txtNombre.Texts = MyReader2.GetString(1);
                    txtPrecio.Texts = MyReader2.GetString(3);
                    txtStock.Texts = MyReader2.GetString(4);
                }
                else
                {
                    MessageBox.Show("No se encontro producto con ese id");
                }
                MyConn2.Close();
            }
        }
        //Obtener el total
        private void calcularTotal()
        {
            decimal total = 0;
            if (dgvProveedores.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvProveedores.Rows)
                {
                    total += Convert.ToDecimal(row.Cells["Cantidad"].Value.ToString());
                }
            }
            txtTotalPagar.Texts = total.ToString("0.00");

        }

        //Validaciones de los productos
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            decimal precio = 0;
            bool productoExiste = false;

            if (int.Parse(txtIdProducto.Texts) != 0)
            {
                if (Convert.ToInt32(txtStock.Texts) > Convert.ToInt32(dudCantidad.Value.ToString()))
                {
                    dgvProveedores.Rows.Add(new object[] {
                        txtIdProducto.Texts,
                        txtNombre.Text,
                        precio.ToString("0.00"),
                        dudCantidad.Value.ToString(),
                        (dudCantidad.Value * precio).ToString("0.00")
                    });
                    calcularTotal();
                    limpiarProducto();
                    txtIdProducto.Select();
                }
                else
                {
                    MessageBox.Show("La cantidad excede el stock");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Debes de seleccionar un producto");
                return;
            }
        }

        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProveedores.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    dgvProveedores.Rows.RemoveAt(index);
                    calcularTotal();
                }
            }
        }


        private void rjTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("En este recuadro sólo se aceptan números.\nIntenta de nuevo.");
                e.Handled = true;
                return;
            }
        }

        private void rjTextBox1_KeyPress(object sender, KeyPressEventArgs e)
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
