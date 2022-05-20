using System;

namespace _1den_10a_kadar_olan_sayıların_küplerinin_toplamını_veren_program
{
    class Program
    {
        static void Main(string[] args)
        {
            //SORU : 1den 10a kadar olan sayıların küplerinin toplamını veren program
            #region Çözüm 1:
            double toplamSonucu1 = 0;
            for (int i = 1; i <= 10; i++)
            {
                toplamSonucu1 += Math.Pow(i, 3);
            }
            Console.WriteLine($"Çözüm 1: 1'den 10'a kadar olan sayıların küplerinin toplamı = {toplamSonucu1}");

            #endregion

            #region Çözüm 2:
            double toplamSonucu2 = 0;
            int sayac = 1;

            while (sayac <= 10)
            {
                toplamSonucu2 += Math.Pow(sayac, 3);
                //if (sayac == 10)
                //    break;
                sayac++;
            }

            Console.WriteLine($"Çözüm 2 : 1'den 10'a kadar olan sayıların küplerinin toplamı = {toplamSonucu2}");

            #endregion

            #region Çözüm 3:
            int sayac2 = 1;
            double toplamSonucu3 = 0;

            do
            {
                toplamSonucu3 += Math.Pow(sayac2, 3);
                sayac2++;
            } while (sayac2 <= 10);

            Console.WriteLine($"Çözüm 3 : 1'den 10'a kadar olan sayıların küplerinin toplamı = {toplamSonucu3}");

            #endregion

            #region Çözüm 4:
            int sayac3 = 1;
            double toplamSonucu4 = 0;
            string sonuc = "";
            while (sayac3 <= 10)
            {
                toplamSonucu4 += Math.Pow(sayac3, 3);

                if (sayac3 != 10)
                    sonuc += $"{sayac3}^3 + ";
                else
                    sonuc += $"{sayac3}^3 = {toplamSonucu4} ";

                sayac3++;
            }
            Console.WriteLine($"Çözüm 4 : {sonuc}");

            #endregion

        }
    }
}
