namespace Dijkstra
{
    partial class VeDoThi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DSDuongGrid = new System.Windows.Forms.DataGridView();
            this.DiemDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChieuDai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.XoaDuongButton = new System.Windows.Forms.Button();
            this.SuaDuongButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DSDiemList = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SuaDiemButton = new System.Windows.Forms.Button();
            this.XoaDiemButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.điểmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đườngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đườngCóHướngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đườngVôHướngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.môTảThuậtToánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dijkstraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.floydToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSDuongGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DSDuongGrid);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 222);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 344);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách đừơng đi:";
            // 
            // DSDuongGrid
            // 
            this.DSDuongGrid.AllowUserToAddRows = false;
            this.DSDuongGrid.AllowUserToDeleteRows = false;
            this.DSDuongGrid.BackgroundColor = System.Drawing.Color.White;
            this.DSDuongGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DSDuongGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DiemDau,
            this.Column1,
            this.ChieuDai});
            this.DSDuongGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DSDuongGrid.Location = new System.Drawing.Point(3, 23);
            this.DSDuongGrid.MultiSelect = false;
            this.DSDuongGrid.Name = "DSDuongGrid";
            this.DSDuongGrid.ReadOnly = true;
            this.DSDuongGrid.RowHeadersVisible = false;
            this.DSDuongGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DSDuongGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DSDuongGrid.Size = new System.Drawing.Size(269, 318);
            this.DSDuongGrid.TabIndex = 2;
            // 
            // DiemDau
            // 
            this.DiemDau.DataPropertyName = "DiemDau";
            this.DiemDau.HeaderText = "Đầu";
            this.DiemDau.Name = "DiemDau";
            this.DiemDau.ReadOnly = true;
            this.DiemDau.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DiemDau.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DiemDau.Width = 75;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "DiemCuoi";
            this.Column1.HeaderText = "Cuối";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 75;
            // 
            // ChieuDai
            // 
            this.ChieuDai.DataPropertyName = "ChieuDai";
            this.ChieuDai.HeaderText = "Chiều dài";
            this.ChieuDai.Name = "ChieuDai";
            this.ChieuDai.ReadOnly = true;
            this.ChieuDai.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ChieuDai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ChieuDai.Width = 115;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.XoaDuongButton);
            this.panel1.Controls.Add(this.SuaDuongButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(272, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(81, 318);
            this.panel1.TabIndex = 1;
            // 
            // XoaDuongButton
            // 
            this.XoaDuongButton.Location = new System.Drawing.Point(3, 80);
            this.XoaDuongButton.Name = "XoaDuongButton";
            this.XoaDuongButton.Size = new System.Drawing.Size(75, 30);
            this.XoaDuongButton.TabIndex = 0;
            this.XoaDuongButton.Text = "Xóa";
            this.XoaDuongButton.UseVisualStyleBackColor = true;
            this.XoaDuongButton.Click += new System.EventHandler(this.XoaDuongButton_Click);
            // 
            // SuaDuongButton
            // 
            this.SuaDuongButton.Location = new System.Drawing.Point(3, 31);
            this.SuaDuongButton.Name = "SuaDuongButton";
            this.SuaDuongButton.Size = new System.Drawing.Size(75, 30);
            this.SuaDuongButton.TabIndex = 1;
            this.SuaDuongButton.Text = "Sửa";
            this.SuaDuongButton.UseVisualStyleBackColor = true;
            this.SuaDuongButton.Click += new System.EventHandler(this.SuaDuongButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(534, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 566);
            this.panel2.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DSDiemList);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 222);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách đỉnh:";
            // 
            // DSDiemList
            // 
            this.DSDiemList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DSDiemList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DSDiemList.FormattingEnabled = true;
            this.DSDiemList.ItemHeight = 25;
            this.DSDiemList.Location = new System.Drawing.Point(3, 23);
            this.DSDiemList.Name = "DSDiemList";
            this.DSDiemList.Size = new System.Drawing.Size(269, 196);
            this.DSDiemList.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.SuaDiemButton);
            this.panel3.Controls.Add(this.XoaDiemButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(272, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(81, 196);
            this.panel3.TabIndex = 0;
            // 
            // SuaDiemButton
            // 
            this.SuaDiemButton.Location = new System.Drawing.Point(3, 29);
            this.SuaDiemButton.Name = "SuaDiemButton";
            this.SuaDiemButton.Size = new System.Drawing.Size(75, 30);
            this.SuaDiemButton.TabIndex = 1;
            this.SuaDiemButton.Text = "Sửa";
            this.SuaDiemButton.UseVisualStyleBackColor = true;
            this.SuaDiemButton.Click += new System.EventHandler(this.SuaDiemButton_Click);
            // 
            // XoaDiemButton
            // 
            this.XoaDiemButton.BackColor = System.Drawing.SystemColors.Control;
            this.XoaDiemButton.Location = new System.Drawing.Point(3, 74);
            this.XoaDiemButton.Name = "XoaDiemButton";
            this.XoaDiemButton.Size = new System.Drawing.Size(75, 30);
            this.XoaDiemButton.TabIndex = 0;
            this.XoaDiemButton.Text = "Xóa";
            this.XoaDiemButton.UseVisualStyleBackColor = false;
            this.XoaDiemButton.Click += new System.EventHandler(this.XoaDiemButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.điểmToolStripMenuItem,
            this.đườngToolStripMenuItem,
            this.môTảThuậtToánToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(534, 33);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // điểmToolStripMenuItem
            // 
            this.điểmToolStripMenuItem.Name = "điểmToolStripMenuItem";
            this.điểmToolStripMenuItem.Size = new System.Drawing.Size(84, 29);
            this.điểmToolStripMenuItem.Text = "Vẽ đỉnh";
            this.điểmToolStripMenuItem.Click += new System.EventHandler(this.điểmToolStripMenuItem_Click);
            // 
            // đườngToolStripMenuItem
            // 
            this.đườngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đườngCóHướngToolStripMenuItem,
            this.đườngVôHướngToolStripMenuItem});
            this.đườngToolStripMenuItem.Name = "đườngToolStripMenuItem";
            this.đườngToolStripMenuItem.Size = new System.Drawing.Size(123, 29);
            this.đườngToolStripMenuItem.Text = "Vẽ đường đi";
            // 
            // đườngCóHướngToolStripMenuItem
            // 
            this.đườngCóHướngToolStripMenuItem.Name = "đườngCóHướngToolStripMenuItem";
            this.đườngCóHướngToolStripMenuItem.Size = new System.Drawing.Size(235, 30);
            this.đườngCóHướngToolStripMenuItem.Text = "Đường có hướng";
            this.đườngCóHướngToolStripMenuItem.Click += new System.EventHandler(this.đườngCóHướngToolStripMenuItem_Click);
            // 
            // đườngVôHướngToolStripMenuItem
            // 
            this.đườngVôHướngToolStripMenuItem.Name = "đườngVôHướngToolStripMenuItem";
            this.đườngVôHướngToolStripMenuItem.Size = new System.Drawing.Size(235, 30);
            this.đườngVôHướngToolStripMenuItem.Text = "Đường vô hướng";
            this.đườngVôHướngToolStripMenuItem.Click += new System.EventHandler(this.đườngVôHướngToolStripMenuItem_Click);
            // 
            // môTảThuậtToánToolStripMenuItem
            // 
            this.môTảThuậtToánToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dijkstraToolStripMenuItem,
            this.floydToolStripMenuItem});
            this.môTảThuậtToánToolStripMenuItem.Name = "môTảThuậtToánToolStripMenuItem";
            this.môTảThuậtToánToolStripMenuItem.Size = new System.Drawing.Size(158, 29);
            this.môTảThuậtToánToolStripMenuItem.Text = "Mô tả thuật toán";
            // 
            // dijkstraToolStripMenuItem
            // 
            this.dijkstraToolStripMenuItem.Name = "dijkstraToolStripMenuItem";
            this.dijkstraToolStripMenuItem.Size = new System.Drawing.Size(155, 30);
            this.dijkstraToolStripMenuItem.Text = "Dijkstra";
            this.dijkstraToolStripMenuItem.Click += new System.EventHandler(this.dijkstraToolStripMenuItem_Click);
            // 
            // floydToolStripMenuItem
            // 
            this.floydToolStripMenuItem.Name = "floydToolStripMenuItem";
            this.floydToolStripMenuItem.Size = new System.Drawing.Size(155, 30);
            this.floydToolStripMenuItem.Text = "Floyd";
            this.floydToolStripMenuItem.Click += new System.EventHandler(this.floydToolStripMenuItem_Click);
            // 
            // VeDoThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 566);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "VeDoThi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vẽ đồ thị";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VeDoThi_FormClosed);
            this.Load += new System.EventHandler(this.VeDijkstra_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.VeDijkstra_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.VeDijkstra_MouseMove);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSDuongGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SuaDuongButton;
        private System.Windows.Forms.Button XoaDuongButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem điểmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đườngToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button SuaDiemButton;
        private System.Windows.Forms.Button XoaDiemButton;
        private System.Windows.Forms.DataGridView DSDuongGrid;
        private System.Windows.Forms.ListBox DSDiemList;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChieuDai;
        private System.Windows.Forms.ToolStripMenuItem môTảThuậtToánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đườngCóHướngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đườngVôHướngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dijkstraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem floydToolStripMenuItem;


    }
}