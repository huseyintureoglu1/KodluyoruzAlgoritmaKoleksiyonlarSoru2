using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoleksiyonlarSoru_2
{
   public  class KullaniciGirisi
    {
        SanalDatabase db = new SanalDatabase();
        static int sayac = 0;
        public void KullaniciGiris()
        {
            try
            {
                Console.WriteLine("Lütfen sayı giriniz: ");
                while (sayac<5)
                {
                    int sayi = Convert.ToInt32(Console.ReadLine());
                    db.SayiEkle(sayi);
                    sayac++;
                }
           

            }
            catch (Exception)
            {
                Console.WriteLine("Lütfen tam sayı giriniz!!!");
                KullaniciGiris();
            }
        }
       
    }
}
