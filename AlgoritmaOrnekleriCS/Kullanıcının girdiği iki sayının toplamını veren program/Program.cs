using System;

namespace Kullanıcının_girdiği_iki_sayının_toplamını_veren_program
{
    class Program
    {
        static void Main(string[] args)
        {
            //SORU : Kullanıcının girdiği iki sayının karelerinin toplamını veren program

            #region Çözüm 1:
            Console.WriteLine("Çözüm 1 için İlk sayiyi giriniz");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Çözüm 1 için İkinci sayiyi giriniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Çözüm 1 : sayi1 in karesi {sayi1 * sayi1} + sayi 2 nin karesi {sayi2 * sayi2} = {(sayi1 * sayi1) + (sayi2 * sayi2)} ");
            #endregion

            #region Çözüm 2:
            Console.WriteLine("Çözüm 2 için İlk sayiyi giriniz");
            int sayi3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Çözüm 2 için İkinci sayiyi giriniz");
            int sayi4 = Convert.ToInt32(Console.ReadLine());

            double sonuc2 = Math.Pow(sayi3, 2) + Math.Pow(sayi4, 2);

            Console.WriteLine($"Çözüm 2 : Girilen sayılarin karelerinin toplamı = {sonuc2}");
            #endregion

            #region Çözüm 3:
            Console.WriteLine("Çözüm 3 için ilk ve ikinci sayiyi giriniz");

            double sonuc3 = Math.Pow(Convert.ToInt32(Console.ReadLine()), 2) + Math.Pow(Convert.ToInt32(Console.ReadLine()), 2);

            Console.WriteLine($"Çözüm 3 : Girilen sayılarin karelerinin toplamı = {sonuc3}");
            #endregion
        }
    }
}
