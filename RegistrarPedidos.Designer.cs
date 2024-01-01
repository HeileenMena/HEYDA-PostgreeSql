namespace HEYDA
{
    partial class RegistrarPedidos
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
            label1 = new Label();
            label2 = new Label();
            btnModificar = new CustomControls.RJControls.RJButton();
            panel1 = new Panel();
            dpFechaEntrega = new CustomControls.RJControls.RJDatePicker();
            label6 = new Label();
            dpFechaPedido = new CustomControls.RJControls.RJDatePicker();
            label3 = new Label();
            panel2 = new Panel();
            rjTextBox2 = new CustomControls.RJControls.RJTextBox();
            rjTextBox1 = new CustomControls.RJControls.RJTextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            panel3 = new Panel();
            dudCantidad = new NumericUpDown();
            label14 = new Label();
            txtPrecio = new CustomControls.RJControls.RJTextBox();
            label13 = new Label();
            txtStock = new CustomControls.RJControls.RJTextBox();
            label12 = new Label();
            btnBuscar = new PictureBox();
            txtNombre = new CustomControls.RJControls.RJTextBox();
            txtIdProducto = new CustomControls.RJControls.RJTextBox();
            label5 = new Label();
            label7 = new Label();
            label11 = new Label();
            panel4 = new Panel();
            btnAgregar = new Button();
            label15 = new Label();
            txtTotalPagar = new CustomControls.RJControls.RJTextBox();
            label16 = new Label();
            dgvProveedores = new DataGridView();
            IdProducto = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            btnEliminar = new DataGridViewButtonColumn();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnBuscar).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(49, 66, 82);
            label1.Location = new Point(616, 49);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(286, 31);
            label1.TabIndex = 0;
            label1.Text = "REGISTRAR PEDIDO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(49, 66, 82);
            label2.Location = new Point(10, 29);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 2;
            label2.Text = "FECHA PEDIDO:";
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
            btnModificar.Location = new Point(1239, 524);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(187, 51);
            btnModificar.TabIndex = 20;
            btnModificar.Text = "CREAR PEDIDO";
            btnModificar.TextColor = Color.White;
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dpFechaEntrega);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(dpFechaPedido);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(53, 116);
            panel1.Name = "panel1";
            panel1.Size = new Size(263, 165);
            panel1.TabIndex = 29;
            // 
            // dpFechaEntrega
            // 
            dpFechaEntrega.BorderColor = Color.PaleVioletRed;
            dpFechaEntrega.BorderSize = 0;
            dpFechaEntrega.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dpFechaEntrega.Location = new Point(10, 115);
            dpFechaEntrega.MinimumSize = new Size(4, 35);
            dpFechaEntrega.Name = "dpFechaEntrega";
            dpFechaEntrega.Size = new Size(237, 35);
            dpFechaEntrega.SkinColor = Color.FromArgb(255, 111, 94);
            dpFechaEntrega.TabIndex = 8;
            dpFechaEntrega.TextColor = Color.White;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(49, 66, 82);
            label6.Location = new Point(10, 92);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(125, 20);
            label6.TabIndex = 7;
            label6.Text = "FECHA ENTREGA:";
            // 
            // dpFechaPedido
            // 
            dpFechaPedido.BorderColor = Color.PaleVioletRed;
            dpFechaPedido.BorderSize = 0;
            dpFechaPedido.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dpFechaPedido.Location = new Point(10, 52);
            dpFechaPedido.MinimumSize = new Size(4, 35);
            dpFechaPedido.Name = "dpFechaPedido";
            dpFechaPedido.Size = new Size(237, 35);
            dpFechaPedido.SkinColor = Color.FromArgb(255, 111, 94);
            dpFechaPedido.TabIndex = 4;
            dpFechaPedido.TextColor = Color.White;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(49, 66, 82);
            label3.Location = new Point(5, 0);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(161, 20);
            label3.TabIndex = 3;
            label3.Text = "INFORMACIÓN VENTA:";
            // 
            // panel2
            // 
            panel2.Controls.Add(rjTextBox2);
            panel2.Controls.Add(rjTextBox1);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label10);
            panel2.Location = new Point(334, 116);
            panel2.Name = "panel2";
            panel2.Size = new Size(338, 165);
            panel2.TabIndex = 30;
            // 
            // rjTextBox2
            // 
            rjTextBox2.BackColor = SystemColors.Window;
            rjTextBox2.BorderColor = Color.FromArgb(255, 111, 94);
            rjTextBox2.BorderFocusColor = Color.FromArgb(44, 61, 99);
            rjTextBox2.BorderRadius = 0;
            rjTextBox2.BorderSize = 2;
            rjTextBox2.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            rjTextBox2.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox2.Location = new Point(10, 115);
            rjTextBox2.Margin = new Padding(5, 4, 5, 4);
            rjTextBox2.Multiline = false;
            rjTextBox2.Name = "rjTextBox2";
            rjTextBox2.Padding = new Padding(10, 7, 10, 7);
            rjTextBox2.PasswordChar = false;
            rjTextBox2.PlaceholderColor = Color.DarkGray;
            rjTextBox2.PlaceholderText = "";
            rjTextBox2.Size = new Size(312, 35);
            rjTextBox2.TabIndex = 8;
            rjTextBox2.Texts = "";
            rjTextBox2.UnderlinedStyle = false;
            rjTextBox2.KeyPress += rjTextBox2_KeyPress;
            // 
            // rjTextBox1
            // 
            rjTextBox1.BackColor = SystemColors.Window;
            rjTextBox1.BorderColor = Color.FromArgb(255, 111, 94);
            rjTextBox1.BorderFocusColor = Color.FromArgb(44, 61, 99);
            rjTextBox1.BorderRadius = 0;
            rjTextBox1.BorderSize = 2;
            rjTextBox1.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            rjTextBox1.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox1.Location = new Point(10, 52);
            rjTextBox1.Margin = new Padding(5, 4, 5, 4);
            rjTextBox1.Multiline = false;
            rjTextBox1.Name = "rjTextBox1";
            rjTextBox1.Padding = new Padding(10, 7, 10, 7);
            rjTextBox1.PasswordChar = false;
            rjTextBox1.PlaceholderColor = Color.DarkGray;
            rjTextBox1.PlaceholderText = "";
            rjTextBox1.Size = new Size(312, 35);
            rjTextBox1.TabIndex = 7;
            rjTextBox1.Texts = "";
            rjTextBox1.UnderlinedStyle = false;
            rjTextBox1.KeyPress += rjTextBox1_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.FromArgb(49, 66, 82);
            label8.Location = new Point(10, 91);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(83, 20);
            label8.TabIndex = 5;
            label8.Text = "TELÉFONO:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.FromArgb(49, 66, 82);
            label9.Location = new Point(5, 0);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(171, 20);
            label9.TabIndex = 3;
            label9.Text = "INFORMACIÓN CLIENTE:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.FromArgb(49, 66, 82);
            label10.Location = new Point(10, 29);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(73, 20);
            label10.TabIndex = 2;
            label10.Text = "NOMBRE:";
            label10.Click += label10_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(dudCantidad);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(txtPrecio);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(txtStock);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(btnBuscar);
            panel3.Controls.Add(txtNombre);
            panel3.Controls.Add(txtIdProducto);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label11);
            panel3.Location = new Point(690, 116);
            panel3.Name = "panel3";
            panel3.Size = new Size(658, 165);
            panel3.TabIndex = 31;
            // 
            // dudCantidad
            // 
            dudCantidad.Location = new Point(534, 53);
            dudCantidad.Margin = new Padding(3, 4, 3, 4);
            dudCantidad.Name = "dudCantidad";
            dudCantidad.Size = new Size(104, 27);
            dudCantidad.TabIndex = 40;
            dudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.FromArgb(49, 66, 82);
            label14.Location = new Point(534, 31);
            label14.Margin = new Padding(5, 0, 5, 0);
            label14.Name = "label14";
            label14.Size = new Size(86, 20);
            label14.TabIndex = 38;
            label14.Text = "CANTIDAD:";
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = SystemColors.Window;
            txtPrecio.BorderColor = Color.FromArgb(255, 111, 94);
            txtPrecio.BorderFocusColor = Color.FromArgb(44, 61, 99);
            txtPrecio.BorderRadius = 0;
            txtPrecio.BorderSize = 2;
            txtPrecio.Enabled = false;
            txtPrecio.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecio.ForeColor = Color.FromArgb(64, 64, 64);
            txtPrecio.Location = new Point(368, 53);
            txtPrecio.Margin = new Padding(5, 4, 5, 4);
            txtPrecio.Multiline = false;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Padding = new Padding(10, 7, 10, 7);
            txtPrecio.PasswordChar = false;
            txtPrecio.PlaceholderColor = Color.DarkGray;
            txtPrecio.PlaceholderText = "";
            txtPrecio.Size = new Size(144, 35);
            txtPrecio.TabIndex = 36;
            txtPrecio.Texts = "";
            txtPrecio.UnderlinedStyle = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.FromArgb(49, 66, 82);
            label13.Location = new Point(368, 92);
            label13.Margin = new Padding(5, 0, 5, 0);
            label13.Name = "label13";
            label13.Size = new Size(56, 20);
            label13.TabIndex = 35;
            label13.Text = "STOCK:";
            // 
            // txtStock
            // 
            txtStock.BackColor = SystemColors.Window;
            txtStock.BorderColor = Color.FromArgb(255, 111, 94);
            txtStock.BorderFocusColor = Color.FromArgb(44, 61, 99);
            txtStock.BorderRadius = 0;
            txtStock.BorderSize = 2;
            txtStock.Enabled = false;
            txtStock.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtStock.ForeColor = Color.FromArgb(64, 64, 64);
            txtStock.Location = new Point(368, 113);
            txtStock.Margin = new Padding(5, 4, 5, 4);
            txtStock.Multiline = false;
            txtStock.Name = "txtStock";
            txtStock.Padding = new Padding(10, 7, 10, 7);
            txtStock.PasswordChar = false;
            txtStock.PlaceholderColor = Color.DarkGray;
            txtStock.PlaceholderText = "";
            txtStock.Size = new Size(144, 35);
            txtStock.TabIndex = 34;
            txtStock.Texts = "";
            txtStock.UnderlinedStyle = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.FromArgb(49, 66, 82);
            label12.Location = new Point(368, 29);
            label12.Margin = new Padding(5, 0, 5, 0);
            label12.Name = "label12";
            label12.Size = new Size(61, 20);
            label12.TabIndex = 33;
            label12.Text = "PRECIO:";
            // 
            // btnBuscar
            // 
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.Location = new Point(314, 13);
            btnBuscar.Margin = new Padding(5);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(33, 37);
            btnBuscar.SizeMode = PictureBoxSizeMode.Zoom;
            btnBuscar.TabIndex = 32;
            btnBuscar.TabStop = false;
            btnBuscar.Click += btnBuscar_Click;
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
            txtNombre.Location = new Point(10, 113);
            txtNombre.Margin = new Padding(5, 4, 5, 4);
            txtNombre.Multiline = false;
            txtNombre.Name = "txtNombre";
            txtNombre.Padding = new Padding(10, 7, 10, 7);
            txtNombre.PasswordChar = false;
            txtNombre.PlaceholderColor = Color.DarkGray;
            txtNombre.PlaceholderText = "";
            txtNombre.Size = new Size(337, 35);
            txtNombre.TabIndex = 8;
            txtNombre.Texts = "";
            txtNombre.UnderlinedStyle = false;
            // 
            // txtIdProducto
            // 
            txtIdProducto.BackColor = SystemColors.Window;
            txtIdProducto.BorderColor = Color.FromArgb(255, 111, 94);
            txtIdProducto.BorderFocusColor = Color.FromArgb(44, 61, 99);
            txtIdProducto.BorderRadius = 0;
            txtIdProducto.BorderSize = 2;
            txtIdProducto.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdProducto.ForeColor = Color.FromArgb(64, 64, 64);
            txtIdProducto.Location = new Point(10, 53);
            txtIdProducto.Margin = new Padding(5, 4, 5, 4);
            txtIdProducto.Multiline = false;
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Padding = new Padding(10, 7, 10, 7);
            txtIdProducto.PasswordChar = false;
            txtIdProducto.PlaceholderColor = Color.DarkGray;
            txtIdProducto.PlaceholderText = "";
            txtIdProducto.Size = new Size(337, 35);
            txtIdProducto.TabIndex = 7;
            txtIdProducto.Texts = "0";
            txtIdProducto.UnderlinedStyle = false;
            txtIdProducto.KeyPress += txtIdProducto_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(49, 66, 82);
            label5.Location = new Point(10, 92);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 5;
            label5.Text = "PRODUCTO:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(49, 66, 82);
            label7.Location = new Point(5, 0);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(192, 20);
            label7.TabIndex = 3;
            label7.Text = "INFORMACIÓN PRODUCTO:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.FromArgb(49, 66, 82);
            label11.Location = new Point(10, 29);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new Size(126, 20);
            label11.TabIndex = 2;
            label11.Text = "COD. PRODUCTO:";
            // 
            // panel4
            // 
            panel4.Controls.Add(btnAgregar);
            panel4.Controls.Add(label15);
            panel4.Location = new Point(1378, 127);
            panel4.Name = "panel4";
            panel4.Size = new Size(168, 137);
            panel4.TabIndex = 32;
            // 
            // btnAgregar
            // 
            btnAgregar.BackgroundImageLayout = ImageLayout.Zoom;
            btnAgregar.Location = new Point(21, 23);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(119, 84);
            btnAgregar.TabIndex = 37;
            btnAgregar.TextAlign = ContentAlignment.BottomCenter;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = Color.FromArgb(49, 66, 82);
            label15.Location = new Point(46, 109);
            label15.Margin = new Padding(5, 0, 5, 0);
            label15.Name = "label15";
            label15.Size = new Size(75, 20);
            label15.TabIndex = 39;
            label15.Text = "AGREGAR";
            // 
            // txtTotalPagar
            // 
            txtTotalPagar.BackColor = SystemColors.Window;
            txtTotalPagar.BorderColor = Color.FromArgb(255, 111, 94);
            txtTotalPagar.BorderFocusColor = Color.FromArgb(44, 61, 99);
            txtTotalPagar.BorderRadius = 0;
            txtTotalPagar.BorderSize = 2;
            txtTotalPagar.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotalPagar.ForeColor = Color.FromArgb(64, 64, 64);
            txtTotalPagar.Location = new Point(1208, 381);
            txtTotalPagar.Margin = new Padding(5, 4, 5, 4);
            txtTotalPagar.Multiline = false;
            txtTotalPagar.Name = "txtTotalPagar";
            txtTotalPagar.Padding = new Padding(10, 7, 10, 7);
            txtTotalPagar.PasswordChar = false;
            txtTotalPagar.PlaceholderColor = Color.DarkGray;
            txtTotalPagar.PlaceholderText = "";
            txtTotalPagar.Size = new Size(259, 35);
            txtTotalPagar.TabIndex = 10;
            txtTotalPagar.Texts = "0";
            txtTotalPagar.UnderlinedStyle = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = Color.FromArgb(49, 66, 82);
            label16.Location = new Point(1208, 357);
            label16.Margin = new Padding(5, 0, 5, 0);
            label16.Name = "label16";
            label16.Size = new Size(117, 20);
            label16.TabIndex = 9;
            label16.Text = "TOTAL A PAGAR:";
            // 
            // dgvProveedores
            // 
            dgvProveedores.AllowUserToDeleteRows = false;
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Columns.AddRange(new DataGridViewColumn[] { IdProducto, Producto, Precio, Cantidad, SubTotal, btnEliminar });
            dgvProveedores.Location = new Point(53, 307);
            dgvProveedores.Margin = new Padding(3, 4, 3, 4);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.ReadOnly = true;
            dgvProveedores.RowHeadersWidth = 51;
            dgvProveedores.RowTemplate.Height = 25;
            dgvProveedores.Size = new Size(1082, 384);
            dgvProveedores.TabIndex = 37;
            dgvProveedores.CellContentClick += dgvProveedores_CellContentClick;
            // 
            // IdProducto
            // 
            IdProducto.HeaderText = "IdProducto";
            IdProducto.MinimumWidth = 6;
            IdProducto.Name = "IdProducto";
            IdProducto.ReadOnly = true;
            IdProducto.Width = 125;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 6;
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            Producto.Width = 400;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            Precio.Width = 125;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Width = 125;
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "SubTotal";
            SubTotal.MinimumWidth = 6;
            SubTotal.Name = "SubTotal";
            SubTotal.ReadOnly = true;
            SubTotal.Width = 125;
            // 
            // btnEliminar
            // 
            btnEliminar.HeaderText = "";
            btnEliminar.MinimumWidth = 6;
            btnEliminar.Name = "btnEliminar";
            btnEliminar.ReadOnly = true;
            btnEliminar.Text = "Eliminar";
            btnEliminar.Width = 125;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += imprimir;
            // 
            // RegistrarPedidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 248, 243);
            ClientSize = new Size(1557, 884);
            Controls.Add(dgvProveedores);
            Controls.Add(txtTotalPagar);
            Controls.Add(panel4);
            Controls.Add(label16);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnModificar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "RegistrarPedidos";
            Text = "productos";
            Load += Pedidos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnBuscar).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CustomControls.RJControls.RJButton btnModificar;
        private Panel panel1;
        private CustomControls.RJControls.RJDatePicker dpFechaEntrega;
        private Label label6;
        private CustomControls.RJControls.RJDatePicker dpFechaPedido;
        private Label label3;
        private Panel panel2;
        private CustomControls.RJControls.RJTextBox rjTextBox2;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private Label label8;
        private Label label9;
        private Label label10;
        private Panel panel3;
        private Label label5;
        private Label label7;
        private Label label11;
        private Label label14;
        private Label label13;
        private Label label12;
        private PictureBox btnBuscar;
        private Panel panel4;
        private Label label15;
        private CustomControls.RJControls.RJTextBox txtTotalPagar;
        private Label label16;
        public CustomControls.RJControls.RJTextBox txtIdProducto;
        public CustomControls.RJControls.RJTextBox txtNombre;
        public CustomControls.RJControls.RJTextBox txtPrecio;
        public CustomControls.RJControls.RJTextBox txtStock;
        private NumericUpDown dudCantidad;
        private Button btnAgregar;
        private DataGridView dgvProveedores;
        private DataGridViewTextBoxColumn Column1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
        private DataGridViewButtonColumn btnEliminar;
    }
}
