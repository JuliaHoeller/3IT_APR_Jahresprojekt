namespace _3IT_Höller_Jahresprojekt
{
    partial class NewWorker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewWorker));
            this.txBx_firstname = new System.Windows.Forms.TextBox();
            this.txBx_lastname = new System.Windows.Forms.TextBox();
            this.txBx_address = new System.Windows.Forms.TextBox();
            this.txBx_department = new System.Windows.Forms.TextBox();
            this.txBx_phoneNumber = new System.Windows.Forms.TextBox();
            this.txBx_money = new System.Windows.Forms.TextBox();
            this.txBx_hours = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_firstname = new System.Windows.Forms.Label();
            this.lbl_lastname = new System.Windows.Forms.Label();
            this.lbl_department = new System.Windows.Forms.Label();
            this.lbl_phoneNumber = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_money = new System.Windows.Forms.Label();
            this.lbl_hours = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txBx_firstname
            // 
            this.txBx_firstname.Location = new System.Drawing.Point(164, 30);
            this.txBx_firstname.Name = "txBx_firstname";
            this.txBx_firstname.Size = new System.Drawing.Size(250, 25);
            this.txBx_firstname.TabIndex = 0;
            // 
            // txBx_lastname
            // 
            this.txBx_lastname.Location = new System.Drawing.Point(164, 65);
            this.txBx_lastname.Name = "txBx_lastname";
            this.txBx_lastname.Size = new System.Drawing.Size(250, 25);
            this.txBx_lastname.TabIndex = 1;
            // 
            // txBx_address
            // 
            this.txBx_address.Location = new System.Drawing.Point(164, 170);
            this.txBx_address.Name = "txBx_address";
            this.txBx_address.Size = new System.Drawing.Size(250, 25);
            this.txBx_address.TabIndex = 4;
            // 
            // txBx_department
            // 
            this.txBx_department.Location = new System.Drawing.Point(164, 100);
            this.txBx_department.Name = "txBx_department";
            this.txBx_department.Size = new System.Drawing.Size(250, 25);
            this.txBx_department.TabIndex = 2;
            // 
            // txBx_phoneNumber
            // 
            this.txBx_phoneNumber.Location = new System.Drawing.Point(164, 135);
            this.txBx_phoneNumber.Name = "txBx_phoneNumber";
            this.txBx_phoneNumber.Size = new System.Drawing.Size(250, 25);
            this.txBx_phoneNumber.TabIndex = 3;
            // 
            // txBx_money
            // 
            this.txBx_money.Location = new System.Drawing.Point(164, 205);
            this.txBx_money.Name = "txBx_money";
            this.txBx_money.Size = new System.Drawing.Size(250, 25);
            this.txBx_money.TabIndex = 5;
            // 
            // txBx_hours
            // 
            this.txBx_hours.Location = new System.Drawing.Point(164, 240);
            this.txBx_hours.Name = "txBx_hours";
            this.txBx_hours.Size = new System.Drawing.Size(250, 25);
            this.txBx_hours.TabIndex = 6;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(472, 237);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(90, 28);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "Speichern";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(472, 30);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(90, 28);
            this.btn_back.TabIndex = 9;
            this.btn_back.Text = "Zurück";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_firstname
            // 
            this.lbl_firstname.AutoSize = true;
            this.lbl_firstname.Location = new System.Drawing.Point(30, 33);
            this.lbl_firstname.Name = "lbl_firstname";
            this.lbl_firstname.Size = new System.Drawing.Size(67, 19);
            this.lbl_firstname.TabIndex = 10;
            this.lbl_firstname.Text = "Vorname:";
            // 
            // lbl_lastname
            // 
            this.lbl_lastname.AutoSize = true;
            this.lbl_lastname.Location = new System.Drawing.Point(30, 68);
            this.lbl_lastname.Name = "lbl_lastname";
            this.lbl_lastname.Size = new System.Drawing.Size(77, 19);
            this.lbl_lastname.TabIndex = 11;
            this.lbl_lastname.Text = "Nachname:";
            // 
            // lbl_department
            // 
            this.lbl_department.AutoSize = true;
            this.lbl_department.Location = new System.Drawing.Point(30, 103);
            this.lbl_department.Name = "lbl_department";
            this.lbl_department.Size = new System.Drawing.Size(71, 19);
            this.lbl_department.TabIndex = 13;
            this.lbl_department.Text = "Abteilung:";
            // 
            // lbl_phoneNumber
            // 
            this.lbl_phoneNumber.AutoSize = true;
            this.lbl_phoneNumber.Location = new System.Drawing.Point(30, 138);
            this.lbl_phoneNumber.Name = "lbl_phoneNumber";
            this.lbl_phoneNumber.Size = new System.Drawing.Size(107, 19);
            this.lbl_phoneNumber.TabIndex = 14;
            this.lbl_phoneNumber.Text = "Telefonnummer:";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(30, 173);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(60, 19);
            this.lbl_address.TabIndex = 15;
            this.lbl_address.Text = "Adresse:";
            // 
            // lbl_money
            // 
            this.lbl_money.AutoSize = true;
            this.lbl_money.Location = new System.Drawing.Point(30, 208);
            this.lbl_money.Name = "lbl_money";
            this.lbl_money.Size = new System.Drawing.Size(125, 19);
            this.lbl_money.TabIndex = 16;
            this.lbl_money.Text = "Verdienst / h (in €):";
            // 
            // lbl_hours
            // 
            this.lbl_hours.AutoSize = true;
            this.lbl_hours.Location = new System.Drawing.Point(30, 243);
            this.lbl_hours.Name = "lbl_hours";
            this.lbl_hours.Size = new System.Drawing.Size(130, 19);
            this.lbl_hours.TabIndex = 17;
            this.lbl_hours.Text = "Stunden pro Monat";
            // 
            // NewWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 301);
            this.Controls.Add(this.lbl_hours);
            this.Controls.Add(this.lbl_money);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.lbl_phoneNumber);
            this.Controls.Add(this.lbl_department);
            this.Controls.Add(this.lbl_lastname);
            this.Controls.Add(this.lbl_firstname);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txBx_hours);
            this.Controls.Add(this.txBx_money);
            this.Controls.Add(this.txBx_phoneNumber);
            this.Controls.Add(this.txBx_department);
            this.Controls.Add(this.txBx_address);
            this.Controls.Add(this.txBx_lastname);
            this.Controls.Add(this.txBx_firstname);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewWorker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewWorker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txBx_firstname;
        private TextBox txBx_lastname;
        private TextBox txBx_address;
        private TextBox txBx_department;
        private TextBox txBx_phoneNumber;
        private TextBox txBx_money;
        private TextBox txBx_hours;
        private Button btn_save;
        private Button btn_back;
        private Label lbl_firstname;
        private Label lbl_lastname;
        private Label lbl_department;
        private Label lbl_phoneNumber;
        private Label lbl_address;
        private Label lbl_money;
        private Label lbl_hours;
    }
}