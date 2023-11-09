using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Model
{
    internal class Chitiet
    {
        private int id;
        private string idp;
        private string idsp;
        private int songay;
        private int hoadon;

        public Chitiet()
        {

        }

        public Chitiet(int id, string idpn, string idsp, int songay, int hoadon)
        {
            this.id = id;
            this.idp = idpn;
            this.idsp = idsp;
            this.songay = songay;
            this.hoadon = hoadon;
        }
        public int getId() { return id; }
        public String getIdp() { return idp; }
        public String getIdsp() { return idsp; }
        public int getSongay() { return songay; }
        public int getHoadon() { return hoadon; }

        public void setId(int id) { this.id = id; }
        public void setIdp(string idp) { this.idp = idp; }
        public void setIdsp(string idsp) { this.idsp = idsp; }
        public void setSongay(int songay) { this.songay = songay; }
        public void setHoadon(int hoadon) { this.hoadon = hoadon; }
        public String toString()
        {
            return id + idp + idsp + songay + hoadon;
        }
    }
    
}
