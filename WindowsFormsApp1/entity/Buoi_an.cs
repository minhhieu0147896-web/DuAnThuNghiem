using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.entity
{
    internal class Buoi_an
    {
        private int buoian_id;
        private string buoian_ten;
        private string buoian_tiletienan;
        public Buoi_an()
        {
            buoian_id = 0;
            buoian_ten = "chua xac dinh";
            buoian_tiletienan = "chua xac dinh";
        }
    }
    // 3. Constructor co tham so
        public Buoi_an(int id, string ten, string tile)
        {
            buoian_id = id;
            buoian_ten = ten;
            buoian_tiletienan = tile;
        }

        // 4. Cac thuoc tinh (Properties) get/set
        public int id
        {
            get { return buoian_id; }
            set { buoian_id = value; }
        }

        public string ten
        {
            get { return buoian_ten; }
            set { buoian_ten = value; }
        }

        public string tile
        {
            get { return buoian_tiletienan; }
            set { buoian_tiletienan = value; }
        }
    }
