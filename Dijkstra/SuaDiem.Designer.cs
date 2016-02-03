namespace Dijkstra
{
    partial class SuaDiem
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
            this.label1 = new System.Windows.Forms.Label();
            this.TenDiemTextBox = new System.Windows.Forms.TextBox();
            this.LuuButton = new System.Windows.Forms.Button();
            this.ThoatButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên điểm mới:";
            // 
            // TenDiemTextBox
            // 
            this.TenDiemTextBox.Location = new System.Drawing.Point(139, 43);
            this.TenDiemTextBox.MaxLength = 2;
            this.TenDiemTextBox.Name = "TenDiemTextBox";
            this.TenDiemTextBox.Size = new System.Drawing.Size(214, 27);
            this.TenDiemTextBox.TabIndex = 1;
            // 
            // LuuButton
            // 
            this.LuuButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.LuuButton.Location = new System.Drawing.Point(215, 90);
            this.LuuButton.Name = "LuuButton";
            this.LuuButton.Size = new System.Drawing.Size(66, 30);
            this.LuuButton.TabIndex = 2;
            this.LuuButton.Text = "Lưu";
            this.LuuButton.UseVisualStyleBackColor = true;
            this.LuuButton.Click += new System.EventHandler(this.LuuButton_Click);
            // 
            // ThoatButton
            // 
            this.ThoatButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ThoatButton.Location = new System.Drawing.Point(287, 90);
            this.ThoatButton.Name = "ThoatButton";
            this.ThoatButton.Size = new System.Drawing.Size(66, 30);
            this.ThoatButton.TabIndex = 3;
            this.ThoatButton.Text = "Thóat";
            this.ThoatButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 22);
            this.label2.TabIndex = 4;
            // 
            // SuaDiem
            // 
            this.AcceptButton = this.LuuButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ThoatButton;
            this.ClientSize = new System.Drawing.Size(365, 132);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ThoatButton);
            this.Controls.Add(this.LuuButton);
            this.Controls.Add(this.TenDiemTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "SuaDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sửa tên đỉnh";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SuaDiem_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TenDiemTextBox;
        private System.Windows.Forms.Button LuuButton;
        private System.Windows.Forms.Button ThoatButton;
        private System.Windows.Forms.Label label2;
    }
}