namespace _3IT_Höller_Jahresprojekt
{
    partial class All
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(All));
            this.coBx_name = new System.Windows.Forms.ComboBox();
            this.liBx_all = new System.Windows.Forms.ListBox();
            this.btn_show = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // coBx_name
            // 
            this.coBx_name.FormattingEnabled = true;
            this.coBx_name.Location = new System.Drawing.Point(27, 29);
            this.coBx_name.Name = "coBx_name";
            this.coBx_name.Size = new System.Drawing.Size(660, 25);
            this.coBx_name.TabIndex = 0;
            // 
            // liBx_all
            // 
            this.liBx_all.FormattingEnabled = true;
            this.liBx_all.ItemHeight = 17;
            this.liBx_all.Location = new System.Drawing.Point(27, 78);
            this.liBx_all.Name = "liBx_all";
            this.liBx_all.Size = new System.Drawing.Size(660, 344);
            this.liBx_all.TabIndex = 1;
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(715, 422);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(90, 28);
            this.btn_show.TabIndex = 2;
            this.btn_show.Text = "Anzeigen";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(715, 25);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(90, 28);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "Zurück";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // All
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 478);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.liBx_all);
            this.Controls.Add(this.coBx_name);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "All";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zeiterfassungssoftware - Alle Daten ausgeben";
            this.Load += new System.EventHandler(this.All_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox coBx_name;
        private ListBox liBx_all;
        private Button btn_show;
        private Button btn_back;
    }
}