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
    public partial class MoTaDijkstra : Form
    {
        private static DiemCollection diemColl = new DiemCollection();
        private static  DuongThangCollection duongColl = new DuongThangCollection();   
        int[,] MaTranTrongSo;
        #region Thao tác control
        bool CoHuong = true;
        public MoTaDijkstra(DiemCollection _diemcoll, DuongThangCollection _duongthangcoll,bool _cohuong)
        {
            diemColl = _diemcoll;
            duongColl = _duongthangcoll;
            CoHuong = _cohuong;
            MaTranTrongSo = new int[diemColl.Count, diemColl.Count];
            InitializeComponent();
        }
        private void MoTaThuatToan_Load(object sender, EventArgs e)
        {

            Point point = new Point(Application.OpenForms[0].Location.X, Application.OpenForms[0].Location.Y);
            this.Location = point;

            if (diemColl.Count != 0)
            {
                TuCmb.DisplayMember = "Ten";
                TuCmb.ValueMember = "Ten";
                BindingSource bd = new BindingSource();
                bd.DataSource = diemColl;
                TuCmb.DataSource = bd;

                BindingSource bd1 = new BindingSource();
                bd1.DataSource = diemColl;
                DenCmb.DisplayMember = "Ten";
                DenCmb.ValueMember = "Ten";
                DenCmb.DataSource = bd1;
            }
        }
        private void TuCmb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void DenCmb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void ChayKetQuaRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (ChayKetQuaRadio.Checked == true)
            {
                ChayTungBuocRadio.Checked = false;
                ChayKetQuaButton.Enabled = true;
                ChayTungBuocButton.Enabled = false;
                TruocButton.Enabled = false;
                TiepButton.Enabled = false;
                ChayTuDongButton.Enabled = false;
                ChayTungBuocButton.BackgroundImage = (System.Drawing.Bitmap)(Properties.Resources.play);
                ChayTuDongButton.BackgroundImage = (System.Drawing.Bitmap)(Properties.Resources.playall2);
                DangChayTungBuoc = false;
                dangchaytudong = false;
                CachVe = "TatCa";
                TuCmb.Enabled = true;
                DenCmb.Enabled = true;
                Invalidate();
            }
            else
            {
                ChayTungBuocRadio.Checked = true;
                ChayKetQuaButton.Enabled = false;
                ChayTungBuocButton.Enabled = true;
                TruocButton.Enabled = true;
                TiepButton.Enabled = true;
                ChayTuDongButton.Enabled = true;
                ChayKetQuaButton.BackgroundImage = (System.Drawing.Bitmap)(Properties.Resources.play);
                DangChay = false;
                //reset
                KetQuaTextBox.Text = "";
        
            }
        }
        private void ChayTungBuocRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (ChayTungBuocRadio.Checked == true)
            {
                ChayKetQuaRadio.Checked = false;
                ChayKetQuaButton.Enabled = false;
                ChayTungBuocButton.Enabled = true;                
                TruocButton.Enabled = true;
                TiepButton.Enabled = true;

                ChayTuDongButton.Enabled = true;
                ChayKetQuaButton.BackgroundImage = (System.Drawing.Bitmap)(Properties.Resources.play);
                DangChay = false;
                CachVe = "TatCa";
                TuCmb.Enabled = true;
                DenCmb.Enabled = true;
                Invalidate();
            }
            else
            {
                ChayKetQuaRadio.Checked = true;
                ChayKetQuaButton.Enabled = true;
                ChayTungBuocButton.Enabled = false;
                TruocButton.Enabled = false;
                TiepButton.Enabled = false;
                ChayTuDongButton.Enabled = false;
                ChayTungBuocButton.BackgroundImage = (System.Drawing.Bitmap)(Properties.Resources.play);
                ChayTuDongButton.BackgroundImage = (System.Drawing.Bitmap)(Properties.Resources.playall2);
                DangChayTungBuoc = false;
                dangchaytudong = false;
                //reset
                dinhdauLabel.Text = "0";
                dinhcuoiLabel.Text = "0";
                chieudaiLabel.Text = "0";
                Buoc = 0;
                label3.Text = "0";
                LuuBuocChay.Clear();
                LuuDiem.Clear();
                LuuDuong.Clear();
                label7.Text = "===đến===>";
                label7.ForeColor = Color.Black;
                BuocChayGridView.DataSource = null;
               
            }
        }
        private void quayLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms[0].Visible = true;
        }
        private void ThoiGianTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ThoiGianTextBox.Text.Trim()==""|| Convert.ToInt32(ThoiGianTextBox.Text) < 2)
                ThoiGianTextBox.Text = "2";
        }
        private void ThoiGianTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion
        #region Vẽ
        public void VeDiem(string ten, int x, int y, Color cl)
        {
            //     PointMove pm = new PointMove();
            Graphics graph = this.CreateGraphics();
            SolidBrush brush = new SolidBrush(cl);
            /*   Pen pen = new Pen(Color.Red);      
               graph.FillEllipse(brush, x, y, 10, 10);*/
            Pen pen = new Pen(Color.Blue);
            graph.FillEllipse(brush, x, y, 10, 10);
            graph.DrawString(ten.ToString(), new Font("Arial", 16), brush, x - 20, y - 20);


        }
        private void VeDuong(Diem diemdau, Diem diemcuoi, Color cl)
        {
            SolidBrush myBrush = new SolidBrush(Color.Green);
            Graphics tengido = this.CreateGraphics();
            Pen pen = new Pen(cl, 3);
            Font font = new Font("Arial", 15, FontStyle.Bold);
            tengido.DrawLine(pen, diemdau.A, diemdau.B, diemcuoi.A, diemcuoi.B);

            //vẽ mũi tên 
            if (CoHuong == true)
            {
                pen.EndCap = System.Drawing.Drawing2D.LineCap.Custom;
                pen.CustomEndCap = new System.Drawing.Drawing2D.AdjustableArrowCap(4, 4, true);
            }
            tengido.DrawLine(pen, diemdau.A, diemdau.B, (diemcuoi.A + diemdau.A) / 2, (diemcuoi.B + diemdau.B) / 2);
            //       tengido.DrawLine(pen, x1, y1, x2, y2);
            //hủy
            pen.Dispose();
            tengido.Dispose();

        }
        string CachVe = "TatCa";
        protected override void OnPaint(PaintEventArgs e)
        {
            ///////////////////////////////////////////vẽ tòan bộ//////////////////////////
            if (CachVe == "DuongDi")
            {
                //Vẽ đường    
                foreach (DuongThang dt in duongColl)
                {
                    VeDuong(dt.DiemDau, dt.DiemCuoi, Color.Green);
                }
                if (ThuTuDuongDi != null)
                {
                    for (int i = 0; i < ThuTuDuongDi.Length-1; i++)
                    {

                        foreach (DuongThang dt in duongColl)
                        {
                            if (dt.DiemDau.Ten == ThuTuDuongDi[i] && dt.DiemCuoi.Ten == ThuTuDuongDi[i + 1])
                            {
                                VeDuong(dt.DiemDau, dt.DiemCuoi, Color.Red);
                                break;
                            }
                        }
                    }
                }
                //vẽ điểm    
                foreach (Diem diem in diemColl)
                {
                    VeDiem(diem.Ten, diem.A, diem.B, Color.Black);
                }
                if (ThuTuDuongDi != null)
                {
                    for (int i = 0; i < ThuTuDuongDi.Length; i++)
                    {
                        foreach (Diem diem in diemColl )
                        {
                            if (diem.Ten == ThuTuDuongDi[i])
                            {
                                VeDiem(diem.Ten, diem.A, diem.B, Color.Blue);
                              
                                break;
                            }
                        }
                    }
                }
            }
            ///////////////////////////////////vẽ từng buớc///////////////////////////////
            else if (CachVe == "TungBuoc")
            {
                
                //Vẽ đường    
                foreach (DuongThang dt in duongColl)
                {
                    VeDuong(dt.DiemDau, dt.DiemCuoi, Color.Green);
                }
                if (ThuTuDuongDi != null)
                {
                    for (int i =0;i< LuuBuocChay.Count; i++)
                    {
                        foreach (DuongThang dt in duongColl)
                        {
                            if (dt.DiemDau.Ten == LuuDuong.Index(Buoc).DiemDau.Ten&&dt.DiemCuoi.Ten==LuuDuong.Index(Buoc).DiemCuoi.Ten)
                            {
                                VeDuong(dt.DiemDau, dt.DiemCuoi, Color.Red);
                                //Xuất chiều dài đường đi
                                dinhdauLabel.Text = dt.DiemDau.Ten;
                                dinhcuoiLabel.Text = dt.DiemCuoi.Ten;
                                chieudaiLabel.Text = dt.ChieuDai.ToString() ;
                           //     break;
                            }

                        }
                    }
                }               
                //vẽ điểm    
                foreach (Diem diem in diemColl)
                {
                    VeDiem(diem.Ten, diem.A, diem.B, Color.Black);
                }
                if (ThuTuDuongDi != null)
                {
                    for (int i = 0; i < LuuBuocChay.Count; i++)
                    {
                        foreach (Diem diem in diemColl)
                        {
                            if (diem.Ten ==LuuDiem.Index(Buoc).Ten)
                            {
                                VeDiem(diem.Ten, diem.A, diem.B, Color.Blue);
                        //        break;
                            }
                        }
                    }
                }
                return;
            }
            /////////////////////////////////vẽ bình thường////////////////////////////
            else
            {
                //Vẽ đường          
                foreach (DuongThang dt in duongColl)
                {
                    VeDuong(dt.DiemDau, dt.DiemCuoi, Color.Green);
                }
                //vẽ điểm    
                foreach (Diem diem in diemColl)
                {
                    //     VeDiem(diem.A, diem.B, Color.Red);
                    VeDiem(diem.Ten, diem.A, diem.B, Color.Black);
                }
            }
        } 
        #endregion
        #region Thuật tóan
        public void TaoMaTranTrongSo()
        {
            for (int i = 0; i < diemColl.Count; i++)
            {
                for (int j = 0; j < diemColl.Count; j++)
                {
                    MaTranTrongSo[i, j] = 0;
                    foreach (DuongThang dt in duongColl)
                    {
                        if (dt.DiemDau.Ten == diemColl.Index(i).Ten && dt.DiemCuoi.Ten == diemColl.Index(j).Ten)
                        {
                            MaTranTrongSo[i, j] = dt.ChieuDai;
                        }
                    }
                }

            }
        }
        //Dijkstra chạy ra kết quả
        public static int max = 100;
        string[] ThuTuDuongDi;
        void RunDijkstra(int n, int D, int C)
        {
            char[] DanhDau = new char[max];
            int[] Nhan = new int[max];
            int[] Truoc = new int[max];
            int XP;
            int min;
            for (int i = 0; i < n; i++)
            {
                Nhan[i] = 1000000;
                DanhDau[i] = '0';
                Truoc[i] = D;
            }
            Nhan[D] = 0;
            DanhDau[D] = '1';
            XP = D;
            int dem = 0;
            while (XP != C)
            {
                //xét đỉnh kề....              
                for (int j = 0; j < n; j++)
                {
                    if (MaTranTrongSo[XP, j] > 0 && Nhan[j] > MaTranTrongSo[XP, j] + Nhan[XP] && DanhDau[j] == '0')
                    {
                        Nhan[j] = MaTranTrongSo[XP, j] + Nhan[XP];
                        Truoc[j] = XP;                  
                    }
                }

                //lấy chiều dài tới đỉnh ngắn nhất, gán XP= đỉnh đó
                min = 1000000;
                for (int j = 0; j < n; j++)
                {
                    if (min > Nhan[j] && DanhDau[j] == '0')
                    {
                        min = Nhan[j];
                        XP = j;
                    }
                }
                DanhDau[XP] = '1';
                dem++;
                if (dem == diemColl.Count)
                {
                    KetQuaTextBox.Text = "Không có đường đi giữa 2 đỉnh";
                    return;
                }
            
            }

            //Xuất đường đi/////////////////////////////
            string chuoi = "";
            chuoi += "Tổng chiều dài đường đi: " + Nhan[C];
            chuoi += "\r\n";
            chuoi += diemColl.Index(C).Ten.ToString() + "<-" + diemColl.Index(Truoc[C]).Ten.ToString();

            int k = Truoc[C];
            while (k != D)
            {
                k = Truoc[k];
                chuoi += "<-" + diemColl.Index(k).Ten.ToString();
            }
            //Đảo chuỗi
            string []chuoidao = chuoi.Split(new string[] { "\r\n", "<-" }, StringSplitOptions.None);
            string kq = "";
            kq += chuoidao[0] + "\r\n";
            ThuTuDuongDi = new string[chuoidao.Length - 1];
            int z = 0;
            for (int i = chuoidao.Length - 1; i >= 1; i--)
            {
                ThuTuDuongDi[z] = chuoidao[i];
                kq += chuoidao[i];
                if(i!=1)
                    kq+= "->";
                z++;
            }
            KetQuaTextBox.Text = kq;
        }        
        //Dijkstra chạy từng bước
        public char[] DanhDau1 = new char[max];
        public int[] Nhan1 = new int[max];
        public int[] Truoc1 = new int[max];
        public int XP1;
        public int min1;
        //Lưu trữ buớc chạy
        List<BangGhiDijkstraCollection> LuuBuocChay = new List<BangGhiDijkstraCollection>();
        DuongThangCollection LuuDuong = new DuongThangCollection();
        DiemCollection LuuDiem = new DiemCollection();
        public void LuuDuongVaDiem(string _diem, string _diemdau, string _diemsau)
        {
            //Lưu đỉêm
            Diem diem = new Diem();
            diem.Ten = _diem;
            LuuDiem.Add(diem);
            //Lưu đường
            DuongThang dt = new DuongThang();
            Diem diemdau = new Diem();
            diemdau.Ten = _diemdau;
            dt.DiemDau = diemdau;

            Diem diemsau = new Diem();
            diemsau.Ten = _diemsau;
            dt.DiemCuoi = diemsau;
            LuuDuong.Add(dt);
        }
        public BangGhiDijkstraCollection TaoBangGhi()
        {
            BangGhiDijkstraCollection bgcoll = new BangGhiDijkstraCollection();           
            for (int i = 0; i < diemColl.Count; i++)
            {
                BangGhiDijkstra gb = new BangGhiDijkstra();
                gb.Nhan = Nhan1[i];
                gb.DanhDau = DanhDau1[i];
                gb.Truoc = diemColl.Index(Truoc1[i]).Ten;
                gb.TenDiem = diemColl.Index(i).Ten;
                bgcoll.Add(gb);
            }            
            return bgcoll;
        }      
        void RunDijkstra(int n, string dau, string cuoi)
        {            
            int D=0;
            int C=0;
            for (int d = 0; d < diemColl.Count; d++)
            {
                if (diemColl.Index(d).Ten == dau)
                {
                    D = d;
                    break;
                }
            }
            for (int c = 0; c < diemColl.Count; c++)
            {
                if (diemColl.Index(c).Ten == cuoi)
                {
                    C = c;
                    break;
                }
            }
            //khởi tạo          
            for (int i = 0; i < n; i++)
            {
                Nhan1[i] = 1000000;
                DanhDau1[i] = '0';
                Truoc1[i] = D;               
            }
            LuuBuocChay.Add(TaoBangGhi());
            LuuDuongVaDiem("", "", "");

            //---------Xuất khởi tạo ----------
            Nhan1[D] = 0;
            DanhDau1[D] = '1';
            XP1 = D;
            int dem = 0;
            LuuBuocChay.Add(TaoBangGhi());
            LuuDuongVaDiem(diemColl.Index(XP1).Ten, "", "");
            //Lặp
            while (XP1 != C)
            {
                //xét đỉnh kề.... ------Xuất đỉnh kề---------
                for (int j = 0; j < n; j++)
                {
                    if (MaTranTrongSo[XP1, j] > 0 && Nhan1[j] > MaTranTrongSo[XP1, j] + Nhan1[XP1] && DanhDau1[j] == '0')
                    {
                        Nhan1[j] = MaTranTrongSo[XP1, j] + Nhan1[XP1];
                        Truoc1[j] = XP1;
                        //Lưu bảng ghi
                        LuuBuocChay.Add(TaoBangGhi());                        
                        //Lưu đỉnh và đường
                        LuuDuongVaDiem(diemColl.Index(XP1).Ten, diemColl.Index(XP1).Ten, diemColl.Index(j).Ten);                        
                    }
                }

                //lấy chiều dài tới đỉnh ngắn nhất, gán XP= đỉnh đó... --------Xuất min----------
                min1 = 1000000;
                for (int j = 0; j < n; j++)
                {
                    if (min1 > Nhan1[j] && DanhDau1[j] == '0')
                    {
                        min1 = Nhan1[j];
                        XP1 = j;                        
                    }
                    
                }
                DanhDau1[XP1] = '1';
                LuuBuocChay.Add(TaoBangGhi());
                //Lưu đỉnh và đường
                LuuDuongVaDiem(diemColl.Index(XP1).Ten, "","");                        
                dem++;
                if (dem == diemColl.Count)
                {
                   return ;
                }

            }
   //         return Nhan1[C];
        }
        #endregion
        #region Thao tác chạy
        /// //////////////////////Chạy kết quả/////////////
        bool DangChay = false;
        private void ChayKetQuaButton_Click(object sender, EventArgs e)
        {
            if (TuCmb.Text == "" || DenCmb.Text == "")
                return;
            //Thay đổi icon
            if (DangChay == false)
            {
                ChayKetQuaButton.BackgroundImage = (System.Drawing.Bitmap)(Properties.Resources.pause);
                DangChay = true;
                TuCmb.Enabled = false;
                DenCmb.Enabled = false;
                if (DangChay == true)
                {
                    TaoMaTranTrongSo();
                    RunDijkstra(diemColl.Count, TuCmb.SelectedIndex, DenCmb.SelectedIndex);
                    CachVe = "DuongDi";
                    Invalidate();
                    //Load thông tin lên các control
                }
            }
            else
            {
                ChayKetQuaButton.BackgroundImage = (System.Drawing.Bitmap)(Properties.Resources.play);
                DangChay = false;
                TuCmb.Enabled = true;
                DenCmb.Enabled = true;
                CachVe = "TatCa";
                Invalidate();
            }
            //Chạy thuật tóan
           

        }
        /// //////////////////////Chạy từng bứơc/////////////
        bool DangChayTungBuoc = false;
        private void ChayTungBuocButton_Click(object sender, EventArgs e)
        {
            //Thay đổi Icon của chạy tự động       
            if (dangchaytudong == false)
            {
           //     ChayTuDongButton.BackgroundImage = (System.Drawing.Bitmap)(Dijkstra.Properties.Resources.stop);
                ChayTungBuocButton.BackgroundImage = (System.Drawing.Bitmap)(Dijkstra.Properties.Resources.pause);
                TuCmb.Enabled = false;
                DenCmb.Enabled = false;
                dangchaytudong = true;
                ChayTuDongButton.Enabled = false;

            }
            else
            {
          //      ChayTuDongButton.BackgroundImage = (System.Drawing.Bitmap)(Dijkstra.Properties.Resources.playall2);
                ChayTungBuocButton.BackgroundImage = (System.Drawing.Bitmap)(Dijkstra.Properties.Resources.step);
                TuCmb.Enabled = true;
                DenCmb.Enabled = true;
                dangchaytudong = false;
                ChayTuDongButton.Enabled = true;
            }
            //reset
            dinhdauLabel.Text = "0";
            dinhcuoiLabel.Text = "0";
            chieudaiLabel.Text = "0";
            Buoc = 0;
            label3.Text = "0";
            label7.Text = "===đến===>";
            label7.ForeColor = Color.Black;
            LuuBuocChay.Clear();
            LuuDiem.Clear();
            LuuDuong.Clear();
            BuocChayGridView.DataSource = null;
            //Chạy thuật tóan
            if (TuCmb.Text == "" || DenCmb.Text == "")
                return;
            //Thay đổi icon
            if (DangChayTungBuoc == false)
            {
                ChayTungBuocButton.BackgroundImage = (System.Drawing.Bitmap)(Properties.Resources.pause);
                DangChayTungBuoc = true;
                TuCmb.Enabled = false;
                DenCmb.Enabled = false;
                CachVe = "TungBuoc";
                if (DangChayTungBuoc == true)
                {
                    TaoMaTranTrongSo();
                    //lấy đỉnh XP và các đỉnh kề             
                    RunDijkstra(diemColl.Count, TuCmb.SelectedIndex, DenCmb.SelectedIndex);
                    RunDijkstra(diemColl.Count, TuCmb.Text, DenCmb.Text);
                    if (KetQuaTextBox.Text == "Không có đường đi giữa 2 đỉnh")
                    {
                        dinhdauLabel.Text = TuCmb.Text;
                        dinhcuoiLabel.Text = DenCmb.Text;
                        label7.Text = "không đến đựơc";
                        KetQuaTextBox.Text = "";
                        label7.ForeColor = Color.Red;  
                        return;
                    }
                    KetQuaTextBox.Text = "";
                    ThaoTacTungBuoc();
                }
            }
            else
            {
                TuDongTimer.Enabled = false;
                TuDongTimer.Dispose();
                //reset
                ChayTungBuocButton.BackgroundImage = (System.Drawing.Bitmap)(Properties.Resources.play);
                DangChayTungBuoc = false;
                TuCmb.Enabled = true;
                DenCmb.Enabled = true;
                CachVe = "TatCa";                
                Invalidate();
            }
            //Chạy thuật tóan
          
        }
        private int Buoc=0;
        private void ThaoTacTungBuoc()
        {
            if (label7.Text != "không đến đựơc")
            {
            CachVe = "TungBuoc";
            if (LuuBuocChay.Count != 0)
            {
                BuocChayGridView.DataSource = LuuBuocChay[Buoc];
                label3.Text = Buoc.ToString();
                Invalidate();
            }
            if (Buoc == 0)
            {
                dinhdauLabel.Text = "0";
                dinhcuoiLabel.Text = "0";
                chieudaiLabel.Text = "0";
            }
            if (Buoc == LuuBuocChay.Count - 1)
            {
                dinhdauLabel.Text = TuCmb.Text;
                dinhcuoiLabel.Text = DenCmb.Text;
                chieudaiLabel.Text = Nhan1[DenCmb.SelectedIndex].ToString();
                CachVe = "DuongDi";
                Invalidate();
            }
            }
        }
        private void TiepButton_Click(object sender, EventArgs e)
        {
            if (LuuBuocChay.Count != 0)
            {
                if (Buoc < LuuBuocChay.Count-1)
                {
                    Buoc++;
                    ThaoTacTungBuoc();                   
                }
            }
        }
        private void TruocButton_Click(object sender, EventArgs e)
        {
            if (LuuBuocChay.Count != 0)
            {
                if (Buoc >0)
                {
                    Buoc--;
                    ThaoTacTungBuoc();
                }
            }
        }
       
        /// //////////////////////Chạy tự động/////////////       
        bool dangchaytudong = false;
        private void ChayTuDongButton_Click(object sender, EventArgs e)
        {
            
            //Thay đổi Icon            
            if (dangchaytudong==false)
            {
                ChayTuDongButton.BackgroundImage = (System.Drawing.Bitmap)(Dijkstra.Properties.Resources.stop);
        //        ChayTungBuocButton.BackgroundImage = (System.Drawing.Bitmap)(Dijkstra.Properties.Resources.pause);
                TuCmb.Enabled = false;
                DenCmb.Enabled = false;
                ThoiGianTextBox.Enabled = false;
                dangchaytudong = true;
                TruocButton.Enabled = false;
                TiepButton.Enabled = false;
                ChayTungBuocButton.Enabled = false;
            }
            else
            {
                ChayTuDongButton.BackgroundImage = (System.Drawing.Bitmap)(Dijkstra.Properties.Resources.playall2);
        //        ChayTungBuocButton.BackgroundImage = (System.Drawing.Bitmap)(Dijkstra.Properties.Resources.step);
                TuCmb.Enabled = true;
                DenCmb.Enabled = true;
                ThoiGianTextBox.Enabled = true;
                dangchaytudong = false;
                TruocButton.Enabled = true;
                TiepButton.Enabled = true;
                ChayTungBuocButton.Enabled = true;
            }

            //reset
            Buoc = 0;
            ThoiGian = LuuBuocChay.Count;
            dinhdauLabel.Text = "0";
            dinhcuoiLabel.Text = "0";
            chieudaiLabel.Text = "0";
            label3.Text = "0";
            label7.Text = "===đến===>";
            label7.ForeColor = Color.Black;
            LuuBuocChay.Clear();
            LuuDiem.Clear();
            LuuDuong.Clear();
            BuocChayGridView.DataSource = null;
            //Chạy thuật tóan
            if (TuCmb.Text == "" || DenCmb.Text == "")
                return;
            if (DangChayTungBuoc == false)
            {               
                DangChayTungBuoc = true;
                TuCmb.Enabled = false;
                DenCmb.Enabled = false;
                CachVe = "TungBuoc";
                if (DangChayTungBuoc == true)
                {
                    TaoMaTranTrongSo();
                    //lấy đỉnh XP và các đỉnh kề             
                    RunDijkstra(diemColl.Count, TuCmb.SelectedIndex, DenCmb.SelectedIndex);
                    RunDijkstra(diemColl.Count, TuCmb.Text, DenCmb.Text);
                    if (KetQuaTextBox.Text == "Không có đường đi giữa 2 đỉnh")
                    {
                        dinhdauLabel.Text = TuCmb.Text;
                        dinhcuoiLabel.Text = DenCmb.Text;
                        label7.Text = "không đến đựơc";
                        label7.ForeColor = Color.Red;
                        KetQuaTextBox.Text = "";
                        return;
                    }
                    BuocChayGridView.DataSource = LuuBuocChay[0];
                    KetQuaTextBox.Text = "";
                    TuDongTimer.Interval = Convert.ToInt32(ThoiGianTextBox.Text)*1000;
                    TuDongTimer.Enabled = true;
                    ThoiGian = LuuBuocChay.Count;
                }
            }
            else
            {
                DangChayTungBuoc = false;
                TuCmb.Enabled = true;
                DenCmb.Enabled = true;
                CachVe = "TatCa";
                Invalidate();
            }
        }
        int ThoiGian = 0;
        private void TuDongTimer_Tick(object sender, EventArgs e)
        {
            ThoiGian--;
            if (ThoiGian != 0)
            {
                Buoc++;
                ThaoTacTungBuoc();
            }
            else
            {
                //reset
              /*  ChayTungBuocButton.BackgroundImage = (System.Drawing.Bitmap)(Properties.Resources.play);
                ChayTuDongButton.BackgroundImage = (System.Drawing.Bitmap)(Properties.Resources.playall2);   */
                TuCmb.Enabled = true;
                DenCmb.Enabled = true;
                TuDongTimer.Enabled = false;
                TuDongTimer.Dispose();
            }
        }
        #endregion


       
    }
}
