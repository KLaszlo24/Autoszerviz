using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class TeherAuto : Jarmu
    {
        private int rakomany;


        public TeherAuto(string rendszam, int kor, int kilometerOra, int uzemanyagSzint, int rako) : base(rendszam, kor, kilometerOra, uzemanyagSzint)
        {
            Rakomany = rako;
        }

        public int Rakomany { get => rakomany;
            set {
                if (rakomany > 20)
                {
                    rakomany = 20;
                }
                else if (rakomany < 0)
                {
                    rakomany = 0;
                }
                else
                {
                    rakomany = value;
                }
            } 
        }

        public override void InformaciotAd()
        {
            Console.WriteLine($"{Rendszam}- {Kor} éves teherautó, {KilometerOra} km-rel. Rakomány: {rakomany} tonna");
        }

        public override void Szervizel(int dij)
        {
            rakomany = 0;
            //majd rájövök
        }
    }

}
