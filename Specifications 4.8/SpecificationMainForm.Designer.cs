namespace Specifications_4._8
{
    partial class SpecificationMainForm
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
            this.BeadingType_dropdown = new System.Windows.Forms.ComboBox();
            this.BeadingType_lbl = new System.Windows.Forms.Label();
            this.GlassType_dropdown = new System.Windows.Forms.ComboBox();
            this.GlassType_lbl = new System.Windows.Forms.Label();
            this.HingeType_dropdown = new System.Windows.Forms.ComboBox();
            this.HingeType_lbl = new System.Windows.Forms.Label();
            this.OpeningSide_dropdown = new System.Windows.Forms.ComboBox();
            this.OpenSide_lbl = new System.Windows.Forms.Label();
            this.LockType_dropdown = new System.Windows.Forms.ComboBox();
            this.LockType_lbl = new System.Windows.Forms.Label();
            this.Ironmongery_dropdown = new System.Windows.Forms.ComboBox();
            this.Ironmongery_lbl = new System.Windows.Forms.Label();
            this.IronFinish_dropdown = new System.Windows.Forms.ComboBox();
            this.IronFinish_lbl = new System.Windows.Forms.Label();
            this.FrameColour_dropdown = new System.Windows.Forms.ComboBox();
            this.FrameColour_lbl = new System.Windows.Forms.Label();
            this.MasterLeaf_dropdown = new System.Windows.Forms.ComboBox();
            this.MasterLeaf_lbl = new System.Windows.Forms.Label();
            this.BeadingSide_dropdown = new System.Windows.Forms.ComboBox();
            this.BeadingSide_lbl = new System.Windows.Forms.Label();
            this.ViewedFrom_dropdown = new System.Windows.Forms.ComboBox();
            this.ViewedFrom_lbl = new System.Windows.Forms.Label();
            this.ItemTypes_dropdown = new System.Windows.Forms.ComboBox();
            this.Type_lbl = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Placements_dropdown = new System.Windows.Forms.ComboBox();
            this.Quantity_lbl = new System.Windows.Forms.Label();
            this.Placement_lbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.RefNo_lbl = new System.Windows.Forms.Label();
            this.Specification_tab = new System.Windows.Forms.TabControl();
            this.Specifications_tab = new System.Windows.Forms.TabPage();
            this.ViewData_tab = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ConsoleLine = new System.Windows.Forms.Label();
            this.Specification_tab.SuspendLayout();
            this.Specifications_tab.SuspendLayout();
            this.ViewData_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BeadingType_dropdown
            // 
            this.BeadingType_dropdown.AllowDrop = true;
            this.BeadingType_dropdown.DisplayMember = "Internal";
            this.BeadingType_dropdown.FormattingEnabled = true;
            this.BeadingType_dropdown.Location = new System.Drawing.Point(96, 220);
            this.BeadingType_dropdown.Name = "BeadingType_dropdown";
            this.BeadingType_dropdown.Size = new System.Drawing.Size(220, 21);
            this.BeadingType_dropdown.TabIndex = 58;
            this.BeadingType_dropdown.ValueMember = "Internal";
            this.BeadingType_dropdown.SelectedIndexChanged += new System.EventHandler(this.DropdownList_Changed);
            // 
            // BeadingType_lbl
            // 
            this.BeadingType_lbl.AutoSize = true;
            this.BeadingType_lbl.Location = new System.Drawing.Point(19, 223);
            this.BeadingType_lbl.Name = "BeadingType_lbl";
            this.BeadingType_lbl.Size = new System.Drawing.Size(73, 13);
            this.BeadingType_lbl.TabIndex = 57;
            this.BeadingType_lbl.Text = "Beading Type";
            // 
            // GlassType_dropdown
            // 
            this.GlassType_dropdown.AllowDrop = true;
            this.GlassType_dropdown.FormattingEnabled = true;
            this.GlassType_dropdown.Location = new System.Drawing.Point(406, 191);
            this.GlassType_dropdown.Name = "GlassType_dropdown";
            this.GlassType_dropdown.Size = new System.Drawing.Size(220, 21);
            this.GlassType_dropdown.TabIndex = 56;
            this.GlassType_dropdown.SelectedIndexChanged += new System.EventHandler(this.DropdownList_Changed);
            // 
            // GlassType_lbl
            // 
            this.GlassType_lbl.AutoSize = true;
            this.GlassType_lbl.Location = new System.Drawing.Point(329, 193);
            this.GlassType_lbl.Name = "GlassType_lbl";
            this.GlassType_lbl.Size = new System.Drawing.Size(33, 13);
            this.GlassType_lbl.TabIndex = 55;
            this.GlassType_lbl.Text = "Glass";
            // 
            // HingeType_dropdown
            // 
            this.HingeType_dropdown.AllowDrop = true;
            this.HingeType_dropdown.FormattingEnabled = true;
            this.HingeType_dropdown.Location = new System.Drawing.Point(96, 191);
            this.HingeType_dropdown.Name = "HingeType_dropdown";
            this.HingeType_dropdown.Size = new System.Drawing.Size(220, 21);
            this.HingeType_dropdown.TabIndex = 54;
            this.HingeType_dropdown.SelectedIndexChanged += new System.EventHandler(this.DropdownList_Changed);
            // 
            // HingeType_lbl
            // 
            this.HingeType_lbl.AutoSize = true;
            this.HingeType_lbl.Location = new System.Drawing.Point(19, 193);
            this.HingeType_lbl.Name = "HingeType_lbl";
            this.HingeType_lbl.Size = new System.Drawing.Size(40, 13);
            this.HingeType_lbl.TabIndex = 53;
            this.HingeType_lbl.Text = "Hinges";
            // 
            // OpeningSide_dropdown
            // 
            this.OpeningSide_dropdown.AllowDrop = true;
            this.OpeningSide_dropdown.FormattingEnabled = true;
            this.OpeningSide_dropdown.Location = new System.Drawing.Point(405, 68);
            this.OpeningSide_dropdown.Name = "OpeningSide_dropdown";
            this.OpeningSide_dropdown.Size = new System.Drawing.Size(220, 21);
            this.OpeningSide_dropdown.TabIndex = 51;
            this.OpeningSide_dropdown.SelectedIndexChanged += new System.EventHandler(this.DropdownList_Changed);
            // 
            // OpenSide_lbl
            // 
            this.OpenSide_lbl.AutoSize = true;
            this.OpenSide_lbl.Location = new System.Drawing.Point(328, 71);
            this.OpenSide_lbl.Name = "OpenSide_lbl";
            this.OpenSide_lbl.Size = new System.Drawing.Size(77, 13);
            this.OpenSide_lbl.TabIndex = 52;
            this.OpenSide_lbl.Text = "Open Towards";
            // 
            // LockType_dropdown
            // 
            this.LockType_dropdown.AllowDrop = true;
            this.LockType_dropdown.FormattingEnabled = true;
            this.LockType_dropdown.Location = new System.Drawing.Point(96, 161);
            this.LockType_dropdown.Name = "LockType_dropdown";
            this.LockType_dropdown.Size = new System.Drawing.Size(220, 21);
            this.LockType_dropdown.TabIndex = 50;
            this.LockType_dropdown.SelectedIndexChanged += new System.EventHandler(this.DropdownList_Changed);
            // 
            // LockType_lbl
            // 
            this.LockType_lbl.AutoSize = true;
            this.LockType_lbl.Location = new System.Drawing.Point(19, 164);
            this.LockType_lbl.Name = "LockType_lbl";
            this.LockType_lbl.Size = new System.Drawing.Size(58, 13);
            this.LockType_lbl.TabIndex = 49;
            this.LockType_lbl.Text = "Lock Type";
            // 
            // Ironmongery_dropdown
            // 
            this.Ironmongery_dropdown.AllowDrop = true;
            this.Ironmongery_dropdown.FormattingEnabled = true;
            this.Ironmongery_dropdown.Location = new System.Drawing.Point(405, 159);
            this.Ironmongery_dropdown.Name = "Ironmongery_dropdown";
            this.Ironmongery_dropdown.Size = new System.Drawing.Size(220, 21);
            this.Ironmongery_dropdown.TabIndex = 47;
            this.Ironmongery_dropdown.SelectedIndexChanged += new System.EventHandler(this.DropdownList_Changed);
            // 
            // Ironmongery_lbl
            // 
            this.Ironmongery_lbl.AutoSize = true;
            this.Ironmongery_lbl.Location = new System.Drawing.Point(328, 162);
            this.Ironmongery_lbl.Name = "Ironmongery_lbl";
            this.Ironmongery_lbl.Size = new System.Drawing.Size(65, 13);
            this.Ironmongery_lbl.TabIndex = 48;
            this.Ironmongery_lbl.Text = "Ironmongery";
            // 
            // IronFinish_dropdown
            // 
            this.IronFinish_dropdown.AllowDrop = true;
            this.IronFinish_dropdown.FormattingEnabled = true;
            this.IronFinish_dropdown.Location = new System.Drawing.Point(95, 130);
            this.IronFinish_dropdown.Name = "IronFinish_dropdown";
            this.IronFinish_dropdown.Size = new System.Drawing.Size(220, 21);
            this.IronFinish_dropdown.TabIndex = 46;
            this.IronFinish_dropdown.SelectedIndexChanged += new System.EventHandler(this.DropdownList_Changed);
            // 
            // IronFinish_lbl
            // 
            this.IronFinish_lbl.AutoSize = true;
            this.IronFinish_lbl.Location = new System.Drawing.Point(18, 133);
            this.IronFinish_lbl.Name = "IronFinish_lbl";
            this.IronFinish_lbl.Size = new System.Drawing.Size(55, 13);
            this.IronFinish_lbl.TabIndex = 45;
            this.IronFinish_lbl.Text = "Iron Finish";
            // 
            // FrameColour_dropdown
            // 
            this.FrameColour_dropdown.AllowDrop = true;
            this.FrameColour_dropdown.FormattingEnabled = true;
            this.FrameColour_dropdown.Location = new System.Drawing.Point(406, 127);
            this.FrameColour_dropdown.Name = "FrameColour_dropdown";
            this.FrameColour_dropdown.Size = new System.Drawing.Size(220, 21);
            this.FrameColour_dropdown.TabIndex = 43;
            this.FrameColour_dropdown.SelectedIndexChanged += new System.EventHandler(this.DropdownList_Changed);
            // 
            // FrameColour_lbl
            // 
            this.FrameColour_lbl.AutoSize = true;
            this.FrameColour_lbl.Location = new System.Drawing.Point(329, 130);
            this.FrameColour_lbl.Name = "FrameColour_lbl";
            this.FrameColour_lbl.Size = new System.Drawing.Size(69, 13);
            this.FrameColour_lbl.TabIndex = 44;
            this.FrameColour_lbl.Text = "Frame Colour";
            // 
            // MasterLeaf_dropdown
            // 
            this.MasterLeaf_dropdown.AllowDrop = true;
            this.MasterLeaf_dropdown.FormattingEnabled = true;
            this.MasterLeaf_dropdown.Location = new System.Drawing.Point(96, 98);
            this.MasterLeaf_dropdown.Name = "MasterLeaf_dropdown";
            this.MasterLeaf_dropdown.Size = new System.Drawing.Size(220, 21);
            this.MasterLeaf_dropdown.TabIndex = 42;
            this.MasterLeaf_dropdown.SelectedIndexChanged += new System.EventHandler(this.DropdownList_Changed);
            // 
            // MasterLeaf_lbl
            // 
            this.MasterLeaf_lbl.AutoSize = true;
            this.MasterLeaf_lbl.Location = new System.Drawing.Point(19, 100);
            this.MasterLeaf_lbl.Name = "MasterLeaf_lbl";
            this.MasterLeaf_lbl.Size = new System.Drawing.Size(63, 13);
            this.MasterLeaf_lbl.TabIndex = 41;
            this.MasterLeaf_lbl.Text = "Master Leaf";
            // 
            // BeadingSide_dropdown
            // 
            this.BeadingSide_dropdown.AllowDrop = true;
            this.BeadingSide_dropdown.FormattingEnabled = true;
            this.BeadingSide_dropdown.Location = new System.Drawing.Point(405, 98);
            this.BeadingSide_dropdown.Name = "BeadingSide_dropdown";
            this.BeadingSide_dropdown.Size = new System.Drawing.Size(220, 21);
            this.BeadingSide_dropdown.TabIndex = 39;
            this.BeadingSide_dropdown.SelectedIndexChanged += new System.EventHandler(this.DropdownList_Changed);
            // 
            // BeadingSide_lbl
            // 
            this.BeadingSide_lbl.AutoSize = true;
            this.BeadingSide_lbl.Location = new System.Drawing.Point(328, 100);
            this.BeadingSide_lbl.Name = "BeadingSide_lbl";
            this.BeadingSide_lbl.Size = new System.Drawing.Size(70, 13);
            this.BeadingSide_lbl.TabIndex = 40;
            this.BeadingSide_lbl.Text = "Beading Side";
            // 
            // ViewedFrom_dropdown
            // 
            this.ViewedFrom_dropdown.AllowDrop = true;
            this.ViewedFrom_dropdown.FormattingEnabled = true;
            this.ViewedFrom_dropdown.Location = new System.Drawing.Point(404, 39);
            this.ViewedFrom_dropdown.Name = "ViewedFrom_dropdown";
            this.ViewedFrom_dropdown.Size = new System.Drawing.Size(220, 21);
            this.ViewedFrom_dropdown.TabIndex = 37;
            this.ViewedFrom_dropdown.SelectedIndexChanged += new System.EventHandler(this.DropdownList_Changed);
            // 
            // ViewedFrom_lbl
            // 
            this.ViewedFrom_lbl.AutoSize = true;
            this.ViewedFrom_lbl.Location = new System.Drawing.Point(327, 42);
            this.ViewedFrom_lbl.Name = "ViewedFrom_lbl";
            this.ViewedFrom_lbl.Size = new System.Drawing.Size(68, 13);
            this.ViewedFrom_lbl.TabIndex = 38;
            this.ViewedFrom_lbl.Text = "Viewed From";
            // 
            // ItemTypes_dropdown
            // 
            this.ItemTypes_dropdown.AllowDrop = true;
            this.ItemTypes_dropdown.FormattingEnabled = true;
            this.ItemTypes_dropdown.Location = new System.Drawing.Point(95, 68);
            this.ItemTypes_dropdown.Name = "ItemTypes_dropdown";
            this.ItemTypes_dropdown.Size = new System.Drawing.Size(220, 21);
            this.ItemTypes_dropdown.TabIndex = 36;
            this.ItemTypes_dropdown.SelectedIndexChanged += new System.EventHandler(this.DropdownList_Changed);
            // 
            // Type_lbl
            // 
            this.Type_lbl.AutoSize = true;
            this.Type_lbl.Location = new System.Drawing.Point(18, 71);
            this.Type_lbl.Name = "Type_lbl";
            this.Type_lbl.Size = new System.Drawing.Size(31, 13);
            this.Type_lbl.TabIndex = 32;
            this.Type_lbl.Text = "Type";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(404, 11);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(50, 20);
            this.textBox2.TabIndex = 34;
            // 
            // Placements_dropdown
            // 
            this.Placements_dropdown.AllowDrop = true;
            this.Placements_dropdown.FormattingEnabled = true;
            this.Placements_dropdown.Location = new System.Drawing.Point(95, 39);
            this.Placements_dropdown.Name = "Placements_dropdown";
            this.Placements_dropdown.Size = new System.Drawing.Size(220, 21);
            this.Placements_dropdown.TabIndex = 35;
            this.Placements_dropdown.SelectedIndexChanged += new System.EventHandler(this.DropdownList_Changed);
            // 
            // Quantity_lbl
            // 
            this.Quantity_lbl.AutoSize = true;
            this.Quantity_lbl.Location = new System.Drawing.Point(327, 14);
            this.Quantity_lbl.Name = "Quantity_lbl";
            this.Quantity_lbl.Size = new System.Drawing.Size(46, 13);
            this.Quantity_lbl.TabIndex = 31;
            this.Quantity_lbl.Text = "Quantity";
            // 
            // Placement_lbl
            // 
            this.Placement_lbl.AutoSize = true;
            this.Placement_lbl.Location = new System.Drawing.Point(18, 42);
            this.Placement_lbl.Name = "Placement_lbl";
            this.Placement_lbl.Size = new System.Drawing.Size(57, 13);
            this.Placement_lbl.TabIndex = 30;
            this.Placement_lbl.Text = "Placement";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 20);
            this.textBox1.TabIndex = 33;
            // 
            // RefNo_lbl
            // 
            this.RefNo_lbl.AutoSize = true;
            this.RefNo_lbl.Location = new System.Drawing.Point(18, 14);
            this.RefNo_lbl.Name = "RefNo_lbl";
            this.RefNo_lbl.Size = new System.Drawing.Size(47, 13);
            this.RefNo_lbl.TabIndex = 29;
            this.RefNo_lbl.Text = "Ref. No.";
            // 
            // Specification_tab
            // 
            this.Specification_tab.Controls.Add(this.Specifications_tab);
            this.Specification_tab.Controls.Add(this.ViewData_tab);
            this.Specification_tab.Location = new System.Drawing.Point(0, 0);
            this.Specification_tab.Name = "Specification_tab";
            this.Specification_tab.SelectedIndex = 0;
            this.Specification_tab.Size = new System.Drawing.Size(653, 430);
            this.Specification_tab.TabIndex = 60;
            // 
            // Specifications_tab
            // 
            this.Specifications_tab.Controls.Add(this.RefNo_lbl);
            this.Specifications_tab.Controls.Add(this.BeadingType_dropdown);
            this.Specifications_tab.Controls.Add(this.textBox1);
            this.Specifications_tab.Controls.Add(this.BeadingType_lbl);
            this.Specifications_tab.Controls.Add(this.Placement_lbl);
            this.Specifications_tab.Controls.Add(this.GlassType_dropdown);
            this.Specifications_tab.Controls.Add(this.Quantity_lbl);
            this.Specifications_tab.Controls.Add(this.GlassType_lbl);
            this.Specifications_tab.Controls.Add(this.Placements_dropdown);
            this.Specifications_tab.Controls.Add(this.HingeType_dropdown);
            this.Specifications_tab.Controls.Add(this.textBox2);
            this.Specifications_tab.Controls.Add(this.HingeType_lbl);
            this.Specifications_tab.Controls.Add(this.Type_lbl);
            this.Specifications_tab.Controls.Add(this.OpeningSide_dropdown);
            this.Specifications_tab.Controls.Add(this.ItemTypes_dropdown);
            this.Specifications_tab.Controls.Add(this.OpenSide_lbl);
            this.Specifications_tab.Controls.Add(this.ViewedFrom_lbl);
            this.Specifications_tab.Controls.Add(this.LockType_dropdown);
            this.Specifications_tab.Controls.Add(this.ViewedFrom_dropdown);
            this.Specifications_tab.Controls.Add(this.LockType_lbl);
            this.Specifications_tab.Controls.Add(this.BeadingSide_lbl);
            this.Specifications_tab.Controls.Add(this.Ironmongery_dropdown);
            this.Specifications_tab.Controls.Add(this.BeadingSide_dropdown);
            this.Specifications_tab.Controls.Add(this.Ironmongery_lbl);
            this.Specifications_tab.Controls.Add(this.MasterLeaf_lbl);
            this.Specifications_tab.Controls.Add(this.IronFinish_dropdown);
            this.Specifications_tab.Controls.Add(this.MasterLeaf_dropdown);
            this.Specifications_tab.Controls.Add(this.IronFinish_lbl);
            this.Specifications_tab.Controls.Add(this.FrameColour_lbl);
            this.Specifications_tab.Controls.Add(this.FrameColour_dropdown);
            this.Specifications_tab.Location = new System.Drawing.Point(4, 22);
            this.Specifications_tab.Name = "Specifications_tab";
            this.Specifications_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Specifications_tab.Size = new System.Drawing.Size(645, 404);
            this.Specifications_tab.TabIndex = 0;
            this.Specifications_tab.Text = "Specifications";
            this.Specifications_tab.UseVisualStyleBackColor = true;
            // 
            // ViewData_tab
            // 
            this.ViewData_tab.Controls.Add(this.ConsoleLine);
            this.ViewData_tab.Controls.Add(this.dataGridView1);
            this.ViewData_tab.Location = new System.Drawing.Point(4, 22);
            this.ViewData_tab.Name = "ViewData_tab";
            this.ViewData_tab.Padding = new System.Windows.Forms.Padding(3);
            this.ViewData_tab.Size = new System.Drawing.Size(645, 404);
            this.ViewData_tab.TabIndex = 1;
            this.ViewData_tab.Text = "View Data";
            this.ViewData_tab.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(619, 351);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += SelectionChanged;
            this.dataGridView1.MultiSelectChanged += MultiSelectionChanged;
            this.dataGridView1.CellLeave += CellLeft;
            // 
            // ConsoleLine
            // 
            this.ConsoleLine.AutoSize = true;
            this.ConsoleLine.Location = new System.Drawing.Point(35, 12);
            this.ConsoleLine.Name = "ConsoleLine";
            this.ConsoleLine.Size = new System.Drawing.Size(35, 13);
            this.ConsoleLine.TabIndex = 1;
            this.ConsoleLine.Text = "label1";
            // 
            // SpecificationMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 429);
            this.Controls.Add(this.Specification_tab);
            this.Name = "SpecificationMainForm";
            this.Text = "Specifications";
            this.Specification_tab.ResumeLayout(false);
            this.Specifications_tab.ResumeLayout(false);
            this.Specifications_tab.PerformLayout();
            this.ViewData_tab.ResumeLayout(false);
            this.ViewData_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox BeadingType_dropdown;
        private System.Windows.Forms.Label BeadingType_lbl;
        private System.Windows.Forms.ComboBox GlassType_dropdown;
        private System.Windows.Forms.Label GlassType_lbl;
        private System.Windows.Forms.ComboBox HingeType_dropdown;
        private System.Windows.Forms.Label HingeType_lbl;
        private System.Windows.Forms.ComboBox OpeningSide_dropdown;
        private System.Windows.Forms.Label OpenSide_lbl;
        private System.Windows.Forms.ComboBox LockType_dropdown;
        private System.Windows.Forms.Label LockType_lbl;
        private System.Windows.Forms.ComboBox Ironmongery_dropdown;
        private System.Windows.Forms.Label Ironmongery_lbl;
        private System.Windows.Forms.ComboBox IronFinish_dropdown;
        private System.Windows.Forms.Label IronFinish_lbl;
        private System.Windows.Forms.ComboBox FrameColour_dropdown;
        private System.Windows.Forms.Label FrameColour_lbl;
        private System.Windows.Forms.ComboBox MasterLeaf_dropdown;
        private System.Windows.Forms.Label MasterLeaf_lbl;
        private System.Windows.Forms.ComboBox BeadingSide_dropdown;
        private System.Windows.Forms.Label BeadingSide_lbl;
        private System.Windows.Forms.ComboBox ViewedFrom_dropdown;
        private System.Windows.Forms.Label ViewedFrom_lbl;
        private System.Windows.Forms.ComboBox ItemTypes_dropdown;
        private System.Windows.Forms.Label Type_lbl;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox Placements_dropdown;
        private System.Windows.Forms.Label Quantity_lbl;
        private System.Windows.Forms.Label Placement_lbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label RefNo_lbl;
        private System.Windows.Forms.TabControl Specification_tab;
        private System.Windows.Forms.TabPage Specifications_tab;
        private System.Windows.Forms.TabPage ViewData_tab;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label ConsoleLine;
    }
}