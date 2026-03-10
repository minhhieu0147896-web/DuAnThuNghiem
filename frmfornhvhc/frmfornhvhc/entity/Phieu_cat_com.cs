using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmfornhvhc.entity
{
    internal class Phieu_cat_com
    {
        private int phieucatcom_id;
        private int buoian_id;
        private string ngay_thang_nam;
        private int quannhan_id;
        private string phieucatcom_lydo;

        // 3. Constructor co tham so
        public Phieu_cat_com(int id, int id_buoian, string ngaythang, int id_quannhan, string lydo)
        {
            phieucatcom_id = id;
            buoian_id = id_buoian;
            ngay_thang_nam = ngaythang;
            quannhan_id = id_quannhan;
            phieucatcom_lydo = lydo;
        }

        // 4. Cac thuoc tinh (Properties) get/set
        public int id
        {
            get { return phieucatcom_id; }
            set { phieucatcom_id = value; }
        }

        public int id_buoian
        {
            get { return buoian_id; }
            set { buoian_id = value; }
        }

        public string ngaythang
        {
            get { return ngay_thang_nam; }
            set { ngay_thang_nam = value; }
        }

        public int id_quannhan
        {
            get { return quannhan_id; }
            set { quannhan_id = value; }
        }

        public string lydo
        {
            get { return phieucatcom_lydo; }
            set { phieucatcom_lydo = value; }
        }
    }
}
