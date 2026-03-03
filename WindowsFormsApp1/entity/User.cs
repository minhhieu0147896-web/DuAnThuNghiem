using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.entity
{
    internal class User
    {
        private int user_id;
        private int quannhan_id;
        private string user_taikhoan;
        private string user_matkhau;
        private string user_vaitro;
        public User()
        {
            user_id = 0;
            quannhan_id = 0;
            user_taikhoan = "chua xac dinh";
            user_matkhau = "chua xac dinh";
            user_vaitro = "chua xac dinh";
        }
        // 3. Constructor co tham so
        public User(int id, int id_quannhan, string taikhoan, string matkhau, string vaitro)
        {
            user_id = id;
            quannhan_id = id_quannhan;
            user_taikhoan = taikhoan;
            user_matkhau = matkhau;
            user_vaitro = vaitro;
        }

        // 4. Cac thuoc tinh (Properties) get/set
        public int id
        {
            get { return user_id; }
            set { user_id = value; }
        }

        public int id_quannhan
        {
            get { return quannhan_id; }
            set { quannhan_id = value; }
        }

        public string taikhoan
        {
            get { return user_taikhoan; }
            set { user_taikhoan = value; }
        }

        public string matkhau
        {
            get { return user_matkhau; }
            set { user_matkhau = value; }
        }

        public string vaitro
        {
            get { return user_vaitro; }
            set { user_vaitro = value; }
        }
    }
}
