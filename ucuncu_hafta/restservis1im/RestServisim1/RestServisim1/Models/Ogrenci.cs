using System.ComponentModel;

namespace RestServisim1.Models
{
    public class Ogrenci
    {
        public int Id { get; set; }
        [DisplayName("Öğrenci Adı :")]
        public string Adi { get; set; }
        [DisplayName("Ogrenci Soyadı: ")]
        public string Soyadi { get; set; }
        [DisplayName("Tc No : ")]
        public long TcNo { get; set; }

        [DisplayName("Bölümü :")]
        public string BolumAdi { get; set; }

        public virtual Bolum Bolumu { get; set; }

        [DisplayName("Fakültesi :")]
        public string FakulteAdi { get; set; }
        public virtual Fakulte Fakultesi { get; set; }

    }
}