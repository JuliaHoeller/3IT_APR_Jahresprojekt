namespace _3IT_Höller_Jahresprojekt
{
    partial class NotHere
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotHere));
            this.liBx_name = new System.Windows.Forms.ListBox();
            this.txBx_dateMissing = new System.Windows.Forms.TextBox();
            this.txBx_startMissing = new System.Windows.Forms.TextBox();
            this.txBx_endMissing = new System.Windows.Forms.TextBox();
            this.cobx_cause = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_dateMissing = new System.Windows.Forms.Label();
            this.lbl_startMissing = new System.Windows.Forms.Label();
            this.lbl_EndMissing = new System.Windows.Forms.Label();
            this.lbl_causeMissing = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // liBx_name
            // 
            this.liBx_name.FormattingEnabled = true;
            this.liBx_name.ItemHeight = 17;
            this.liBx_name.Location = new System.Drawing.Point(30, 30);
            this.liBx_name.Name = "liBx_name";
            this.liBx_name.Size = new System.Drawing.Size(400, 21);
            this.liBx_name.TabIndex = 0;
            // 
            // txBx_dateMissing
            // 
            this.txBx_dateMissing.Location = new System.Drawing.Point(164, 90);
            this.txBx_dateMissing.Name = "txBx_dateMissing";
            this.txBx_dateMissing.Size = new System.Drawing.Size(230, 25);
            this.txBx_dateMissing.TabIndex = 1;
            // 
            // txBx_startMissing
            // 
            this.txBx_startMissing.Location = new System.Drawing.Point(164, 145);
            this.txBx_startMissing.Name = "txBx_startMissing";
            this.txBx_startMissing.Size = new System.Drawing.Size(230, 25);
            this.txBx_startMissing.TabIndex = 2;
            // 
            // txBx_endMissing
            // 
            this.txBx_endMissing.Location = new System.Drawing.Point(164, 180);
            this.txBx_endMissing.Name = "txBx_endMissing";
            this.txBx_endMissing.Size = new System.Drawing.Size(230, 25);
            this.txBx_endMissing.TabIndex = 3;
            // 
            // cobx_cause
            // 
            this.cobx_cause.FormattingEnabled = true;
            this.cobx_cause.Items.AddRange(new object[] {
            "Krankenstand",
            "Urlaub",
            "Fortbildung",
            "Zeitausgleich",
            "Arztbesuch",
            "Sonstiges"});
            this.cobx_cause.Location = new System.Drawing.Point(164, 235);
            this.cobx_cause.Name = "cobx_cause";
            this.cobx_cause.Size = new System.Drawing.Size(230, 25);
            this.cobx_cause.TabIndex = 4;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(480, 235);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(90, 28);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "Speichern";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(480, 28);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(90, 28);
            this.btn_back.TabIndex = 6;
            this.btn_back.Text = "Zurück";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_dateMissing
            // 
            this.lbl_dateMissing.AutoSize = true;
            this.lbl_dateMissing.Location = new System.Drawing.Point(30, 93);
            this.lbl_dateMissing.Name = "lbl_dateMissing";
            this.lbl_dateMissing.Size = new System.Drawing.Size(54, 19);
            this.lbl_dateMissing.TabIndex = 7;
            this.lbl_dateMissing.Text = "Datum:";
            // 
            // lbl_startMissing
            // 
            this.lbl_startMissing.AutoSize = true;
            this.lbl_startMissing.Location = new System.Drawing.Point(30, 148);
            this.lbl_startMissing.Name = "lbl_startMissing";
            this.lbl_startMissing.Size = new System.Drawing.Size(102, 19);
            this.lbl_startMissing.TabIndex = 8;
            this.lbl_startMissing.Text = "Uhrzeit Beginn:";
            // 
            // lbl_EndMissing
            // 
            this.lbl_EndMissing.AutoSize = true;
            this.lbl_EndMissing.Location = new System.Drawing.Point(30, 183);
            this.lbl_EndMissing.Name = "lbl_EndMissing";
            this.lbl_EndMissing.Size = new System.Drawing.Size(90, 19);
            this.lbl_EndMissing.TabIndex = 9;
            this.lbl_EndMissing.Text = "Uhrzeit Ende:";
            // 
            // lbl_causeMissing
            // 
            this.lbl_causeMissing.AutoSize = true;
            this.lbl_causeMissing.Location = new System.Drawing.Point(30, 238);
            this.lbl_causeMissing.Name = "lbl_causeMissing";
            this.lbl_causeMissing.Size = new System.Drawing.Size(51, 19);
            this.lbl_causeMissing.TabIndex = 10;
            this.lbl_causeMissing.Text = "Grund:";
            // 
            // NotHere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 326);
            this.Controls.Add(this.lbl_causeMissing);
            this.Controls.Add(this.lbl_EndMissing);
            this.Controls.Add(this.lbl_startMissing);
            this.Controls.Add(this.lbl_dateMissing);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.cobx_cause);
            this.Controls.Add(this.txBx_endMissing);
            this.Controls.Add(this.txBx_startMissing);
            this.Controls.Add(this.txBx_dateMissing);
            this.Controls.Add(this.liBx_name);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NotHere";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jahresprojekt - Mitarbeiter als fehlend eintragen";
            this.Load += new System.EventHandler(this.NotHere_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox liBx_name;
        private TextBox txBx_dateMissing;
        private TextBox txBx_startMissing;
        private TextBox txBx_endMissing;
        private ComboBox cobx_cause;
        private Button btn_save;
        private Button btn_back;
        private Label lbl_dateMissing;
        private Label lbl_startMissing;
        private Label lbl_EndMissing;
        private Label lbl_causeMissing;
    }
}