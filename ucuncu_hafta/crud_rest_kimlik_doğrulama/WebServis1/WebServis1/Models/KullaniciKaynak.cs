using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServis1.Models
{
    public class KullaniciKaynak
    {
        public static List<KullaniciBilgisi> ButunKullanicilariAl()
        {
            dbOrnekEntities VeriIcerigi = new dbOrnekEntities();
            var sorgu = from kullanici in VeriIcerigi.KullaniciBilgisi
                        select kullanici;
            return sorgu.ToList();
        }
        public static KullaniciBilgisi KullaniciAl(string kullaniciID)
        {
            dbOrnekEntities VeriIcerigi = new dbOrnekEntities();
            var sorgu = (from kullanici in VeriIcerigi.KullaniciBilgisi

                         where kullanici.KullaniciID == kullaniciID
                         select kullanici).SingleOrDefault();
            return sorgu;
        }
        public static void KullaniciEkle(KullaniciBilgisi YeniKullanici)
        {
            dbOrnekEntities VeriIcerigi = new dbOrnekEntities();
            VeriIcerigi.KullaniciBilgisi.Add(YeniKullanici);
            VeriIcerigi.SaveChanges();
        }
        public static void KullaniciGuncelle(KullaniciBilgisi EskiKullanici)
        {
            dbOrnekEntities VeriIcerigi = new dbOrnekEntities();
            var sorgu = (from kullanici in VeriIcerigi.KullaniciBilgisi
                         where kullanici.KullaniciID == EskiKullanici.KullaniciID
                         select kullanici).SingleOrDefault();
            sorgu.KullaniciAdi = EskiKullanici.KullaniciAdi;
            sorgu.Adres = EskiKullanici.Adres;
            VeriIcerigi.SaveChanges();
        }
        public static void KullaniciSil(string kullaniciID)
        {
            dbOrnekEntities VeriIcerigi = new dbOrnekEntities();
            var sorgu = (from kullanici in VeriIcerigi.KullaniciBilgisi
                         where kullanici.KullaniciID == kullaniciID
                         select kullanici).SingleOrDefault();
            VeriIcerigi.KullaniciBilgisi.Remove(sorgu);
            VeriIcerigi.SaveChanges();
        }
    }
}