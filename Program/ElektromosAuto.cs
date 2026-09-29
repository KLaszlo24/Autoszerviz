using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class ElektromosAuto : Jarmu
    {
        private int akkumulatorSzint;

        public ElektromosAuto(string rendszam, int kor, int kilometerOra, int akku): base( rendszam,  kor,  kilometerOra,  0)
        {
            AkkumulatorSzint = akku;
           
        }

        public int AkkumulatorSzint
        {
            get => akkumulatorSzint;
            set
            {
                this.akkumulatorSzint = Math.Clamp(value, 0, 100);
            }
        }

        public override void InformaciotAd()
        {
            Console.WriteLine($"{Rendszam}- {Kor} éves elektromos jármű, {KilometerOra} km-rel. {AkkumulatorSzint}% töltöttséggel");
        }

        public override void Szervizel(int dij)
        {
            if (dij > 100000)
            {
                KilometerOra -= 10000;
               
            }
            akkumulatorSzint = akkumulatorSzint + 20;
            Console.WriteLine("A jármű szervizelése megtörtént");
        }
    }
}
