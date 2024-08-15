using Kapanis.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapanis.Concrete
{
    internal class Telefon : BaseMakine , ITelefon
    {
        public bool TrLisansLiMi {  get; set; }

        public void AlarmVer()
        {
            //
        }

        public void Ara()
        {
            //
        }

        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            Console.WriteLine(TrLisansLiMi ? "Tr lisansı var."  : "Tr lisansı yok");
        }

        public void GPSKullan()
        {
            //
        }

        public void INterneteBaglan()
        {
            //
        }

        public void KonumAt()
        {
            //
        }

        public void MesajAt()
        {
            //
        }

        public void OrtamSicakliğiOlc()
        {
            //
        }

        public void SaatGoster()
        {
            //
        }

        public override void UrunAdiGetir()
        {
            Console.WriteLine("Telefonun Adı : ->" + Ad);
        }
    }
}
