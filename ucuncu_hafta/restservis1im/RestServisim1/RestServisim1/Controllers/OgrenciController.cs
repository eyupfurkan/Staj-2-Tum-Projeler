using System.Web.Mvc;
using RestServisim1.Models;
using RestServisim1.OgrenciVeri;
namespace RestServisim1.Controllers
{
    public class OgrenciController : Controller
    {
        // GET: Ogrenci
        public ActionResult OgrenciListele()
        {
            return View(OgrenciData.OgrenciList);
        }
        // GET: Ogrenci/Create
        public ActionResult OgrenciEkle()
        {
            return View();
        }
        // POST: Ogrenci/Create
        [HttpPost]
        public ActionResult OgrenciEkle(Ogrenci yeniOgrenci)
        {
            try
            {
                Ogrenci eklenecekOgrenci = new Ogrenci()
                {
                    Adi = yeniOgrenci.Adi,
                    Soyadi = yeniOgrenci.Soyadi,
                    TcNo = yeniOgrenci.TcNo,
                    BolumAdi = yeniOgrenci.BolumAdi,
                    FakulteAdi = yeniOgrenci.FakulteAdi
                };
                OgrenciData.OgrenciList.Add(eklenecekOgrenci);
                return View();
            }
            catch
            {
                return View();
            }
        }
    }
}
