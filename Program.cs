using System;

namespace ucgen_cizme;

class Program
{
    static void Main(string[] args)
    {
        Islemler islemler;
        
        Basla:
        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(">> Çizdirmek istediğiniz üçgenin uzunluğunu satır sayısı olarak giriniz! <<");
        Console.WriteLine("---------------------------------------------------------------------------");

        if (!islemler.GirdiAl())    // Kullanıcı pozitif bir tam sayı girmez ise hata alır ve tekrar sayı girmesi istenir.
            goto Basla;

        switch (islemler.TekrarMi())
        {
            case 1:
                goto Basla;
            case 0:
                break;
        }
    }
}
