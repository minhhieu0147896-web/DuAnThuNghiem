using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.entity
{
    internal class Quan_nhan
    {
        private int quannhan_id;
        private string quannhan_hoten;
        private string quannhan_capbac;
        private string quannhan_chucvu;
        private int donvi_id;
        private int chedo_id;
        private string quannhan_binhchung;
        public Quan_nhan()
        {
            quannhan_id = 0;
            quannhan_hoten = "chua xac dinh";
            quannhan_capbac= "chua xac dinh";
            quannhan_chucvu = "chua xac dinh";
            donvi_id = 0;
            chedo_id = 0;
            quannhan_binhchung = "chua xac dinh";
        }
        // 3. Constructor co tham so
        public Quan_nhan(int id, string hoten, string capbac, string chucvu, int id_donvi, int id_chedo, string binhchung)
        {
            quannhan_id = id;
            quannhan_hoten = hoten;
            quannhan_capbac = capbac;
            quannhan_chucvu = chucvu;
            donvi_id = id_donvi;
            chedo_id = id_chedo;
            quannhan_binhchung = binhchung;
        }

        // 4. Cac thuoc tinh (Properties) get/set
        public int id
        {
            get { return quannhan_id; }
            set { quannhan_id = value; }
        }

        public string hoten
        {
            get { return quannhan_hoten; }
            set { quannhan_hoten = value; }
        }

        public string capbac
        {
            get { return quannhan_capbac; }
            set { quannhan_capbac = value; }
        }

        public string chucvu
        {
            get { return quannhan_chucvu; }
            set { quannhan_chucvu = value; }
        }

        public int id_donvi
        {
            get { return donvi_id; }
            set { donvi_id = value; }
        }

        public int id_chedo
        {
            get { return chedo_id; }
            set { chedo_id = value; }
        }

        public string binhchung
        {
            get { return quannhan_binhchung; }
            set { quannhan_binhchung = value; }
        }
    }
}
