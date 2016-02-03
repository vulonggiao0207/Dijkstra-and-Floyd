using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dijkstra
{
    public partial class SuaDiem : Form
    {
        public string _diem;
        DiemCollection diemCheck = new DiemCollection();
        public SuaDiem(string diem, DiemCollection diemcoll)
        {
            InitializeComponent();
            _diem = diem;
            diemCheck = diemcoll;
            label2.Text = "Sửa tên điểm " + diem.ToString();
            TenDiemTextBox.Text = diem.ToString();
        }
        bool allowclose = true;
        private void LuuButton_Click(object sender, EventArgs e)
        {
            _diem = TenDiemTextBox.Text;
            if (_diem.Trim()=="")
            {
                MessageBox.Show("Không được bỏ trống");
                allowclose = false;
            }
            foreach (Diem diem in diemCheck)
            {
                if (diem.Ten == _diem)
                {
                    MessageBox.Show("Điểm này đã tồn tại. Hãy đặt tên khác");
                    allowclose = false;
                }
            }
          
        }

        private void SuaDiem_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (allowclose != true)
                e.Cancel = true;
            allowclose = true;                
        }
    }
}
