using CustomControls.RJControls;
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
    public partial class empleados : Form
    {
        string MyConnection2 = "server=localhost; port=5432; user id= postgres; password=123; database=heyda;";
        public empleados()
        {
            InitializeComponent();
        }

        //Dar de alta un empleado
        private void btnagregar_Click(object sender, EventArgs e)
        {
            //INSERT INTO `empleado` (`id_empleado`, `nombre`, `apellidop`, `apellidom`, `telefono`, `email`, `puesto`) VALUES (NULL, 'Juan', 'Perez', '', '6561236547', 'juan@gmail.com', 'Vendedor');
            try
            {
                if (txtNombre.Texts != "" && txtApellidoP.Texts != "" && txtApellidoM.Texts != "" && txtTelefono.Texts != "" && txtEmail.Texts != "" && txtPuesto.Texts != "")
                {
                    string Query = "SELECT * FROM empleado WHERE nombre='" + txtNombre.Texts + "' AND apellidop= '" + txtApellidoP.Texts + "' AND apellidom = '" + txtApellidoM.Texts + "';";
                    NpgsqlConnection MyConn2 = new NpgsqlConnection(MyConnection2);
                    NpgsqlCommand MyCommand2 = new NpgsqlCommand(Query, MyConn2);
                    NpgsqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    if (MyReader2.Read())
                    {
                        MessageBox.Show("Ya exite un registro con estos datos");
                        txtNombre.Texts = "";
                        txtApellidoP.Texts = "";
                        txtApellidoM.Texts = "";
                        txtTelefono.Texts = "";
                        txtEmail.Texts = "";
                        txtPuesto.Texts = "";
                    }
                    else
                    {
                        string Query2 = "INSERT INTO empleado (id_empleado,nombre, apellidop, apellidom, telefono, email, puesto) VALUES ("+txtId.Texts+",'"+txtNombre.Texts+"', '"+txtApellidoP.Texts+"', '"+txtApellidoM.Texts+"', '"+txtTelefono.Texts+"', '"+txtEmail.Texts+"', '"+txtPuesto.Texts+"');";
                        NpgsqlConnection MyConn = new NpgsqlConnection(MyConnection2);
                        NpgsqlCommand MyCommand = new NpgsqlCommand(Query2, MyConn);
                        NpgsqlDataReader MyReader;
                        MyConn.Open();
                        MyReader = MyCommand.ExecuteReader();
                        MessageBox.Show("Save Data");
                        MyConn2.Close();

                        //Actualizar la tabla
                        string Query3 = "select * from empleado";
                        NpgsqlConnection MyConn3 = new NpgsqlConnection(MyConnection2);
                        NpgsqlCommand MyCommand3 = new NpgsqlCommand(Query3, MyConn3);
                        MyConn3.Open();
                        NpgsqlDataAdapter MyAdapter = new NpgsqlDataAdapter();
                        MyAdapter.SelectCommand = MyCommand3;
                        DataTable dTable = new DataTable();
                        MyAdapter.Fill(dTable);
                        dgvEmpleados.DataSource = dTable;
                        MyConn3.Close();

                        //Reestablecer los campos
                        txtId.Texts = ""; 
                        txtNombre.Texts = "";
                        txtApellidoP.Texts = "";
                        txtApellidoM.Texts = "";
                        txtTelefono.Texts = "";
                        txtEmail.Texts = "";
                        txtPuesto.Texts = "";
                        txtId.Enabled = false;
                        txtNombre.Enabled = false;
                        txtApellidoP.Enabled = false;
                        txtApellidoM.Enabled = false;
                        txtTelefono.Enabled = false;
                        txtEmail.Enabled = false;
                        txtPuesto.Enabled = false;
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

        //Pasar los datos del DataGridView a los textbox
        private void btnModificar_Click(object sender, EventArgs e)
        {
            rjButton1.Visible = false;
            //Pasar los datos del DataGridView al los TextBox
            txtId.Texts = dgvEmpleados.CurrentRow.Cells[0].Value.ToString(); 
            txtNombre.Texts = dgvEmpleados.CurrentRow.Cells[1].Value.ToString();
            txtApellidoP.Texts = dgvEmpleados.CurrentRow.Cells[2].Value.ToString();
            txtApellidoM.Texts = dgvEmpleados.CurrentRow.Cells[3].Value.ToString();
            txtTelefono.Texts = dgvEmpleados.CurrentRow.Cells[4].Value.ToString();
            txtEmail.Texts = dgvEmpleados.CurrentRow.Cells[5].Value.ToString();
            txtPuesto.Texts = dgvEmpleados.CurrentRow.Cells[6].Value.ToString();
            //Permitir modificar la información
            txtId.Enabled = true;
            txtNombre.Enabled = true;
            txtApellidoP.Enabled = true;
            txtApellidoM.Enabled = true;
            txtTelefono.Enabled = true;
            txtEmail.Enabled = true;
            txtPuesto.Enabled = true;
        }

        //Eliminar un empleado
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //DELETE FROM `empleado` WHERE `nombre`="Juan" AND `apellidop`="Perez" AND `apellidom`=""
            try
            {
                if (txtId.Texts != "" || txtNombre.Texts != "" || txtApellidoP.Texts != "" || txtApellidoM.Texts != "" || txtTelefono.Texts != "" || txtEmail.Texts != "" || txtPuesto.Texts != "")
                {
                    string Query = "DELETE FROM empleado WHERE nombre= '" + txtNombre.Texts + "' AND apellidop='" + txtApellidoP.Texts + "' AND apellidom='" + txtApellidoM.Texts + "';";
                    NpgsqlConnection MyConn2 = new NpgsqlConnection(MyConnection2);
                    NpgsqlCommand MyCommand2 = new NpgsqlCommand(Query, MyConn2);
                    NpgsqlDataReader MyReader2;
                    MyConn2.Open();
                    DialogResult dialogResult = MessageBox.Show("¿Esta seguro de eliminar este registro?", "Eliminar registro", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        MyReader2 = MyCommand2.ExecuteReader();
                        MessageBox.Show("Data Deleted");

                        //Actualizar tabla
                        string Query2 = "select * from empleado";
                        NpgsqlConnection MyConn = new NpgsqlConnection(MyConnection2);
                        NpgsqlCommand MyCommand = new NpgsqlCommand(Query2, MyConn);
                        MyConn.Open();
                        NpgsqlDataAdapter MyAdapter = new NpgsqlDataAdapter();
                        MyAdapter.SelectCommand = MyCommand;
                        DataTable dTable = new DataTable();
                        MyAdapter.Fill(dTable);
                        dgvEmpleados.DataSource = dTable;
                        MyConn.Close();
                    }
                    MyConn2.Close();

                    //Restablecer campos
                    txtId.Texts = "";
                    txtNombre.Texts = "";
                    txtApellidoP.Texts = "";
                    txtApellidoM.Texts = "";
                    txtTelefono.Texts = "";
                    txtEmail.Texts = "";
                    txtPuesto.Texts = "";
                    txtId.Enabled = false;
                    txtNombre.Enabled = false;
                    txtApellidoP.Enabled = false;
                    txtApellidoM.Enabled = false;
                    txtTelefono.Enabled = false;
                    txtEmail.Enabled = false;
                    txtPuesto.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado algún empleado. O hay un campo vació.");
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("No se puede eliminar a este empleado, debido a que cuenta con usuario\nPrimero elimina el usuario");
            }
        }

        //Consultar la base de datos y lo pone en el datagridview
        private void empleados_Load(object sender, EventArgs e)
        {
            string Query = "select * from empleado";
            NpgsqlConnection MyConn2 = new NpgsqlConnection(MyConnection2);
            NpgsqlCommand MyCommand2 = new NpgsqlCommand(Query, MyConn2);
            MyConn2.Open();
            NpgsqlDataAdapter MyAdapter = new NpgsqlDataAdapter();
            MyAdapter.SelectCommand = MyCommand2;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
            dgvEmpleados.DataSource = dTable;
            MyConn2.Close();
        }

        //Actualizar empleado seleccionado
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //UPDATE `empleado` SET `id_empleado`='[value-1]',`nombre`='[value-2]',`apellidop`='[value-3]',`apellidom`='[value-4]',`telefono`='[value-5]',`email`='[value-6]',`puesto`='[value-7]' WHERE 1
            try
            {
                if (txtNombre.Texts != "" || txtApellidoP.Texts != "" || txtApellidoM.Texts != "" || txtTelefono.Texts != "" || txtEmail.Texts != "" || txtPuesto.Texts != "")
                {
                    if (txtNombre.Texts != dgvEmpleados.CurrentRow.Cells[1].Value.ToString() || txtApellidoP.Texts != dgvEmpleados.CurrentRow.Cells[2].Value.ToString() || txtApellidoM.Texts != dgvEmpleados.CurrentRow.Cells[3].Value.ToString() || txtTelefono.Texts != dgvEmpleados.CurrentRow.Cells[4].Value.ToString() || txtEmail.Texts != dgvEmpleados.CurrentRow.Cells[5].Value.ToString() || txtPuesto.Texts != dgvEmpleados.CurrentRow.Cells[6].Value.ToString())
                    {
                        string Query = "UPDATE empleado SET nombre='" + txtNombre.Texts + "', apellidop='" + txtApellidoP.Texts + "', apellidom='" + txtApellidoM.Texts + "', telefono='" + txtTelefono.Texts + "', email ='" + txtEmail.Texts + "', puesto='" + txtPuesto.Texts + "' WHERE id_empleado=" + dgvEmpleados.CurrentRow.Cells[0].Value.ToString();
                        NpgsqlConnection MyConn2 = new NpgsqlConnection(MyConnection2);
                        NpgsqlCommand MyCommand2 = new NpgsqlCommand(Query, MyConn2);
                        NpgsqlDataReader MyReader2;
                        MyConn2.Open();
                        MyReader2 = MyCommand2.ExecuteReader();
                        MessageBox.Show("Data Updated");
                        MyConn2.Close();

                        //Restablecer datos
                        txtId.Texts = "";
                        txtNombre.Texts = "";
                        txtApellidoP.Texts = "";
                        txtApellidoM.Texts = "";
                        txtTelefono.Texts = "";
                        txtEmail.Texts = "";
                        txtPuesto.Texts = "";
                        txtId.Enabled = false;
                        txtNombre.Enabled = false;
                        txtApellidoP.Enabled = false;
                        txtApellidoM.Enabled = false;
                        txtTelefono.Enabled = false;
                        txtEmail.Enabled = false;
                        txtPuesto.Enabled = false;

                        //Actualizar tabla
                        string Query2 = "select * from empleado";
                        NpgsqlConnection MyConn = new NpgsqlConnection(MyConnection2);
                        NpgsqlCommand MyCommand = new NpgsqlCommand(Query2, MyConn);
                        MyConn.Open();
                        NpgsqlDataAdapter MyAdapter = new NpgsqlDataAdapter();
                        MyAdapter.SelectCommand = MyCommand;
                        DataTable dTable = new DataTable();
                        MyAdapter.Fill(dTable);
                        dgvEmpleados.DataSource = dTable;
                        MyConn.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se a actualizado ningun campo");
                    }
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

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            rjButton1.Visible = false;
            MessageBox.Show("Un clic habilita los cuadros de texto, 2 clic guarda el registro");
            txtId.Enabled = true;
            txtNombre.Enabled = true;
            txtApellidoP.Enabled = true;
            txtApellidoM.Enabled = true;
            txtTelefono.Enabled = true;
            txtEmail.Enabled = true;
            txtPuesto.Enabled = true;
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

        private void txtApellidoP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("En este recuadro sólo se aceptan letras.\nIntenta de nuevo.");
                e.Handled = true;
                return;
            }
        }

        private void txtApellidoM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("En este recuadro sólo se aceptan letras.\nIntenta de nuevo.");
                e.Handled = true;
                return;
            }
        }

        private void txtPuesto_KeyPress(object sender, KeyPressEventArgs e)
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
