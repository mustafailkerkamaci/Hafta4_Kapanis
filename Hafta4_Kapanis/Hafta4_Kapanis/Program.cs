using Hafta4_Kapanis.Concrete;

List<Bilgisayar> bilgisayarlar = new List<Bilgisayar>();
List<Telefon> telefonlar = new List<Telefon>();


while (true)
{
    Console.WriteLine("Bilgisayar eklemek icin 1 - telefon eklemek icin 2");
    int karar = Convert.ToInt32(Console.ReadLine());

    if (karar == 1)
    {
        Bilgisayar yenibilgisayar = new Bilgisayar();
        Console.WriteLine("Bilgisayarin adi ?");
        yenibilgisayar.Ad = Console.ReadLine();

        Console.WriteLine("bilgisayarin  Isletim sistemi ? ");
        yenibilgisayar.IsletimSistemi = Console.ReadLine();

        Console.WriteLine("Usb Giris Sayisi ?");
        yenibilgisayar.UsbGirisSayisi = int.Parse(Console.ReadLine());

        Console.WriteLine("Bilgisayar Uretildi");
        bilgisayarlar.Add(yenibilgisayar);
    }
    else if (karar == 2)
    {
        Telefon yenitelefon = new Telefon();
        Console.WriteLine("Telefonu adi?");
        yenitelefon.Ad = Console.ReadLine();

        Console.WriteLine("Telegonun isletim Sistemi ? ");
        yenitelefon.IsletimSistemi = Console.ReadLine();

    soru: Console.WriteLine("Telefon Lisanli Mi ? (e/h) ");
        char yanit = Convert.ToChar(Console.ReadLine());
        if(yanit == 'e')
            yenitelefon.LisansliMi = true;
        else if (yanit == 'h')
            yenitelefon.LisansliMi = false;
        else
        {
            Console.WriteLine("Gecersiz secim, lütfen tekrar deneyin.");
            goto soru;
        }
        Console.WriteLine("Telefonunuz ueretildi");
        telefonlar.Add(yenitelefon);


    }
    else
    {
        Console.WriteLine("Gecersiz secim, lutfen tekrar deneyin.");
    }

    Console.WriteLine("Yeniden ekleme islemi yapmak istiyor musunuz? (e/h) ");
    char cevap = Convert.ToChar(Console.ReadLine());

    if (cevap == 'h')
    {
        break;
    }

}

Console.WriteLine("=====BILGISAYARLAR===== ");

foreach (var bilgisayar in bilgisayarlar) 
{
    bilgisayar.BilgileriYazdir();
    
    Console.WriteLine("-----------------------");
}
Console.WriteLine("=====TELEFONLAR=====");

foreach (var telefon in telefonlar)
{
    telefon.BilgileriYazdir();

    Console.WriteLine("-----------------------");
}