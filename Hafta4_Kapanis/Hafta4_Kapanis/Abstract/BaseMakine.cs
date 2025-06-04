using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta4_Kapanis.Abstract
{
    internal abstract class BaseMakine
    {

        protected BaseMakine()
        { // base makinadan miras alan hangi classi newlersek uretim tarihi her zamanan now olacak
            UretimTarihi = DateTime.Now; 
        }
        public int Id { get; set; }
        public DateTime UretimTarihi { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public string IsletimSistemi { get; set; }


        public virtual void BilgileriYazdir() 
        {
            Console.WriteLine("Id ->" + Id);
            Console.WriteLine("Uretim Tarihi ->" + UretimTarihi);
            Console.WriteLine("Ad ->" + Ad);
            Console.WriteLine("Aciklama ->" + Aciklama);
            Console.WriteLine("Isletim Sistemi ->" + IsletimSistemi);

        }
        public abstract void UrunAdiGetir();
    }
}
