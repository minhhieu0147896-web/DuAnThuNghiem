using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.entity
{
    internal class Thuc_pham
    {
        private int thucpham_id;
        private string thucpham_ten;
        private int chedo_id;
        private string thucpham_donvitinh;
        private string giatien;
        private string thucpham_protein;
        private string thucpham_lipid;
        public Thuc_pham()
        {
            thucpham_id = 0;
            thucpham_ten = "chua xac dinh";
            thucpham_donvitinh = "chua xac dinh";
            chedo_id = 0;
            giatien = "chua xac dinh";
            thucpham_protein = "chua xac dinh";
            thucpham_lipid = "chua xac dinh";
        }
        // 3. Constructor co tham so
        public Thuc_pham(int id, string ten, int id_chedo, string dvt, string gia, string protein, string lipid)
        {
            thucpham_id = id;
            thucpham_ten = ten;
            chedo_id = id_chedo;
            thucpham_donvitinh = dvt;
            giatien = gia;
            thucpham_protein = protein;
            thucpham_lipid = lipid;
        }

        // 4. Cac thuoc tinh (Properties) get/set
        public int id
        {
            get { return thucpham_id; }
            set { thucpham_id = value; }
        }

        public string ten
        {
            get { return thucpham_ten; }
            set { thucpham_ten = value; }
        }

        public int id_chedo
        {
            get { return chedo_id; }
            set { chedo_id = value; }
        }

        public string dvt
        {
            get { return thucpham_donvitinh; }
            set { thucpham_donvitinh = value; }
        }

        public string gia
        {
            get { return giatien; }
            set { giatien = value; }
        }

        public string protein
        {
            get { return thucpham_protein; }
            set { thucpham_protein = value; }
        }

        public string lipid
        {
            get { return thucpham_lipid; }
            set { thucpham_lipid = value; }
        }
    }
}
