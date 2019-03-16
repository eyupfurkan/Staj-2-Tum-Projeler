using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebServis1.Models;

namespace WebServis1.Controllers
{
    public class KullaniciController : ApiController
    {
        public List<KullaniciBilgisi> Get()
        {
            return KullaniciKaynak.ButunKullanicilariAl();
        }
        public KullaniciBilgisi Get(string id)
        {
            return KullaniciKaynak.KullaniciAl(id);
        }
        public void Post([FromBody]KullaniciBilgisi kullanici)
        {
            KullaniciKaynak.KullaniciEkle(kullanici);
        }
        public void Put([FromBody]KullaniciBilgisi kullanici)
        {
            KullaniciKaynak.KullaniciGuncelle(kullanici);
        }
        public void Delete(string id)
        {
            KullaniciKaynak.KullaniciSil(id);
        }
    }
}
