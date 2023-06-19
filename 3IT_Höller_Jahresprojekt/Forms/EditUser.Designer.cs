namespace _3IT_Höller_Jahresprojekt
{
    partial class EditUser
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
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_change = new System.Windows.Forms.Label();
            this.lbl_new = new System.Windows.Forms.Label();
            this.txBx_new = new System.Windows.Forms.TextBox();
            this.coBx_username = new System.Windows.Forms.ComboBox();
            this.coBx_change = new System.Windows.Forms.ComboBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_change = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txbx_password = new System.Windows.Forms.TextBox();
            this.chBx_showPassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_username.Location = new System.Drawing.Point(31, 47);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(125, 23);
            this.lbl_username.TabIndex = 0;
            this.lbl_username.Text = "Benutzername:";
            // 
            // lbl_change
            // 
            this.lbl_change.AutoSize = true;
            this.lbl_change.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_change.Location = new System.Drawing.Point(31, 131);
            this.lbl_change.Name = "lbl_change";
            this.lbl_change.Size = new System.Drawing.Size(206, 23);
            this.lbl_change.TabIndex = 1;
            this.lbl_change.Text = "Der zu verändernde Wert:";
            // 
            // lbl_new
            // 
            this.lbl_new.AutoSize = true;
            this.lbl_new.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_new.Location = new System.Drawing.Point(31, 215);
            this.lbl_new.Name = "lbl_new";
            this.lbl_new.Size = new System.Drawing.Size(125, 23);
            this.lbl_new.TabIndex = 2;
            this.lbl_new.Text = "Der neue Wert:";
            // 
            // txBx_new
            // 
            this.txBx_new.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txBx_new.Location = new System.Drawing.Point(257, 211);
            this.txBx_new.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txBx_new.Name = "txBx_new";
            this.txBx_new.Size = new System.Drawing.Size(399, 30);
            this.txBx_new.TabIndex = 4;
            // 
            // coBx_username
            // 
            this.coBx_username.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.coBx_username.FormattingEnabled = true;
            this.coBx_username.Location = new System.Drawing.Point(257, 43);
            this.coBx_username.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.coBx_username.Name = "coBx_username";
            this.coBx_username.Size = new System.Drawing.Size(399, 31);
            this.coBx_username.TabIndex = 5;
            // 
            // coBx_change
            // 
            this.coBx_change.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.coBx_change.FormattingEnabled = true;
            this.coBx_change.Items.AddRange(new object[] {
            "Benutzername",
            "Passwort",
            "E-Mail"});
            this.coBx_change.Location = new System.Drawing.Point(256, 127);
            this.coBx_change.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.coBx_change.Name = "coBx_change";
            this.coBx_change.Size = new System.Drawing.Size(399, 31);
            this.coBx_change.TabIndex = 6;
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_back.Location = new System.Drawing.Point(703, 40);
            this.btn_back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(103, 37);
            this.btn_back.TabIndex = 7;
            this.btn_back.Text = "Zurück";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_change
            // 
            this.btn_change.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_change.Location = new System.Drawing.Point(451, 373);
            this.btn_change.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(185, 37);
            this.btn_change.TabIndex = 8;
            this.btn_change.Text = "Änderungen speichern";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_delete.Location = new System.Drawing.Point(665, 373);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(141, 37);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "User löschen";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_password.Location = new System.Drawing.Point(31, 299);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(153, 23);
            this.lbl_password.TabIndex = 10;
            this.lbl_password.Text = "Das altes Passwort:";
            // 
            // txbx_password
            // 
            this.txbx_password.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbx_password.Location = new System.Drawing.Point(257, 291);
            this.txbx_password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbx_password.Name = "txbx_password";
            this.txbx_password.PasswordChar = '*';
            this.txbx_password.Size = new System.Drawing.Size(399, 30);
            this.txbx_password.TabIndex = 11;
            // 
            // chBx_showPassword
            // 
            this.chBx_showPassword.AutoSize = true;
            this.chBx_showPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chBx_showPassword.Location = new System.Drawing.Point(705, 295);
            this.chBx_showPassword.Name = "chBx_showPassword";
            this.chBx_showPassword.Size = new System.Drawing.Size(101, 27);
            this.chBx_showPassword.TabIndex = 12;
            this.chBx_showPassword.Text = "anzeigen";
            this.chBx_showPassword.UseVisualStyleBackColor = true;
            this.chBx_showPassword.CheckedChanged += new System.EventHandler(this.chBx_showPassword_CheckedChanged);
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 440);
            this.Controls.Add(this.chBx_showPassword);
            this.Controls.Add(this.txbx_password);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.coBx_change);
            this.Controls.Add(this.coBx_username);
            this.Controls.Add(this.txBx_new);
            this.Controls.Add(this.lbl_new);
            this.Controls.Add(this.lbl_change);
            this.Controls.Add(this.lbl_username);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EditUser";
            this.Text = "Jahresprojekt - Benutzer bearbeiten und löschen";
            this.Load += new System.EventHandler(this.EditUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_username;
        private Label lbl_change;
        private Label lbl_new;
        private TextBox txBx_new;
        private ComboBox coBx_username;
        private ComboBox coBx_change;
        private Button btn_back;
        private Button btn_change;
        private Button btn_delete;
        private Label lbl_password;
        private TextBox txbx_password;
        private CheckBox chBx_showPassword;
    }
}