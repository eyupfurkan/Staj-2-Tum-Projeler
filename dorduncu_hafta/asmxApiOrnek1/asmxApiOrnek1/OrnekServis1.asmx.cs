using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace asmxApiOrnek1
{
    /// <summary>
    /// Summary description for OrnekServis1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class OrnekServis1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public string Kimsin(string Ad)
        {
            //Parametre olarak verilen ismin başına "Merhaba" ifadesini yerleştirip geriye döndüren metod
            return "Merhaba " + Ad;
        }

        [WebMethod]
        public bool UyeKontrol(string kullanici, string sifre)
        {
            // Aldığı iki parametreyi sabit değerler ile kıyaslayıp geriye bool bir değer döndürür.
            bool kontrol = false;
            if (kullanici == "Furkan" && sifre == "1234")
            {
                kontrol = true;
            }
            return kontrol;
        }
        List<Insan> kisiler = new List<Insan>() {
        new Insan() {Id=0,AdSoyad="Ali ARIKAN",Tel="05462469491" },
        new Insan() {Id=1,AdSoyad="Ayşe Dudu ARIKAN",Tel="05515501292" },
        new Insan() {Id=2,AdSoyad="Beyza Rumeysa ARIKAN",Tel="05462315283" },
        new Insan() {Id=3,AdSoyad="Adem AKSOY",Tel="05423226730" }, 
        new Insan() {Id=4,AdSoyad="Ahmet ARIKAN",Tel="05432899769" },
        new Insan() {Id=5,AdSoyad="Abdilkadir BİZ",Tel="05434367196" },
        new Insan() {Id=6,AdSoyad="Ali BİÇER",Tel="05366507916" },
        new Insan() {Id=7,AdSoyad="Ali Osman SELVİ",Tel="05367317358 - 05445592513" },
     };

        [WebMethod]
        public Insan KisiGetir(int id)
        {
            return kisiler[id];
        }

        [WebMethod]
        public List<Insan> KisiListesi()
        {
            return kisiler;
        }
    }
}
