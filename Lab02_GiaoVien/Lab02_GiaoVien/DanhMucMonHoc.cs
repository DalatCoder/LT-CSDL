using System.Collections;
using System.Collections.Generic;

namespace Lab02_GiaoVien
{
    public class DanhMucMonHoc
    {
        public List<MonHoc> ds;
        public DanhMucMonHoc()
        {
            ds = new List<MonHoc>();
        }
        public MonHoc this[int index]
        {
            get { return ds[index]; }
            set { ds[index] = value; }
        }
        public void Them(MonHoc mh)
        {
            ds.Add(mh);
        }
        public override string ToString()
        {
            string str = "Danh sach mon hoc: ";
            foreach (var monHoc in ds)
            {
                str += monHoc + "; ";
            }
            return str;
        }
    }
}
