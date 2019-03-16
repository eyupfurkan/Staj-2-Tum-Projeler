using System.Collections.Generic;
using RestServisim1.Models;

namespace RestServisim1.FakulteVeri
{
    public class FakulteData
    {
        public static List<Fakulte> FakulteList = new List<Fakulte>()
            {
            new Fakulte
            {
                Id = 1,
                Adi = "Mühendislik Fakültesi"
            },
                new Fakulte
                {
                    Id = 2,
                    Adi = "Eczacılık Fakültesi"
                }
            }
            ;
    }
}