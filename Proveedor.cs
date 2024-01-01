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
    public partial class Proveedor : Form
    {
        string MyConnection2 = "server=localhost; port=5432; user id= postgres; password=123; database=heyda;";

        public Proveedor()
        {
            InitializeComponent();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Texts != "" && txtTelefono.Texts != "")
                {
                    if (txtId.Texts != dgvProveedores.CurrentRow.Cells[0].Value.ToString()||txtNombre.Texts != dgvProveedores.CurrentRow.Cells[1].Value.ToString() || txtTelefono.Texts != dgvProveedores.CurrentRow.Cells[2].Value.ToString())
                    {
                        string Query2 = "INSERT INTO proveedor (id_proveedor, nombre, telefono) VALUES ("+txtId.Texts+", '" + txtNombre.Texts + "', '" + txtTelefono.Texts + "');";
                        NpgsqlConnection MyConn = new NpgsqlConnection(MyConnection2);
                        NpgsqlCommand MyCommand = new NpgsqlCommand(Query2, MyConn);
                        NpgsqlDataReader MyReader;
                        MyConn.Open();
                        MyReader = MyCommand.ExecuteReader();
                        MessageBox.Show("Save Data");
                        MyConn.Close();
                        txtId.Texts = "";
                        txtNombre.Texts = "";
                        txtTelefono.Texts = "";

                        //Actualizar registros
                        string Query = "select * from proveedor";
                        NpgsqlConnection MyConn2 = new NpgsqlConnection(MyConnection2);
                        NpgsqlCommand MyCommand2 = new NpgsqlCommand(Query, MyConn2);
                        MyConn2.Open();
                        NpgsqlDataAdapter MyAdapter = new NpgsqlDataAdapter();
                        MyAdapter.SelectCommand = MyCommand2;
                        DataTable dTable = new DataTable();
                        MyAdapter.Fill(dTable);
                        dgvProveedores.DataSource = dTable;
                        MyConn2.Close();
                    }
                    else
                    {
                        MessageBox.Show("Se esta tratando de ingresar un dato previamente registrado");
                    }
                }

                else
                {
                    MessageBox.Show("Falta colocar algún dato");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Texts != "" || txtNombre.Texts != "" || txtTelefono.Texts != "")
                {
                    if (txtId.Texts != dgvProveedores.CurrentRow.Cells[0].Value.ToString() || txtNombre.Texts != dgvProveedores.CurrentRow.Cells[1].Value.ToString() || txtTelefono.Texts != dgvProveedores.CurrentRow.Cells[2].Value.ToString())
                    {
                        string Query = "UPDATE proveedor SET id_proveedor='"+txtId.Texts+"', nombre='" + txtNombre.Texts + "', telefono='" + txtTelefono.Texts + "' WHERE id_proveedor='" + dgvProveedores.CurrentRow.Cells[0].Value.ToString() + "';";
                        NpgsqlConnection MyConn2 = new NpgsqlConnection(MyConnection2);
                        NpgsqlCommand MyCommand2 = new NpgsqlCommand(Query, MyConn2);
                        NpgsqlDataReader MyReader2;
                        MyConn2.Open();
                        MyReader2 = MyCommand2.ExecuteReader();
                        MessageBox.Show("Data Updated");
                        txtId.Texts = "";
                        txtNombre.Texts = "";
                        txtTelefono.Texts = "";
                        MyConn2.Close();

                        //Actualizar registros
                        string Query2 = "select * from proveedor";
                        NpgsqlConnection MyConn = new NpgsqlConnection(MyConnection2);
                        NpgsqlCommand MyCommand = new NpgsqlCommand(Query2, MyConn);
                        MyConn.Open();
                        NpgsqlDataAdapter MyAdapter = new NpgsqlDataAdapter();
                        MyAdapter.SelectCommand = MyCommand;
                        DataTable dTable = new DataTable();
                        MyAdapter.Fill(dTable);
                        dgvProveedores.DataSource = dTable;
                        MyConn.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se ha modificado ningún campo.\nNo es posible actualizar");
                    }
                }
                else
                {
                    MessageBox.Show("Falta algún campo.\nNo es posible actualizar");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Pasar los datos del DataGridView al los TextBox
            txtId.Texts = dgvProveedores.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Texts = dgvProveedores.CurrentRow.Cells[1].Value.ToString();
            txtTelefono.Texts = dgvProveedores.CurrentRow.Cells[2].Value.ToString();
            //Permitir modificar la información
            txtId.Enabled = true;
            txtNombre.Enabled = true;
            txtTelefono.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Texts != "")
                {
                    string Query = "DELETE FROM proveedor WHERE nombre='" + txtNombre.Texts;
                    NpgsqlConnection MyConn2 = new NpgsqlConnection(MyConnection2);
                    NpgsqlCommand MyCommand2 = new NpgsqlCommand(Query, MyConn2);
                    NpgsqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    MessageBox.Show("Data Deleted");
                    MyConn2.Close();
                    txtId.Texts = "";
                    txtNombre.Texts = "";
                    txtTelefono.Texts = "";

                    //Actualizar registros
                    string Query2 = "select * from proveedor";
                    NpgsqlConnection MyConn = new NpgsqlConnection(MyConnection2);
                    NpgsqlCommand MyCommand = new NpgsqlCommand(Query2, MyConn);
                    MyConn.Open();
                    NpgsqlDataAdapter MyAdapter = new NpgsqlDataAdapter();
                    MyAdapter.SelectCommand = MyCommand;
                    DataTable dTable = new DataTable();
                    MyAdapter.Fill(dTable);
                    dgvProveedores.DataSource = dTable;
                    MyConn.Close();
                }
                else
                {
                    MessageBox.Show("Los campos están vacíos. Primero pulsa modificar");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Este prooveedor esta asociado a algún producto. Favor de eliminar dicho producto.");
            }
        }

        private void Proveedor_Load(object sender, EventArgs e)
        {
            string Query = "select * from proveedor";
            NpgsqlConnection MyConn2 = new NpgsqlConnection(MyConnection2);
            NpgsqlCommand MyCommand2 = new NpgsqlCommand(Query, MyConn2);
            MyConn2.Open();
            NpgsqlDataAdapter MyAdapter = new NpgsqlDataAdapter();
            MyAdapter.SelectCommand = MyCommand2;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
            dgvProveedores.DataSource = dTable;
            MyConn2.Close();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            rjButton1.Visible = false;
            MessageBox.Show("Un clic habilita los cuadros de texto, 2 clic guarda el registro");
            txtId.Enabled = true;
            txtNombre.Enabled = true;
            txtTelefono.Enabled = true;
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("En este recuadro sólo se aceptan números.\nIntenta de nuevo.");
                e.Handled = true;
                return;
            }
            else
            {
                if (txtTelefono.Texts.Length >= 10)
                {
                    MessageBox.Show("En este recuadro sólo se aceptan 10 números.\nIntenta de nuevo.");
                    e.Handled = true;
                    txtTelefono.Texts = "";
                    return;
                }
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
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
