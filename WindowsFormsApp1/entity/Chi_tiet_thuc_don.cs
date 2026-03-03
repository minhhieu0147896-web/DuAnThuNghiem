using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.entity
{
    internal class Chi_tiet_thuc_don
    {
        private int thucdon_id;
        private int monan_id;
        private string ngay_thang_nam;
        private int buoian_id;
        private string thuc_te;
        private string ly_do;
        public Chi_tiet_thuc_don()
        {
            thucdon_id = 0;
            ngay_thang_nam = "chua xac dinh";
            buoian_id = 0;
            monan_id = 0;
            thuc_te = "chua xac dinh";
            ly_do = "chua xac dinh";
        }
    }
    // 4. Cac thuoc tinh (Properties) get/set
        public int id_thucdon
        {
            get { return thucdon_id; }
            set { thucdon_id = value; }
        }

        public int id_monan
        {
            get { return monan_id; }
            set { monan_id = value; }
        }

        public string ngaythang
        {
            get { return ngay_thang_nam; }
            set { ngay_thang_nam = value; }
        }

        public int id_buoian
        {
            get { return buoian_id; }
            set { buoian_id = value; }
        }

        public string thucte
        {
            get { return thuc_te; }
            set { thuc_te = value; }
        }

        public string lydo
        {
            get { return ly_do; }
            set { ly_do = value; }
        }
    }
