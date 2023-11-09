using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace demo.Model
{
    internal class Phieuthue
    {
        private string id;
        private string idnv;
        private string idkh;
        private DateTime datethue;
        private DateTime datetra;
        private string tientra;
        public Phieuthue() { }

        public Phieuthue(string id, string idnv, string idkh, DateTime datethue, DateTime datetra, string tientra)
        {
            this.id = id;
            this.idnv = idnv;
            this.idkh = idkh;
            this.datethue = datethue;
            this.datetra = datetra;
            this.tientra = tientra;
        }
        public String getId() { return id; }
        public String getIdnv() { return idnv; }
        public void setId(String id) { this.id = id; }
        public void setIdnv(String idnv) { this.idnv = idnv; }
        public String getIdkh() { return idkh; }
        public void setIdkh(String idkh) { this.idkh = idkh; }
        public DateTime getDatethue() { return datethue; }
        public void setDatethue(DateTime datethue) { this.datethue = datethue; }
        public DateTime getDatetra() { return datetra; }
        public void setDatetra(DateTime datetra) { this.datetra = datetra; }
        public String getTientra() { return tientra; }
        public void setTientra(String tientra) { this.tientra = tientra; }
        public String toString ()
        {
            return id + idnv + idkh + datethue + datetra + tientra;
        }
    }

}
