using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmfornhvhc.entity
{
    internal class Mon_an
    {
        private int monan_id;
        private string monan_ten;
        private string monan_loaimon;
        public Mon_an()
        {
            monan_id = 0;
            monan_ten = "chua xac dinh";
            monan_loaimon = "chua xac dinh";
        }

        // 3. Constructor co tham so
        public Mon_an(int id, string ten, string loaimon)
        {
            monan_id = id;
            monan_ten = ten;
            monan_loaimon = loaimon;
        }

        // 4. Cac thuoc tinh (Properties) get/set
        public int id
        {
            get { return monan_id; }
            set { monan_id = value; }
        }

        public string ten
        {
            get { return monan_ten; }
            set { monan_ten = value; }
        }

        public string loaimon
        {
            get { return monan_loaimon; }
            set { monan_loaimon = value; }
        }
    }
}

