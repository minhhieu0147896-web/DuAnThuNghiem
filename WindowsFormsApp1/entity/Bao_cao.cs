using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.entity
{
    internal class Bao_cao
    {
        private int baocao_id;
        private string ngay_thang_nam;
        private int donvi_id;
        private int tong_chi_phi;
        private long tong_tien_cat_com;
        private string trang_thai;
        private string ngay_lap;
        public Bao_cao()
        {
            baocao_id = 0;
            ngay_thang_nam = "chua xac dinh";
            donvi_id = 0;
            tong_chi_phi = 0;
            tong_tien_cat_com = 0;
            trang_thai = "chua xac dinh";
            ngay_lap = "chua xac dinh";
        }
    }
    // 4. Cac thuoc tinh (Properties) get/set
        public int id
        {
            get { return baocao_id; }
            set { baocao_id = value; }
        }

        public string ngaythang
        {
            get { return ngay_thang_nam; }
            set { ngay_thang_nam = value; }
        }

        public int id_donvi
        {
            get { return donvi_id; }
            set { donvi_id = value; }
        }

        public int chiphi
        {
            get { return tong_chi_phi; }
            set { tong_chi_phi = value; }
        }

        public long tiencatcom
        {
            get { return tong_tien_cat_com; }
            set { tong_tien_cat_com = value; }
        }

        public string trangthai
        {
            get { return trang_thai; }
            set { trang_thai = value; }
        }

        public string ngaylap
        {
            get { return ngay_lap; }
            set { ngay_lap = value; }
        }
    }
