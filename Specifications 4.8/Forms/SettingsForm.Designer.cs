namespace Specifications.Forms
{
    partial class SettingsForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Settings_lbl = new System.Windows.Forms.Label();
            this.techName_lbl = new System.Windows.Forms.Label();
            this.technicianName_txt = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.closesettings_btn = new System.Windows.Forms.Button();
            this.savesettings_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.techName_lbl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.technicianName_txt, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Settings_lbl, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(396, 80);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Settings_lbl
            // 
            this.Settings_lbl.AutoSize = true;
            this.Settings_lbl.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings_lbl.Location = new System.Drawing.Point(0, 0);
            this.Settings_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.Settings_lbl.Name = "Settings_lbl";
            this.Settings_lbl.Size = new System.Drawing.Size(191, 52);
            this.Settings_lbl.TabIndex = 0;
            this.Settings_lbl.Text = "Settings";
            // 
            // techName_lbl
            // 
            this.techName_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.techName_lbl.AutoSize = true;
            this.techName_lbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.techName_lbl.Location = new System.Drawing.Point(3, 57);
            this.techName_lbl.Name = "techName_lbl";
            this.techName_lbl.Size = new System.Drawing.Size(131, 18);
            this.techName_lbl.TabIndex = 1;
            this.techName_lbl.Text = "Technician Name:";
            // 
            // technicianName_txt
            // 
            this.technicianName_txt.Location = new System.Drawing.Point(194, 55);
            this.technicianName_txt.MaxLength = 90;
            this.technicianName_txt.Name = "technicianName_txt";
            this.technicianName_txt.Size = new System.Drawing.Size(194, 20);
            this.technicianName_txt.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.closesettings_btn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.savesettings_btn, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(208, 98);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 62);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // closesettings_btn
            // 
            this.closesettings_btn.AutoSize = true;
            this.closesettings_btn.BackColor = System.Drawing.Color.Silver;
            this.closesettings_btn.Location = new System.Drawing.Point(3, 3);
            this.closesettings_btn.Name = "closesettings_btn";
            this.closesettings_btn.Size = new System.Drawing.Size(94, 56);
            this.closesettings_btn.TabIndex = 0;
            this.closesettings_btn.Text = "Close";
            this.closesettings_btn.UseVisualStyleBackColor = false;
            this.closesettings_btn.Click += new System.EventHandler(this.CloseSettings);
            // 
            // savesettings_btn
            // 
            this.savesettings_btn.BackColor = System.Drawing.Color.Silver;
            this.savesettings_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.savesettings_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.savesettings_btn.Location = new System.Drawing.Point(103, 3);
            this.savesettings_btn.Name = "savesettings_btn";
            this.savesettings_btn.Size = new System.Drawing.Size(94, 56);
            this.savesettings_btn.TabIndex = 1;
            this.savesettings_btn.Text = "Save";
            this.savesettings_btn.UseVisualStyleBackColor = false;
            this.savesettings_btn.Click += new System.EventHandler(this.SaveSettings);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(410, 170);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Settings ";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Settings_lbl;
        private System.Windows.Forms.Label techName_lbl;
        private System.Windows.Forms.TextBox technicianName_txt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button closesettings_btn;
        private System.Windows.Forms.Button savesettings_btn;
    }
}