namespace HEYDA
{
    partial class inicio
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
            components = new System.ComponentModel.Container();
            pictureBox2 = new PictureBox();
            lblHora = new Label();
            lblFecha = new Label();
            horafecha = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = HEYDA_Postgree.Properties.Resources.logo_HEYDA;
            pictureBox2.Location = new Point(83, 14);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(652, 352);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Arial Narrow", 72F, FontStyle.Italic, GraphicsUnit.Point);
            lblHora.ForeColor = Color.FromArgb(173, 220, 202);
            lblHora.Location = new Point(432, 408);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(343, 137);
            lblHora.TabIndex = 2;
            lblHora.Text = "HORA";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Arial Narrow", 32F, FontStyle.Italic, GraphicsUnit.Point);
            lblFecha.ForeColor = Color.FromArgb(44, 61, 99);
            lblFecha.Location = new Point(315, 564);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(178, 64);
            lblFecha.TabIndex = 3;
            lblFecha.Text = "FECHA";
            // 
            // horafecha
            // 
            horafecha.Enabled = true;
            horafecha.Tick += horafecha_Tick;
            // 
            // inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 248, 243);
            ClientSize = new Size(876, 769);
            Controls.Add(lblFecha);
            Controls.Add(lblHora);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "inicio";
            Text = "inicio";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private Label lblHora;
        private Label lblFecha;
        private System.Windows.Forms.Timer horafecha;
    }
}