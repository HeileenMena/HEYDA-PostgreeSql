namespace HEYDA_Postgree
{
    partial class Login
    {/// <summary>
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
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            lblErrorMessage = new Label();
            lbError = new Label();
            txtuser = new TextBox();
            rjButton1 = new CustomControls.RJControls.RJButton();
            txtpass = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(358, 140);
            label2.Name = "label2";
            label2.Size = new Size(89, 22);
            label2.TabIndex = 10;
            label2.Text = "Contraseña:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(358, 69);
            label1.Name = "label1";
            label1.Size = new Size(64, 22);
            label1.TabIndex = 8;
            label1.Text = "Usuario:";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.Foto_Login;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(238, 330);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 61, 99);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 330);
            panel1.TabIndex = 12;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Cerrar_Button;
            pictureBox2.Location = new Point(753, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(15, 15);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Minimizar_Button;
            pictureBox3.Location = new Point(732, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(15, 15);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // lblErrorMessage
            // 
            lblErrorMessage.AutoSize = true;
            lblErrorMessage.Location = new Point(347, 259);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new Size(0, 20);
            lblErrorMessage.TabIndex = 18;
            // 
            // lbError
            // 
            lbError.AutoSize = true;
            lbError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbError.ForeColor = Color.FromArgb(255, 111, 94);
            lbError.Location = new Point(360, 220);
            lbError.Name = "lbError";
            lbError.Size = new Size(127, 20);
            lbError.TabIndex = 22;
            lbError.Text = "Mensaje de error";
            lbError.Visible = false;
            // 
            // txtuser
            // 
            txtuser.Location = new Point(362, 95);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(310, 27);
            txtuser.TabIndex = 23;
            txtuser.TextChanged += txtuser_TextChanged;
            txtuser.KeyPress += txtuser_KeyPress;
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
            rjButton1.Location = new Point(420, 259);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(188, 50);
            rjButton1.TabIndex = 25;
            rjButton1.Text = "Login";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += rjButton1_Click;
            // 
            // txtpass
            // 
            txtpass.Location = new Point(362, 165);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(310, 27);
            txtpass.TabIndex = 26;
            txtpass.Text = "AD";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 248, 243);
            ClientSize = new Size(780, 330);
            Controls.Add(txtpass);
            Controls.Add(rjButton1);
            Controls.Add(txtuser);
            Controls.Add(lbError);
            Controls.Add(lblErrorMessage);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio_Sesion";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label lblErrorMessage;
        private Label lbError;
        private TextBox txtuser;
        private CustomControls.RJControls.RJButton rjButton1;
        private TextBox txtpass;
    }
}