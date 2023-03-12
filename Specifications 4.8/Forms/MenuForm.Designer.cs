namespace Specifications.Forms
{
    partial class MenuForm
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
            System.Windows.Forms.Panel Background;
            System.Windows.Forms.Panel LefthandPanel;
            System.Windows.Forms.TableLayoutPanel lefthandtable_panel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.techname_lbl = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            Background = new System.Windows.Forms.Panel();
            LefthandPanel = new System.Windows.Forms.Panel();
            lefthandtable_panel = new System.Windows.Forms.TableLayoutPanel();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            Background.SuspendLayout();
            LefthandPanel.SuspendLayout();
            lefthandtable_panel.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Background
            // 
            Background.Controls.Add(LefthandPanel);
            Background.Controls.Add(this.flowLayoutPanel3);
            Background.Controls.Add(this.flowLayoutPanel1);
            Background.Dock = System.Windows.Forms.DockStyle.Fill;
            Background.Location = new System.Drawing.Point(0, 0);
            Background.Name = "Background";
            Background.Size = new System.Drawing.Size(849, 571);
            Background.TabIndex = 2;
            // 
            // LefthandPanel
            // 
            LefthandPanel.BackColor = System.Drawing.Color.Gainsboro;
            LefthandPanel.Controls.Add(lefthandtable_panel);
            LefthandPanel.Dock = System.Windows.Forms.DockStyle.Left;
            LefthandPanel.Location = new System.Drawing.Point(0, 46);
            LefthandPanel.Margin = new System.Windows.Forms.Padding(0);
            LefthandPanel.Name = "LefthandPanel";
            LefthandPanel.Size = new System.Drawing.Size(146, 505);
            LefthandPanel.TabIndex = 6;
            // 
            // lefthandtable_panel
            // 
            lefthandtable_panel.AutoSize = true;
            lefthandtable_panel.ColumnCount = 1;
            lefthandtable_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            lefthandtable_panel.Controls.Add(this.flowLayoutPanel2, 0, 0);
            lefthandtable_panel.Controls.Add(this.flowLayoutPanel4, 0, 3);
            lefthandtable_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            lefthandtable_panel.Location = new System.Drawing.Point(0, 0);
            lefthandtable_panel.Margin = new System.Windows.Forms.Padding(0);
            lefthandtable_panel.Name = "lefthandtable_panel";
            lefthandtable_panel.RowCount = 5;
            lefthandtable_panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            lefthandtable_panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            lefthandtable_panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            lefthandtable_panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            lefthandtable_panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            lefthandtable_panel.Size = new System.Drawing.Size(146, 505);
            lefthandtable_panel.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.Controls.Add(label1);
            this.flowLayoutPanel2.Controls.Add(this.button1);
            this.flowLayoutPanel2.Controls.Add(this.button2);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(10, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(125, 113);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Cursor = System.Windows.Forms.Cursors.Default;
            label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(25, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(76, 32);
            label1.TabIndex = 0;
            label1.Text = "Start";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "New Project";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.Gold;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(3, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "Open Project";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel4.Controls.Add(label3);
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(0, 113);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(146, 384);
            this.flowLayoutPanel4.TabIndex = 6;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Cursor = System.Windows.Forms.Cursors.Default;
            label3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(3, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(130, 32);
            label3.TabIndex = 0;
            label3.Text = "Previous";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.Gainsboro;
            this.flowLayoutPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel3.Controls.Add(label2);
            this.flowLayoutPanel3.Controls.Add(this.techname_lbl);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 551);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(849, 20);
            this.flowLayoutPanel3.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(3, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(131, 18);
            label2.TabIndex = 0;
            label2.Text = "Technician Name:";
            // 
            // techname_lbl
            // 
            this.techname_lbl.AutoSize = true;
            this.techname_lbl.Font = new System.Drawing.Font("Arial", 12F);
            this.techname_lbl.Location = new System.Drawing.Point(140, 0);
            this.techname_lbl.Name = "techname_lbl";
            this.techname_lbl.Size = new System.Drawing.Size(80, 18);
            this.techname_lbl.TabIndex = 1;
            this.techname_lbl.Text = "tech name";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Gainsboro;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(849, 46);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 571);
            this.Controls.Add(Background);
            this.Name = "MenuForm";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            Background.ResumeLayout(false);
            LefthandPanel.ResumeLayout(false);
            LefthandPanel.PerformLayout();
            lefthandtable_panel.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label techname_lbl;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
    }
}