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
    public partial class MoTaFloyd : Form
    {
        public DuongThangCollection duongColl = new DuongThangCollection();
        public DiemCollection diemColl = new DiemCollection();
        bool CoHuong = true;
        #region Thao tác control
        public MoTaFloyd(DuongThangCollection _duongcoll, DiemCollection _diemcoll, bool _cohuong)
        {
            CoHuong = _cohuong;
            duongColl = _duongcoll;
            diemColl = _diemcoll;
            InitializeComponent();
        }
        private void MoTaFloyd_Load(object sender, EventArgs e)
        {
            Invalidate();
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
        private void quayLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            TuDongTimer.Enabled = false;
            Application.OpenForms[0].Visible = true;
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
                TuCmb.Enabled = true;
                DenCmb.Enabled = true;
                CachVe = -1;
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
                TuCmb.Enabled = true;
                DenCmb.Enabled = true;
                CachVe = -1;
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
                //reset              
                label3.Text = "0";
                BuocChayGridView.DataSource = null;

            }
        } 
        #endregion

        #region Thuật tóan Floyd
        static int TOIDA = 50;
        static int VOCUNG = 1000000;
        static int[,] weight = new int[TOIDA, TOIDA]; //Ma tran trong so
        static int[,] D = new int[TOIDA, TOIDA]; // Ma tran chieu dai ngan nhat giua 2 diem
        static int[,] P = new int[TOIDA, TOIDA]; // Ma tran duong di ngan nhat giua 2 diem qua nut trung gian
        static int SoNut; // So nut
        public void Init() // Khởi tạo Ma Tran Trong so
        {
            int i, j;
            for (i = 0; i < TOIDA; i++)
                for (j = 0; j < TOIDA; j++)
                {
                    if (i == j)
                        weight[i, j] = 0;
                    else
                        weight[i, j] = VOCUNG;
                }
        }
        public void TaoMaTranTrongSo()// Gán trọng số vào ma trận
        {
            for (int i = 0; i < diemColl.Count; i++)
            {
                for (int j = 0; j < diemColl.Count; j++)
                {
                  //  weight[i, j] = 0;
                    foreach (DuongThang dt in duongColl)
                    {
                        if (dt.DiemDau.Ten == diemColl.Index(i).Ten && dt.DiemCuoi.Ten == diemColl.Index(j).Ten)
                        {
                            weight[i, j] = dt.ChieuDai;
                        }
                    }
                }

            }
        }
  //      static List<BangGhiFloydCollection> BangGhi = new List<BangGhiFloydCollection>();
        BangGhiFloydCollection Initbgcoll = new BangGhiFloydCollection();
        BangGhiFloydCollection StepColl = new BangGhiFloydCollection();
        public void floyd()
        {
            Initbgcoll.Clear();
            StepColl.Clear();
            int i, j, k;         
            //khoi dong ma tran D va P    
            for (i = 0; i < SoNut; i++)
            {
                for (j = 0; j < SoNut; j++)
                {
                    D[i, j] = weight[i, j];
                    P[i, j] = -1;
                    //Khởi tạo BangGhi
                    if (weight[i, j] > 0 && weight[i, j] < VOCUNG)
                    {
                        BangGhiFloyd bgFloyd = new BangGhiFloyd();
                        bgFloyd.Dau = diemColl.Index(i).Ten;
                        bgFloyd.TrungGian = "-1";
                        bgFloyd.Cuoi = diemColl.Index(j).Ten;
                        bgFloyd.ChieuDai = D[i, j];
                        Initbgcoll.Add(bgFloyd);
                    }
                }
            }
    //        BangGhi.Add(Initbgcoll);  
            // Tinh ma tran D va P o buoc lap thu k
           
            for (k = 0; k < SoNut; k++)
            {
                for (i = 0; i < SoNut; i++)
                {
                    if ((D[i, k] > 0) && (D[i, k] < VOCUNG))
                        for (j = 0; j < SoNut; j++)
                        {
                            if ((D[k, j] > 0) && (D[k, j] < VOCUNG))
                            {
                                if ((D[i, j] != 0) && (D[i, k] + D[k, j] < D[i, j]))
                                {
                                    D[i, j] = D[i, k] + D[k, j];
                                    P[i, j] = k;
                                    //Thêm vào 1 dòng
                                    BangGhiFloyd bgFloyd1 = new BangGhiFloyd();
                                    bgFloyd1.Dau = diemColl.Index(i).Ten;
                                    bgFloyd1.TrungGian = diemColl.Index(k).Ten;
                                    bgFloyd1.Cuoi = diemColl.Index(j).Ten;
                                    bgFloyd1.ChieuDai = D[i, j];
                                    StepColl.Add(bgFloyd1);
                            //        BangGhi.Add(Initbgcoll);
                                }
                            }
                        }
                }
            }
        }
        public List<string> LoTrinh = new List<string>();
        public void inlotrinh(int x, int y)
        {         
            int r;
            if (P[x, y] == -1)
            {                
          //      LoTrinh.Add(x + "->" + y + " ");     
                LoTrinh.Add(diemColl.Index(y).Ten);
                return;
            }
            else
            {
                r = P[x, y];
                inlotrinh(x, r);                
                inlotrinh(r, y);
            }
        }    
        #endregion

        #region Các bước chạy bằng control
        int Buoc = 0;       
        private void ChayKetQuaButton_Click(object sender, EventArgs e)
        {           
            //Thay đổi Hình ảnh
            LoTrinh.Clear();
            if (CachVe != 1)
            {
                ChayKetQuaButton.BackgroundImage = (System.Drawing.Bitmap)(Dijkstra.Properties.Resources.pause);
                CachVe = 1;
                TuCmb.Enabled = false;
                DenCmb.Enabled = false;
            }
            else
            {
                ChayKetQuaButton.BackgroundImage = (System.Drawing.Bitmap)(Dijkstra.Properties.Resources.play);
                CachVe = -1;
                TuCmb.Enabled = true;
                DenCmb.Enabled = true;
                KetQuaTextBox.Text = "";
                Invalidate();
            }
            if (CachVe == 1 && diemColl.Count!=0)
            {
                
                //Nhập
                int x = TuCmb.SelectedIndex;
                int y = DenCmb.SelectedIndex;
                SoNut = diemColl.Count;
                Init();
                TaoMaTranTrongSo();
                //Chạy
                string ketqua = "";
                if (x >= SoNut || y >= SoNut)
                    ketqua="Không hợp lệ";
                else
                {
                    floyd();
                    ketqua+="Tổng chiều dài đường đi: " + D[x, y];
                    ketqua+="\r\n";
                    LoTrinh.Add(TuCmb.Text);
                    if (D[x, y] >= 1000000)
                    {
                        ketqua = "Không có đường đi giữa hai đỉnh";
                        KetQuaTextBox.Text = ketqua;
                        Invalidate();
                        return;
                    }
                    inlotrinh(x, y);
                }    
                int i = 0;
                for(; i < LoTrinh.Count-1; i++)
                    ketqua+=LoTrinh[i]+"-> ";
                ketqua += LoTrinh[LoTrinh.Count - 1];
                //Nếu không có đường đi                
                KetQuaTextBox.Text = ketqua;
                Invalidate();
            }
            


        }
        private void ChayTungBuocButton_Click(object sender, EventArgs e)
        {
            if (CachVe != 2)
            {
      //          ChayTuDongButton.BackgroundImage = (System.Drawing.Bitmap)(Dijkstra.Properties.Resources.pause);
                ChayTungBuocButton.BackgroundImage = (System.Drawing.Bitmap)(Dijkstra.Properties.Resources.pause);
                CachVe = 2;
                TuCmb.Enabled = false;
                DenCmb.Enabled = false;
                BuocChayGridView.DataSource = null;
                ChayTuDongButton.Enabled = false;
            }
            else
            {
     //           ChayTuDongButton.BackgroundImage = (System.Drawing.Bitmap)(Dijkstra.Properties.Resources.playall2);
                ChayTungBuocButton.BackgroundImage = (System.Drawing.Bitmap)(Dijkstra.Properties.Resources.step);
                CachVe = -1;
                TuCmb.Enabled = true;
                DenCmb.Enabled = true;
                label3.Text = "0";
                KetQuaTextBox.Text = "";     
                Invalidate();
                BuocChayGridView.DataSource = null;
                ChayTuDongButton.Enabled = true;
            }
            if (CachVe == 2 && diemColl.Count != 0)
            {
                Buoc = 0;
                //Nhập
                int x = TuCmb.SelectedIndex;
                int y = DenCmb.SelectedIndex;
                SoNut = diemColl.Count;
                Init();
                TaoMaTranTrongSo();       
                //Chạy
                string ketqua = "";
                if (x >= SoNut || y >= SoNut)
                    ketqua = "Không hợp lệ";
                else
                {
                    floyd();
                    ketqua += "Tổng chiều dài đường đi: " + D[x, y];
                    ketqua += "\r\n";
                    LoTrinh.Add(TuCmb.Text);
                    if (D[x, y] >= 1000000)
                    {
                        ketqua = "Không có đường đi giữa hai đỉnh";
                        KetQuaTextBox.Text = ketqua;
                        Invalidate();
                        return;
                    }
                    inlotrinh(x, y);
                }
                int i = 0;
                for (; i < LoTrinh.Count - 1; i++)
                    ketqua += LoTrinh[i] + "-> ";
                ketqua += LoTrinh[LoTrinh.Count - 1];
                //Nếu không có đường đi                
            //    KetQuaTextBox.Text = ketqua;
                Invalidate();
                BuocChayGridView.DataSource = Initbgcoll;
            }
        }
        private void ChayTuDongButton_Click(object sender, EventArgs e)
        {            
            if(label3.Text==(StepColl.Count+1).ToString())
                CachVe = 2;
            if (CachVe != 2)
            {
                ChayTuDongButton.BackgroundImage = (System.Drawing.Bitmap)(Dijkstra.Properties.Resources.pause);
        //        ChayTungBuocButton.BackgroundImage = (System.Drawing.Bitmap)(Dijkstra.Properties.Resources.pause);
                CachVe = 2;
                TuCmb.Enabled = false;
                DenCmb.Enabled = false;
                TiepButton.Enabled = false;
                TruocButton.Enabled = false;
                ChayTungBuocButton.Enabled = false;
                BuocChayGridView.DataSource = null;                    
            }
            else
            {
                BuocChayGridView.DataSource = null;   
                TiepButton.Enabled = true;
                TruocButton.Enabled = true;
                ChayTungBuocButton.Enabled = true;
                ChayTuDongButton.BackgroundImage = (System.Drawing.Bitmap)(Dijkstra.Properties.Resources.playall2);
         //       ChayTungBuocButton.BackgroundImage = (System.Drawing.Bitmap)(Dijkstra.Properties.Resources.step);
                CachVe = -1;
                TuCmb.Enabled = true;
                DenCmb.Enabled = true;
                label3.Text = "0";
                TuDongTimer.Enabled = false;
                Invalidate();
                KetQuaTextBox.Text = "";
            }
            if (CachVe == 2 && diemColl.Count != 0)
            {
                Buoc = 0;
                //Nhập
                int x = TuCmb.SelectedIndex;
                int y = DenCmb.SelectedIndex;
                SoNut = diemColl.Count;
                Init();
                TaoMaTranTrongSo();
                //Chạy
                string ketqua = "";
                if (x >= SoNut || y >= SoNut)
                    ketqua = "Không hợp lệ";
                else
                {
                    floyd();
                    ketqua += "Tổng chiều dài đường đi: " + D[x, y];
                    ketqua += "\r\n";
                    LoTrinh.Add(TuCmb.Text);
                    if (D[x, y] >= 1000000)
                    {
                        ketqua = "Không có đường đi giữa hai đỉnh";
                        KetQuaTextBox.Text = ketqua;
                        Invalidate();
                        return;
                    }
                    inlotrinh(x, y);
                }
                int i = 0;
                for (; i < LoTrinh.Count - 1; i++)
                    ketqua += LoTrinh[i] + "-> ";
                ketqua += LoTrinh[LoTrinh.Count - 1];
                //Nếu không có đường đi                
                //    KetQuaTextBox.Text = ketqua;
                Invalidate();
                BuocChayGridView.DataSource = Initbgcoll;
                ThoiGian = StepColl.Count + 1;
                TuDongTimer.Interval = Convert.ToInt32(ThoiGianTextBox.Text) * 1000;
                TuDongTimer.Enabled = true;
            }
            
        }
      
        private void TruocButton_Click(object sender, EventArgs e)
        {
            CachVe = 2;
            if (label3.Text == (StepColl.Count+1).ToString())
            {
                label3.Text = (StepColl.Count).ToString();
          //      label3.Text = Buoc.ToString();
          //      Initbgcoll.Remove(Initbgcoll.Count - 1);
                BuocChayGridView.DataSource = null;
                BuocChayGridView.DataSource = Initbgcoll;// BangGhi[Buoc];
                Invalidate();
                BuocChayGridView.Rows[BuocChayGridView.Rows.Count - 1].Selected = true;
                BuocChayGridView.FirstDisplayedScrollingRowIndex = BuocChayGridView.Rows.Count - 1;           
                return;
            }
            if (StepColl != null && StepColl.Count != 0 && Buoc > 0 && BuocChayGridView.Rows.Count != 0)
            {
                Buoc--;
                label3.Text = Buoc.ToString();
                Initbgcoll.Remove(Initbgcoll.Count - 1);
                BuocChayGridView.DataSource = null;
                BuocChayGridView.DataSource = Initbgcoll;// BangGhi[Buoc];
                Invalidate();
                BuocChayGridView.Rows[BuocChayGridView.Rows.Count - 1].Selected = true;
                BuocChayGridView.FirstDisplayedScrollingRowIndex = BuocChayGridView.Rows.Count - 1;
            }
           
            
        }
        private void TiepButton_Click(object sender, EventArgs e)
        {
            CachVe = 2;
       //     bool last=true;
            if (StepColl != null && StepColl.Count != 0 && Buoc < StepColl.Count)
            {
                Buoc++;     
                label3.Text = Buoc.ToString();
                Initbgcoll.Add(StepColl.Index(Buoc-1));             
                BuocChayGridView.DataSource = null;
                BuocChayGridView.DataSource = Initbgcoll;
                Invalidate();
               // last = false;
                BuocChayGridView.Rows[BuocChayGridView.Rows.Count - 1].Selected = true;
                BuocChayGridView.FirstDisplayedScrollingRowIndex = BuocChayGridView.Rows.Count - 1;
                return;
            }
            if (BuocChayGridView.Rows.Count != 0)
            {
                CachVe = 1;
                Invalidate();
                label3.Text = (StepColl.Count + 1).ToString();
                BuocChayGridView.Rows[BuocChayGridView.Rows.Count - 1].Selected = true;
                BuocChayGridView.FirstDisplayedScrollingRowIndex = BuocChayGridView.Rows.Count - 1;
            }
        } 
        #endregion

        #region Vẽ
        int CachVe = -1;//1: Tất cả; 2: từng bứơc ; 3: tự động
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
        private void VeDuongAo(Diem diemdau, Diem diemcuoi, Color cl)
        {
            SolidBrush myBrush = new SolidBrush(Color.Green);
            Graphics tengido = this.CreateGraphics();
            Pen pen = new Pen(cl, 3);
            Font font = new Font("Arial", 15, FontStyle.Bold);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
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
        protected override void OnPaint(PaintEventArgs e)
        {
            ///////////////////////////////////////////vẽ tòan bộ//////////////////////////
            if (CachVe == 1)
            {
                //Vẽ đường    
                foreach (DuongThang dt in duongColl)
                {
                    VeDuong(dt.DiemDau, dt.DiemCuoi, Color.Green);
                }
                if (LoTrinh != null)
                {
                    for (int i = 0; i < LoTrinh.Count - 1; i++)
                    {

                        foreach (DuongThang dt in duongColl)
                        {
                            if (dt.DiemDau.Ten == LoTrinh[i] && dt.DiemCuoi.Ten == LoTrinh[i + 1])
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
                if (LoTrinh != null)
                {
                    for (int i = 0; i < LoTrinh.Count; i++)
                    {
                        foreach (Diem diem in diemColl)
                        {
                            if (diem.Ten == LoTrinh[i])
                            {
                                VeDiem(diem.Ten, diem.A, diem.B, Color.Blue);
                                break;
                            }
                        }
                    }
                }
            }
            ///////////////////////////////////vẽ từng buớc///////////////////////////////
            else if (CachVe == 2)
            {
                //Vẽ đường    
                foreach (DuongThang dt in duongColl)
                {
                    VeDuong(dt.DiemDau, dt.DiemCuoi, Color.Green);
                }
                Diem _dau = new Diem();
                Diem _cuoi = new Diem();
                Diem _trunggian = new Diem();
                if (StepColl != null && StepColl.Count!=0 && Buoc!=0)
                {
                    foreach (Diem diem in diemColl)
                    {
                        if (diem.Ten == StepColl.Index(Buoc - 1).Dau)
                        {
                            _dau.A = diem.A + 5;
                            _dau.B = diem.B + 5;
                            _dau.Ten = diem.Ten;
                        }
                        if (diem.Ten == StepColl.Index(Buoc - 1).TrungGian)
                        {
                            _trunggian.A = diem.A + 5;
                            _trunggian.B = diem.B + 5;
                            _trunggian.Ten = diem.Ten;
                        }
                        if (diem.Ten == StepColl.Index(Buoc - 1).Cuoi)
                        {
                            _cuoi.A = diem.A + 5;
                            _cuoi.B = diem.B + 5;
                            _cuoi.Ten = diem.Ten;
                        }
                    }
                    foreach (DuongThang dt in duongColl)
                    {
                        if (dt.DiemDau.Ten == _dau.Ten && dt.DiemCuoi.Ten == _trunggian.Ten)
                        {
                            VeDuong(_dau, _trunggian, Color.Red);
                            break;
                        }
                        else
                            VeDuongAo(_dau, _trunggian, Color.Tomato);
                    }
                    foreach (DuongThang dt in duongColl)
                    {
                        if (dt.DiemDau.Ten == _trunggian.Ten && dt.DiemCuoi.Ten == _cuoi.Ten)
                        {
                            VeDuong(_trunggian, _cuoi, Color.Red);
                            break;
                        }
                        else
                            VeDuongAo(_trunggian, _cuoi, Color.Tomato);
                        
                    }
                   

                }
                //vẽ điểm    
                foreach (Diem diem in diemColl)
                {
                    VeDiem(diem.Ten, diem.A, diem.B, Color.Black);
                }
                if (StepColl != null && StepColl.Count != 0&&Buoc!=0)
                {
                    VeDiem(_trunggian.Ten,_trunggian.A-5, _trunggian.B-5, Color.Blue);               
                }
          //      CachVe = 2;
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

        int ThoiGian = 0;
        private void TuDongTimer_Tick(object sender, EventArgs e)
        {
            ThoiGian--;
            if (ThoiGian != 0 )
            {
                CachVe = 2;             
                //     bool last=true;      
                if (Buoc < StepColl.Count)
                {
                    Buoc++;
                    label3.Text = Buoc.ToString();
                    Initbgcoll.Add(StepColl.Index(Buoc - 1));
                    BuocChayGridView.DataSource = null;
                    BuocChayGridView.DataSource = Initbgcoll;
                    Invalidate();
                    // last = false;
                    BuocChayGridView.Rows[BuocChayGridView.Rows.Count - 1].Selected = true;
                    BuocChayGridView.FirstDisplayedScrollingRowIndex = BuocChayGridView.Rows.Count - 1;
               //        return;
                }             
            }                     
            else
            {//
                CachVe = 1;
                Invalidate();
                label3.Text = (StepColl.Count + 1).ToString();
                BuocChayGridView.Rows[BuocChayGridView.Rows.Count - 1].Selected = true;
                BuocChayGridView.FirstDisplayedScrollingRowIndex = BuocChayGridView.Rows.Count - 1;  

                TuCmb.Enabled = true;
                DenCmb.Enabled = true;
                TuDongTimer.Enabled = false;
                TuDongTimer.Dispose();
            }
            
        }




    }
}
