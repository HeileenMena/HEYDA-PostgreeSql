namespace HEYDA
{
    partial class AgregarProducto
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
            txtBuscarProducto = new CustomControls.RJControls.RJTextBox();
            label10 = new Label();
            label9 = new Label();
            dgvProductos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // txtBuscarProducto
            // 
            txtBuscarProducto.BackColor = SystemColors.Window;
            txtBuscarProducto.BorderColor = Color.FromArgb(255, 111, 94);
            txtBuscarProducto.BorderFocusColor = Color.FromArgb(44, 61, 99);
            txtBuscarProducto.BorderRadius = 0;
            txtBuscarProducto.BorderSize = 2;
            txtBuscarProducto.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscarProducto.ForeColor = Color.FromArgb(64, 64, 64);
            txtBuscarProducto.Location = new Point(192, 128);
            txtBuscarProducto.Margin = new Padding(4);
            txtBuscarProducto.Multiline = false;
            txtBuscarProducto.Name = "txtBuscarProducto";
            txtBuscarProducto.Padding = new Padding(10, 7, 10, 7);
            txtBuscarProducto.PasswordChar = false;
            txtBuscarProducto.PlaceholderColor = Color.DarkGray;
            txtBuscarProducto.PlaceholderText = "";
            txtBuscarProducto.Size = new Size(585, 35);
            txtBuscarProducto.TabIndex = 48;
            txtBuscarProducto.Texts = "";
            txtBuscarProducto.UnderlinedStyle = false;
            txtBuscarProducto._TextChanged += txtBuscarProducto__TextChanged;
            txtBuscarProducto.KeyPress += txtBuscarProducto_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.FromArgb(49, 66, 82);
            label10.Location = new Point(18, 104);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(244, 20);
            label10.TabIndex = 47;
            label10.Text = "BUSCAR PRODUCTO POR NOMBRE:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Narrow", 20F, FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(49, 66, 82);
            label9.Location = new Point(336, 23);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(196, 40);
            label9.TabIndex = 46;
            label9.Text = "PRODUCTOS";
            // 
            // dgvProductos
            // 
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProductos.BackgroundColor = Color.FromArgb(247, 248, 243);
            dgvProductos.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dgvProductos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 111, 94);
            dataGridViewCellStyle1.Font = new Font("Arial Narrow", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 111, 94);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductos.ColumnHeadersHeight = 30;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProductos.EnableHeadersVisualStyles = false;
            dgvProductos.GridColor = Color.FromArgb(173, 220, 202);
            dgvProductos.Location = new Point(21, 170);
            dgvProductos.Name = "dgvProductos";
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
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(902, 213);
            dgvProductos.TabIndex = 45;
            dgvProductos.CellDoubleClick += dgvProductos_CellDoubleClick;
            // 
            // AgregarProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 468);
            Controls.Add(txtBuscarProducto);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(dgvProductos);
            Name = "AgregarProducto";
            Text = "AgregarProducto";
            Load += AgregarProducto_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.RJControls.RJTextBox txtBuscarProducto;
        private Label label10;
        private Label label9;
        private DataGridView dgvProductos;
    }
}