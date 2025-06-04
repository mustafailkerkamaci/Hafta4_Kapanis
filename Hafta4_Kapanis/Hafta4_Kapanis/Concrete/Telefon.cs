using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hafta4_Kapanis.Abstract;

namespace Hafta4_Kapanis.Concrete
{
    internal class Telefon : BaseMakine, ITelefon
    {

        public bool LisansliMi { get; set; }

        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            Console.WriteLine(LisansliMi ? "Lisansi Var" : "Lisansi Yok");
        }

        public override void UrunAdiGetir()
        {
            Console.WriteLine("Telefonunuzun adi ->" + Ad);        }

        void ITelefon.Ara()
        {
            Console.WriteLine("Arama Yapiliyor");
        }

        void ITelefon.InterneteBaglan()
        {
            Console.WriteLine("Internete Baglaniliyor");
        }

        void ITelefon.MesajGonder()
        {
            Console.WriteLine("Mesaj Gonderiliyor.");
        }

        void ITelefon.OyunOyna()
        {
            Console.WriteLine("Oyun Oynaniyor");
        }
    }
}
