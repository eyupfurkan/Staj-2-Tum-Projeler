using System.Collections.Generic;
using RestServisim1.Models;

namespace RestServisim1.OgrenciVeri
{
    public class OgrenciData
    {
        public static List<Ogrenci> OgrenciList = new List<Ogrenci>()
        {
            new Ogrenci
            {
                Id = 1,
                Adi = "Faruk",
                Soyadi = "GÜNGÖR",
                TcNo = 41698796323,
               BolumAdi = BolumVeri.BolumData.BolumList[0].Adi,
                FakulteAdi = BolumVeri.BolumData.BolumList[0].FakulteAdi
            }
        };
    }
}