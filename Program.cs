using System;

namespace Csharp_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
           System.Console.WriteLine(Gunler.Pazartesi);
           System.Console.WriteLine((int)Gunler.Cumartesi);

            int Sicaklik = 32;
            if (Sicaklik <=(int)HavaDurumu.Normal)
            {
                System.Console.WriteLine("Dışarıya Çıkmak İçin Havanın Biraz Daha Isınmasını Bekleyelim");
            }
            else if (Sicaklik >= (int)HavaDurumu.Sıcak)
            {
                System.Console.WriteLine("Dışarıya Çıkmak İçin Çok Sıcak Bir Gün");
            }
            else if (Sicaklik >=(int)HavaDurumu.Normal && Sicaklik <(int)HavaDurumu.CokSicak)
            {
                System.Console.WriteLine("Hadi Dışarı Çıkalım");
            }


        }    
    }
    enum Gunler
    {
        Pazartesi=1,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma=23,
        Cumartesi,
        Pazar
    }
    enum HavaDurumu
    {
        Soguk=5,

        Normal=20,

        Sıcak = 25,

        CokSicak = 30
    }
    
}
