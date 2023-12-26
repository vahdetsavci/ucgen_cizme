using System;

namespace ucgen_cizme;

struct Ucgen
{
    internal Ucgen(int uzunluk)
    {
        Ciz(uzunluk);
    }

    private void Ciz(int uzunluk)
    {
        int orta = 0;
        for (int sol = uzunluk - 1; sol >= 0; sol--)
        {
            BoslukAt(sol);
            Console.Write(@"/");
            
            if(sol == 0)
                CizgiCiz(orta);
            else
                BoslukAt(orta);
            Console.WriteLine(@"\");
            orta += 2;
        }
        Console.WriteLine();
        Console.WriteLine("Üçgen çizildi.");
    }

    private void BoslukAt(int bosluk)
    {
        while (bosluk > 0)
        {
            Console.Write(" ");
            bosluk--;
        }
    }

    private void CizgiCiz(int uzunluk)
    {
        while (uzunluk > 0)
        {
            Console.Write("_");
            uzunluk--;
        }
    }
}