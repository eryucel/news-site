using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebProje.Models
{
    public class Yorum
    {
        public int YorumId { get; set; }
        public int UyeId { get; set; }
        public int HaberId { get; set; }
        public string Icerik { get; set; }
        public DateTime YorumTarihi { get; set; }
        public bool? Onay { get; set; }
        //Alttaki ikili foreign key olmasını sağlıyor.
        public virtual Uye Uye { get; set; }
        public virtual Haber Haber { get; set; }
    }
}