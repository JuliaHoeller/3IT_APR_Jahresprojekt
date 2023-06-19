namespace _3IT_Höller_Jahresprojekt
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.lbl_3 = new System.Windows.Forms.Label();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.txbx_login = new System.Windows.Forms.TextBox();
            this.txbx_password = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chbx_showPassword = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(370, 210);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 30);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Location = new System.Drawing.Point(27, 100);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(125, 23);
            this.lbl_2.TabIndex = 4;
            this.lbl_2.Text = "Benutzername:";
            // 
            // lbl_3
            // 
            this.lbl_3.AutoSize = true;
            this.lbl_3.Location = new System.Drawing.Point(27, 140);
            this.lbl_3.Name = "lbl_3";
            this.lbl_3.Size = new System.Drawing.Size(80, 23);
            this.lbl_3.TabIndex = 5;
            this.lbl_3.Text = "Passwort:";
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_1.Location = new System.Drawing.Point(160, 33);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(327, 36);
            this.lbl_1.TabIndex = 3;
            this.lbl_1.Text = "Zeiterfassungssoftware";
            // 
            // txbx_login
            // 
            this.txbx_login.Location = new System.Drawing.Point(160, 97);
            this.txbx_login.Name = "txbx_login";
            this.txbx_login.Size = new System.Drawing.Size(200, 30);
            this.txbx_login.TabIndex = 0;
            // 
            // txbx_password
            // 
            this.txbx_password.Location = new System.Drawing.Point(160, 137);
            this.txbx_password.Name = "txbx_password";
            this.txbx_password.Size = new System.Drawing.Size(200, 30);
            this.txbx_password.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // chbx_showPassword
            // 
            this.chbx_showPassword.AutoSize = true;
            this.chbx_showPassword.Location = new System.Drawing.Point(371, 139);
            this.chbx_showPassword.Name = "chbx_showPassword";
            this.chbx_showPassword.Size = new System.Drawing.Size(101, 27);
            this.chbx_showPassword.TabIndex = 7;
            this.chbx_showPassword.Text = "anzeigen";
            this.chbx_showPassword.UseVisualStyleBackColor = true;
            this.chbx_showPassword.CheckedChanged += new System.EventHandler(this.chbx_showPassword_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.chbx_showPassword);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txbx_password);
            this.Controls.Add(this.txbx_login);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.lbl_3);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.btn_login);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zeiterfassungssoftware - Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_login;
        private Label lbl_2;
        private Label lbl_3;
        private Label lbl_1;
        private TextBox txbx_login;
        private TextBox txbx_password;
        private PictureBox pictureBox1;
        private CheckBox chbx_showPassword;
    }
}