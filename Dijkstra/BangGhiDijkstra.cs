using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dijkstra
{
    public class BangGhiDijkstra
    {
        string tendiem;
        int nhan;
        char danhdau;
        string truoc;
        public BangGhiDijkstra()
        {
            tendiem = "";
            nhan = 10000;
            danhdau = '0';
            truoc = "";
        }
        public string TenDiem
        {
            get { return tendiem;}
            set { tendiem = value; }
        }
        public int Nhan
        {
            get { return nhan; }
            set { nhan = value; }
        }
        public char DanhDau
        {
            get { return danhdau; }
            set { danhdau = value; }
        }
        public string Truoc
        {
            get { return truoc; }
            set { truoc = value; }
        }
    }
    public class BangGhiDijkstraCollection : System.Collections.CollectionBase
    {
        public BangGhiDijkstra Index(int index)
        {
            return (BangGhiDijkstra)List[index];
        }
        public void Remove(int index)
        {
            List.RemoveAt(index);
        }
        public void Add(BangGhiDijkstra bangghi)
        {
            List.Add(bangghi);
        }
    }
}
