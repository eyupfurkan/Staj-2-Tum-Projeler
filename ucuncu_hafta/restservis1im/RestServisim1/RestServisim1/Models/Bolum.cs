using System.Collections.Generic;
using System.ComponentModel;

namespace RestServisim1.Models
{
    public class Bolum
    {
        public int Id { get; set; }

        [DisplayName("Bölüm Adı :")]
        public string Adi { get; set; }

        [DisplayName("Fakültesi :")]
        public string FakulteAdi { get; set; }
        public virtual Fakulte Fakultesi { get; set; }

        public ICollection<Ogrenci> Ogrenciler { get; set; }
    }
}