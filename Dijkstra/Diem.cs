using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dijkstra
{
    public class Diem
    {
        int a;
        int b;
        string ten;
        public Diem()
        {
            a = -1;
            b = -1;
        }
        public int A
        {
            get { return a; }
            set { a = value; }
        }
        public int B
        {
            get { return b; }
            set { b = value; }
        }
        public string Ten
        {
            get{return ten;}
            set{ten=value;}
        }


    }
    public class DiemCollection : System.Collections.CollectionBase
    {

        public void Add(Diem diem)
        {
            List.Add(diem);
        }
        public void Remove(int index)
        {
            List.RemoveAt(index);
        }
        public Diem Index(int index)
        {
            return (Diem)List[index];
        }
    }
}
