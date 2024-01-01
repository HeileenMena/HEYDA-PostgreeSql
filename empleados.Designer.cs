namespace HEYDA
{
    partial class empleados
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
            label1 = new Label();
            label2 = new Label();
            lblApellido = new Label();
            label4 = new Label();
            btnagregar = new CustomControls.RJControls.RJButton();
            txtNombre = new CustomControls.RJControls.RJTextBox();
            txtTelefono = new CustomControls.RJControls.RJTextBox();
            txtApellidoM = new CustomControls.RJControls.RJTextBox();
            label5 = new Label();
            label6 = new Label();
            txtEmail = new CustomControls.RJControls.RJTextBox();
            label7 = new Label();
            btnModificar = new CustomControls.RJControls.RJButton();
            btnEliminar = new CustomControls.RJControls.RJButton();
            txtApellidoP = new CustomControls.RJControls.RJTextBox();
            txtPuesto = new CustomControls.RJControls.RJTextBox();
            dgvEmpleados = new DataGridView();
            btnGuardar = new CustomControls.RJControls.RJButton();
            rjButton1 = new CustomControls.RJControls.RJButton();
            txtId = new CustomControls.RJControls.RJTextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(49, 66, 82);
            label1.Location = new Point(212, 53);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(182, 31);
            label1.TabIndex = 0;
            label1.Text = "EMPLEADOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(49, 66, 82);
            label2.Location = new Point(51, 204);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 2;
            label2.Text = "NOMBRE:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.ForeColor = Color.FromArgb(49, 66, 82);
            lblApellido.Location = new Point(51, 252);
            lblApellido.Margin = new Padding(4, 0, 4, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(145, 20);
            lblApellido.TabIndex = 4;
            lblApellido.Text = "APELLIDO PATERNO:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(49, 66, 82);
            label4.Location = new Point(51, 302);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(151, 20);
            label4.TabIndex = 6;
            label4.Text = "APELLIDO MATERNO:";
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
            btnagregar.ForeColor = Color.White;
            btnagregar.Location = new Point(51, 570);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(188, 50);
            btnagregar.TabIndex = 8;
            btnagregar.Text = "AGREGAR";
            btnagregar.TextColor = Color.White;
            btnagregar.UseVisualStyleBackColor = false;
            btnagregar.Click += btnagregar_Click;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.Window;
            txtNombre.BorderColor = Color.FromArgb(255, 111, 94);
            txtNombre.BorderFocusColor = Color.FromArgb(44, 61, 99);
            txtNombre.BorderRadius = 0;
            txtNombre.BorderSize = 2;
            txtNombre.Enabled = false;
            txtNombre.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.ForeColor = Color.FromArgb(64, 64, 64);
            txtNombre.Location = new Point(211, 204);
            txtNombre.Margin = new Padding(4);
            txtNombre.Multiline = false;
            txtNombre.Name = "txtNombre";
            txtNombre.Padding = new Padding(10, 7, 10, 7);
            txtNombre.PasswordChar = false;
            txtNombre.PlaceholderColor = Color.DarkGray;
            txtNombre.PlaceholderText = "";
            txtNombre.Size = new Size(312, 35);
            txtNombre.TabIndex = 9;
            txtNombre.Texts = "";
            txtNombre.UnderlinedStyle = false;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = SystemColors.Window;
            txtTelefono.BorderColor = Color.FromArgb(255, 111, 94);
            txtTelefono.BorderFocusColor = Color.FromArgb(44, 61, 99);
            txtTelefono.BorderRadius = 0;
            txtTelefono.BorderSize = 2;
            txtTelefono.Enabled = false;
            txtTelefono.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefono.ForeColor = Color.FromArgb(64, 64, 64);
            txtTelefono.Location = new Point(211, 354);
            txtTelefono.Margin = new Padding(4);
            txtTelefono.Multiline = false;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Padding = new Padding(10, 7, 10, 7);
            txtTelefono.PasswordChar = false;
            txtTelefono.PlaceholderColor = Color.DarkGray;
            txtTelefono.PlaceholderText = "";
            txtTelefono.Size = new Size(312, 35);
            txtTelefono.TabIndex = 10;
            txtTelefono.Texts = "";
            txtTelefono.UnderlinedStyle = false;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // txtApellidoM
            // 
            txtApellidoM.BackColor = SystemColors.Window;
            txtApellidoM.BorderColor = Color.FromArgb(255, 111, 94);
            txtApellidoM.BorderFocusColor = Color.FromArgb(44, 61, 99);
            txtApellidoM.BorderRadius = 0;
            txtApellidoM.BorderSize = 2;
            txtApellidoM.Enabled = false;
            txtApellidoM.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellidoM.ForeColor = Color.FromArgb(64, 64, 64);
            txtApellidoM.Location = new Point(211, 302);
            txtApellidoM.Margin = new Padding(4);
            txtApellidoM.Multiline = false;
            txtApellidoM.Name = "txtApellidoM";
            txtApellidoM.Padding = new Padding(10, 7, 10, 7);
            txtApellidoM.PasswordChar = false;
            txtApellidoM.PlaceholderColor = Color.DarkGray;
            txtApellidoM.PlaceholderText = "";
            txtApellidoM.Size = new Size(312, 35);
            txtApellidoM.TabIndex = 11;
            txtApellidoM.Texts = "";
            txtApellidoM.UnderlinedStyle = false;
            txtApellidoM.KeyPress += txtApellidoM_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(49, 66, 82);
            label5.Location = new Point(51, 354);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 13;
            label5.Text = "TELÉFONO:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(49, 66, 82);
            label6.Location = new Point(51, 417);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 15;
            label6.Text = "EMAIL:\r\n";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.Window;
            txtEmail.BorderColor = Color.FromArgb(255, 111, 94);
            txtEmail.BorderFocusColor = Color.FromArgb(44, 61, 99);
            txtEmail.BorderRadius = 0;
            txtEmail.BorderSize = 2;
            txtEmail.Enabled = false;
            txtEmail.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.ForeColor = Color.FromArgb(64, 64, 64);
            txtEmail.Location = new Point(211, 417);
            txtEmail.Margin = new Padding(4);
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(10, 7, 10, 7);
            txtEmail.PasswordChar = false;
            txtEmail.PlaceholderColor = Color.DarkGray;
            txtEmail.PlaceholderText = "";
            txtEmail.Size = new Size(312, 35);
            txtEmail.TabIndex = 14;
            txtEmail.Texts = "";
            txtEmail.UnderlinedStyle = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(49, 66, 82);
            label7.Location = new Point(51, 473);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(64, 20);
            label7.TabIndex = 17;
            label7.Text = "PUESTO:";
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
            btnModificar.Location = new Point(1047, 769);
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
            btnEliminar.Location = new Point(193, 651);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(188, 50);
            btnEliminar.TabIndex = 22;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.TextColor = Color.White;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtApellidoP
            // 
            txtApellidoP.BackColor = SystemColors.Window;
            txtApellidoP.BorderColor = Color.FromArgb(255, 111, 94);
            txtApellidoP.BorderFocusColor = Color.FromArgb(44, 61, 99);
            txtApellidoP.BorderRadius = 0;
            txtApellidoP.BorderSize = 2;
            txtApellidoP.Enabled = false;
            txtApellidoP.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellidoP.ForeColor = Color.FromArgb(64, 64, 64);
            txtApellidoP.Location = new Point(211, 251);
            txtApellidoP.Margin = new Padding(4);
            txtApellidoP.Multiline = false;
            txtApellidoP.Name = "txtApellidoP";
            txtApellidoP.Padding = new Padding(10, 7, 10, 7);
            txtApellidoP.PasswordChar = false;
            txtApellidoP.PlaceholderColor = Color.DarkGray;
            txtApellidoP.PlaceholderText = "";
            txtApellidoP.Size = new Size(312, 35);
            txtApellidoP.TabIndex = 24;
            txtApellidoP.Texts = "";
            txtApellidoP.UnderlinedStyle = false;
            txtApellidoP.KeyPress += txtApellidoP_KeyPress;
            // 
            // txtPuesto
            // 
            txtPuesto.BackColor = SystemColors.Window;
            txtPuesto.BorderColor = Color.FromArgb(255, 111, 94);
            txtPuesto.BorderFocusColor = Color.FromArgb(44, 61, 99);
            txtPuesto.BorderRadius = 0;
            txtPuesto.BorderSize = 2;
            txtPuesto.Enabled = false;
            txtPuesto.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtPuesto.ForeColor = Color.FromArgb(64, 64, 64);
            txtPuesto.Location = new Point(211, 473);
            txtPuesto.Margin = new Padding(4);
            txtPuesto.Multiline = false;
            txtPuesto.Name = "txtPuesto";
            txtPuesto.Padding = new Padding(10, 7, 10, 7);
            txtPuesto.PasswordChar = false;
            txtPuesto.PlaceholderColor = Color.DarkGray;
            txtPuesto.PlaceholderText = "";
            txtPuesto.Size = new Size(312, 35);
            txtPuesto.TabIndex = 25;
            txtPuesto.Texts = "";
            txtPuesto.UnderlinedStyle = false;
            txtPuesto.KeyPress += txtPuesto_KeyPress;
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
            dgvEmpleados.Location = new Point(602, 138);
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
            dgvEmpleados.Size = new Size(975, 600);
            dgvEmpleados.TabIndex = 26;
            dgvEmpleados.CellContentClick += dgvEmpleados_CellContentClick;
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
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(335, 570);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(188, 50);
            btnGuardar.TabIndex = 27;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.TextColor = Color.White;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
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
            rjButton1.ForeColor = Color.White;
            rjButton1.Location = new Point(51, 570);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(188, 50);
            rjButton1.TabIndex = 28;
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
            txtId.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.ForeColor = Color.FromArgb(64, 64, 64);
            txtId.Location = new Point(211, 151);
            txtId.Margin = new Padding(4);
            txtId.Multiline = false;
            txtId.Name = "txtId";
            txtId.Padding = new Padding(10, 7, 10, 7);
            txtId.PasswordChar = false;
            txtId.PlaceholderColor = Color.DarkGray;
            txtId.PlaceholderText = "";
            txtId.Size = new Size(312, 35);
            txtId.TabIndex = 30;
            txtId.Texts = "";
            txtId.UnderlinedStyle = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(49, 66, 82);
            label3.Location = new Point(51, 151);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(27, 20);
            label3.TabIndex = 29;
            label3.Text = "ID:";
            // 
            // empleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 248, 243);
            ClientSize = new Size(1649, 942);
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(rjButton1);
            Controls.Add(btnGuardar);
            Controls.Add(dgvEmpleados);
            Controls.Add(txtPuesto);
            Controls.Add(txtApellidoP);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(txtApellidoM);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Controls.Add(btnagregar);
            Controls.Add(label4);
            Controls.Add(lblApellido);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "empleados";
            Text = "productos";
            Load += empleados_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label label4;
        private CustomControls.RJControls.RJButton btnagregar;
        private CustomControls.RJControls.RJTextBox txtNombre;
        private CustomControls.RJControls.RJTextBox txtTelefono;
        private CustomControls.RJControls.RJTextBox txtApellidoM;
        private Label label5;
        private Label label6;
        private CustomControls.RJControls.RJTextBox txtEmail;
        private Label label7;
        private CustomControls.RJControls.RJButton btnModificar;
        private CustomControls.RJControls.RJButton btnEliminar;
        private CustomControls.RJControls.RJTextBox txtApellidoP;
        private CustomControls.RJControls.RJTextBox txtPuesto;
        private DataGridView dgvEmpleados;
        private CustomControls.RJControls.RJButton btnGuardar;
        private CustomControls.RJControls.RJButton rjButton1;
        private CustomControls.RJControls.RJTextBox txtId;
        private Label label3;
    }
}
