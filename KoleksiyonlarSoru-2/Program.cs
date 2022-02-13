using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoleksiyonlarSoru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            KullaniciGirisi kullanici = new KullaniciGirisi();
            SanalDatabase db = new SanalDatabase();
            kullanici.KullaniciGiris();
            db.KucuktenBuyugeSirala();
            db.EnBuyukUcSayiOrtalama();
            db.EnKucukUcSayiOrtalama();
            db.OrtalamaToplamlari();
            Console.ReadLine();
        }
    }
}
