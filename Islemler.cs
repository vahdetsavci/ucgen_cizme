using System;

namespace ucgen_cizme;

struct Islemler
{
    internal bool GirdiAl()
    {
        try
        {
            int uzunluk = Convert.ToInt32(Console.ReadLine());
            if (uzunluk < 1)
                throw new Exception();

            new Ucgen(uzunluk);     // Üçgen çiziliyor
            return true;
        }
        catch (Exception)
        {
            Console.WriteLine("Üçgenin uzunluğu için pozitif bir tam sayı girmeniz gerekli!");
            System.Threading.Thread.Sleep(2000);
            return false;
        }
    }

    internal int TekrarMi()
    {
        Soru:
        Console.WriteLine("Başka bir üçgen çizdirmek ister misiniz? [E] Evet / [H] Hayır");
        switch (Console.ReadLine().ToLower())
        {
            case "e":
                return 1;
            case "h":
                return 0;
            default:
                Console.WriteLine("Hatalı seçim yaptınız! Lütfen tekrar deneyin!");
                Console.WriteLine();
                goto Soru;
        }
    }
}