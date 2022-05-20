using System;

namespace İki_sayının_toplamını_veren_program
{
    class Program
    {
        static void Main(string[] args)
        {
            //SORU : İki sayının toplamını veren program

            #region Çözüm 1:
            int sayi1 = 10;
            int sayi2 = 20;

            Console.WriteLine($"Çözüm 1 : {sayi1}+{sayi2} = {sayi1 + sayi2}");

            #endregion

            #region Çözüm 2:
            Console.WriteLine("İlk sayı değerini giriniz");
            int sayi3 = int.Parse(Console.ReadLine());

            Console.WriteLine("İkinci sayı değerini giriniz");
            int sayi4 = int.Parse(Console.ReadLine());


            Console.WriteLine($"Çözüm 2 : {sayi3}+{sayi4} = {sayi3 + sayi4}");

            #endregion

            #region Çözüm 3:
            try
            {
                Console.WriteLine("İlk sayı değerini giriniz");
                int sayi5 = int.Parse(Console.ReadLine());

                Console.WriteLine("İkinci sayı değerini giriniz");
                int sayi6 = int.Parse(Console.ReadLine());

                int sonuc3 = sayi5 + sayi6;
                Console.WriteLine($"Çözüm 3 : {sayi5}+{sayi6} = {sayi5 + sayi6}");
            }
            catch
            {
                Console.WriteLine("Lütfen doğru bir sayı değeri giriniz");
            }

            #endregion

            #region Çözüm 4:

            Random rnd = new Random();

            int sayi7 = rnd.Next(1, 10);
            int sayi8 = rnd.Next(1, 10);

            Console.WriteLine($"Çözüm 4 : {sayi7} + {sayi8} = {sayi7 + sayi8}");

            #endregion
        }
    }
}
