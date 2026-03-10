using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmfornhvhc.entity
{
    internal class Dinh_luong
    {
        private int thucpham_id;
        private int chedo_id;
        private string dinhluong_donvitinh;
        public Dinh_luong()
        {
            thucpham_id = 0;
            chedo_id = 0;
            dinhluong_donvitinh = "chua xac dinh";
        }
        // 3. Constructor co tham so
        public Dinh_luong(int id_thucpham, int id_chedo, string dvt)
        {
            thucpham_id = id_thucpham;
            chedo_id = id_chedo;
            dinhluong_donvitinh = dvt;
        }

        // 4. Cac thuoc tinh (Properties) get/set
        public int id_thucpham
        {
            get { return thucpham_id; }
            set { thucpham_id = value; }
        }

        public int id_chedo
        {
            get { return chedo_id; }
            set { chedo_id = value; }
        }

        public string dvt
        {
            get { return dinhluong_donvitinh; }
            set { dinhluong_donvitinh = value; }
        }
    }
}
