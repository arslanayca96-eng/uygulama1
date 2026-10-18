int gun;
while (true)
{

    Console.Write("ödünç almak istediğiniz gün sayısını giriniz:(1 ile 7 arasında) ");
    while (!int.TryParse(Console.ReadLine(), out gun) || gun < 1 || gun > 7)
    {



        Console.WriteLine("ÖDÜNÇ ALAMAZSINIZ!");
        Console.Write(" Lütfen 1 ile 7 arasında geçerli bir sayı giriniz.");
    }
    if (gun >= 1 && gun <= 7)
    {
        Console.WriteLine("TEBRİKLER! Ödünç alma işlemi başarılı!");
    }
    else
    {
        Console.WriteLine("ÖDÜNÇ ALAMAZSINIZ!");
    }
    Console.ReadKey();
}

