using Kapanis.Concrete;
bool BaskaVeriGirilecekMi = true;

while (BaskaVeriGirilecekMi)
{
tercih: Console.WriteLine("telefoın ıcın 1 bilgisayar ıcın 2   ");
    int tercih = Convert.ToInt32(Console.ReadLine());

    if (tercih == 1)
    {
        Bilgisayar yenibilgisayar = new Bilgisayar();

        Console.WriteLine("Bilgisayarın seri numarası ?");
        yenibilgisayar.SeriNumarasi = Console.ReadLine();

        Console.WriteLine("Bilgisayarın adı ?");
        yenibilgisayar.Ad = Console.ReadLine();

        Console.WriteLine("Bilgisayarın Acıklaması ?");
        yenibilgisayar.Aciklama = Console.ReadLine();

        Console.WriteLine("Bilgisayarın ısletim sistemi ?");
        yenibilgisayar.IsletimSistemi = Console.ReadLine();


        Console.WriteLine("Bilgisayarın Usb giris sayısı kactır ?");
        yenibilgisayar.UsbGirisSayisi = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Bilgisayarın Bluetoothu var mı?");
        yenibilgisayar.BluetoothVarmi = Convert.ToBoolean(Console.ReadLine());

        Console.WriteLine("bilgisayar oluşturuldu");
        yenibilgisayar.BilgileriYazdir();sa



    }
    else if (tercih == 2)
    {

    }
    else
    {
        Console.WriteLine("yanlıs bir sayi girdiniz");
        goto tercih;
    }

    


}

