using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dijkstra
{
    public class BangGhiFloyd
    {
        string dau;
        string trunggian;
        string cuoi;
        int chieudai;
        public BangGhiFloyd()
        {
            dau = "";
            cuoi = "";
            trunggian = "";
            chieudai = -1;
        }

        public string Dau
        {
            get { return dau; }
            set { dau = value; }
        }
        public string TrungGian
        {
            get { return trunggian; }
            set { trunggian = value; }
        }
        public string Cuoi
        {
            get { return cuoi; }
            set { cuoi = value; }
        }
        public int ChieuDai
        {
            get { return chieudai; }
            set { chieudai = value; }
        }
    }
    public class BangGhiFloydCollection : System.Collections.CollectionBase
    {
        public BangGhiFloyd Index(int index)
        {
            return (BangGhiFloyd)List[index];
        }
        public void Remove(int index)
        {
            List.RemoveAt(index);
        }
        public void Add(BangGhiFloyd bangghi)
        {
            List.Add(bangghi);
        }
    }
}
