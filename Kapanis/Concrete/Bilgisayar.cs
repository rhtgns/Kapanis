using Kapanis.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapanis.Concrete
{
    internal class Bilgisayar : BaseMakine
    {
        int _usbGirisSayisi;
        public int UsbGirisSayisi
        {

            get
            {
                return _usbGirisSayisi; 
                    }
            set
            {
                if (value == 2 || value == 4)
                    _usbGirisSayisi = value;
                else { 
                    _usbGirisSayisi = -1;
                    Console.WriteLine("Usb giriş sayısı atamsı hatalı :-1 olarak atandı ");

                }
            }
        }
        public bool BluetoothVarmi {  get; set; }

        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();//icerisden bu kodlar calısır demek
            Console.WriteLine(UsbGirisSayisi);
            Console.WriteLine(BluetoothVarmi ? "Bluetooth Var" : " Bluetooth  Yok");
        }
        public override void UrunAdiGetir()
        {
            Console.WriteLine("Bİlgisayarın Adı ->" + Ad);
        }
    }
}
