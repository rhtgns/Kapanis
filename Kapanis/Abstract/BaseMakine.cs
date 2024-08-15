using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapanis.Abstract
{
    internal abstract class BaseMakine
    {
        protected BaseMakine() { 

            UretimTarihi = DateTime.Now;
        }
        public DateTime UretimTarihi { get; set; }
        public string SeriNumarasi { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public string IsletimSistemi { get; set; }

        public  virtual void BilgileriYazdir()
        {
            Console.WriteLine(UretimTarihi);
            Console.WriteLine(SeriNumarasi);
            Console.WriteLine(Ad);
            Console.WriteLine(Aciklama);
            Console.WriteLine(IsletimSistemi);
        }
        public abstract void UrunAdiGetir();
        
        

    }

}
