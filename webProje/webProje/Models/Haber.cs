using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebProje.Models
{
    public class Haber
    {
        public int HaberId { get; set; }
        public int AdminId { get; set; }
        public string Icerik { get; set; }
        public string Foto { get; set; }
        public DateTime? HaberTarihi { get; set; }
        public bool? Onay { get; set; }
        public string Baslik{ get; set; }
        public int OkunmaSayisi { get; set; }
        public virtual ICollection<Yorum> Yorumlar { get; set; }

        public virtual Admin Admin { get; set; }
    }
}