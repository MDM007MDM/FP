namespace ProjectRoom
{
    partial class Admin
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grid_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_major = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_datein = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grid_name,
            this.grid_lastname,
            this.grid_id,
            this.grid_major,
            this.grid_level,
            this.grid_datein});
            this.dataGridView1.Location = new System.Drawing.Point(14, 36);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(963, 548);
            this.dataGridView1.TabIndex = 0;
            // 
            // grid_name
            // 
            this.grid_name.HeaderText = "ชื่อ";
            this.grid_name.MinimumWidth = 6;
            this.grid_name.Name = "grid_name";
            this.grid_name.ReadOnly = true;
            this.grid_name.Width = 120;
            // 
            // grid_lastname
            // 
            this.grid_lastname.HeaderText = "นามสกุล";
            this.grid_lastname.MinimumWidth = 6;
            this.grid_lastname.Name = "grid_lastname";
            this.grid_lastname.ReadOnly = true;
            this.grid_lastname.Width = 120;
            // 
            // grid_id
            // 
            this.grid_id.HeaderText = "รหัสนักศึกษา";
            this.grid_id.MinimumWidth = 6;
            this.grid_id.Name = "grid_id";
            this.grid_id.ReadOnly = true;
            this.grid_id.Width = 120;
            // 
            // grid_major
            // 
            this.grid_major.HeaderText = "สาขา";
            this.grid_major.MinimumWidth = 6;
            this.grid_major.Name = "grid_major";
            this.grid_major.ReadOnly = true;
            this.grid_major.Width = 120;
            // 
            // grid_level
            // 
            this.grid_level.HeaderText = "ชั้นปี";
            this.grid_level.MinimumWidth = 6;
            this.grid_level.Name = "grid_level";
            this.grid_level.ReadOnly = true;
            this.grid_level.Width = 120;
            // 
            // grid_datein
            // 
            this.grid_datein.HeaderText = "เวลาเข้าใช้งาน";
            this.grid_datein.MinimumWidth = 6;
            this.grid_datein.Name = "grid_datein";
            this.grid_datein.ReadOnly = true;
            this.grid_datein.Width = 200;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(862, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click_1);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click_1);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 600);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Admin";
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem backToolStripMenuItem;
        private DataGridViewTextBoxColumn grid_name;
        private DataGridViewTextBoxColumn grid_lastname;
        private DataGridViewTextBoxColumn grid_id;
        private DataGridViewTextBoxColumn grid_major;
        private DataGridViewTextBoxColumn grid_level;
        private DataGridViewTextBoxColumn grid_datein;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
    }
}