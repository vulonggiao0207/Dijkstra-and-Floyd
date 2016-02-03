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
    public partial class VeDoThi : Form
    {
        public VeDoThi()
        {
            InitializeComponent();
        }
        bool Dangve = false;
        bool CoHuong = true;
        DiemCollection diemColl = new DiemCollection();
        DuongThangCollection duongColl = new DuongThangCollection();
        private void VeDijkstra_Load(object sender, EventArgs e)
        {
            
        }               
        private void LoadDSDiem()
        {
            DSDiemList.DataSource = null;
            DataTable dt = new DataTable();
            dt.Columns.Add("Ten",typeof(String));           
            dt.Columns.Add("A", typeof(Int32));
            dt.Columns.Add("B", typeof(Int32));
            foreach (Diem diem in diemColl)
            {
                DataRow dr = dt.NewRow();
                dr["Ten"] =diem.Ten ;
                dr["A"] = diem.A;
                dr["B"] = diem.B;
                dt.Rows.Add(dr);
            }
            DSDiemList.DataSource = dt;
            DSDiemList.DisplayMember = "Ten";
            DSDiemList.ValueMember = "Ten";
        }
        private void LoadDSDuongThang()
        {
            DSDuongGrid.DataSource = null;
            DataTable dt = new DataTable();
            dt.Columns.Add("DiemDau",typeof(String));           
            dt.Columns.Add("DiemCuoi", typeof(String));
            dt.Columns.Add("ChieuDai", typeof(Int32));
            foreach (DuongThang duongthang in duongColl)
            {
                DataRow dr = dt.NewRow();
                dr["DiemDau"] = duongthang.DiemDau.Ten;
                dr["DiemCuoi"] = duongthang.DiemCuoi.Ten;
                dr["ChieuDai"] = duongthang.ChieuDai;
                dt.Rows.Add(dr);
            }
            DSDuongGrid.DataSource = dt;
            DSDuongGrid.Columns[0].Width = 75;
            DSDuongGrid.Columns[1].Width = 75;
            DSDuongGrid.Columns[2].Width = 115;
            DSDuongGrid.Columns[0].HeaderText = "Đầu";
            DSDuongGrid.Columns[1].HeaderText = "Cuối";
            DSDuongGrid.Columns[2].HeaderText = "Chiều dài";
            DSDuongGrid.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            DSDuongGrid.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            DSDuongGrid.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
        }
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
        private void VeDuong(Diem diemdau,Diem diemcuoi, Color cl)
        {
            SolidBrush myBrush = new SolidBrush(Color.Green);
            Graphics tengido = this.CreateGraphics();
            Pen pen = new Pen(cl, 3);        
            Font font = new Font("Arial", 15, FontStyle.Bold);
            tengido.DrawLine(pen,diemdau.A,diemdau.B,diemcuoi.A,diemcuoi.B );    
   
            //vẽ mũi tên 
            if (CoHuong == true)
            {
                pen.EndCap = System.Drawing.Drawing2D.LineCap.Custom;
                pen.CustomEndCap = new System.Drawing.Drawing2D.AdjustableArrowCap(4, 4, true);
            }
            tengido.DrawLine(pen, diemdau.A, diemdau.B, (diemcuoi.A+diemdau.A)/2, (diemcuoi.B+diemdau.B)/2);  
     //       tengido.DrawLine(pen, x1, y1, x2, y2);
            //hủy
            pen.Dispose();
            tengido.Dispose();
           
        }
        public Diem KiemTraDiem_ThuocDiem(int x, int y)
        {
            foreach (Diem diem in diemColl)
            {
                if (diem.A < x && x < diem.A + 10 && diem.B < y && y < diem.B + 10)
                {
                    return diem;
                }
            }
            return null;

        }
        public bool KiemTraDuongTonTai(DuongThang dt)
        {
            foreach (DuongThang duong in duongColl)
            {
                if (dt.DiemDau.Ten == duong.DiemDau.Ten && dt.DiemCuoi.Ten == duong.DiemCuoi.Ten)
                {
                    return true;
                }
            }
            return false;
        }
     /*   public void XoaDiem()
        {
            if (Dangve == false && DangXoa == true)
            {
                Diem kq1 = KiemTraDiem_ThuocDiem(e.X, e.Y);
                if (kq1 != null)
                {
                    for (int i = diemColl.Count - 1; i >= 0; i--)
                    {
                        if (diemColl.Index(i).Ten.ToString() == kq1.Ten.ToString())
                        {
                            diemColl.Remove(i);
                        }
                    }
                    for (int j = duongColl.Count - 1; j >= 0; j--)
                    {
                        if (duongColl.Index(j).DiemDau.Ten.ToString() == kq1.Ten.ToString() || duongColl.Index(j).DiemCuoi.Ten.ToString() == kq1.Ten.ToString())
                        {
                            duongColl.Remove(j);
                        }
                    }

                }
                Invalidate();
            }          
        }*/
        int thutu_diem = 1;        
        bool mauve = false;      
        private static int x1, y1, x2, y2;
        private static string DiemBatDau = "";
        private static string DiemCuoi = "";
        protected override void OnPaint(PaintEventArgs e)
        {
            //Vẽ đường      
            foreach (DuongThang dt in duongColl)
            {
                VeDuong(dt.DiemDau, dt.DiemCuoi, Color.Green);
            }
            if (Dangve != true)
                LoadDSDuongThang();

            //vẽ điểm    

            if (mauve == true)
            {
                foreach (Diem diem in diemColl)
                {
                    VeDiem(diem.Ten, diem.A, diem.B, Color.Blue);
                }
            }
            else
            {
                foreach (Diem diem in diemColl)
                {
                    //     VeDiem(diem.A, diem.B, Color.Red);
                    VeDiem(diem.Ten, diem.A, diem.B, Color.Black);
                }
            }
            if (Dangve == true)
                LoadDSDiem();
          
        }
        private void điểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dangve = true;
            điểmToolStripMenuItem.BackColor = Color.YellowGreen;
            đườngCóHướngToolStripMenuItem.BackColor=SystemColors.Control;
            đườngVôHướngToolStripMenuItem.BackColor = SystemColors.Control;
        }
      
        private void đườngCóHướngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dangve = false;
            if (CoHuong == false)
            {
                if (duongColl.Count != 0)
                {
                    DialogResult dr = MessageBox.Show("Đồ thị đang tồn tại đường đi vô hướng! Bạn muốn xóa tất cả không", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        CoHuong = true;
                        đườngCóHướngToolStripMenuItem.BackColor = Color.YellowGreen;
                        điểmToolStripMenuItem.BackColor = SystemColors.Control;
                        đườngVôHướngToolStripMenuItem.BackColor = SystemColors.Control;
                        duongColl.Clear();
                        LoadDSDuongThang();
                        Invalidate();
                    }
                }
                else
                {
                    CoHuong = true;
                    đườngCóHướngToolStripMenuItem.BackColor = Color.YellowGreen;
                    điểmToolStripMenuItem.BackColor = SystemColors.Control;
                    đườngVôHướngToolStripMenuItem.BackColor = SystemColors.Control;
                }
            }
            else
            {
                CoHuong = true;
                đườngCóHướngToolStripMenuItem.BackColor = Color.YellowGreen;
                điểmToolStripMenuItem.BackColor = SystemColors.Control;
                đườngVôHướngToolStripMenuItem.BackColor = SystemColors.Control;
            }
                
        }
        private void đườngVôHướngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dangve = false;
            if (CoHuong == true)
            {
                if (duongColl.Count != 0)
                {
                    DialogResult dr= MessageBox.Show("Đồ thị đang tồn tại đường đi có hướng! Bạn muốn xóa tất cả không","",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        CoHuong = false;
                        đườngVôHướngToolStripMenuItem.BackColor = Color.YellowGreen;
                        đườngCóHướngToolStripMenuItem.BackColor = SystemColors.Control;
                        điểmToolStripMenuItem.BackColor = SystemColors.Control;
                        duongColl.Clear();
                        LoadDSDuongThang();
                        Invalidate();
                    }
                }
                else
                {
                    CoHuong = false;
                    đườngVôHướngToolStripMenuItem.BackColor = Color.YellowGreen;
                    đườngCóHướngToolStripMenuItem.BackColor = SystemColors.Control;
                    điểmToolStripMenuItem.BackColor = SystemColors.Control;
                }
            }
            else
            {
                CoHuong = false;
                đườngVôHướngToolStripMenuItem.BackColor = Color.YellowGreen;
                đườngCóHướngToolStripMenuItem.BackColor = SystemColors.Control;
                điểmToolStripMenuItem.BackColor = SystemColors.Control;
            }
        }
        private void dijkstraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoTaDijkstra mttt = new MoTaDijkstra(diemColl, duongColl,CoHuong);
            mttt.Show();
            this.Visible = false;
        }
        private void floydToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoTaFloyd mtf = new MoTaFloyd(duongColl, diemColl, CoHuong);
            mtf.Show();
            this.Visible = false;
        }
        private void VeDijkstra_MouseDown(object sender, MouseEventArgs e)
        {
            //Vẽ điểm          
            if (Dangve == true)
            {
                Diem diem = new Diem();
                diem.A = e.X;
                diem.B = e.Y;
                diem.Ten = thutu_diem.ToString();
                diemColl.Add(diem);
                thutu_diem++;
                Invalidate();
                return;
         //       Dangve = false;
            }
            //Xóa điểm
           

            //Vẽ đường
            Diem kq = new Diem();
            kq = KiemTraDiem_ThuocDiem(e.X, e.Y);
            if (kq != null)
            {
                if (DiemBatDau == "")
                {
                    x1 = kq.A+5;
                    y1 = kq.B+5;
                    DiemBatDau = kq.Ten.ToString();
                    return;
                }
                if (DiemCuoi == "")
                {
                   
                    x2 = kq.A+5;
                    y2 = kq.B+5;
                    DiemCuoi = kq.Ten.ToString();
           
                    //Gán đừơng thẳng và đưa vào Coll
                    DuongThang dt = new DuongThang();                
                    Diem temp = new Diem();
                    temp.A = x1;
                    temp.B = y1;
                    temp.Ten = DiemBatDau;
                    dt.DiemDau = temp;
                    Diem temp1 = new Diem();
                    temp1.A = x2;
                    temp1.B = y2;
                    temp1.Ten = DiemCuoi;
                    dt.DiemCuoi = temp1;
                    int dodai =(int) Math.Sqrt(Math.Pow((dt.DiemDau.A - dt.DiemCuoi.A),2) + Math.Pow((dt.DiemDau.B - dt.DiemCuoi.B),2));
                    dt.ChieuDai = dodai;  
                    if(KiemTraDuongTonTai(dt)!=true &&DiemBatDau!=DiemCuoi)
                        duongColl.Add(dt);    
                    //Nếu là đường vô hướng
                    if (CoHuong == false)
                    {
                        dt = new DuongThang();
                        temp = new Diem();
                        temp1 = new Diem();
                        temp.A = x1;
                        temp.B = y1;
                        temp.Ten = DiemCuoi;
                        dt.DiemDau = temp;

                        temp1.A = x2;
                        temp1.B = y2;
                        temp1.Ten = DiemBatDau;
                        dt.DiemCuoi = temp1;
                        dodai = (int)Math.Sqrt(Math.Pow((dt.DiemDau.A - dt.DiemCuoi.A), 2) + Math.Pow((dt.DiemDau.B - dt.DiemCuoi.B), 2));
                        dt.ChieuDai = dodai;
                        if (KiemTraDuongTonTai(dt) != true && DiemBatDau != DiemCuoi)
                            duongColl.Add(dt);
                    }
                    Invalidate();
                    DiemBatDau = "";
                    DiemCuoi = "";
                }

            }
        }       
        private void VeDijkstra_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dangve != true)
            {
                int x = e.X;
                int y = e.Y;
                foreach (Diem diem in diemColl)
                {
                    
                    if (diem.A < x && x < diem.A + 10 && diem.B < y && y < diem.B + 10)
                    {
                        VeDiem(diem.Ten, diem.A, diem.B, Color.Blue);                       
                        mauve = true; 
                    }
                    else
                    {
                        mauve = false;
                        VeDiem(diem.Ten, diem.A, diem.B, Color.Black);
                    }
                }
           //     Invalidate();
            }  
            
        }
        #region Các Button Xóa/Sửa đường và đỉnh
        private void SuaDiemButton_Click(object sender, EventArgs e)
        {
            if (DSDiemList.Items.Count != 0)
            {
                SuaDiem sd = new SuaDiem(DSDiemList.SelectedValue.ToString(), diemColl);
                string old = DSDiemList.SelectedValue.ToString();
                int pos = DSDiemList.SelectedIndex;
                if (sd.ShowDialog() == DialogResult.OK)
                {
                    diemColl.Index(pos).Ten = sd._diem;
                    foreach (DuongThang dt in duongColl)
                    {
                        if (dt.DiemDau.Ten == old)
                        {
                            dt.DiemDau.Ten = sd._diem;
                        }
                        if (dt.DiemCuoi.Ten == old)
                        {
                            dt.DiemCuoi.Ten = sd._diem;
                        }
                    }
                    LoadDSDiem();
                    LoadDSDuongThang();
                    Invalidate();

                }
            }
        }
        private void SuaDuongButton_Click(object sender, EventArgs e)
        {
            if (DSDuongGrid.SelectedRows.Count != 0)
            {
                string diemdau = DSDuongGrid.SelectedRows[0].Cells[0].Value.ToString();
                string diemcuoi = DSDuongGrid.SelectedRows[0].Cells[1].Value.ToString();
                int chieudai = Convert.ToInt32(DSDuongGrid.SelectedRows[0].Cells[2].Value.ToString());
                SuaDuong sd = new SuaDuong(diemdau, diemcuoi, chieudai, duongColl);
                if (sd.ShowDialog() == DialogResult.OK)
                {
                    foreach (DuongThang dt in duongColl)
                    {
                        if (dt.DiemDau.Ten == sd.diemdau && dt.DiemCuoi.Ten == sd.diemcuoi)
                            dt.ChieuDai = sd.chieudai;
                        if (dt.DiemDau.Ten == sd.diemcuoi && dt.DiemCuoi.Ten == sd.diemdau)
                            dt.ChieuDai = sd.chieudai;
                    }
                    LoadDSDuongThang();
                }
            }
        }
        private void XoaDiemButton_Click(object sender, EventArgs e)
        {
            if (DSDiemList.Items.Count != 0)
            {
                string ten = DSDiemList.SelectedValue.ToString();
                diemColl.Remove(DSDiemList.SelectedIndex);
                int n = duongColl.Count;
                for (int i = n - 1; i >= 0; i--)
                {
                    if (duongColl.Index(i).DiemDau.Ten == ten || duongColl.Index(i).DiemCuoi.Ten == ten)
                    {
                        duongColl.Remove(i);
                        n = duongColl.Count;
                    }
                }
                LoadDSDuongThang();
                LoadDSDiem();
                Invalidate();
            }
        }
        private void XoaDuongButton_Click(object sender, EventArgs e)
        {
            for (int i = DSDuongGrid.Rows.Count - 1; i >= 0; i--)
            {
                string dinhdau="";
                string dinhcuoi="";
                if (DSDuongGrid.Rows[i].Selected == true)
                {
                    dinhdau=DSDuongGrid[1,i].Value.ToString();
                    dinhcuoi=DSDuongGrid[0,i].Value.ToString();
                    duongColl.Remove(i);
                    //Nếu là đồ thị vô hướng
                    if (CoHuong == false)
                    {
                        for (int j = DSDuongGrid.Rows.Count - 1; j >= 0; j--)
                        {
                            if (dinhdau == DSDuongGrid[1, j].Value.ToString() && dinhcuoi == DSDuongGrid[0, j].Value.ToString())
                                duongColl.Remove(j);
                        }
                    }
                }
              
            }
            LoadDSDuongThang();
            Invalidate();
        } 
        #endregion

        private void VeDoThi_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

      

     



      

     
    }
}
