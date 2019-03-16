using System.Collections.Generic;

namespace RestServisim1.Models
{
    public class Fakulte
    {
        public int Id { get; set; }

        public string Adi { get; set; }

        public ICollection<Bolum> Bolumler { get; set; }
        public ICollection<Ogrenci> Ogrenciler { get; set; }
    }
}