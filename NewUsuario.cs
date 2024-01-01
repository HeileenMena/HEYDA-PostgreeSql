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
    public partial class NewUsuario : Form
    {
        string MyConnection2 = "server=localhost; port=5432; user id= postgres; password=123; database=heyda;";

        public NewUsuario()
        {
            InitializeComponent();
        }

        //Dar de alta un empleado
        private void btnagregar_Click(object sender, EventArgs e)
        {
            //Agregar a la base de datos
            try
            {
                if (txtUsuario.Texts != "" && txtPassword.Texts != "" && cbIdEmpleado.Text != "")
                {
                    string Query = "SELECT * FROM usuario WHERE usuario='" + txtUsuario.Texts + "';";
                    NpgsqlConnection MyConn2 = new NpgsqlConnection(MyConnection2);
                    NpgsqlCommand MyCommand2 = new NpgsqlCommand(Query, MyConn2);
                    NpgsqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    if (MyReader2.Read())
                    {
                        MessageBox.Show("Ya exite un registro con estos datos");
                        txtUsuario.Texts = "";
                        txtPassword.Texts = "";
                        cbIdEmpleado.Text = "";
                    }
                    else
                    {
                        string Query2 = "INSERT INTO usuario (id_usuario, usuario, password, id_empleado) VALUES ("+txtId.Texts+", '" + txtUsuario.Texts + "', '" + txtPassword.Texts + "', '" + cbIdEmpleado.SelectedIndex.ToString() + "');";
                        NpgsqlConnection MyConn = new NpgsqlConnection(MyConnection2);
                        NpgsqlCommand MyCommand = new NpgsqlCommand(Query2, MyConn);
                        NpgsqlDataReader MyReader;
                        MyConn.Open();
                        MyReader = MyCommand.ExecuteReader();
                        MessageBox.Show("Save Data");
                        MyConn.Close();
                        txtId.Texts = "";
                        txtUsuario.Texts = "";
                        txtPassword.Texts = "";
                        cbIdEmpleado.Text = "";

                        //Actualizar registros
                        string Query3 = "select * from usuario";
                        NpgsqlConnection MyConn3 = new NpgsqlConnection(MyConnection2);
                        NpgsqlCommand MyCommand3 = new NpgsqlCommand(Query3, MyConn3);
                        MyConn3.Open();
                        NpgsqlDataAdapter MyAdapter = new NpgsqlDataAdapter();
                        MyAdapter.SelectCommand = MyCommand3;
                        DataTable dTable = new DataTable();
                        MyAdapter.Fill(dTable);
                        dgvUsuarios.DataSource = dTable;
                        MyConn3.Close();
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

        //Permitir modificar la información
        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Pasar los datos del DataGridView al los TextBox
            txtId.Texts = dgvUsuarios.CurrentRow.Cells[0].Value.ToString();
            txtUsuario.Texts = dgvUsuarios.CurrentRow.Cells[1].Value.ToString();
            txtPassword.Texts = dgvUsuarios.CurrentRow.Cells[2].Value.ToString();
            cbIdEmpleado.Text = dgvUsuarios.CurrentRow.Cells[3].Value.ToString();
            //Permitir modificar la información
            txtId.Enabled = true; 
            cbIdEmpleado.Enabled = true;
            txtPassword.Enabled = true;
            txtUsuario.Enabled = true;
        }

        //Actualizar empleado seleccionado
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuario.Texts != "" && txtPassword.Texts != "" && cbIdEmpleado.Text != "")
                {
                    string Query = "UPDATE usuario SET usuario='" + txtUsuario.Texts + "', password='" + txtPassword.Texts + "' WHERE id_usuario=" + dgvEmpleados.CurrentRow.Cells[0].Value.ToString();
                    NpgsqlConnection MyConn2 = new NpgsqlConnection(MyConnection2);
                    NpgsqlCommand MyCommand2 = new NpgsqlCommand(Query, MyConn2);
                    NpgsqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    MessageBox.Show("Data Updated");
                    txtId.Texts = "";
                    txtUsuario.Texts = "";
                    txtPassword.Texts = "";
                    cbIdEmpleado.Text = "";
                    MyConn2.Close();

                    //Actualizar registros
                    string Query2 = "select * from usuario";
                    NpgsqlConnection MyConn = new NpgsqlConnection(MyConnection2);
                    NpgsqlCommand MyCommand = new NpgsqlCommand(Query2, MyConn);
                    MyConn.Open();
                    NpgsqlDataAdapter MyAdapter = new NpgsqlDataAdapter();
                    MyAdapter.SelectCommand = MyCommand;
                    DataTable dTable = new DataTable();
                    MyAdapter.Fill(dTable);
                    dgvUsuarios.DataSource = dTable;
                    MyConn.Close();
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

        //Eliminar un usuario
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //DELETE FROM `empleado` WHERE `nombre`="Juan" AND `apellidop`="Perez" AND `apellidom`=""
            try
            {
                if (txtUsuario.Texts != "" || txtPassword.Texts != "" || cbIdEmpleado.Text != "")
                {
                    string Query = "DELETE FROM usuario WHERE id_empleado='" + cbIdEmpleado.Text + "';";
                    NpgsqlConnection MyConn2 = new NpgsqlConnection(MyConnection2);
                    NpgsqlCommand MyCommand2 = new NpgsqlCommand(Query, MyConn2);
                    NpgsqlDataReader MyReader2;
                    MyConn2.Open();
                    DialogResult dialogResult = MessageBox.Show("¿Esta seguro de eliminar este registro?", "Eliminar registro", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        MyReader2 = MyCommand2.ExecuteReader();
                        MessageBox.Show("Data Deleted");

                        //Actualizar registros
                        string Query2 = "select * from usuario";
                        NpgsqlConnection MyConn = new NpgsqlConnection(MyConnection2);
                        NpgsqlCommand MyCommand = new NpgsqlCommand(Query2, MyConn);
                        MyConn.Open();
                        NpgsqlDataAdapter MyAdapter = new NpgsqlDataAdapter();
                        MyAdapter.SelectCommand = MyCommand;
                        DataTable dTable = new DataTable();
                        MyAdapter.Fill(dTable);
                        dgvUsuarios.DataSource = dTable;
                        MyConn.Close();
                    }
                    MyConn2.Close();
                    txtId.Texts = "";
                    txtUsuario.Texts = "";
                    txtPassword.Texts = "";
                    cbIdEmpleado.Text = "";
                }
                else
                {
                    MessageBox.Show("Hay algún campo vacío, favor de corregir");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NewUsuario_Load(object sender, EventArgs e)
        {
            //Pasar los datos de los Usuarios
            string Query = "select * from usuario";
            NpgsqlConnection MyConn2 = new NpgsqlConnection(MyConnection2);
            NpgsqlCommand MyCommand2 = new NpgsqlCommand(Query, MyConn2);
            MyConn2.Open();
            NpgsqlDataAdapter MyAdapter = new NpgsqlDataAdapter();
            MyAdapter.SelectCommand = MyCommand2;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
            dgvUsuarios.DataSource = dTable;

            //Pasar los datos de los Empleados
            string Query2 = "select * from empleado";
            NpgsqlConnection MyConn = new NpgsqlConnection(MyConnection2);
            NpgsqlCommand MyCommand = new NpgsqlCommand(Query2, MyConn);
            MyConn.Open();
            NpgsqlDataAdapter MyAdapter2 = new NpgsqlDataAdapter();
            MyAdapter2.SelectCommand = MyCommand;
            DataTable dTable2 = new DataTable();
            MyAdapter2.Fill(dTable2);
            dgvEmpleados.DataSource = dTable2;
            MyConn.Close();

            //Llenar el ComboBox con los id de los empleados
            string consul = "select * from empleado";
            NpgsqlCommand comando = new NpgsqlCommand(consul, MyConn2);
            NpgsqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                cbIdEmpleado.Items.Add(lector.GetString(1));
            }
            MyConn2.Close();
        }

        private void txtBuscarUser__TextChanged(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM empleado WHERE nombre LIKE '" + txtBuscarUser.Texts + "%';";
            NpgsqlConnection MyConn2 = new NpgsqlConnection(MyConnection2);
            NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter(consulta, MyConn2);
            MyConn2.Open();
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgvEmpleados.DataSource = dt;
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            rjButton1.Visible = false;
            MessageBox.Show("Un clic habilita los cuadros de texto, 2 clic guarda el registro");
            txtId.Enabled = true;
            txtUsuario.Enabled = true;
            txtPassword.Enabled = true;
            cbIdEmpleado.Enabled = true;
        }

        private void txtBuscarUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("En este recuadro sólo se aceptan letras.\nIntenta de nuevo.");
                e.Handled = true;
                return;
            }
        }
    }
}
