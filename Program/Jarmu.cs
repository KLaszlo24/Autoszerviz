using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class Jarmu
    {
       private string rendszam;
        private int kor;
        private int kilometerOra;
        private int uzemanyagSzint;
        private bool szervizSzukseges;

        public Jarmu(string rendszam, int kor, int kilometerOra, int uzemanyagSzint)
        {
            Rendszam = rendszam;
            Kor = kor;
            KilometerOra = kilometerOra;
            UzemanyagSzint = uzemanyagSzint;
            SzervizSzukseges = szervizSzukseges;
        }

        public string Rendszam { get => rendszam;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    rendszam = "ISMERETLEN";
                }
                else
                {
                    rendszam = value;
                }
            }
        }
        public int Kor
        {
            get => kor;
            set
            {
                if (value > 50)
                {
                    kor = 50;
                }
                else if (value < 0)
                {
                    kor = 0;
                }
                else
                {
                    kor = value;
                }
            }
        }
        public int KilometerOra { get => kilometerOra;
            set
            {
                if (value < 0)
                {
                    kilometerOra = 0;
                }
                else
                {
                    kilometerOra = value;
                }
            }
        }
        public int UzemanyagSzint { get => uzemanyagSzint;
            set
            {
                if (value > 100)
                {
                    uzemanyagSzint = 100;
                }
                else if (value < 0)
                {
                    uzemanyagSzint = 0;
                }
                else
                {
                    uzemanyagSzint = value;
                }
            }
        }
        public bool SzervizSzukseges { get => szervizSzukseges;
            set
            {
                if (this.kilometerOra >= 200000)
                {
                    szervizSzukseges = true;
                }
                else
                {
                    szervizSzukseges = false;
                }
            }
        }

        public virtual void InformaciotAd()
        {
            Console.WriteLine($"{rendszam}- {kor} éves jármű, {kilometerOra} km-rel.");
        }

        public virtual void Szervizel(int dij)
        {
            if (dij > 100000)
            {
                kilometerOra = kilometerOra-10000;
                
            }
            uzemanyagSzint = uzemanyagSzint - 10;
            Console.WriteLine("A jármű szervizelése megtörtént");
        }
    }
}
