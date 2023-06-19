namespace _3IT_Höller_Jahresprojekt
{
    partial class NewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUser));
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_usertypes = new System.Windows.Forms.Label();
            this.txbx_username = new System.Windows.Forms.TextBox();
            this.txbx_password = new System.Windows.Forms.TextBox();
            this.txbx_email = new System.Windows.Forms.TextBox();
            this.cobx_usertypes = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_username.Location = new System.Drawing.Point(30, 33);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(100, 19);
            this.lbl_username.TabIndex = 0;
            this.lbl_username.Text = "Benutzername:";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Password.Location = new System.Drawing.Point(30, 68);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(67, 19);
            this.lbl_Password.TabIndex = 1;
            this.lbl_Password.Text = "Passwort:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_email.Location = new System.Drawing.Point(30, 103);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(51, 19);
            this.lbl_email.TabIndex = 2;
            this.lbl_email.Text = "E-Mail:";
            // 
            // lbl_usertypes
            // 
            this.lbl_usertypes.AutoSize = true;
            this.lbl_usertypes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_usertypes.Location = new System.Drawing.Point(30, 138);
            this.lbl_usertypes.Name = "lbl_usertypes";
            this.lbl_usertypes.Size = new System.Drawing.Size(108, 19);
            this.lbl_usertypes.TabIndex = 3;
            this.lbl_usertypes.Text = "Berechtigungen:";
            // 
            // txbx_username
            // 
            this.txbx_username.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbx_username.Location = new System.Drawing.Point(164, 30);
            this.txbx_username.Name = "txbx_username";
            this.txbx_username.Size = new System.Drawing.Size(250, 25);
            this.txbx_username.TabIndex = 4;
            // 
            // txbx_password
            // 
            this.txbx_password.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbx_password.Location = new System.Drawing.Point(164, 65);
            this.txbx_password.Name = "txbx_password";
            this.txbx_password.Size = new System.Drawing.Size(250, 25);
            this.txbx_password.TabIndex = 5;
            // 
            // txbx_email
            // 
            this.txbx_email.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbx_email.Location = new System.Drawing.Point(164, 100);
            this.txbx_email.Name = "txbx_email";
            this.txbx_email.Size = new System.Drawing.Size(250, 25);
            this.txbx_email.TabIndex = 6;
            // 
            // cobx_usertypes
            // 
            this.cobx_usertypes.FormattingEnabled = true;
            this.cobx_usertypes.Items.AddRange(new object[] {
            "Administrator",
            "Head-User",
            "User"});
            this.cobx_usertypes.Location = new System.Drawing.Point(164, 135);
            this.cobx_usertypes.Name = "cobx_usertypes";
            this.cobx_usertypes.Size = new System.Drawing.Size(250, 23);
            this.cobx_usertypes.TabIndex = 7;
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_save.Location = new System.Drawing.Point(472, 133);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(90, 28);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "Speichern";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click_1);
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_back.Location = new System.Drawing.Point(472, 33);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(90, 28);
            this.btn_back.TabIndex = 9;
            this.btn_back.Text = "Zurück";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click_1);
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 181);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.cobx_usertypes);
            this.Controls.Add(this.txbx_email);
            this.Controls.Add(this.txbx_password);
            this.Controls.Add(this.txbx_username);
            this.Controls.Add(this.lbl_usertypes);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_username);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_username;
        private Label lbl_Password;
        private Label lbl_email;
        private Label lbl_usertypes;
        private TextBox txbx_username;
        private TextBox txbx_password;
        private TextBox txbx_email;
        private ComboBox cobx_usertypes;
        private Button btn_save;
        private Button btn_back;
    }
}