namespace _3IT_Höller_Jahresprojekt
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.liBx_name = new System.Windows.Forms.ListBox();
            this.cobx_timespan = new System.Windows.Forms.ComboBox();
            this.libx_payment = new System.Windows.Forms.ListBox();
            this.btn_show = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // liBx_name
            // 
            this.liBx_name.FormattingEnabled = true;
            this.liBx_name.ItemHeight = 17;
            this.liBx_name.Location = new System.Drawing.Point(30, 30);
            this.liBx_name.Name = "liBx_name";
            this.liBx_name.Size = new System.Drawing.Size(550, 21);
            this.liBx_name.TabIndex = 0;
            // 
            // cobx_timespan
            // 
            this.cobx_timespan.FormattingEnabled = true;
            this.cobx_timespan.Items.AddRange(new object[] {
            "Erarbeitetes Gehalt des heutigen Tages",
            "Erarbeitetes Gehalt dieses Monats",
            "Erarbeitetes Gehalt dieses Jahres"});
            this.cobx_timespan.Location = new System.Drawing.Point(30, 80);
            this.cobx_timespan.Name = "cobx_timespan";
            this.cobx_timespan.Size = new System.Drawing.Size(550, 25);
            this.cobx_timespan.TabIndex = 1;
            // 
            // libx_payment
            // 
            this.libx_payment.FormattingEnabled = true;
            this.libx_payment.ItemHeight = 17;
            this.libx_payment.Location = new System.Drawing.Point(30, 130);
            this.libx_payment.Name = "libx_payment";
            this.libx_payment.Size = new System.Drawing.Size(550, 208);
            this.libx_payment.TabIndex = 2;
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(610, 300);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(90, 28);
            this.btn_show.TabIndex = 3;
            this.btn_show.Text = "Anzeigen";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(610, 30);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(90, 28);
            this.btn_back.TabIndex = 4;
            this.btn_back.Text = "Zurück";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 351);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.libx_payment);
            this.Controls.Add(this.cobx_timespan);
            this.Controls.Add(this.liBx_name);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jahresprojekt - erarbeitetes Gehalt bzw. erarbeiteten Lohn ausgeben";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox liBx_name;
        private ComboBox cobx_timespan;
        private ListBox libx_payment;
        private Button btn_show;
        private Button btn_back;
    }
}