namespace HEYDA
{
    partial class productos
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
            label4 = new Label();
            txtProducto = new CustomControls.RJControls.RJTextBox();
            txtPrecioVenta = new CustomControls.RJControls.RJTextBox();
            txtStock = new CustomControls.RJControls.RJTextBox();
            label5 = new Label();
            txtId = new CustomControls.RJControls.RJTextBox();
            label8 = new Label();
            btnGuardar = new CustomControls.RJControls.RJButton();
            dgvProductos = new DataGridView();
            btnEliminar = new CustomControls.RJControls.RJButton();
            btnModificar = new CustomControls.RJControls.RJButton();
            btnagregar = new CustomControls.RJControls.RJButton();
            label6 = new Label();
            cbCategoria = new ComboBox();
            label3 = new Label();
            txtPrecioProveedor = new CustomControls.RJControls.RJTextBox();
            label7 = new Label();
            cbProveedor = new ComboBox();
            label9 = new Label();
            dgvProveedores = new DataGridView();
            label10 = new Label();
            txtBuscarProveedor = new CustomControls.RJControls.RJTextBox();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(49, 66, 82);
            label1.Location = new Point(570, 97);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(189, 31);
            label1.TabIndex = 0;
            label1.Text = "PRODUCTOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(49, 66, 82);
            label2.Location = new Point(52, 193);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 2;
            label2.Text = "PRODUCTO:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(49, 66, 82);
            label4.Location = new Point(52, 293);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 6;
            label4.Text = "STOCK:";
            // 
            // txtProducto
            // 
            txtProducto.BackColor = SystemColors.Window;
            txtProducto.BorderColor = Color.FromArgb(255, 111, 94);
            txtProducto.BorderFocusColor = Color.FromArgb(44, 61, 99);
            txtProducto.BorderRadius = 0;
            txtProducto.BorderSize = 2;
            txtProducto.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtProducto.ForeColor = Color.FromArgb(64, 64, 64);
            txtProducto.Location = new Point(212, 193);
            txtProducto.Margin = new Padding(4);
            txtProducto.Multiline = false;
            txtProducto.Name = "txtProducto";
            txtProducto.Padding = new Padding(10, 7, 10, 7);
            txtProducto.PasswordChar = false;
            txtProducto.PlaceholderColor = Color.DarkGray;
            txtProducto.PlaceholderText = "";
            txtProducto.Size = new Size(312, 35);
            txtProducto.TabIndex = 9;
            txtProducto.Texts = "";
            txtProducto.UnderlinedStyle = false;
            txtProducto.KeyPress += txtProducto_KeyPress;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.BackColor = SystemColors.Window;
            txtPrecioVenta.BorderColor = Color.FromArgb(255, 111, 94);
            txtPrecioVenta.BorderFocusColor = Color.FromArgb(44, 61, 99);
            txtPrecioVenta.BorderRadius = 0;
            txtPrecioVenta.BorderSize = 2;
            txtPrecioVenta.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecioVenta.ForeColor = Color.FromArgb(64, 64, 64);
            txtPrecioVenta.Location = new Point(212, 350);
            txtPrecioVenta.Margin = new Padding(4);
            txtPrecioVenta.Multiline = false;
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Padding = new Padding(10, 7, 10, 7);
            txtPrecioVenta.PasswordChar = false;
            txtPrecioVenta.PlaceholderColor = Color.DarkGray;
            txtPrecioVenta.PlaceholderText = "";
            txtPrecioVenta.Size = new Size(312, 35);
            txtPrecioVenta.TabIndex = 10;
            txtPrecioVenta.Texts = "";
            txtPrecioVenta.UnderlinedStyle = false;
            // 
            // txtStock
            // 
            txtStock.BackColor = SystemColors.Window;
            txtStock.BorderColor = Color.FromArgb(255, 111, 94);
            txtStock.BorderFocusColor = Color.FromArgb(44, 61, 99);
            txtStock.BorderRadius = 0;
            txtStock.BorderSize = 2;
            txtStock.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtStock.ForeColor = Color.FromArgb(64, 64, 64);
            txtStock.Location = new Point(212, 293);
            txtStock.Margin = new Padding(4);
            txtStock.Multiline = false;
            txtStock.Name = "txtStock";
            txtStock.Padding = new Padding(10, 7, 10, 7);
            txtStock.PasswordChar = false;
            txtStock.PlaceholderColor = Color.DarkGray;
            txtStock.PlaceholderText = "";
            txtStock.Size = new Size(312, 35);
            txtStock.TabIndex = 11;
            txtStock.Texts = "";
            txtStock.UnderlinedStyle = false;
            txtStock.KeyPress += txtStock_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(49, 66, 82);
            label5.Location = new Point(52, 350);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(110, 20);
            label5.TabIndex = 13;
            label5.Text = "PRECIO VENTA:";
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.Window;
            txtId.BorderColor = Color.FromArgb(255, 111, 94);
            txtId.BorderFocusColor = Color.FromArgb(44, 61, 99);
            txtId.BorderRadius = 0;
            txtId.BorderSize = 2;
            txtId.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.ForeColor = Color.FromArgb(64, 64, 64);
            txtId.Location = new Point(214, 141);
            txtId.Margin = new Padding(4);
            txtId.Multiline = false;
            txtId.Name = "txtId";
            txtId.Padding = new Padding(10, 7, 10, 7);
            txtId.PasswordChar = false;
            txtId.PlaceholderColor = Color.DarkGray;
            txtId.PlaceholderText = "";
            txtId.Size = new Size(312, 35);
            txtId.TabIndex = 25;
            txtId.Texts = "";
            txtId.UnderlinedStyle = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.FromArgb(49, 66, 82);
            label8.Location = new Point(54, 141);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(27, 20);
            label8.TabIndex = 24;
            label8.Text = "ID:";
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
            btnGuardar.Location = new Point(308, 518);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(188, 50);
            btnGuardar.TabIndex = 32;
            btnGuardar.Text = "ACTUALIZAR";
            btnGuardar.TextColor = Color.White;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProductos.BackgroundColor = Color.FromArgb(247, 248, 243);
            dgvProductos.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 111, 94);
            dataGridViewCellStyle1.Font = new Font("Arial Narrow", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 111, 94);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.EnableHeadersVisualStyles = false;
            dgvProductos.GridColor = Color.FromArgb(173, 220, 202);
            dgvProductos.Location = new Point(570, 141);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Arial Narrow", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(173, 220, 202);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.RowTemplate.Height = 29;
            dgvProductos.Size = new Size(975, 259);
            dgvProductos.TabIndex = 31;
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
            btnEliminar.Location = new Point(159, 598);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(188, 50);
            btnEliminar.TabIndex = 30;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.TextColor = Color.White;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
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
            btnModificar.Location = new Point(973, 418);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(188, 50);
            btnModificar.TabIndex = 29;
            btnModificar.Text = "MODIFICAR";
            btnModificar.TextColor = Color.White;
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
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
            btnagregar.Location = new Point(24, 518);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(188, 50);
            btnagregar.TabIndex = 28;
            btnagregar.Text = "AGREGAR";
            btnagregar.TextColor = Color.White;
            btnagregar.UseVisualStyleBackColor = false;
            btnagregar.Click += btnagregar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(49, 66, 82);
            label6.Location = new Point(54, 245);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 33;
            label6.Text = "CATEGORIA:";
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Items.AddRange(new object[] { "Artículos de sobremesa", "Todo lo relacionado con la escritura", "Papeles y etiquetas", "Material de embalaje", "Organización personal", "Archivo y clasificación", "Los manipulados del papel" });
            cbCategoria.Location = new Point(214, 245);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(308, 28);
            cbCategoria.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(49, 66, 82);
            label3.Location = new Point(54, 409);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(149, 20);
            label3.TabIndex = 36;
            label3.Text = "PRECIO PROVEEDOR:";
            // 
            // txtPrecioProveedor
            // 
            txtPrecioProveedor.BackColor = SystemColors.Window;
            txtPrecioProveedor.BorderColor = Color.FromArgb(255, 111, 94);
            txtPrecioProveedor.BorderFocusColor = Color.FromArgb(44, 61, 99);
            txtPrecioProveedor.BorderRadius = 0;
            txtPrecioProveedor.BorderSize = 2;
            txtPrecioProveedor.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecioProveedor.ForeColor = Color.FromArgb(64, 64, 64);
            txtPrecioProveedor.Location = new Point(214, 409);
            txtPrecioProveedor.Margin = new Padding(4);
            txtPrecioProveedor.Multiline = false;
            txtPrecioProveedor.Name = "txtPrecioProveedor";
            txtPrecioProveedor.Padding = new Padding(10, 7, 10, 7);
            txtPrecioProveedor.PasswordChar = false;
            txtPrecioProveedor.PlaceholderColor = Color.DarkGray;
            txtPrecioProveedor.PlaceholderText = "";
            txtPrecioProveedor.Size = new Size(312, 35);
            txtPrecioProveedor.TabIndex = 35;
            txtPrecioProveedor.Texts = "";
            txtPrecioProveedor.UnderlinedStyle = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(49, 66, 82);
            label7.Location = new Point(52, 462);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(96, 20);
            label7.TabIndex = 38;
            label7.Text = "PROVEEDOR:";
            // 
            // cbProveedor
            // 
            cbProveedor.FormattingEnabled = true;
            cbProveedor.Items.AddRange(new object[] { "" });
            cbProveedor.Location = new Point(212, 462);
            cbProveedor.Name = "cbProveedor";
            cbProveedor.Size = new Size(308, 28);
            cbProveedor.TabIndex = 39;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Narrow", 20F, FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(49, 66, 82);
            label9.Location = new Point(923, 632);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(235, 40);
            label9.TabIndex = 41;
            label9.Text = "PROVEEDORES";
            // 
            // dgvProveedores
            // 
            dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvProveedores.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProveedores.BackgroundColor = Color.FromArgb(247, 248, 243);
            dgvProveedores.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dgvProveedores.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 111, 94);
            dataGridViewCellStyle3.Font = new Font("Arial Narrow", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 111, 94);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvProveedores.ColumnHeadersHeight = 30;
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProveedores.EnableHeadersVisualStyles = false;
            dgvProveedores.GridColor = Color.FromArgb(173, 220, 202);
            dgvProveedores.Location = new Point(561, 678);
            dgvProveedores.Name = "dgvProveedores";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Arial Narrow", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(173, 220, 202);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvProveedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvProveedores.RowHeadersVisible = false;
            dgvProveedores.RowHeadersWidth = 51;
            dgvProveedores.RowTemplate.Height = 29;
            dgvProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProveedores.Size = new Size(975, 213);
            dgvProveedores.TabIndex = 40;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.FromArgb(49, 66, 82);
            label10.Location = new Point(570, 563);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(252, 20);
            label10.TabIndex = 42;
            label10.Text = "BUSCAR PROVEEDOR POR NOMBRE:";
            // 
            // txtBuscarProveedor
            // 
            txtBuscarProveedor.BackColor = SystemColors.Window;
            txtBuscarProveedor.BorderColor = Color.FromArgb(255, 111, 94);
            txtBuscarProveedor.BorderFocusColor = Color.FromArgb(44, 61, 99);
            txtBuscarProveedor.BorderRadius = 0;
            txtBuscarProveedor.BorderSize = 2;
            txtBuscarProveedor.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscarProveedor.ForeColor = Color.FromArgb(64, 64, 64);
            txtBuscarProveedor.Location = new Point(744, 587);
            txtBuscarProveedor.Margin = new Padding(4);
            txtBuscarProveedor.Multiline = false;
            txtBuscarProveedor.Name = "txtBuscarProveedor";
            txtBuscarProveedor.Padding = new Padding(10, 7, 10, 7);
            txtBuscarProveedor.PasswordChar = false;
            txtBuscarProveedor.PlaceholderColor = Color.DarkGray;
            txtBuscarProveedor.PlaceholderText = "";
            txtBuscarProveedor.Size = new Size(585, 35);
            txtBuscarProveedor.TabIndex = 43;
            txtBuscarProveedor.Texts = "";
            txtBuscarProveedor.UnderlinedStyle = false;
            txtBuscarProveedor._TextChanged += txtBuscarProveedor__TextChanged;
            txtBuscarProveedor.KeyPress += txtBuscarProveedor_KeyPress;
            // 
            // productos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 248, 243);
            ClientSize = new Size(1573, 942);
            Controls.Add(txtBuscarProveedor);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(dgvProveedores);
            Controls.Add(cbProveedor);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(txtPrecioProveedor);
            Controls.Add(cbCategoria);
            Controls.Add(label6);
            Controls.Add(btnGuardar);
            Controls.Add(dgvProductos);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnagregar);
            Controls.Add(txtId);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(txtStock);
            Controls.Add(txtPrecioVenta);
            Controls.Add(txtProducto);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "productos";
            Text = "productos";
            Load += productos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private CustomControls.RJControls.RJTextBox txtProducto;
        private CustomControls.RJControls.RJTextBox txtPrecioVenta;
        private CustomControls.RJControls.RJTextBox txtStock;
        private Label label5;
        private CustomControls.RJControls.RJTextBox txtId;
        private Label label8;
        private CustomControls.RJControls.RJButton btnGuardar;
        private DataGridView dgvProductos;
        private CustomControls.RJControls.RJButton btnEliminar;
        private CustomControls.RJControls.RJButton btnModificar;
        private CustomControls.RJControls.RJButton btnagregar;
        private Label label6;
        private ComboBox cbCategoria;
        private Label label3;
        private CustomControls.RJControls.RJTextBox txtPrecioProveedor;
        private Label label7;
        private ComboBox cbProveedor;
        private Label label9;
        private DataGridView dgvProveedores;
        private Label label10;
        private CustomControls.RJControls.RJTextBox txtBuscarProveedor;
    }
}
