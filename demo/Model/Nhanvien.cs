using Org.BouncyCastle.Crypto;
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
            this.idnv = idnv;
            this.tennv = tennv;
            this.ngaysinh = ngaysinh;
            this.email = email;
            this.sdt = sdt;
            this.diachi = diachi;
            this.sodon = sodon;
        }
        public String getIdnv() { return idnv; }
        public String getTennv() { return tennv; }
        public void setIdnv(String idnv) { this.idnv = idnv; }
        public void setTennv(String tennv) { this.tennv = tennv; }
        public DateTime getNgaysinh() { return ngaysinh; }
        public void setNgaysinh(DateTime ngaysinh) { this.ngaysinh = ngaysinh; }
        public String getEmail() { return email; }
        public void setEmail(String email) { this.email = email; }
        public String getSdt() { return sdt; }
        public void setSdt(String sdt) { this.sdt = sdt; }
        public String getDiachi() { return diachi; }
        public void setDiachi(String diachi) { this.diachi = diachi; }
        public int getSodon() { return sodon; }
        public void setSodon(int sodon) { this.sodon = sodon; }
        public String toString()
        { return idnv + tennv + ngaysinh + email + sdt + diachi + sodon; }
    }
}
