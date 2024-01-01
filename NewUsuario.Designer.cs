namespace HEYDA
{
    partial class NewUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            lblPassword = new Label();
            btnagregar = new CustomControls.RJControls.RJButton();
            txtUsuario = new CustomControls.RJControls.RJTextBox();
            label5 = new Label();
            btnModificar = new CustomControls.RJControls.RJButton();
            btnEliminar = new CustomControls.RJControls.RJButton();
            txtPassword = new CustomControls.RJControls.RJTextBox();
            dgvEmpleados = new DataGridView();
            btnGuardar = new CustomControls.RJControls.RJButton();
            label3 = new Label();
            label6 = new Label();
            dgvUsuarios = new DataGridView();
            cbIdEmpleado = new ComboBox();
            txtBuscarUser = new CustomControls.RJControls.RJTextBox();
            label10 = new Label();
            rjButton1 = new CustomControls.RJControls.RJButton();
            txtId = new CustomControls.RJControls.RJTextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 20F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(49, 66, 82);
            label1.Location = new Point(212, 53);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(164, 40);
            label1.TabIndex = 0;
            label1.Text = "USUARIOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(49, 66, 82);
            label2.Location = new Point(52, 196);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 22);
            label2.TabIndex = 2;
            label2.Text = "USUARIO:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Arial Narrow", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            lblPassword.ForeColor = Color.FromArgb(49, 66, 82);
            lblPassword.Location = new Point(52, 244);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(118, 22);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "CONTRASEÑA:";
            // 
            // btnagregar
            // 
            btnagregar.BackColor = Color.FromArgb(255, 111, 94);
            btnagregar.BackgroundColor = Color.FromArgb(255, 111, 94);
            btnagregar.BorderColor = Color.PaleVioletRed;
            btnagregar.BorderRadius = 20;
            btnagregar.BorderSize = 0;
            btnagregar.FlatAppearance.BorderSize = 0;
            btnagregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 61, 99);
            btnagregar.FlatStyle = FlatStyle.Flat;
            btnagregar.Font = new Font("Arial Narrow", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            btnagregar.ForeColor = Color.White;
            btnagregar.Location = new Point(61, 386);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(188, 50);
            btnagregar.TabIndex = 8;
            btnagregar.Text = "AGREGAR";
            btnagregar.TextColor = Color.White;
            btnagregar.UseVisualStyleBackColor = false;
            btnagregar.Click += btnagregar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.Window;
            txtUsuario.BorderColor = Color.FromArgb(255, 111, 94);
            txtUsuario.BorderFocusColor = Color.FromArgb(44, 61, 99);
            txtUsuario.BorderRadius = 0;
            txtUsuario.BorderSize = 2;
            txtUsuario.Enabled = false;
            txtUsuario.Font = new Font("Arial Narrow", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            txtUsuario.ForeColor = Color.FromArgb(64, 64, 64);
            txtUsuario.Location = new Point(212, 196);
            txtUsuario.Margin = new Padding(4);
            txtUsuario.Multiline = false;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Padding = new Padding(10, 7, 10, 7);
            txtUsuario.PasswordChar = false;
            txtUsuario.PlaceholderColor = Color.DarkGray;
            txtUsuario.PlaceholderText = "";
            txtUsuario.Size = new Size(312, 37);
            txtUsuario.TabIndex = 9;
            txtUsuario.Texts = "";
            txtUsuario.UnderlinedStyle = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(49, 66, 82);
            label5.Location = new Point(52, 301);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(115, 22);
            label5.TabIndex = 13;
            label5.Text = "ID EMPLEADO:";
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(255, 111, 94);
            btnModificar.BackgroundColor = Color.FromArgb(255, 111, 94);
            btnModificar.BorderColor = Color.PaleVioletRed;
            btnModificar.BorderRadius = 20;
            btnModificar.BorderSize = 0;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 61, 99);
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(1042, 371);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(188, 50);
            btnModificar.TabIndex = 20;
            btnModificar.Text = "MODIFICAR";
            btnModificar.TextColor = Color.White;
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(255, 111, 94);
            btnEliminar.BackgroundColor = Color.FromArgb(255, 111, 94);
            btnEliminar.BorderColor = Color.PaleVioletRed;
            btnEliminar.BorderRadius = 20;
            btnEliminar.BorderSize = 0;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 61, 99);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(212, 462);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(188, 50);
            btnEliminar.TabIndex = 22;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.TextColor = Color.White;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Window;
            txtPassword.BorderColor = Color.FromArgb(255, 111, 94);
            txtPassword.BorderFocusColor = Color.FromArgb(44, 61, 99);
            txtPassword.BorderRadius = 0;
            txtPassword.BorderSize = 2;
            txtPassword.Enabled = false;
            txtPassword.Font = new Font("Arial Narrow", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            txtPassword.ForeColor = Color.FromArgb(64, 64, 64);
            txtPassword.Location = new Point(212, 243);
            txtPassword.Margin = new Padding(4);
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.Padding = new Padding(10, 7, 10, 7);
            txtPassword.PasswordChar = false;
            txtPassword.PlaceholderColor = Color.DarkGray;
            txtPassword.PlaceholderText = "";
            txtPassword.Size = new Size(312, 37);
            txtPassword.TabIndex = 24;
            txtPassword.Texts = "";
            txtPassword.UnderlinedStyle = false;
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvEmpleados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvEmpleados.BackgroundColor = Color.FromArgb(247, 248, 243);
            dgvEmpleados.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dgvEmpleados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 111, 94);
            dataGridViewCellStyle1.Font = new Font("Arial Narrow", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 111, 94);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEmpleados.ColumnHeadersHeight = 30;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvEmpleados.EnableHeadersVisualStyles = false;
            dgvEmpleados.GridColor = Color.FromArgb(173, 220, 202);
            dgvEmpleados.Location = new Point(615, 632);
            dgvEmpleados.Name = "dgvEmpleados";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Arial Narrow", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(173, 220, 202);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvEmpleados.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvEmpleados.RowHeadersVisible = false;
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.RowTemplate.Height = 29;
            dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpleados.Size = new Size(975, 213);
            dgvEmpleados.TabIndex = 26;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(255, 111, 94);
            btnGuardar.BackgroundColor = Color.FromArgb(255, 111, 94);
            btnGuardar.BorderColor = Color.PaleVioletRed;
            btnGuardar.BorderRadius = 20;
            btnGuardar.BorderSize = 0;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 61, 99);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Arial Narrow", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(345, 386);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(188, 50);
            btnGuardar.TabIndex = 27;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.TextColor = Color.White;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 20F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(49, 66, 82);
            label3.Location = new Point(942, 579);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(388, 40);
            label3.TabIndex = 31;
            label3.Text = "EMPLEADOS HABILITADOS";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 20F, FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(49, 66, 82);
            label6.Location = new Point(977, 92);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(311, 40);
            label6.TabIndex = 33;
            label6.Text = "USUARIOS CREADOS";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvUsuarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvUsuarios.BackgroundColor = Color.FromArgb(247, 248, 243);
            dgvUsuarios.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dgvUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 111, 94);
            dataGridViewCellStyle3.Font = new Font("Arial Narrow", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 111, 94);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvUsuarios.ColumnHeadersHeight = 30;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvUsuarios.EnableHeadersVisualStyles = false;
            dgvUsuarios.GridColor = Color.FromArgb(173, 220, 202);
            dgvUsuarios.Location = new Point(615, 138);
            dgvUsuarios.Name = "dgvUsuarios";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Arial Narrow", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(173, 220, 202);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.RowTemplate.Height = 29;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(975, 213);
            dgvUsuarios.TabIndex = 32;
            // 
            // cbIdEmpleado
            // 
            cbIdEmpleado.Enabled = false;
            cbIdEmpleado.Font = new Font("Arial Narrow", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            cbIdEmpleado.FormattingEnabled = true;
            cbIdEmpleado.Location = new Point(212, 301);
            cbIdEmpleado.Name = "cbIdEmpleado";
            cbIdEmpleado.Size = new Size(312, 30);
            cbIdEmpleado.TabIndex = 35;
            // 
            // txtBuscarUser
            // 
            txtBuscarUser.BackColor = SystemColors.Window;
            txtBuscarUser.BorderColor = Color.FromArgb(255, 111, 94);
            txtBuscarUser.BorderFocusColor = Color.FromArgb(44, 61, 99);
            txtBuscarUser.BorderRadius = 0;
            txtBuscarUser.BorderSize = 2;
            txtBuscarUser.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscarUser.ForeColor = Color.FromArgb(64, 64, 64);
            txtBuscarUser.Location = new Point(774, 521);
            txtBuscarUser.Margin = new Padding(4);
            txtBuscarUser.Multiline = false;
            txtBuscarUser.Name = "txtBuscarUser";
            txtBuscarUser.Padding = new Padding(10, 7, 10, 7);
            txtBuscarUser.PasswordChar = false;
            txtBuscarUser.PlaceholderColor = Color.DarkGray;
            txtBuscarUser.PlaceholderText = "";
            txtBuscarUser.Size = new Size(585, 35);
            txtBuscarUser.TabIndex = 45;
            txtBuscarUser.Texts = "";
            txtBuscarUser.UnderlinedStyle = false;
            txtBuscarUser._TextChanged += txtBuscarUser__TextChanged;
            txtBuscarUser.KeyPress += txtBuscarUser_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.FromArgb(49, 66, 82);
            label10.Location = new Point(600, 497);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(244, 20);
            label10.TabIndex = 44;
            label10.Text = "BUSCAR EMPLEADO POR NOMBRE:";
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.FromArgb(255, 111, 94);
            rjButton1.BackgroundColor = Color.FromArgb(255, 111, 94);
            rjButton1.BorderColor = Color.PaleVioletRed;
            rjButton1.BorderRadius = 20;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 61, 99);
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Arial Narrow", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            rjButton1.ForeColor = Color.White;
            rjButton1.Location = new Point(61, 386);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(188, 50);
            rjButton1.TabIndex = 46;
            rjButton1.Text = "AGREGAR";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += rjButton1_Click;
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.Window;
            txtId.BorderColor = Color.FromArgb(255, 111, 94);
            txtId.BorderFocusColor = Color.FromArgb(44, 61, 99);
            txtId.BorderRadius = 0;
            txtId.BorderSize = 2;
            txtId.Enabled = false;
            txtId.Font = new Font("Arial Narrow", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            txtId.ForeColor = Color.FromArgb(64, 64, 64);
            txtId.Location = new Point(212, 151);
            txtId.Margin = new Padding(4);
            txtId.Multiline = false;
            txtId.Name = "txtId";
            txtId.Padding = new Padding(10, 7, 10, 7);
            txtId.PasswordChar = false;
            txtId.PlaceholderColor = Color.DarkGray;
            txtId.PlaceholderText = "";
            txtId.Size = new Size(312, 37);
            txtId.TabIndex = 48;
            txtId.Texts = "";
            txtId.UnderlinedStyle = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(49, 66, 82);
            label4.Location = new Point(52, 151);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(29, 22);
            label4.TabIndex = 47;
            label4.Text = "ID:";
            // 
            // NewUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 248, 243);
            ClientSize = new Size(1649, 942);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(rjButton1);
            Controls.Add(txtBuscarUser);
            Controls.Add(label10);
            Controls.Add(cbIdEmpleado);
            Controls.Add(label6);
            Controls.Add(dgvUsuarios);
            Controls.Add(label3);
            Controls.Add(btnGuardar);
            Controls.Add(dgvEmpleados);
            Controls.Add(txtPassword);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(label5);
            Controls.Add(txtUsuario);
            Controls.Add(btnagregar);
            Controls.Add(lblPassword);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "NewUsuario";
            Text = "productos";
            Load += NewUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPassword;
        private CustomControls.RJControls.RJButton btnagregar;
        private CustomControls.RJControls.RJTextBox txtUsuario;
        private Label label5;
        private CustomControls.RJControls.RJButton btnModificar;
        private CustomControls.RJControls.RJButton btnEliminar;
        private CustomControls.RJControls.RJTextBox txtPassword;
        private DataGridView dgvEmpleados;
        private CustomControls.RJControls.RJButton btnGuardar;
        private Label label3;
        private Label label6;
        private DataGridView dgvUsuarios;
        private ComboBox cbIdEmpleado;
        private CustomControls.RJControls.RJTextBox txtBuscarUser;
        private Label label10;
        private CustomControls.RJControls.RJButton rjButton1;
        private CustomControls.RJControls.RJTextBox txtId;
        private Label label4;
    }
}
