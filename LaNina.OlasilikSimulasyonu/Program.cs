using System;

namespace LaNina.OlasilikSimulasyonu
{
    class Program
    {
        private static string _tercih;
        static void SonuclariEkranaYazdir(int oyunSayisi, int win)
        {
            Console.WriteLine("Oynatma Sayısı: {0}", oyunSayisi);
            Console.WriteLine("Kazanma Sayısı: {0}", win);
            Console.WriteLine("Kaybetme Sayısı: {0}", oyunSayisi-win);
        }

        static void StratejiBelirle()
        {    
            do
            {
                Console.WriteLine("Stratejinizi belirleyin: Seçiminizi değiştirmek ister misiniz?\nEvet için 'E' Hayır için 'H' tuşuna basınız.");
                _tercih = Console.ReadLine().ToLower();
            }
            while (!(_tercih == "e" || _tercih == "h"));
        }

        static void Main(string[] args)
        {
            int oyunSayisi;
            int guess;
            int sansliKapi;
            int win = 0;
            int kapiSayisi=0;
            Random random = new Random();

            for (int i= 0;i<1;i++)
            {
                Console.Clear();
                Console.WriteLine("Kapı sayısını belirleyiniz: ");
                if ((!int.TryParse(Console.ReadLine(), out kapiSayisi)) || kapiSayisi < 2)
                    i--;

            }

            //KapiSay:
            //Console.Clear();
            //Console.WriteLine("Kapı sayısını belirleyiniz: ");
            //if ((!int.TryParse(Console.ReadLine(), out kapiSayisi)) || kapiSayisi < 2)
            //    goto KapiSay;

            //do
            //{
            //    Console.Clear();
            //    Console.WriteLine("Kapı sayısını belirleyiniz: ");
            //}
            //while ((!int.TryParse(Console.ReadLine(), out kapiSayisi)) || kapiSayisi < 2);

            do
            {                
                Console.WriteLine("Oyun sayısını belirleyiniz: ");
            }
            while ((!int.TryParse(Console.ReadLine(), out oyunSayisi)) || oyunSayisi < 1);

            StratejiBelirle();
          
            for (int i = 0; i < oyunSayisi; i++)
            {
                sansliKapi = random.Next(0, kapiSayisi);
                guess = random.Next(0, kapiSayisi);
                
                if(_tercih =="h")
                {
                    if(guess == sansliKapi) win++;
                }
                else
                {
                    if (guess != sansliKapi) win++;
                }
            }
            SonuclariEkranaYazdir(oyunSayisi, win);
            Console.ReadLine();
        }
    }
}
