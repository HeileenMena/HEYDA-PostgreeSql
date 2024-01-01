namespace HEYDA_Postgree
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            BarraTitulo = new Panel();
            btnRestaurar = new PictureBox();
            btnMinimizar = new PictureBox();
            btnMaximizar = new PictureBox();
            btnCerrar = new PictureBox();
            MenuVertical = new Panel();
            panel3 = new Panel();
            panel13 = new Panel();
            button5 = new Button();
            pnl = new Panel();
            pictureBox1 = new PictureBox();
            btnLogout = new Button();
            panel6 = new Panel();
            btnProveedores = new Button();
            panel5 = new Panel();
            btnEmpleados = new Button();
            panel2 = new Panel();
            btnPedidos = new Button();
            panel1 = new Panel();
            btnproductos = new Button();
            btninicio = new PictureBox();
            panelContenedor = new Panel();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            MenuVertical.SuspendLayout();
            panel3.SuspendLayout();
            pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btninicio).BeginInit();
            SuspendLayout();
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.FromArgb(173, 220, 202);
            BarraTitulo.Controls.Add(btnRestaurar);
            BarraTitulo.Controls.Add(btnMinimizar);
            BarraTitulo.Controls.Add(btnMaximizar);
            BarraTitulo.Controls.Add(btnCerrar);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(0, 0);
            BarraTitulo.Margin = new Padding(4, 5, 4, 5);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(1733, 58);
            BarraTitulo.TabIndex = 0;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar.Cursor = Cursors.Hand;
            btnRestaurar.Image = Properties.Resources.Restaurar_Button;
            btnRestaurar.Location = new Point(1628, 9);
            btnRestaurar.Margin = new Padding(4, 5, 4, 5);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(33, 38);
            btnRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            btnRestaurar.TabIndex = 3;
            btnRestaurar.TabStop = false;
            btnRestaurar.Visible = false;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = Properties.Resources.Minimizar_Button;
            btnMinimizar.Location = new Point(1565, 10);
            btnMinimizar.Margin = new Padding(4, 5, 4, 5);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(33, 38);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 2;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.Cursor = Cursors.Hand;
            btnMaximizar.Image = Properties.Resources.Maximizar_Button;
            btnMaximizar.Location = new Point(1628, 9);
            btnMaximizar.Margin = new Padding(4, 5, 4, 5);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(33, 38);
            btnMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMaximizar.TabIndex = 1;
            btnMaximizar.TabStop = false;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = Properties.Resources.Cerrar_Button;
            btnCerrar.Location = new Point(1683, 9);
            btnCerrar.Margin = new Padding(4, 5, 4, 5);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(33, 38);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 0;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = Color.FromArgb(44, 61, 99);
            MenuVertical.Controls.Add(panel3);
            MenuVertical.Controls.Add(pnl);
            MenuVertical.Controls.Add(panel6);
            MenuVertical.Controls.Add(btnProveedores);
            MenuVertical.Controls.Add(panel5);
            MenuVertical.Controls.Add(btnEmpleados);
            MenuVertical.Controls.Add(panel2);
            MenuVertical.Controls.Add(btnPedidos);
            MenuVertical.Controls.Add(panel1);
            MenuVertical.Controls.Add(btnproductos);
            MenuVertical.Controls.Add(btninicio);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.Location = new Point(0, 58);
            MenuVertical.Margin = new Padding(4, 5, 4, 5);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(293, 942);
            MenuVertical.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel13);
            panel3.Controls.Add(button5);
            panel3.Location = new Point(0, 383);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(294, 61);
            panel3.TabIndex = 20;
            // 
            // panel13
            // 
            panel13.BackColor = Color.FromArgb(173, 220, 202);
            panel13.Location = new Point(0, 6);
            panel13.Margin = new Padding(4, 5, 4, 5);
            panel13.Name = "panel13";
            panel13.Size = new Size(7, 48);
            panel13.TabIndex = 17;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(44, 61, 99);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Arial Narrow", 12F, FontStyle.Italic, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Image = Properties.Resources.clientes;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(4, 6);
            button5.Margin = new Padding(4, 5, 4, 5);
            button5.Name = "button5";
            button5.Size = new Size(290, 48);
            button5.TabIndex = 16;
            button5.Text = "Crear Usuarios";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // pnl
            // 
            pnl.Controls.Add(pictureBox1);
            pnl.Controls.Add(btnLogout);
            pnl.Location = new Point(22, 878);
            pnl.Name = "pnl";
            pnl.Size = new Size(250, 52);
            pnl.TabIndex = 19;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.logout;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(44, 61, 99);
            btnLogout.Dock = DockStyle.Fill;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Arial Narrow", 12F, FontStyle.Italic, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.White;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 0);
            btnLogout.Margin = new Padding(4, 5, 4, 5);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(250, 52);
            btnLogout.TabIndex = 16;
            btnLogout.Text = "Cerrar Sesión";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(173, 220, 202);
            panel6.Location = new Point(0, 445);
            panel6.Margin = new Padding(4, 5, 4, 5);
            panel6.Name = "panel6";
            panel6.Size = new Size(7, 54);
            panel6.TabIndex = 12;
            // 
            // btnProveedores
            // 
            btnProveedores.BackColor = Color.FromArgb(44, 61, 99);
            btnProveedores.FlatAppearance.BorderSize = 0;
            btnProveedores.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnProveedores.FlatStyle = FlatStyle.Flat;
            btnProveedores.Font = new Font("Arial Narrow", 12F, FontStyle.Italic, GraphicsUnit.Point);
            btnProveedores.ForeColor = Color.White;
            btnProveedores.Image = Properties.Resources.pagos;
            btnProveedores.ImageAlign = ContentAlignment.MiddleLeft;
            btnProveedores.Location = new Point(5, 445);
            btnProveedores.Margin = new Padding(4, 5, 4, 5);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(289, 54);
            btnProveedores.TabIndex = 11;
            btnProveedores.Text = "Proveedores";
            btnProveedores.UseVisualStyleBackColor = false;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(173, 220, 202);
            panel5.Location = new Point(0, 324);
            panel5.Margin = new Padding(4, 5, 4, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(7, 49);
            panel5.TabIndex = 10;
            // 
            // btnEmpleados
            // 
            btnEmpleados.BackColor = Color.FromArgb(44, 61, 99);
            btnEmpleados.FlatAppearance.BorderSize = 0;
            btnEmpleados.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnEmpleados.FlatStyle = FlatStyle.Flat;
            btnEmpleados.Font = new Font("Arial Narrow", 12F, FontStyle.Italic, GraphicsUnit.Point);
            btnEmpleados.ForeColor = Color.White;
            btnEmpleados.Image = Properties.Resources.empleados;
            btnEmpleados.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmpleados.Location = new Point(4, 324);
            btnEmpleados.Margin = new Padding(4, 5, 4, 5);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(289, 49);
            btnEmpleados.TabIndex = 9;
            btnEmpleados.Text = "Empleados";
            btnEmpleados.UseVisualStyleBackColor = false;
            btnEmpleados.Click += btnEmpleados_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(173, 220, 202);
            panel2.Location = new Point(0, 265);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(7, 49);
            panel2.TabIndex = 4;
            // 
            // btnPedidos
            // 
            btnPedidos.BackColor = Color.FromArgb(44, 61, 99);
            btnPedidos.FlatAppearance.BorderSize = 0;
            btnPedidos.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnPedidos.FlatStyle = FlatStyle.Flat;
            btnPedidos.Font = new Font("Arial Narrow", 12F, FontStyle.Italic, GraphicsUnit.Point);
            btnPedidos.ForeColor = Color.White;
            btnPedidos.Image = Properties.Resources.venta;
            btnPedidos.ImageAlign = ContentAlignment.MiddleLeft;
            btnPedidos.Location = new Point(4, 265);
            btnPedidos.Margin = new Padding(4, 5, 4, 5);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(289, 49);
            btnPedidos.TabIndex = 3;
            btnPedidos.Text = "Pedidos";
            btnPedidos.UseVisualStyleBackColor = false;
            btnPedidos.Click += btnPedidos_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(173, 220, 202);
            panel1.Location = new Point(0, 206);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(7, 49);
            panel1.TabIndex = 2;
            // 
            // btnproductos
            // 
            btnproductos.BackColor = Color.FromArgb(44, 61, 99);
            btnproductos.FlatAppearance.BorderSize = 0;
            btnproductos.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnproductos.FlatStyle = FlatStyle.Flat;
            btnproductos.Font = new Font("Arial Narrow", 12F, FontStyle.Italic, GraphicsUnit.Point);
            btnproductos.ForeColor = Color.White;
            btnproductos.Image = Properties.Resources.producto;
            btnproductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnproductos.Location = new Point(4, 206);
            btnproductos.Margin = new Padding(4, 5, 4, 5);
            btnproductos.Name = "btnproductos";
            btnproductos.Size = new Size(289, 49);
            btnproductos.TabIndex = 1;
            btnproductos.Text = "Productos";
            btnproductos.UseVisualStyleBackColor = false;
            btnproductos.Click += btnproductos_Click;
            // 
            // btninicio
            // 
            btninicio.Image = Properties.Resources.Foto_Login;
            btninicio.Location = new Point(55, 0);
            btninicio.Margin = new Padding(4, 5, 4, 5);
            btninicio.Name = "btninicio";
            btninicio.Size = new Size(165, 96);
            btninicio.SizeMode = PictureBoxSizeMode.Zoom;
            btninicio.TabIndex = 0;
            btninicio.TabStop = false;
            btninicio.Click += btninicio_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(247, 248, 243);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(293, 58);
            panelContenedor.Margin = new Padding(4, 5, 4, 5);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1440, 942);
            panelContenedor.TabIndex = 2;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1733, 1000);
            Controls.Add(panelContenedor);
            Controls.Add(MenuVertical);
            Controls.Add(BarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Menu";
            Text = "Form1";
            Load += Menu_Load;
            BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            MenuVertical.ResumeLayout(false);
            panel3.ResumeLayout(false);
            pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btninicio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPedidos;
        private Button btnLogout;
        private Panel pnl;
        private PictureBox pictureBox1;
        private PictureBox btninicio;
        private Panel panel3;
        private Panel panel13;
        private Button button5;
        private Panel panel1;
        private Button btnproductos;
    }
}