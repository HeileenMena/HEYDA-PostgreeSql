using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HEYDA_Postgree
{
    public partial class Login : Form
    {
        string MyConnection2 = "server=localhost; port=5432; user id= postgres; password=123; database=heyda;";

        public Login()
        {
            InitializeComponent();
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtpass.Text = "";
            txtuser.Text = "";
            lblErrorMessage.Visible = false;
            this.Show();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            try
            {
                //SELECT * FROM "usuario" WHERE usuario='ADMIN' AND password ='123456';
                NpgsqlConnection MyConn2 = new NpgsqlConnection(MyConnection2);
                MyConn2.Open();
                string Query = "SELECT * FROM \"usuario\" WHERE usuario='" + txtuser.Text + "' AND password ='" + txtpass.Text + "';";
                NpgsqlCommand MyCommand2 = new NpgsqlCommand(Query, MyConn2);
                NpgsqlDataReader MyReader2 = MyCommand2.ExecuteReader();
                if (MyReader2.Read())
                {
                    string tipoUser = MyReader2.GetString(3);
                    MessageBox.Show("Bienvenido " + txtuser.Text);
                    MessageBox.Show("Usuario de tipo: " + tipoUser);
                    Menu mainMenu = new Menu();
                    mainMenu.Show();
                    mainMenu.FormClosed += Logout;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta");
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            Clases.CConexion objetoConexion = new Clases.CConexion();
            objetoConexion.establecerConexion();
        }

        private void txtuser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                //SELECT * FROM "usuario" WHERE usuario='ADMIN' AND password ='123456';
                NpgsqlConnection MyConn2 = new NpgsqlConnection(MyConnection2);
                MyConn2.Open();
                string Query = "SELECT * FROM \"usuario\" WHERE usuario='" + txtuser.Text + "' AND password ='" + txtpass.Text + "';";
                NpgsqlCommand MyCommand2 = new NpgsqlCommand(Query, MyConn2);
                NpgsqlDataReader MyReader2 = MyCommand2.ExecuteReader();
                if (MyReader2.Read())
                {
                    MessageBox.Show("Bienvenido " + txtuser.Text);
                    Menu mainMenu = new Menu();
                    mainMenu.Show();
                    mainMenu.FormClosed += Logout;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta");
                }
                MyConn2.Close();
            }
        }

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                //SELECT * FROM "usuario" WHERE usuario='ADMIN' AND password ='123456';
                NpgsqlConnection MyConn2 = new NpgsqlConnection(MyConnection2);
                MyConn2.Open();
                string Query = "SELECT * FROM \"usuario\" WHERE usuario='" + txtuser.Text + "' AND password ='" + txtpass.Text + "';";
                NpgsqlCommand MyCommand2 = new NpgsqlCommand(Query, MyConn2);
                NpgsqlDataReader MyReader2 = MyCommand2.ExecuteReader();
                if (MyReader2.Read())
                {
                    MessageBox.Show("Bienvenido " + txtuser.Text);
                    Menu mainMenu = new Menu();
                    mainMenu.Show();
                    mainMenu.FormClosed += Logout;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta");
                }
                MyConn2.Close();
            }
        }
    }
}