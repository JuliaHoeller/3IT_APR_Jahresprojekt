namespace _3IT_Höller_Jahresprojekt
{
    partial class EditWorker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditWorker));
            this.coBx_name = new System.Windows.Forms.ComboBox();
            this.coBx_change = new System.Windows.Forms.ComboBox();
            this.txBx_new = new System.Windows.Forms.TextBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_change = new System.Windows.Forms.Label();
            this.lbl_new = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // coBx_name
            // 
            this.coBx_name.FormattingEnabled = true;
            this.coBx_name.Location = new System.Drawing.Point(225, 32);
            this.coBx_name.Name = "coBx_name";
            this.coBx_name.Size = new System.Drawing.Size(350, 25);
            this.coBx_name.TabIndex = 0;
            this.coBx_name.SelectedIndexChanged += new System.EventHandler(this.coBx_name_SelectedIndexChanged);
            // 
            // coBx_change
            // 
            this.coBx_change.FormattingEnabled = true;
            this.coBx_change.Items.AddRange(new object[] {
            "Vorname",
            "Nachname",
            "Abteilung",
            "Telefonnummer",
            "Adresse",
            "Verdienst pro Stunde",
            "Stunden pro Monat"});
            this.coBx_change.Location = new System.Drawing.Point(224, 95);
            this.coBx_change.Name = "coBx_change";
            this.coBx_change.Size = new System.Drawing.Size(350, 25);
            this.coBx_change.TabIndex = 1;
            // 
            // txBx_new
            // 
            this.txBx_new.Location = new System.Drawing.Point(225, 158);
            this.txBx_new.Name = "txBx_new";
            this.txBx_new.Size = new System.Drawing.Size(350, 25);
            this.txBx_new.TabIndex = 2;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(395, 236);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(162, 28);
            this.btn_edit.TabIndex = 3;
            this.btn_edit.Text = "Änderungen speichern";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(582, 236);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(123, 28);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "Arbeiter löschen";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(615, 30);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(90, 28);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "Zurück";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(27, 35);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(115, 19);
            this.lbl_name.TabIndex = 6;
            this.lbl_name.Text = "Name / Nummer:";
            // 
            // lbl_change
            // 
            this.lbl_change.AutoSize = true;
            this.lbl_change.Location = new System.Drawing.Point(27, 98);
            this.lbl_change.Name = "lbl_change";
            this.lbl_change.Size = new System.Drawing.Size(166, 19);
            this.lbl_change.TabIndex = 7;
            this.lbl_change.Text = "Der zu verändernde Wert:";
            // 
            // lbl_new
            // 
            this.lbl_new.AutoSize = true;
            this.lbl_new.Location = new System.Drawing.Point(27, 161);
            this.lbl_new.Name = "lbl_new";
            this.lbl_new.Size = new System.Drawing.Size(101, 19);
            this.lbl_new.TabIndex = 8;
            this.lbl_new.Text = "Der neue Wert:";
            // 
            // EditWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 285);
            this.Controls.Add(this.lbl_new);
            this.Controls.Add(this.lbl_change);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.txBx_new);
            this.Controls.Add(this.coBx_change);
            this.Controls.Add(this.coBx_name);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditWorker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jahresprojekt - Mitarbeiter bearbeiten und löschen";
            this.Load += new System.EventHandler(this.Edit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox coBx_name;
        private ComboBox coBx_change;
        private TextBox txBx_new;
        private Button btn_edit;
        private Button btn_delete;
        private Button btn_back;
        private Label lbl_name;
        private Label lbl_change;
        private Label lbl_new;
    }
}