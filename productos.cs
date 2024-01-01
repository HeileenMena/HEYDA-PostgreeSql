using System;
using System.Collections;
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
    public partial class productos : Form
    {
        string MyConnection2 = "server=localhost; port=5432; user id= postgres; password=123; database=heyda;";
        public productos()
        {
            InitializeComponent();
        }

        //Modificar productos
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //UPDATE `producto` SET `nombre`='a',`categoria`='Artículos de sobremesa',`stock`='3',`precio_venta`='30',`precio_proveedor`='15',`id_proveedor`='1' WHERE `id_producto`='9638521';
            try
            {
                if (txtId.Texts != "" && txtProducto.Texts != "" && cbCategoria.Text != "" && txtStock.Texts != "" && cbProveedor.Text != "" && txtPrecioProveedor.Texts != "")
                {
                    if (txtId.Texts == dgvProductos.CurrentRow.Cells[0].Value.ToString() && txtProducto.Texts == dgvProductos.CurrentRow.Cells[1].Value.ToString() && cbCategoria.SelectedItem.ToString() == dgvProductos.CurrentRow.Cells[2].Value.ToString() && txtStock.Texts == dgvProductos.CurrentRow.Cells[3].Value.ToString() && txtPrecioProveedor.Texts == dgvProductos.CurrentRow.Cells[4].Value.ToString() && cbProveedor.SelectedItem.ToString() == dgvProductos.CurrentRow.Cells[5].Value.ToString())
                    {
                        MessageBox.Show("No se ha modificado ningun dato. No es posible actualizar");
                    }
                    else
                    {
                        string Query = "UPDATE producto SET nombre='" + txtProducto.Texts + "', categoria='" + cbCategoria.Text + "', stock=" + txtStock.Texts + ", precio_venta=" + txtPrecioVenta.Texts + ", precio_proveedor=" + txtPrecioProveedor.Texts + ", id_proveedor=" + cbProveedor.SelectedIndex + " WHERE id_producto=" + txtId.Texts + ";";
                        NpgsqlConnection MyConn2 = new NpgsqlConnection(MyConnection2);
                        NpgsqlCommand MyCommand2 = new NpgsqlCommand(Query, MyConn2);
                        NpgsqlDataReader MyReader2;
                        MyConn2.Open();
                        MyReader2 = MyCommand2.ExecuteReader();
                        MessageBox.Show("Data Updated");
                        MyConn2.Close();

                        //Actualizar la tabla
                        string Query3 = "SELECT id_producto, producto.nombre, categoria, stock, precio_venta, precio_proveedor, proveedor.nombre FROM producto, proveedor WHERE proveedor.id_proveedor = producto.id_proveedor;";
                        NpgsqlConnection MyConn3 = new NpgsqlConnection(MyConnection2);
                        NpgsqlCommand MyCommand3 = new NpgsqlCommand(Query3, MyConn3);
                        MyConn3.Open();
                        NpgsqlDataAdapter MyAdapter = new NpgsqlDataAdapter();
                        MyAdapter.SelectCommand = MyCommand3;
                        DataTable dTable = new DataTable();
                        MyAdapter.Fill(dTable);
                        dgvProductos.DataSource = dTable;
                    }

                }
                else
                {
                    MessageBox.Show("No se ha seleccionado el registro para actualizar. O hay algún campo vacío");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Pasar los datos del DataGridView a los textbox
        private void btnModificar_Click(object sender, EventArgs e)
        {
            txtId.Texts = dgvProductos.CurrentRow.Cells[0].Value.ToString();
            txtProducto.Texts = dgvProductos.CurrentRow.Cells[1].Value.ToString();
            cbCategoria.Text = dgvProductos.CurrentRow.Cells[2].Value.ToString();
            txtStock.Texts = dgvProductos.CurrentRow.Cells[3].Value.ToString();
            txtPrecioVenta.Texts = dgvProductos.CurrentRow.Cells[4].Value.ToString();
            txtPrecioProveedor.Texts = dgvProductos.CurrentRow.Cells[5].Value.ToString();
            cbProveedor.Text = dgvProductos.CurrentRow.Cells[6].Value.ToString();

        }

        //Eliminar un producto
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Texts != "" && txtProducto.Texts != "" && cbCategoria.Text != "" && txtStock.Texts != "" && cbProveedor.Text != "" && txtPrecioProveedor.Texts != "")
                {
                    string Query = "DELETE FROM producto WHERE id_producto="+txtId.Texts+";";
                    NpgsqlConnection MyConn2 = new NpgsqlConnection(MyConnection2);
                    NpgsqlCommand MyCommand2 = new NpgsqlCommand(Query, MyConn2);
                    NpgsqlDataReader MyReader2;
                    MyConn2.Open();
                    DialogResult dialogResult = MessageBox.Show("¿Esta seguro de eliminar este registro?", "Eliminar registro", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        MyReader2 = MyCommand2.ExecuteReader();
                        MessageBox.Show("Data Deleted");
                    }
                    MyConn2.Close();

                    //Actualizar la tabla
                    string Query3 = "SELECT id_producto, producto.nombre, categoria, stock, precio_venta, precio_proveedor, proveedor.nombre FROM producto, proveedor WHERE proveedor.id_proveedor = producto.id_proveedor;";
                    NpgsqlConnection MyConn3 = new NpgsqlConnection(MyConnection2);
                    NpgsqlCommand MyCommand3 = new NpgsqlCommand(Query3, MyConn3);
                    MyConn3.Open();
                    NpgsqlDataAdapter MyAdapter = new NpgsqlDataAdapter();
                    MyAdapter.SelectCommand = MyCommand3;
                    DataTable dTable = new DataTable();
                    MyAdapter.Fill(dTable);
                    dgvProductos.DataSource = dTable;

                }
                else
                {
                    MessageBox.Show("No se ha seleccionado el registro para eliminar. O hay algún campo vacío");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Realizar la consulta con la base de datos
        private void productos_Load(object sender, EventArgs e)
        {
            //Pasar los datos de los productos
            string Query = "SELECT id_producto, producto.nombre, categoria, stock, precio_venta, precio_proveedor, proveedor.nombre FROM producto, proveedor WHERE proveedor.id_proveedor = producto.id_proveedor;";
            NpgsqlConnection MyConn2 = new NpgsqlConnection(MyConnection2);
            NpgsqlCommand MyCommand2 = new NpgsqlCommand(Query, MyConn2);
            MyConn2.Open();
            NpgsqlDataAdapter MyAdapter = new NpgsqlDataAdapter();
            MyAdapter.SelectCommand = MyCommand2;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
            dgvProductos.DataSource = dTable;

            //Pasar los datos de los Proveedores
            string consulta = "SELECT * FROM proveedor;";
            NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter(consulta, MyConn2);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgvProveedores.DataSource = dt;

            //Llenar el ComboBox con los id de los PROVEEDORES
            string consul = "SELECT * FROM proveedor;";
            NpgsqlCommand comando = new NpgsqlCommand(consul, MyConn2);
            NpgsqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                cbProveedor.Items.Add(lector.GetString(1));
            }
            MyConn2.Close();
        }

        //Dar de alta un producto
        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Texts != "" && txtProducto.Texts != "" && cbCategoria.Text != "" && txtStock.Texts != "" && cbProveedor.Text != "" && txtPrecioProveedor.Texts != "" && txtPrecioVenta.Texts != "")
                {
                    string Query = "SELECT * FROM producto WHERE id_producto=" + txtId.Texts + ";";
                    NpgsqlConnection MyConn2 = new NpgsqlConnection(MyConnection2);
                    NpgsqlCommand MyCommand2 = new NpgsqlCommand(Query, MyConn2);
                    NpgsqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    if (MyReader2.Read())
                    {
                        MessageBox.Show("Ya exite un registro con estos datos");
                        txtId.Texts = "";
                        txtProducto.Texts = "";
                        cbCategoria.Text = "";
                        txtStock.Texts = "";
                        txtPrecioVenta.Texts = "";
                        txtPrecioProveedor.Texts = "";
                        cbProveedor.Text = "";
                    }
                    else
                    {
                        string Query2 = "INSERT INTO producto (id_producto, nombre, categoria, stock, precio_venta, precio_proveedor, id_proveedor) VALUES (" + Convert.ToInt32(txtId.Texts) + ", '" + txtProducto.Texts + "', '" + cbCategoria.SelectedItem.ToString() + "', " + Convert.ToInt32(txtStock.Texts) + ", " + Convert.ToInt32(txtPrecioVenta.Texts) + ", " + Convert.ToInt32(txtPrecioProveedor.Texts) + ", " + cbProveedor.SelectedIndex + ");";
                        NpgsqlConnection MyConn = new NpgsqlConnection(MyConnection2);
                        NpgsqlCommand MyCommand = new NpgsqlCommand(Query2, MyConn);
                        NpgsqlDataReader MyReader;
                        MyConn.Open();
                        MyReader = MyCommand.ExecuteReader();
                        MessageBox.Show("Save Data");
                        while (MyReader.Read())
                        {
                        }
                        MyConn2.Close();
                        txtId.Texts = "";
                        txtProducto.Texts = "";
                        cbCategoria.Text = "";
                        txtStock.Texts = "";
                        txtPrecioProveedor.Texts = "";
                        cbProveedor.Text = "";

                        //Actualizar la tabla
                        string Query3 = "SELECT id_producto, producto.nombre, categoria, stock, precio_venta, precio_proveedor, proveedor.nombre FROM producto, proveedor WHERE proveedor.id_proveedor = producto.id_proveedor;";
                        NpgsqlConnection MyConn3 = new NpgsqlConnection(MyConnection2);
                        NpgsqlCommand MyCommand3 = new NpgsqlCommand(Query3, MyConn3);
                        MyConn3.Open();
                        NpgsqlDataAdapter MyAdapter = new NpgsqlDataAdapter();
                        MyAdapter.SelectCommand = MyCommand3;
                        DataTable dTable = new DataTable();
                        MyAdapter.Fill(dTable);
                        dgvProductos.DataSource = dTable;
                    }
                    MyConn2.Close();

                }
                else
                {
                    MessageBox.Show("Algún campo esta vacío, favor de corregir");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Dar color si el Stock es menor a cierta cantidad
        /*private void dgvProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvProductos.Columns[e.ColumnIndex].Name == "stock")
            {
                if (e.Value != null)
                {
                    if (e.Value.GetType() != typeof(System.DBNull))
                    {
                        //Stock menor a 20
                        if (Convert.ToInt32(e.Value) <= 20)
                        {
                            e.CellStyle.BackColor = Color.LightSalmon;
                            e.CellStyle.ForeColor = Color.Red;
                        }
                        //Stock menor a 10
                        if (Convert.ToInt32(e.Value) <= 10)
                        {
                            e.CellStyle.BackColor = Color.Salmon;
                            e.CellStyle.ForeColor = Color.Red;
                        }
                    }
                }
            }
        }*/

        private void txtBuscarProveedor__TextChanged(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM proveedor WHERE nombre LIKE '" + txtBuscarProveedor.Texts + "%';";
            NpgsqlConnection MyConn2 = new NpgsqlConnection(MyConnection2);
            NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter(consulta, MyConn2);
            MyConn2.Open();
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgvProveedores.DataSource = dt;
            MyConn2.Close();
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("En este recuadro sólo se aceptan números.\nIntenta de nuevo.");
                e.Handled = true;
                return;
            }
        }

        private void txtPrecioProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("En este recuadro sólo se aceptan números.\nIntenta de nuevo.");
                e.Handled = true;
                return;
            }
        }

        private void txtProducto_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtBuscarProveedor_KeyPress(object sender, KeyPressEventArgs e)
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
