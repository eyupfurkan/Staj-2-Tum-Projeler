using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace WebApiClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:65131/");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response;
                response = client.GetAsync("api/OgrenciApi").Result;
                if (response.IsSuccessStatusCode)
                {
                    var ogrenciler = response.Content.ReadAsAsync<IEnumerable<Ogrenci>>().Result;
                    foreach (var ogrenci in ogrenciler)
                    {
                        Console.WriteLine("Ogrenci ID : {0} - Öðrencinin Adý: {1}- Soyadý : {2} - Bölümü : {3} - Fakültesi : {4}", ogrenci.Id, ogrenci.Adi, ogrenci.Soyadi, ogrenci.BolumAdi, ogrenci.FakulteAdi);
                    }
                }
                Console.ReadKey();
            }
        }
        }
    class Ogrenci
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public long TcNo { get; set; }
        public string BolumAdi { get; set; }
        public string FakulteAdi { get; set; }
    }
}
