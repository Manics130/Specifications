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
            this.settings_btn = new System.Windows.Forms.Button();
            this.newproject_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // settings_btn
            // 
            this.settings_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.settings_btn.Location = new System.Drawing.Point(467, 12);
            this.settings_btn.Name = "settings_btn";
            this.settings_btn.Size = new System.Drawing.Size(150, 38);
            this.settings_btn.TabIndex = 0;
            this.settings_btn.Text = "Settings";
            this.settings_btn.UseVisualStyleBackColor = true;
            this.settings_btn.Click += new System.EventHandler(this.OpenSettings);
            // 
            // newproject_btn
            // 
            this.newproject_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.newproject_btn.Location = new System.Drawing.Point(12, 12);
            this.newproject_btn.Name = "newproject_btn";
            this.newproject_btn.Size = new System.Drawing.Size(176, 38);
            this.newproject_btn.TabIndex = 1;
            this.newproject_btn.Text = "New Project";
            this.newproject_btn.UseVisualStyleBackColor = true;
            this.newproject_btn.Click += new System.EventHandler(this.CreateNewProject);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 436);
            this.Controls.Add(this.newproject_btn);
            this.Controls.Add(this.settings_btn);
            this.Name = "MenuForm";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button settings_btn;
        private System.Windows.Forms.Button newproject_btn;
    }
}