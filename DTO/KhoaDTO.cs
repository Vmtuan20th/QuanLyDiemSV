using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhoaDTO
    {
        private string makhoa;
        private string tenkhoa;
        private string diachi;
        private float sdt;

        public string Makhoa { get => makhoa; set => makhoa = value; }
        public string Tenkhoa { get => tenkhoa; set => tenkhoa = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public float Sdt { get => sdt; set => sdt = value; }
    }
}
