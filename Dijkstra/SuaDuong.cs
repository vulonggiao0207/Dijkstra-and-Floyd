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
    public partial class SuaDuong : Form
    {
        public string diemdau = "";
        public string diemcuoi = "";
        public int chieudai = 0;
        DuongThangCollection duongcoll = new DuongThangCollection();

        public SuaDuong(string _diemdau,string _diemcuoi,int _chieudai,DuongThangCollection _duongcoll)
        {
            InitializeComponent();
            diemdau = _diemdau;
            diemcuoi = _diemcuoi;
            chieudai = _chieudai;
            ChieuDaiTextBox.Text = chieudai.ToString();
            duongcoll = _duongcoll;
        }
        bool allowclose=true;

        private void LuuButton_Click(object sender, EventArgs e)
        {
  /*          if (ChieuDaiTextBox.Text.Contains('-'))
            {
                MessageBox.Show("Không đựơc nhập số âm");
                allowclose = false;
            }*/
            chieudai = Convert.ToInt32(ChieuDaiTextBox.Text);

        }

        private void ChieuDaiTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) )
            {
                e.Handled = true;
            }
        }

        private void SuaDuong_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (allowclose != true)
                e.Cancel = true;
            allowclose = true;
        }

        private void SuaDuong_Load(object sender, EventArgs e)
        {
            label2.Text="Sửa chiều dài đường "+diemdau+"-"+diemcuoi;
            foreach(DuongThang dt in duongcoll)
                if(dt.DiemCuoi.Ten==diemdau&&dt.DiemDau.Ten==diemcuoi)
                    label2.Text+=" và "+diemcuoi+"-"+diemdau;
            
        }
    }
}
