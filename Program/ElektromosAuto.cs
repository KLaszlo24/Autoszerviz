using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class ElektromosAuto : Jarmu
    {
        private int akkumulatorSzint;

        public ElektromosAuto(string rendszam, int kor, int kilometerOra, int uzemanyagSzint, bool szervizSzukseges, int akku): base( rendszam,  kor,  kilometerOra,  uzemanyagSzint, szervizSzukseges)
        {
            AkkumulatorSzint = akku;
            this.UzemanyagSzint = 0;
        }

        public int AkkumulatorSzint
        {
            get => akkumulatorSzint;
            set
            {
                if (akkumulatorSzint > 100)
                {
                    akkumulatorSzint = 100;
                }
                else if (akkumulatorSzint < 0)
                {
                    akkumulatorSzint = 0;
                }
                else
                {
                    akkumulatorSzint = value;
                }
            }
        }

        public override void InformaciotAd()
        {
            Console.WriteLine($"{Rendszam}- {Kor} éves elektromos jármű, {KilometerOra} km-rel. {AkkumulatorSzint}% töltöttséggel");
        }

        public override void Szervizel(int dij)
        {
            if (dij < 100000)
            {
                KilometerOra -= 10000;
                akkumulatorSzint += 20;
                Console.WriteLine("A jármű szervizelése megtörtént");
            }
        }
    }
}
