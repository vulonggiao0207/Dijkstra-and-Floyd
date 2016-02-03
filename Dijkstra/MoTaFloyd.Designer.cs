namespace Dijkstra
{
    partial class MoTaFloyd
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BuocChayGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChayTungBuocGroup = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ThoiGianTextBox = new System.Windows.Forms.TextBox();
            this.ChayTuDongButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TiepButton = new System.Windows.Forms.Button();
            this.ChayTungBuocRadio = new System.Windows.Forms.RadioButton();
            this.TruocButton = new System.Windows.Forms.Button();
            this.ChayTungBuocButton = new System.Windows.Forms.Button();
            this.ChayKetQuaGroup = new System.Windows.Forms.GroupBox();
            this.KetQuaTextBox = new System.Windows.Forms.TextBox();
            this.ChayKetQuaRadio = new System.Windows.Forms.RadioButton();
            this.ChayKetQuaButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DenCmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TuCmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TuDongTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quayLạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BuocChayGridView)).BeginInit();
            this.ChayTungBuocGroup.SuspendLayout();
            this.ChayKetQuaGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(536, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 568);
            this.panel1.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.ChayTungBuocGroup);
            this.groupBox2.Controls.Add(this.ChayKetQuaGroup);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 509);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chạy thuật tóan";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BuocChayGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 177);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 329);
            this.panel2.TabIndex = 12;
            // 
            // BuocChayGridView
            // 
            this.BuocChayGridView.AllowUserToAddRows = false;
            this.BuocChayGridView.AllowUserToDeleteRows = false;
            this.BuocChayGridView.BackgroundColor = System.Drawing.Color.White;
            this.BuocChayGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BuocChayGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.BuocChayGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BuocChayGridView.Location = new System.Drawing.Point(0, 0);
            this.BuocChayGridView.MultiSelect = false;
            this.BuocChayGridView.Name = "BuocChayGridView";
            this.BuocChayGridView.ReadOnly = true;
            this.BuocChayGridView.RowHeadersVisible = false;
            this.BuocChayGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BuocChayGridView.Size = new System.Drawing.Size(350, 329);
            this.BuocChayGridView.TabIndex = 15;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Dau";
            this.Column1.HeaderText = "Đầu";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TrungGian";
            this.Column2.HeaderText = "Trung gian";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 85;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Cuoi";
            this.Column3.HeaderText = "Cuối";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ChieuDai";
            this.Column4.HeaderText = "Chiều dài";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ChayTungBuocGroup
            // 
            this.ChayTungBuocGroup.Controls.Add(this.label5);
            this.ChayTungBuocGroup.Controls.Add(this.ThoiGianTextBox);
            this.ChayTungBuocGroup.Controls.Add(this.ChayTuDongButton);
            this.ChayTungBuocGroup.Controls.Add(this.label4);
            this.ChayTungBuocGroup.Controls.Add(this.label3);
            this.ChayTungBuocGroup.Controls.Add(this.TiepButton);
            this.ChayTungBuocGroup.Controls.Add(this.ChayTungBuocRadio);
            this.ChayTungBuocGroup.Controls.Add(this.TruocButton);
            this.ChayTungBuocGroup.Controls.Add(this.ChayTungBuocButton);
            this.ChayTungBuocGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChayTungBuocGroup.Location = new System.Drawing.Point(3, 95);
            this.ChayTungBuocGroup.Name = "ChayTungBuocGroup";
            this.ChayTungBuocGroup.Size = new System.Drawing.Size(350, 82);
            this.ChayTungBuocGroup.TabIndex = 11;
            this.ChayTungBuocGroup.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "s/bước";
            // 
            // ThoiGianTextBox
            // 
            this.ThoiGianTextBox.Location = new System.Drawing.Point(254, 37);
            this.ThoiGianTextBox.MaxLength = 2;
            this.ThoiGianTextBox.Name = "ThoiGianTextBox";
            this.ThoiGianTextBox.Size = new System.Drawing.Size(28, 27);
            this.ThoiGianTextBox.TabIndex = 10;
            this.ThoiGianTextBox.Text = "2";
            // 
            // ChayTuDongButton
            // 
            this.ChayTuDongButton.BackgroundImage = global::Dijkstra.Properties.Resources.playall2;
            this.ChayTuDongButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ChayTuDongButton.Enabled = false;
            this.ChayTuDongButton.Location = new System.Drawing.Point(205, 28);
            this.ChayTuDongButton.Name = "ChayTuDongButton";
            this.ChayTuDongButton.Size = new System.Drawing.Size(45, 45);
            this.ChayTuDongButton.TabIndex = 9;
            this.ChayTuDongButton.UseVisualStyleBackColor = true;
            this.ChayTuDongButton.Click += new System.EventHandler(this.ChayTuDongButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Bứơc:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "0";
            // 
            // TiepButton
            // 
            this.TiepButton.BackgroundImage = global::Dijkstra.Properties.Resources.next;
            this.TiepButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TiepButton.Enabled = false;
            this.TiepButton.Location = new System.Drawing.Point(134, 28);
            this.TiepButton.Name = "TiepButton";
            this.TiepButton.Size = new System.Drawing.Size(45, 45);
            this.TiepButton.TabIndex = 6;
            this.TiepButton.UseVisualStyleBackColor = true;
            this.TiepButton.Click += new System.EventHandler(this.TiepButton_Click);
            // 
            // ChayTungBuocRadio
            // 
            this.ChayTungBuocRadio.AutoSize = true;
            this.ChayTungBuocRadio.Location = new System.Drawing.Point(4, -2);
            this.ChayTungBuocRadio.Name = "ChayTungBuocRadio";
            this.ChayTungBuocRadio.Size = new System.Drawing.Size(154, 26);
            this.ChayTungBuocRadio.TabIndex = 0;
            this.ChayTungBuocRadio.TabStop = true;
            this.ChayTungBuocRadio.Text = "Chạy từng bước";
            this.ChayTungBuocRadio.UseVisualStyleBackColor = true;
            this.ChayTungBuocRadio.CheckedChanged += new System.EventHandler(this.ChayTungBuocRadio_CheckedChanged);
            // 
            // TruocButton
            // 
            this.TruocButton.BackgroundImage = global::Dijkstra.Properties.Resources.last;
            this.TruocButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TruocButton.Enabled = false;
            this.TruocButton.Location = new System.Drawing.Point(15, 28);
            this.TruocButton.Name = "TruocButton";
            this.TruocButton.Size = new System.Drawing.Size(45, 45);
            this.TruocButton.TabIndex = 5;
            this.TruocButton.UseVisualStyleBackColor = true;
            this.TruocButton.Click += new System.EventHandler(this.TruocButton_Click);
            // 
            // ChayTungBuocButton
            // 
            this.ChayTungBuocButton.BackgroundImage = global::Dijkstra.Properties.Resources.step;
            this.ChayTungBuocButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ChayTungBuocButton.Enabled = false;
            this.ChayTungBuocButton.Location = new System.Drawing.Point(73, 28);
            this.ChayTungBuocButton.Name = "ChayTungBuocButton";
            this.ChayTungBuocButton.Size = new System.Drawing.Size(45, 45);
            this.ChayTungBuocButton.TabIndex = 4;
            this.ChayTungBuocButton.UseVisualStyleBackColor = true;
            this.ChayTungBuocButton.Click += new System.EventHandler(this.ChayTungBuocButton_Click);
            // 
            // ChayKetQuaGroup
            // 
            this.ChayKetQuaGroup.Controls.Add(this.KetQuaTextBox);
            this.ChayKetQuaGroup.Controls.Add(this.ChayKetQuaRadio);
            this.ChayKetQuaGroup.Controls.Add(this.ChayKetQuaButton);
            this.ChayKetQuaGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChayKetQuaGroup.Location = new System.Drawing.Point(3, 23);
            this.ChayKetQuaGroup.Name = "ChayKetQuaGroup";
            this.ChayKetQuaGroup.Size = new System.Drawing.Size(350, 72);
            this.ChayKetQuaGroup.TabIndex = 10;
            this.ChayKetQuaGroup.TabStop = false;
            // 
            // KetQuaTextBox
            // 
            this.KetQuaTextBox.BackColor = System.Drawing.Color.White;
            this.KetQuaTextBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.KetQuaTextBox.Location = new System.Drawing.Point(64, 23);
            this.KetQuaTextBox.Multiline = true;
            this.KetQuaTextBox.Name = "KetQuaTextBox";
            this.KetQuaTextBox.ReadOnly = true;
            this.KetQuaTextBox.Size = new System.Drawing.Size(283, 46);
            this.KetQuaTextBox.TabIndex = 5;
            // 
            // ChayKetQuaRadio
            // 
            this.ChayKetQuaRadio.AutoSize = true;
            this.ChayKetQuaRadio.Checked = true;
            this.ChayKetQuaRadio.Location = new System.Drawing.Point(3, -2);
            this.ChayKetQuaRadio.Name = "ChayKetQuaRadio";
            this.ChayKetQuaRadio.Size = new System.Drawing.Size(134, 26);
            this.ChayKetQuaRadio.TabIndex = 4;
            this.ChayKetQuaRadio.TabStop = true;
            this.ChayKetQuaRadio.Text = "Chạy kết quả";
            this.ChayKetQuaRadio.UseVisualStyleBackColor = true;
            this.ChayKetQuaRadio.CheckedChanged += new System.EventHandler(this.ChayKetQuaRadio_CheckedChanged);
            // 
            // ChayKetQuaButton
            // 
            this.ChayKetQuaButton.BackgroundImage = global::Dijkstra.Properties.Resources.play;
            this.ChayKetQuaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ChayKetQuaButton.Location = new System.Drawing.Point(13, 23);
            this.ChayKetQuaButton.Name = "ChayKetQuaButton";
            this.ChayKetQuaButton.Size = new System.Drawing.Size(45, 45);
            this.ChayKetQuaButton.TabIndex = 3;
            this.ChayKetQuaButton.UseVisualStyleBackColor = true;
            this.ChayKetQuaButton.Click += new System.EventHandler(this.ChayKetQuaButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DenCmb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TuCmb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 59);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm đường đi";
            // 
            // DenCmb
            // 
            this.DenCmb.FormattingEnabled = true;
            this.DenCmb.Location = new System.Drawing.Point(189, 25);
            this.DenCmb.Name = "DenCmb";
            this.DenCmb.Size = new System.Drawing.Size(63, 28);
            this.DenCmb.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "đến:";
            // 
            // TuCmb
            // 
            this.TuCmb.FormattingEnabled = true;
            this.TuCmb.Location = new System.Drawing.Point(54, 25);
            this.TuCmb.Name = "TuCmb";
            this.TuCmb.Size = new System.Drawing.Size(63, 28);
            this.TuCmb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ:";
            // 
            // TuDongTimer
            // 
            this.TuDongTimer.Tick += new System.EventHandler(this.TuDongTimer_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quayLạiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(536, 33);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quayLạiToolStripMenuItem
            // 
            this.quayLạiToolStripMenuItem.Name = "quayLạiToolStripMenuItem";
            this.quayLạiToolStripMenuItem.Size = new System.Drawing.Size(96, 29);
            this.quayLạiToolStripMenuItem.Text = "Vẽ đồ thị";
            this.quayLạiToolStripMenuItem.Click += new System.EventHandler(this.quayLạiToolStripMenuItem_Click);
            // 
            // MoTaFloyd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 568);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "MoTaFloyd";
            this.Text = "Mô tả thuật tóan Floyd";
            this.Load += new System.EventHandler(this.MoTaFloyd_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BuocChayGridView)).EndInit();
            this.ChayTungBuocGroup.ResumeLayout(false);
            this.ChayTungBuocGroup.PerformLayout();
            this.ChayKetQuaGroup.ResumeLayout(false);
            this.ChayKetQuaGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView BuocChayGridView;
        private System.Windows.Forms.GroupBox ChayTungBuocGroup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ThoiGianTextBox;
        private System.Windows.Forms.Button ChayTuDongButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button TiepButton;
        private System.Windows.Forms.RadioButton ChayTungBuocRadio;
        private System.Windows.Forms.Button TruocButton;
        private System.Windows.Forms.Button ChayTungBuocButton;
        private System.Windows.Forms.GroupBox ChayKetQuaGroup;
        private System.Windows.Forms.TextBox KetQuaTextBox;
        private System.Windows.Forms.RadioButton ChayKetQuaRadio;
        private System.Windows.Forms.Button ChayKetQuaButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox DenCmb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TuCmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer TuDongTimer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quayLạiToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}