using System.Collections.Generic;
using RestServisim1.Models;

namespace RestServisim1.BolumVeri
{
    public class BolumData
    {
        public static List<Bolum> BolumList = new List<Bolum>()
           {
           new Bolum
           {
               Id = 1,
               Adi = "Bilgisayar Mühendisliği",
               FakulteAdi = FakulteVeri.FakulteData.FakulteList[0].Adi
           },
               new Bolum
               {
                   Id = 2,
                   Adi = "Eczacılık",
                   FakulteAdi = FakulteVeri.FakulteData.FakulteList[1].Adi
               }
           }
            ;
    }
}