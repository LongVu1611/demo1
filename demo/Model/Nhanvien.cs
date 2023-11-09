using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Model
{
    internal class Nhanvien
    {
        private string idnv;
        private string tennv;
        private DateTime ngaysinh;
        private string email;
        private string sdt;
        private string diachi;
        private int sodon;
        public Nhanvien()
        { }
        public Nhanvien(string idnv, string tennv, DateTime ngaysinh, string email, string sdt, string diachi, int sodon)
        {
            this.Idnv = idnv;
            this.Tennv = tennv;
            this.Ngaysinh = ngaysinh;
            this.Email = email;
            this.Sdt = sdt;
            this.Diachi = diachi;
            this.Sodon = sodon;
        }
        public String getIdnv() { return idnv; }
        public string Idnv { get => idnv; set => idnv = value; }
        public string Tennv { get => tennv; set => tennv = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Email { get => email; set => email = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public int Sodon { get => sodon; set => sodon = value; }
    }
}
