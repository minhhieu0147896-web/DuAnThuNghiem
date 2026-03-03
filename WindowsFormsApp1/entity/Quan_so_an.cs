using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.entity
{
    internal class Quan_so_an
    {
        private int ngay_thang_nam;
        private int chedo_id;
        private int donvi_id;
        private int quansoan_soluong;
        public Quan_so_an()
        {
            ngay_thang_nam = 0;
            chedo_id = 0;
            donvi_id = 0;
            quansoan_soluong = 0;
        }
    }
    // 3. Constructor co tham so
        public Quan_so_an(int ngaythang, int id_chedo, int id_donvi, int soluong)
        {
            ngay_thang_nam = ngaythang;
            chedo_id = id_chedo;
            donvi_id = id_donvi;
            quansoan_soluong = soluong;
        }

        // 4. Cac thuoc tinh (Properties) get/set
        public int ngaythang
        {
            get { return ngay_thang_nam; }
            set { ngay_thang_nam = value; }
        }

        public int id_chedo
        {
            get { return chedo_id; }
            set { chedo_id = value; }
        }

        public int id_donvi
        {
            get { return donvi_id; }
            set { donvi_id = value; }
        }

        public int soluong
        {
            get { return quansoan_soluong; }
            set { quansoan_soluong = value; }
        }
    }
