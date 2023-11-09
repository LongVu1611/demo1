using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace demo.Model
{
    internal class Sanpham
    {
        private string idsp;
        private string namesp;
        private string soluong;
        private string xuatxu;
        private string tinhtrang;
        private string giavon;
        private string giathue;

        public Sanpham() { }
        public Sanpham(string idsp, string namesp, string soluong, string xuatxu, string tinhtrang, string giavon, string giathue)
        {
            this.idsp = idsp;
            this.namesp = namesp;
            this.soluong = soluong;
            this.xuatxu = xuatxu;
            this.tinhtrang = tinhtrang;
            this.giavon = giavon;
            this.giathue = giathue;
        }


        public String getIdsp() { return idsp; }
        public String getNamesp() { return namesp; }
        public void setIdsp(String idsp) { this.idsp = idsp; }
        public void setNamesp(String namesp) { this.namesp = namesp; }
        public String getSoluong() { return soluong; }
        public void setSoluong(String soluong) { this.soluong = soluong; }
        public String getXuatxu() { return xuatxu; }
        public void setXuatxu(String xuatxu) { this.xuatxu = xuatxu; }
        public String getTinhtrang() { return tinhtrang; }
        public void setTinhtrang(String tinhtrang) { this.tinhtrang = tinhtrang; }
        public String getGiavon() { return giavon; }
        public void setGiavon(String giavon) { this.giavon = giavon; }
        public String getGiathue() { return giathue; }
        public void setGiathue(String giathue) { this.giathue = giathue; }
        public String toString()
        { return idsp + namesp + soluong + xuatxu + tinhtrang + giavon + giathue; }
    }
}
