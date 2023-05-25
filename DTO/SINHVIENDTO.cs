using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SINHVIENDTO
    {
        private string masv;
        private string holotsv;
        private string tensv;
        private string gioitinh;
        private DateTime ngaysinh;
        private string quequan;
        private string malop;

        public string Masv { get => masv; set => masv = value; }
        public string Holotsv { get => holotsv; set => holotsv = value; }
        public string Tensv { get => tensv; set => tensv = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Quequan { get => quequan; set => quequan = value; }
        public string Malop { get => malop; set => malop = value; }
    }
}
