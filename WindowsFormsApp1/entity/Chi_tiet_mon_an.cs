using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.entity
{
    internal class Chi_tiet_mon_an
    {
        private int monan_id;
        private int thucpham_id;
        private string chitietmonan_soluong;
        public Chi_tiet_mon_an()
        {
            monan_id = 0;
            thucpham_id = 0;
            chitietmonan_soluong = "chua xac dinh";
        }
    }
    // 3. Constructor co tham so
        public Chi_tiet_mon_an(int id_monan, int id_thucpham, string soluong)
        {
            monan_id = id_monan;
            thucpham_id = id_thucpham;
            chitietmonan_soluong = soluong;
        }

        // 4. Cac thuoc tinh (Properties) get/set
        public int id_monan
        {
            get { return monan_id; }
            set { monan_id = value; }
        }

        public int id_thucpham
        {
            get { return thucpham_id; }
            set { thucpham_id = value; }
        }

        public string soluong
        {
            get { return chitietmonan_soluong; }
            set { chitietmonan_soluong = value; }
        }
    }
