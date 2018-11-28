using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebProje.Models;

namespace WebProje.DAL
{
    public class DenemeData : System.Data.Entity.DropCreateDatabaseIfModelChanges<WebProjeContext>
    {
        protected override void Seed(WebProjeContext context)
        {
            var Adminler = new List<Admin>
            {
                new Admin {Ad="Melih",Soyad="Güler",KulAdi="melgul",EPosta="melihguler@gmail.com",Sifre="123123123",Yetki="Var",UyelikTarihi=DateTime.Parse("01-01-1999")},
                new Admin { Ad = "Hakan", Soyad = "Eryücel", KulAdi = "haker", EPosta = "hakaneryucel@gmail.com", Sifre = "321321321", Yetki = "Var", UyelikTarihi = DateTime.Parse("02-02-1999") }
            };
            Adminler.ForEach(s => context.Adminler.Add(s));
            context.SaveChanges();
            var Uyeler = new List<Uye>
            {
                new Uye {Ad="Recep Faruk",Soyad="Adak",KulAdi="recad",EPosta="recepadak@gmail.com",Sifre="789789789",UyelikTarihi=DateTime.Parse("03-03-1999")},
                new Uye { Ad = "Faruk", Soyad = "İpek", KulAdi = "farip", EPosta = "farukipek@gmail.com", Sifre = "987987987",UyelikTarihi = DateTime.Parse("03-03-1999") }
            };
            Uyeler.ForEach(s => context.Uyeler.Add(s));
            context.SaveChanges();
            var Haberler = new List<Haber>
            {
                new Haber {AdminId=1,Icerik="Melih Gülerin Haberi",Foto="olmayanFoto",HaberTarihi=DateTime.Parse("27-11-2018"),Onay=true,Baslik="Baslik1",OkunmaSayisi=78565},
                new Haber {AdminId=2,Icerik="Hakan Eryücelin Haberi",Foto="bufotodayokFoto",HaberTarihi=DateTime.Parse("28-11-2018"),Onay=true,Baslik="Baslik2",OkunmaSayisi=121}
            };
            Haberler.ForEach(s => context.Haberler.Add(s));
            context.SaveChanges();
            var Yorumlar = new List<Yorum>
            {
                new Yorum {UyeId=1,HaberId=1,Icerik="Recep Faruk ADAK Yorumu",YorumTarihi=DateTime.Parse("27-11-2018"),Onay=true},
                new Yorum {UyeId=2,HaberId=2,Icerik="Faruk İPEK Yorumu",YorumTarihi=DateTime.Parse("28-11-2018"),Onay=true}
            };
            Yorumlar.ForEach(s => context.Yorumlar.Add(s));
            context.SaveChanges();
            //base.Seed(context);
        }
    }
}