namespace Specifications
{
    partial class NewProject
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
            this.techname_lbl = new System.Windows.Forms.Label();
            this.techname_txt = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.folderlocation_lbl = new System.Windows.Forms.Label();
            this.jobnumber_lbl = new System.Windows.Forms.Label();
            this.folder_panel = new System.Windows.Forms.Panel();
            this.folderdirectory_lbl = new System.Windows.Forms.RichTextBox();
            this.openfile_btn = new System.Windows.Forms.Button();
            this.jobnumber_txt = new System.Windows.Forms.TextBox();
            this.elevations_lbl = new System.Windows.Forms.Label();
            this.elevations_txt = new System.Windows.Forms.TextBox();
            this.confirm_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.openprojectfolder_dialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel2.SuspendLayout();
            this.folder_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // techname_lbl
            // 
            this.techname_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.techname_lbl.AutoSize = true;
            this.techname_lbl.Location = new System.Drawing.Point(3, 6);
            this.techname_lbl.Name = "techname_lbl";
            this.techname_lbl.Size = new System.Drawing.Size(91, 13);
            this.techname_lbl.TabIndex = 0;
            this.techname_lbl.Text = "Technician Name";
            // 
            // techname_txt
            // 
            this.techname_txt.BackColor = System.Drawing.SystemColors.Window;
            this.techname_txt.Location = new System.Drawing.Point(100, 3);
            this.techname_txt.MaxLength = 90;
            this.techname_txt.Name = "techname_txt";
            this.techname_txt.Size = new System.Drawing.Size(199, 20);
            this.techname_txt.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.folderlocation_lbl, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.techname_txt, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.techname_lbl, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.jobnumber_lbl, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.folder_panel, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.jobnumber_txt, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.elevations_lbl, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.elevations_txt, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(20, 20);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(302, 115);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // folderlocation_lbl
            // 
            this.folderlocation_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.folderlocation_lbl.AutoSize = true;
            this.folderlocation_lbl.Location = new System.Drawing.Point(3, 88);
            this.folderlocation_lbl.Name = "folderlocation_lbl";
            this.folderlocation_lbl.Size = new System.Drawing.Size(80, 13);
            this.folderlocation_lbl.TabIndex = 7;
            this.folderlocation_lbl.Text = "Folder Location";
            this.folderlocation_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // jobnumber_lbl
            // 
            this.jobnumber_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.jobnumber_lbl.AutoSize = true;
            this.jobnumber_lbl.Location = new System.Drawing.Point(3, 31);
            this.jobnumber_lbl.Name = "jobnumber_lbl";
            this.jobnumber_lbl.Size = new System.Drawing.Size(64, 13);
            this.jobnumber_lbl.TabIndex = 2;
            this.jobnumber_lbl.Text = "Job Number";
            // 
            // folder_panel
            // 
            this.folder_panel.Controls.Add(this.folderdirectory_lbl);
            this.folder_panel.Controls.Add(this.openfile_btn);
            this.folder_panel.Location = new System.Drawing.Point(100, 78);
            this.folder_panel.Name = "folder_panel";
            this.folder_panel.Size = new System.Drawing.Size(199, 34);
            this.folder_panel.TabIndex = 10;
            // 
            // folderdirectory_lbl
            // 
            this.folderdirectory_lbl.Location = new System.Drawing.Point(31, 0);
            this.folderdirectory_lbl.Name = "folderdirectory_lbl";
            this.folderdirectory_lbl.Size = new System.Drawing.Size(164, 30);
            this.folderdirectory_lbl.TabIndex = 12;
            this.folderdirectory_lbl.Text = "";
            // 
            // openfile_btn
            // 
            this.openfile_btn.BackColor = System.Drawing.SystemColors.Window;
            this.openfile_btn.BackgroundImage = global::Specifications.Properties.Resources.folderIcon1;
            this.openfile_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openfile_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openfile_btn.ForeColor = System.Drawing.Color.White;
            this.openfile_btn.Location = new System.Drawing.Point(4, 7);
            this.openfile_btn.Name = "openfile_btn";
            this.openfile_btn.Size = new System.Drawing.Size(23, 19);
            this.openfile_btn.TabIndex = 8;
            this.openfile_btn.UseVisualStyleBackColor = false;
            this.openfile_btn.Click += new System.EventHandler(this.openfile_btn_Click);
            // 
            // jobnumber_txt
            // 
            this.jobnumber_txt.BackColor = System.Drawing.SystemColors.Window;
            this.jobnumber_txt.Location = new System.Drawing.Point(100, 28);
            this.jobnumber_txt.MaxLength = 90;
            this.jobnumber_txt.Name = "jobnumber_txt";
            this.jobnumber_txt.Size = new System.Drawing.Size(199, 20);
            this.jobnumber_txt.TabIndex = 3;
            // 
            // elevations_lbl
            // 
            this.elevations_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.elevations_lbl.AutoSize = true;
            this.elevations_lbl.Location = new System.Drawing.Point(3, 56);
            this.elevations_lbl.Name = "elevations_lbl";
            this.elevations_lbl.Size = new System.Drawing.Size(56, 13);
            this.elevations_lbl.TabIndex = 4;
            this.elevations_lbl.Text = "Elevations";
            // 
            // elevations_txt
            // 
            this.elevations_txt.BackColor = System.Drawing.SystemColors.Window;
            this.elevations_txt.Location = new System.Drawing.Point(100, 53);
            this.elevations_txt.MaxLength = 90;
            this.elevations_txt.Name = "elevations_txt";
            this.elevations_txt.Size = new System.Drawing.Size(199, 20);
            this.elevations_txt.TabIndex = 5;
            // 
            // confirm_btn
            // 
            this.confirm_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_btn.Location = new System.Drawing.Point(20, 149);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(127, 34);
            this.confirm_btn.TabIndex = 7;
            this.confirm_btn.Text = "Confirm";
            this.confirm_btn.UseVisualStyleBackColor = true;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.Location = new System.Drawing.Point(195, 149);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(127, 34);
            this.cancel_btn.TabIndex = 8;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            // 
            // openprojectfolder_dialog
            // 
            this.openprojectfolder_dialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // NewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(331, 188);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.confirm_btn);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(500, 500);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewProject";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "Create Project";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.folder_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label techname_lbl;
        private System.Windows.Forms.TextBox techname_txt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label jobnumber_lbl;
        private System.Windows.Forms.TextBox jobnumber_txt;
        private System.Windows.Forms.Label elevations_lbl;
        private System.Windows.Forms.TextBox elevations_txt;
        private System.Windows.Forms.Button confirm_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.FolderBrowserDialog openprojectfolder_dialog;
        private System.Windows.Forms.Label folderlocation_lbl;
        private System.Windows.Forms.Button openfile_btn;
        private System.Windows.Forms.Panel folder_panel;
        private System.Windows.Forms.RichTextBox folderdirectory_lbl;
    }
}