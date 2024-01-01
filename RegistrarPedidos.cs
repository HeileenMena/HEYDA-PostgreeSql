using Microsoft.VisualBasic;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HEYDA
{
    public partial class RegistrarPedidos : Form
    {
        string MyConnection2 = "server=localhost; port=5432; user id= postgres; password=123; database=heyda;";
        public RegistrarPedidos()
        {
            InitializeComponent();
        }

        private void Pedidos_Load(object sender, EventArgs e)
        {
            txtIdProducto.Texts = "0";

        }


        private void label10_Click(object sender, EventArgs e)
        {

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
            foreach (DataGridViewRow row in dgvProveedores.Rows)
            {
                if (row.Cells["SubTotal"].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells["SubTotal"].Value.ToString());
                }
            }
            txtTotalPagar.Texts = total.ToString();

        }

        //Validaciones de los productos
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            decimal precio = Convert.ToInt32(txtPrecio.Texts);
            bool productoExiste = false;
            if (txtPrecio.Texts != null)
            {
                if (int.Parse(txtIdProducto.Texts) != 0)
                {
                    if (Convert.ToInt32(txtStock.Texts) > Convert.ToInt32(dudCantidad.Value.ToString()))
                    {
                        dgvProveedores.Rows.Add(new object[] {
                        txtIdProducto.Texts,
                        txtNombre.Texts,
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int stock = 0, stockFinal;

            foreach (DataGridViewRow row in dgvProveedores.Rows)
            {
                if (row.Cells["Cantidad"].Value != null)
                {
                    stock = Convert.ToInt32(row.Cells["Cantidad"].Value.ToString());
                    string consul = "SELECT nombre, stock FROM producto WHERE id_producto = " + row.Cells["IdProducto"].Value.ToString();
                    NpgsqlConnection MyConn2 = new NpgsqlConnection(MyConnection2);
                    NpgsqlCommand comando = new NpgsqlCommand(consul, MyConn2);
                    MyConn2.Open();
                    NpgsqlDataReader lector = comando.ExecuteReader();
                    while (lector.Read())
                    {
                        int stockInicial = Convert.ToInt32(lector.GetInt32(1));
                        stockFinal = stockInicial - stock;
                        string Query = "UPDATE producto SET stock=" + stockFinal + " WHERE id_producto=" + row.Cells["IdProducto"].Value.ToString() + ";";
                        NpgsqlConnection MyConn = new NpgsqlConnection(MyConnection2);
                        NpgsqlCommand MyCommand = new NpgsqlCommand(Query, MyConn);
                        NpgsqlDataReader MyReader;
                        MyConn.Open();
                        MyReader = MyCommand.ExecuteReader();
                        MyConn.Close();

                    }
                    MyConn2.Close();
                }
            }
            dgvProveedores.Rows.Clear();
        }

        private void imprimir(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

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

        private void rjTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("En este recuadro sólo se aceptan números.\nIntenta de nuevo.");
                e.Handled = true;
                return;
            }
            else
            {
                string longitud = rjTextBox2.Texts;
                if (rjTextBox2.Texts.Length >= 10)
                {
                    MessageBox.Show("En este recuadro sólo se aceptan 10 números.\nIntenta de nuevo.");
                    e.Handled = true;
                    rjTextBox2.Texts = "";
                    return;
                }
            }
        }
    }
}
