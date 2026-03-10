using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.entity
{
    internal class Thuc_don
    {
        private int thucdon_id;
        private string user_id;
        private string trang_thai;
        private string ngay_thang_nam;
        public Thuc_don()
        {
            thucdon_id = 0;
            user_id = "chua xac dinh";
            trang_thai = "chua xac dinh";
            ngay_thang_nam = "chua xac dinh";
        }

        // 3. Constructor co tham so
        public Thuc_don(int id, string id_user, string trangthai, string ngaythang)
        {
            thucdon_id = id;
            user_id = id_user;
            trang_thai = trangthai;
            ngay_thang_nam = ngaythang;
        }

        // 4. Cac thuoc tinh (Properties) get/set
        public int id
        {
            get { return thucdon_id; }
            set { thucdon_id = value; }
        }

        public string id_user
        {
            get { return user_id; }
            set { user_id = value; }
        }

        public string trangthai
        {
            get { return trang_thai; }
            set { trang_thai = value; }
        }

        public string ngaythang
        {
            get { return ngay_thang_nam; }
            set { ngay_thang_nam = value; }
        }
    }
}
