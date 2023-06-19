namespace _3IT_Höller_Jahresprojekt
{
    partial class MissingHours
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MissingHours));
            this.liBx_name = new System.Windows.Forms.ListBox();
            this.liBx_missingHours = new System.Windows.Forms.ListBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // liBx_name
            // 
            this.liBx_name.FormattingEnabled = true;
            this.liBx_name.ItemHeight = 17;
            this.liBx_name.Location = new System.Drawing.Point(30, 30);
            this.liBx_name.Name = "liBx_name";
            this.liBx_name.Size = new System.Drawing.Size(660, 21);
            this.liBx_name.TabIndex = 0;
            // 
            // liBx_missingHours
            // 
            this.liBx_missingHours.FormattingEnabled = true;
            this.liBx_missingHours.ItemHeight = 17;
            this.liBx_missingHours.Location = new System.Drawing.Point(30, 65);
            this.liBx_missingHours.Name = "liBx_missingHours";
            this.liBx_missingHours.Size = new System.Drawing.Size(660, 310);
            this.liBx_missingHours.TabIndex = 1;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(715, 30);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(90, 28);
            this.btn_back.TabIndex = 2;
            this.btn_back.Text = "Zurück";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // MissingHours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 418);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.liBx_missingHours);
            this.Controls.Add(this.liBx_name);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MissingHours";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jahresprojekt - Fehlstunden anzeigen";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox liBx_name;
        private ListBox liBx_missingHours;
        private Button btn_back;
    }
}