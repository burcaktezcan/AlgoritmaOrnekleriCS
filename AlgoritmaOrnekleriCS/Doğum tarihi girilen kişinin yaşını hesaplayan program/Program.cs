using System;

namespace Doğum_tarihi_girilen_kişinin_yaşını_hesaplayan_program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Doğum yılınızı giriniz");
            DateTime dogumTarihi = Convert.ToDateTime(Console.ReadLine());

            TimeSpan sonuc = DateTime.Now - dogumTarihi;
            Console.WriteLine($"Yaşınız : {Math.Round(sonuc.TotalDays / 365)}");
        }
    }
}
