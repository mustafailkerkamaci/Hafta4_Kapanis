using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hafta4_Kapanis.Abstract;

namespace Hafta4_Kapanis.Concrete
{
    internal class Bilgisayar : BaseMakine , IBilgisayar

    {
        // public int UsbGirisSayisi { get; set; }
         int _usbGirisSayisi;
        public int UsbGirisSayisi 
        {
            get
            { 
                return _usbGirisSayisi;
            }                                     //ENCAPSULATION

            set
            {
                if (value == 2 || value == 4)
                    _usbGirisSayisi = value;
                else
                    _usbGirisSayisi = -1;
            }
                
        }

        public bool BluetoothVarMi { get; set; }

        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            Console.WriteLine("USB Giris Sayisi ->"+ UsbGirisSayisi);
            Console.WriteLine(BluetoothVarMi ? "Bluetooth Var" : "Bluetooth Yok.");

        }

        public void InterneteBaglan()
        {
            Console.WriteLine("Internete Baglaniliyor.");
        }

        public void OyunOyna()
        {
            Console.WriteLine("Oyun Aciliyor");
        }

        public string TokenUret()
        {
            return "tokeniniz ...";
        }

        public override void UrunAdiGetir()
        {
            Console.WriteLine("Bilgisayar Adi -> " + Ad);
        }
    }
}
