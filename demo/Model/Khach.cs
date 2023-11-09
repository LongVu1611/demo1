using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace demo.Model
{
    internal class Khach
    {
        private string idkh;
        private string namekh;
        private string address;
        private string phone;
        public Khach() { }

        public Khach(string idkh, string namekh, string address, string phone)
        {
            this.idkh = idkh;
            this.namekh = namekh;
            this.address = address;
            this.phone = phone;
        }

        public String getIdkh() { return idkh; }
        public String getNamekh() { return namekh; }
        public void setIdkh(String idkh) { this.idkh = idkh; }
        public void setNamekh(String namekh) { this.namekh = namekh; }
        public String getAddress() { return address; }
        public void setAddress(String address) { this.address = address; }
        public String getPhone() { return phone; }
        public void setPhone(String phone) { this.phone = phone; }
        public String toString()
        { return idkh + namekh + address + phone; }
    }
}
