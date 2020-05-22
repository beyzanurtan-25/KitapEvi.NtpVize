using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapEvi.NtpVize.Models
{
    class Kitap
    {
        public Kitap()
        {
            basimTarihi = DateTime.Now;
        }

        private string kitapAdi;
        private string yazarAdi;
        private DateTime basimTarihi;
        private string tur;

        public string KitapAd { get => kitapAdi; set => kitapAdi = value; }
        public string Yazar { get => yazarAdi; set => yazarAdi = value; }
        public DateTime BasımTarihi { get => basimTarihi; set => basimTarihi = value; }
        public string Turu { get => tur; set => tur = value; }

        public static void TxtDosyasinaYaz(List<Kitap> lst)
        {
            for (int i = 0; i < lst.Count; i++)
            {
                string[] text = { lst[i].KitapAd, lst[i].Yazar, lst[i].BasımTarihi.ToString(), lst[i].Turu };
                File.AppendAllLines(@"C:\ntp\Beyza.txt", text);
            }

        }
    }
}
