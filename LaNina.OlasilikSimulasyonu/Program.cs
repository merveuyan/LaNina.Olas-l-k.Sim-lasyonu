using System;

namespace LaNina.OlasilikSimulasyonu
{
    class Program
    {
        static string _tercihEvet = "e";
        static string _tercihHayir = "h";
        private static string _tercih;
        static void SonuclariEkranaYazdir(int oyunSayisi, int kazanmaSayisi)
        {
            Console.WriteLine("Oynatma Sayısı: {0}", oyunSayisi);
            Console.WriteLine("Kazanma Sayısı: {0}", kazanmaSayisi);
            Console.WriteLine("Kaybetme Sayısı: {0}", oyunSayisi-kazanmaSayisi);
        }

        static void StratejiBelirle()
        {    
            do
            {
                Console.WriteLine("Stratejinizi belirleyin: Seçiminizi değiştirmek ister misiniz?\n" +
                    "Evet için 'E' Hayır için 'H' tuşuna basınız.");
                _tercih = Console.ReadLine().ToLower();
            }
            while (!(_tercih == _tercihEvet || _tercih == _tercihHayir));
        }

        static void Main(string[] args)
        {
            int oyunSayisi;
            int tahmin;
            int sansliKapi;
            int kazanmaSayisi = 0;
            int kapiSayisi=0;
            Random random = new Random();

            #region for ile kapı sayısı alma
            //for (int i= 0;i<1;i++)
            //{
            //    Console.Clear();
            //    Console.WriteLine("Kapı sayısını belirleyiniz: ");
            //    if ((!int.TryParse(Console.ReadLine(), out kapiSayisi)) || kapiSayisi < 2)
            //        i--;
            //}
            #endregion
            #region goto ile kapı sayısı alma
            //KapiSay:
            //Console.Clear();
            //Console.WriteLine("Kapı sayısını belirleyiniz: ");
            //if ((!int.TryParse(Console.ReadLine(), out kapiSayisi)) || kapiSayisi < 2)
            //    goto KapiSay;
            #endregion

            do
            {
                Console.Clear();
                Console.WriteLine("Kapı sayısını belirleyiniz: ");
            }
            while ((!int.TryParse(Console.ReadLine(), out kapiSayisi)) || kapiSayisi < 2);

            do
            {                
                Console.WriteLine("Oyun sayısını belirleyiniz: ");
            }
            while ((!int.TryParse(Console.ReadLine(), out oyunSayisi)) || oyunSayisi < 1);

            StratejiBelirle();
          
            for (int i = 0; i < oyunSayisi; i++)
            {
                sansliKapi = random.Next(0, kapiSayisi);
                tahmin = random.Next(0, kapiSayisi);
                
                if(_tercih == _tercihHayir)
                {
                    if(tahmin == sansliKapi) kazanmaSayisi++;
                }
                else
                {
                    if (tahmin != sansliKapi) kazanmaSayisi++;
                }
            }
            SonuclariEkranaYazdir(oyunSayisi, kazanmaSayisi);
            Console.ReadLine();
        }
    }
}
