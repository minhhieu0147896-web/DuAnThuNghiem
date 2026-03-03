using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_li_tieu_chuan_an.entity
{
    internal class Don_vi
    {
        private int donvi_id;
        private string donvi_ten;
        private string donvi_cap;
        public Don_vi()
        {
            donvi_id = 0;
            donvi_ten = "chua xac dinh";
            donvi_cap = "chua xac dinh";
        }
        public Don_vi(int id, string ten, string cap)
        {
            donvi_id = id;
            donvi_ten = ten;
            donvi_cap = cap;
        }

        public int id
        {
            get { return donvi_id; }
            set { donvi_id = value; }
        }

        public string ten
        {
            get { return donvi_ten; }
            set { donvi_ten = value; }
        }

        public string cap
        {
            get { return donvi_cap; }
            set { donvi_cap = value; }
        }
    }

}
