using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dijkstra
{
    public class DuongThang
    {
        Diem diemdau;
        Diem diemcuoi;
        int chieudai;
        public DuongThang()
        {
            diemdau= null;
            diemcuoi=null;
            chieudai = 0;
        }
        public Diem DiemDau
        {
            get { return diemdau; }
            set { diemdau = value; }
        }
        public Diem DiemCuoi
        {
            get { return diemcuoi; }
            set { diemcuoi = value; }
        }
        public int ChieuDai
        {
            get { return chieudai; }
            set { chieudai = value; }
        }
    }
    public class DuongThangCollection : System.Collections.CollectionBase
    {
        public void Add(DuongThang duongthang)
        {
            List.Add(duongthang);
        }
        public void Remove(int index)
        {
            List.RemoveAt(index);
        }
        public DuongThang Index(int index)
        {
            return (DuongThang)List[index];
        }
    }
}
