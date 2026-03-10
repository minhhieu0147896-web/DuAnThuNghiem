using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmfornhvhc.entity
{
    internal class Che_do
    {
        private int chedo_id;
        private string chedo_ten;
        private long chedo_tienan;
        private string chedo_binhchung;
        private string chedo_mucdo;
        public Che_do()
        {
            chedo_id = 0;
            chedo_tienan = 0;
            chedo_ten = "chua xac dinh";
            chedo_binhchung = "chua xac dinh";
            chedo_mucdo = "chua xac dinh";
        }

        // 3. Constructor co tham so
        public Che_do(int id, string ten, long tienan, string binhchung, string mucdo)
        {
            chedo_id = id;
            chedo_ten = ten;
            chedo_tienan = tienan;
            chedo_binhchung = binhchung;
            chedo_mucdo = mucdo;
        }

        // 4. Cac thuoc tinh (Properties) get/set
        public int id
        {
            get { return chedo_id; }
            set { chedo_id = value; }
        }

        public string ten
        {
            get { return chedo_ten; }
            set { chedo_ten = value; }
        }

        public long tienan
        {
            get { return chedo_tienan; }
            set { chedo_tienan = value; }
        }

        public string binhchung
        {
            get { return chedo_binhchung; }
            set { chedo_binhchung = value; }
        }

        public string mucdo
        {
            get { return chedo_mucdo; }
            set { chedo_mucdo = value; }
        }
    }
}
