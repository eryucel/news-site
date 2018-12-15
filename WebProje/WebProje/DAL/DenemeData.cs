using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebProje.Models;

namespace WebProje.DAL
{
    public class DenemeData:System.Data.Entity.DropCreateDatabaseIfModelChanges<VeriContext>
    {
        protected override void Seed(VeriContext context)
        {
            var Adminler = new List<Admin>
            {
                new Admin {Ad="Melih",Soyad="Güler",KulAdi="melgul",EPosta="melihguler@gmail.com",Sifre="123123123",Yetki="Var",UyelikTarihi=DateTime.Parse("01-01-1999")},
                new Admin {Ad = "Hakan", Soyad = "Eryücel", KulAdi = "haker", EPosta = "hakaneryucel@gmail.com", Sifre = "321321321", Yetki = "Var", UyelikTarihi = DateTime.Parse("02-02-1999") }
            };
            Adminler.ForEach(s => context.Adminler.Add(s));
            context.SaveChanges();
            var Uyeler = new List<Uye>
            {
                new Uye {Ad="Ali",Soyad="Veli",KulAdi="AliVeli",EPosta="aliveli@gmail.com",Sifre="12312312",UyelikTarihi=DateTime.Parse("2018-11-11")},
                new Uye {Ad="Deli",Soyad="Meli",KulAdi="DeliMeli",EPosta="delimeli@gmail.com",Sifre="32132132",UyelikTarihi=DateTime.Parse("2018-11-11")}
            };
            Uyeler.ForEach(s => context.Uyeler.Add(s));
            context.SaveChanges();
            var Haberler = new List<Haber>
            {
                new Haber {AdminID=1,Icerik="Melih Gülerin Haberi",Foto="https://img.fanatik.com.tr/img/78/700x0/5c01479866a97cdcd4229c47",Kategori=Kategoriler.Futbol,Takim=Takim.Fenerbahce,HaberTarihi=DateTime.Parse("2018-11-28"),Onay=true,Baslik="Baslik1",OkunmaSayisi=364},
                new Haber {AdminID=2,Icerik="Hakan Eryücelin Haberi",Foto="https://img.fanatik.com.tr/img/78/700x0/5c01479866a97cdcd4229c47",Kategori=Kategoriler.Futbol,Takim=Takim.Fenerbahce,HaberTarihi=DateTime.Parse("2018-11-28"),Onay=true,Baslik="Baslik2",OkunmaSayisi=121},
                new Haber {AdminID=2,Icerik="Hakan Eryücelin Haberi",Foto="https://img.fanatik.com.tr/img/78/700x0/5c01479866a97cdcd4229c47",Kategori=Kategoriler.Futbol,Takim=Takim.Fenerbahce,HaberTarihi=DateTime.Parse("2018-11-28"),Onay=true,Baslik="Baslik3",OkunmaSayisi=52},
                new Haber {AdminID=2,Icerik="Hakan Eryücelin Haberi",Foto="https://img.fanatik.com.tr/img/78/700x0/5c01479866a97cdcd4229c47",Kategori=Kategoriler.Basketbol,Takim=Takim.Fenerbahce,HaberTarihi=DateTime.Parse("2018-11-28"),Onay=true,Baslik="Baslik4",OkunmaSayisi=121},
                new Haber {AdminID=2,Icerik="Hakan Eryücelin Haberi",Foto="https://img.fanatik.com.tr/img/78/700x0/5c01479866a97cdcd4229c47",Kategori=Kategoriler.Basketbol,Takim=Takim.Fenerbahce,HaberTarihi=DateTime.Parse("2018-11-28"),Onay=true,Baslik="Baslik5",OkunmaSayisi=521},
                new Haber {AdminID=2,Icerik="Hakan Eryücelin Haberi",Foto="https://img.fanatik.com.tr/img/78/700x0/5c01479866a97cdcd4229c47",Kategori=Kategoriler.Voleybol,Takim=Takim.Galatasaray,HaberTarihi=DateTime.Parse("2018-11-28"),Onay=true,Baslik="Baslik6",OkunmaSayisi=121},
                 new Haber {AdminID=1,Icerik="Melih Gülerin Haberi",Foto="https://img.fanatik.com.tr/img/78/700x0/5c01479866a97cdcd4229c47",Kategori=Kategoriler.Futbol,Takim=Takim.Fenerbahce,HaberTarihi=DateTime.Parse("2018-11-28"),Onay=true,Baslik="Baslik1",OkunmaSayisi=41},
                new Haber {AdminID=2,Icerik="Hakan Eryücelin Haberi",Foto="https://img.fanatik.com.tr/img/78/700x0/5c01479866a97cdcd4229c47",Kategori=Kategoriler.Futbol,Takim=Takim.Fenerbahce,HaberTarihi=DateTime.Parse("2018-11-28"),Onay=true,Baslik="Baslik2",OkunmaSayisi=22},
                new Haber {AdminID=2,Icerik="Hakan Eryücelin Haberi",Foto="https://img.fanatik.com.tr/img/78/700x0/5c01479866a97cdcd4229c47",Kategori=Kategoriler.Futbol,Takim=Takim.Galatasaray,HaberTarihi=DateTime.Parse("2018-11-28"),Onay=true,Baslik="Baslik3",OkunmaSayisi=10},
                new Haber {AdminID=2,Icerik="Hakan Eryücelin Haberi",Foto="https://img.fanatik.com.tr/img/78/700x0/5c01479866a97cdcd4229c47",Kategori=Kategoriler.Basketbol,Takim=Takim.Fenerbahce,HaberTarihi=DateTime.Parse("2018-11-28"),Onay=true,Baslik="Baslik4",OkunmaSayisi=15},
                new Haber {AdminID=2,Icerik="Hakan Eryücelin Haberi",Foto="https://img.fanatik.com.tr/img/78/700x0/5c01479866a97cdcd4229c47",Kategori=Kategoriler.Basketbol,Takim=Takim.Fenerbahce,HaberTarihi=DateTime.Parse("2018-11-28"),Onay=true,Baslik="Baslik5",OkunmaSayisi=22},
                new Haber {AdminID=2,Icerik="Hakan Eryücelin Haberi",Foto="https://img.fanatik.com.tr/img/78/700x0/5c01479866a97cdcd4229c47",Kategori=Kategoriler.Voleybol,Takim=Takim.Besiktas,HaberTarihi=DateTime.Parse("2018-11-28"),Onay=true,Baslik="Baslik6",OkunmaSayisi=22},
                 new Haber {AdminID=1,Icerik="Melih Gülerin Haberi",Foto="https://img.fanatik.com.tr/img/78/700x0/5c01479866a97cdcd4229c47",Kategori=Kategoriler.Basketbol,Takim=Takim.Fenerbahce,HaberTarihi=DateTime.Parse("2018-11-28"),Onay=true,Baslik="Baslik1",OkunmaSayisi=22},
                new Haber {AdminID=2,Icerik="Hakan Eryücelin Haberi",Foto="https://img.fanatik.com.tr/img/78/700x0/5c01479866a97cdcd4229c47",Kategori=Kategoriler.Futbol,Takim=Takim.Trabzonspor,HaberTarihi=DateTime.Parse("2018-11-28"),Onay=true,Baslik="Baslik2",OkunmaSayisi=22},
                new Haber {AdminID=2,Icerik="Hakan Eryücelin Haberi",Foto="https://img.fanatik.com.tr/img/78/700x0/5c01479866a97cdcd4229c47",Kategori=Kategoriler.Futbol,Takim=Takim.Fenerbahce,HaberTarihi=DateTime.Parse("2018-11-28"),Onay=true,Baslik="Baslik3",OkunmaSayisi=22},
                new Haber {AdminID=2,Icerik="Hakan Eryücelin Haberi",Foto="https://img.fanatik.com.tr/img/78/700x0/5c01479866a97cdcd4229c47",Kategori=Kategoriler.Basketbol,Takim=Takim.Besiktas,HaberTarihi=DateTime.Parse("2018-11-28"),Onay=true,Baslik="Baslik4",OkunmaSayisi=22},
                new Haber {AdminID=2,Icerik="Hakan Eryücelin Haberi",Foto="https://img.fanatik.com.tr/img/78/700x0/5c01479866a97cdcd4229c47",Kategori=Kategoriler.Basketbol,Takim=Takim.MilliTakim,HaberTarihi=DateTime.Parse("2018-11-28"),Onay=true,Baslik="Baslik5",OkunmaSayisi=22},
                new Haber {AdminID=2,Icerik="Hakan Eryücelin Haberi",Foto="https://img.fanatik.com.tr/img/78/700x0/5c01479866a97cdcd4229c47",Kategori=Kategoriler.Voleybol,Takim=Takim.Fenerbahce,HaberTarihi=DateTime.Parse("2018-11-28"),Onay=true,Baslik="Baslik6",OkunmaSayisi=22},
                 new Haber {AdminID=1,Icerik="Melih Gülerin Haberi",Foto="https://img.fanatik.com.tr/img/78/700x0/5c01479866a97cdcd4229c47",Kategori=Kategoriler.Futbol,Takim=Takim.Fenerbahce,HaberTarihi=DateTime.Parse("2018-11-28"),Onay=true,Baslik="Baslik1",OkunmaSayisi=22},
                new Haber {AdminID=2,Icerik="Hakan Eryücelin Haberi",Foto="https://img.fanatik.com.tr/img/78/700x0/5c01479866a97cdcd4229c47",Kategori=Kategoriler.Futbol,Takim=Takim.Fenerbahce,HaberTarihi=DateTime.Parse("2018-11-28"),Onay=true,Baslik="Baslik2",OkunmaSayisi=22},
                new Haber {AdminID=2,Icerik="Hakan Eryücelin Haberi",Foto="https://img.fanatik.com.tr/img/78/700x0/5c01479866a97cdcd4229c47",Kategori=Kategoriler.Futbol,Takim=Takim.Fenerbahce,HaberTarihi=DateTime.Parse("2018-11-28"),Onay=true,Baslik="Baslik3",OkunmaSayisi=22},
                new Haber {AdminID=2,Icerik="Hakan Eryücelin Haberi",Foto="https://img.fanatik.com.tr/img/78/700x0/5c01479866a97cdcd4229c47",Kategori=Kategoriler.Basketbol,Takim=Takim.Fenerbahce,HaberTarihi=DateTime.Parse("2018-11-28"),Onay=true,Baslik="Baslik4",OkunmaSayisi=22},
                new Haber {AdminID=2,Icerik="Hakan Eryücelin Haberi",Foto="https://img.fanatik.com.tr/img/78/700x0/5c01479866a97cdcd4229c47",Kategori=Kategoriler.Basketbol,Takim=Takim.Fenerbahce,HaberTarihi=DateTime.Parse("2018-11-28"),Onay=true,Baslik="Baslik5",OkunmaSayisi=22},
                new Haber {AdminID=2,Icerik="Hakan Eryücelin Haberi",Foto="https://img.fanatik.com.tr/img/78/700x0/5c01479866a97cdcd4229c47",Kategori=Kategoriler.Voleybol,Takim=Takim.Fenerbahce,HaberTarihi=DateTime.Parse("2018-11-28"),Onay=true,Baslik="Baslik6",OkunmaSayisi=22},
                new Haber {AdminID=2,Icerik="Hakan Eryücelin Haberi",Foto="https://img.fanatik.com.tr/img/78/700x0/5c01479866a97cdcd4229c47",Kategori=Kategoriler.Diger,Takim=Takim.Fenerbahce,HaberTarihi=DateTime.Parse("2018-11-28"),Onay=true,Baslik="Baslik7",OkunmaSayisi=22}
            };
            Haberler.ForEach(s => context.Haberler.Add(s));
            context.SaveChanges();
            var Yorumlar = new List<Yorum>
            {
                new Yorum {UyeID=1,HaberId=1,Icerik="Yorum yaptım",YorumTarihi=DateTime.Parse("2018-11-11"),Onay=true },
                new Yorum {UyeID=1,HaberId=2,Icerik="Yorum yapmışım",YorumTarihi=DateTime.Parse("2018-11-11"),Onay=true },
                new Yorum {UyeID=2,HaberId=3,Icerik="Yorum yapıldı",YorumTarihi=DateTime.Parse("2018-11-11"),Onay=true },
                new Yorum {UyeID=2,HaberId=4,Icerik="Yorum yapılmış",YorumTarihi=DateTime.Parse("2018-11-11"),Onay=true }
            };
            Yorumlar.ForEach(s=>context.Yorumlar.Add(s));
            context.SaveChanges();
            base.Seed(context);
        }
    }
}