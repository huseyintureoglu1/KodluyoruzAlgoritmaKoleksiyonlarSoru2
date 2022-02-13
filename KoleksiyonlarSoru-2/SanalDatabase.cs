using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoleksiyonlarSoru_2
{
   public class SanalDatabase
    {
        public static ArrayList DataBase = new ArrayList();
        static double toplam1;
        static double toplam2;
        public void SayiEkle(int sayi)
        {
            DataBase.Add(sayi);
        }
        public void KucuktenBuyugeSirala()
        {
            DataBase.Sort();
        }
        public double EnBuyukUcSayiGetir()
        {
            int toplam = 0;
            int sayac = 1;
            for (int i = DataBase.Count-1; i > DataBase.Count-4 ; i--)
            {
                toplam = toplam + Convert.ToInt32(DataBase[i]);
                Console.WriteLine("En büyük "+sayac+". sayı: "+ DataBase[i]);
                sayac++;
            }
            return toplam;
        }
        public double EnKucukUcSayıGetir()
        {
            int sayac = 1;
            int toplam = 0;
            for (int i = 0; i < 3; i++)
            {
                toplam = toplam + Convert.ToInt32(DataBase[i]);
                Console.WriteLine("En küçük " + sayac + ". sayı: " + DataBase[i]);
                sayac++;
            }
            return toplam;
        }
        public void EnBuyukUcSayiOrtalama()
        {
           toplam1 = EnBuyukUcSayiGetir() / 3;
           Console.WriteLine("En büyük 3 sayının ortalaması: "+toplam1);
        }
        public void EnKucukUcSayiOrtalama()
        {
            toplam2 = EnKucukUcSayıGetir() / 3;
            Console.WriteLine("En küçük 3 sayının ortalaması: "+toplam2);
        }
        public void OrtalamaToplamlari()
        {
            Console.WriteLine("Ortalama toplamları: "+toplam2 + toplam1);
           
        }
    }
    
}
