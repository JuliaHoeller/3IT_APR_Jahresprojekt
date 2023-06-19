namespace _3IT_Höller_Jahresprojekt
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.coBx_name = new System.Windows.Forms.ComboBox();
            this.txBx_start = new System.Windows.Forms.TextBox();
            this.txBx_end = new System.Windows.Forms.TextBox();
            this.txBx_date = new System.Windows.Forms.TextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_saveAll = new System.Windows.Forms.Button();
            this.btn_missingHours = new System.Windows.Forms.Button();
            this.btn_all = new System.Windows.Forms.Button();
            this.btn_newWorker = new System.Windows.Forms.Button();
            this.btn_editWorker = new System.Windows.Forms.Button();
            this.btn_payment = new System.Windows.Forms.Button();
            this.btn_notHere = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_start = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.btn_newUser = new System.Windows.Forms.Button();
            this.btn_editUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // coBx_name
            // 
            this.coBx_name.FormattingEnabled = true;
            this.coBx_name.Location = new System.Drawing.Point(178, 32);
            this.coBx_name.Name = "coBx_name";
            this.coBx_name.Size = new System.Drawing.Size(350, 25);
            this.coBx_name.TabIndex = 0;
            this.coBx_name.SelectedIndexChanged += new System.EventHandler(this.coBx_name_SelectedIndexChanged);
            // 
            // txBx_start
            // 
            this.txBx_start.Location = new System.Drawing.Point(178, 85);
            this.txBx_start.Name = "txBx_start";
            this.txBx_start.Size = new System.Drawing.Size(350, 25);
            this.txBx_start.TabIndex = 1;
            // 
            // txBx_end
            // 
            this.txBx_end.Location = new System.Drawing.Point(178, 115);
            this.txBx_end.Name = "txBx_end";
            this.txBx_end.Size = new System.Drawing.Size(350, 25);
            this.txBx_end.TabIndex = 2;
            // 
            // txBx_date
            // 
            this.txBx_date.Location = new System.Drawing.Point(178, 168);
            this.txBx_date.Name = "txBx_date";
            this.txBx_date.Size = new System.Drawing.Size(350, 25);
            this.txBx_date.TabIndex = 3;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(545, 30);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(90, 28);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Beenden";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(545, 65);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(90, 28);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "Speichern";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_saveAll
            // 
            this.btn_saveAll.Location = new System.Drawing.Point(473, 325);
            this.btn_saveAll.Name = "btn_saveAll";
            this.btn_saveAll.Size = new System.Drawing.Size(162, 28);
            this.btn_saveAll.TabIndex = 6;
            this.btn_saveAll.Text = "Alle Daten speichern";
            this.btn_saveAll.UseVisualStyleBackColor = true;
            this.btn_saveAll.Click += new System.EventHandler(this.btn_saveAll_Click);
            // 
            // btn_missingHours
            // 
            this.btn_missingHours.Location = new System.Drawing.Point(194, 290);
            this.btn_missingHours.Name = "btn_missingHours";
            this.btn_missingHours.Size = new System.Drawing.Size(129, 28);
            this.btn_missingHours.TabIndex = 10;
            this.btn_missingHours.Text = "Alle Fehlstunden";
            this.btn_missingHours.UseVisualStyleBackColor = true;
            this.btn_missingHours.Click += new System.EventHandler(this.btn_missingHours_Click);
            // 
            // btn_all
            // 
            this.btn_all.Location = new System.Drawing.Point(194, 325);
            this.btn_all.Name = "btn_all";
            this.btn_all.Size = new System.Drawing.Size(129, 28);
            this.btn_all.TabIndex = 11;
            this.btn_all.Text = "Alle Ergebnisse";
            this.btn_all.UseVisualStyleBackColor = true;
            this.btn_all.Click += new System.EventHandler(this.btn_all_Click);
            // 
            // btn_newWorker
            // 
            this.btn_newWorker.Location = new System.Drawing.Point(28, 222);
            this.btn_newWorker.Name = "btn_newWorker";
            this.btn_newWorker.Size = new System.Drawing.Size(124, 28);
            this.btn_newWorker.TabIndex = 12;
            this.btn_newWorker.Text = "Neuer Arbeiter";
            this.btn_newWorker.UseVisualStyleBackColor = true;
            this.btn_newWorker.Click += new System.EventHandler(this.btn_newWorker_Click);
            // 
            // btn_editWorker
            // 
            this.btn_editWorker.Location = new System.Drawing.Point(27, 256);
            this.btn_editWorker.Name = "btn_editWorker";
            this.btn_editWorker.Size = new System.Drawing.Size(124, 28);
            this.btn_editWorker.TabIndex = 13;
            this.btn_editWorker.Text = "Arbeiter ändern";
            this.btn_editWorker.UseVisualStyleBackColor = true;
            this.btn_editWorker.Click += new System.EventHandler(this.btn_editWorker_Click);
            // 
            // btn_payment
            // 
            this.btn_payment.Location = new System.Drawing.Point(28, 290);
            this.btn_payment.Name = "btn_payment";
            this.btn_payment.Size = new System.Drawing.Size(162, 28);
            this.btn_payment.TabIndex = 14;
            this.btn_payment.Text = "Bezahlung ausrechnen";
            this.btn_payment.UseVisualStyleBackColor = true;
            this.btn_payment.Click += new System.EventHandler(this.btn_payment_Click);
            // 
            // btn_notHere
            // 
            this.btn_notHere.Location = new System.Drawing.Point(28, 325);
            this.btn_notHere.Name = "btn_notHere";
            this.btn_notHere.Size = new System.Drawing.Size(162, 28);
            this.btn_notHere.TabIndex = 15;
            this.btn_notHere.Text = "Als Fehlend eintragen";
            this.btn_notHere.UseVisualStyleBackColor = true;
            this.btn_notHere.Click += new System.EventHandler(this.btn_notHere_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(27, 35);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(115, 19);
            this.lbl_name.TabIndex = 16;
            this.lbl_name.Text = "Name / Nummer:";
            // 
            // lbl_start
            // 
            this.lbl_start.AutoSize = true;
            this.lbl_start.Location = new System.Drawing.Point(27, 88);
            this.lbl_start.Name = "lbl_start";
            this.lbl_start.Size = new System.Drawing.Size(146, 19);
            this.lbl_start.TabIndex = 17;
            this.lbl_start.Text = "Beginn der Arbeitszeit:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ende der Arbeitszeit:";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(27, 171);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(54, 19);
            this.lbl_date.TabIndex = 19;
            this.lbl_date.Text = "Datum:";
            // 
            // btn_newUser
            // 
            this.btn_newUser.Location = new System.Drawing.Point(534, 290);
            this.btn_newUser.Name = "btn_newUser";
            this.btn_newUser.Size = new System.Drawing.Size(101, 28);
            this.btn_newUser.TabIndex = 20;
            this.btn_newUser.Text = "Neuer User";
            this.btn_newUser.UseVisualStyleBackColor = true;
            this.btn_newUser.Click += new System.EventHandler(this.btn_newUser_Click);
            // 
            // btn_editUser
            // 
            this.btn_editUser.Location = new System.Drawing.Point(534, 256);
            this.btn_editUser.Name = "btn_editUser";
            this.btn_editUser.Size = new System.Drawing.Size(101, 28);
            this.btn_editUser.TabIndex = 21;
            this.btn_editUser.Text = "User ändern";
            this.btn_editUser.UseVisualStyleBackColor = true;
            this.btn_editUser.Click += new System.EventHandler(this.btn_editUser_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 391);
            this.Controls.Add(this.btn_editUser);
            this.Controls.Add(this.btn_newUser);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_start);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.btn_notHere);
            this.Controls.Add(this.btn_payment);
            this.Controls.Add(this.btn_editWorker);
            this.Controls.Add(this.btn_newWorker);
            this.Controls.Add(this.btn_all);
            this.Controls.Add(this.btn_missingHours);
            this.Controls.Add(this.btn_saveAll);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.txBx_date);
            this.Controls.Add(this.txBx_end);
            this.Controls.Add(this.txBx_start);
            this.Controls.Add(this.coBx_name);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zeiterfassungssoftware - Jahresprojekt von Julia Höller - 3ITK";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox coBx_name;
        private TextBox txBx_start;
        private TextBox txBx_end;
        private TextBox txBx_date;
        private Button btn_exit;
        private Button btn_save;
        private Button btn_saveAll;
        private Button btn_missingHours;
        private Button btn_all;
        private Button btn_newWorker;
        private Button btn_editWorker;
        private Button btn_payment;
        private Button btn_notHere;
        private Label lbl_name;
        private Label lbl_start;
        private Label label3;
        private Label lbl_date;
        private Button btn_newUser;
        private Button btn_editUser;
    }
}