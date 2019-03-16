using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Principal;
using System.Threading;
using System.Net.Http.Headers;
using System.Text;

namespace WebServis1.Modules
{
    public class CBAModule
        : IHttpModule
    {

        public void Dispose()
        {

        }
        public void Init(HttpApplication Baglam)
        {
            Baglam.AuthenticateRequest += Baglam_AuthenticateRequest;
            Baglam.EndRequest += Baglam_EndRequest;
        }

        private void Baglam_EndRequest(object sender, EventArgs e)
        {
            /*dibag*/var tepki = HttpContext.Current.Response;
            if (tepki.StatusCode == 401)
            {
                tepki.Headers.Add("WWW-Authenticate","Basic realm=\"insert for realm\"");
            }
        }

        private void Baglam_AuthenticateRequest(object sender, EventArgs e)
        {
            /*dibag*/var istek = HttpContext.Current.Request;
            var baslik = istek.Headers["Authorization"];
            if (baslik != null)
            {
                var ayristirilmisDeger = AuthenticationHeaderValue.Parse(baslik);
                if (ayristirilmisDeger.Scheme.Equals("basic", StringComparison.OrdinalIgnoreCase) && ayristirilmisDeger.Parameter != null)
                {
                    Authenticate(ayristirilmisDeger.Parameter);
                }
            }
        }
        private bool Authenticate(string KimlikBilgisi)
        {
            bool gecerli=false;
            try
            {
                var KimlikBilgileri = Encoding
                    .GetEncoding("iso-8859-1")
                    .GetString(Convert.FromBase64String(KimlikBilgisi));
                var deger = KimlikBilgileri.Split(':');
                gecerli = KullaniciKontrol(KullaniciAdi: deger[0], Sifre: deger[1]);
                if (gecerli)
                {
                    AsaletAyarla(new GenericPrincipal(new GenericIdentity(deger[0]), null));
                }
            }
            catch
            {
                gecerli = false;
            }
            return gecerli;
        }

        private bool KullaniciKontrol(string KullaniciAdi, string Sifre)
        {
            return (KullaniciAdi == "furkan" && Sifre == "1234");
        }
        private static void AsaletAyarla(IPrincipal principal)
        {
            Thread.CurrentPrincipal = principal;
            if (HttpContext.Current != null)
            {
                HttpContext.Current.User = principal;
            }
        }
    }
}