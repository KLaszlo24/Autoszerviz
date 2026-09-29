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

        public Jarmu(string rendszam, int kor, int kilometerOra, int uzemanyagSzint, bool szervizSzukseges)
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
                    rendszam = "Ismeretlen rendszám";
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
                if (kor > 50)
                {
                    kor = 50;
                }
                else if (kor < 0)
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
                if (kilometerOra < 0)
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
                if (uzemanyagSzint > 100)
                {
                    uzemanyagSzint = 100;
                }
                else if (uzemanyagSzint < 0)
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
                if (kilometerOra > 200000)
                {
                    szervizSzukseges = true;
                }
            }
        }

        public virtual void InformaciotAd()
        {
            Console.WriteLine($"{rendszam}- {kor} éves jármű, {kilometerOra} km-rel.");
        }

        public virtual void Szervizel(int dij)
        {
            if (dij < 100000)
            {
                kilometerOra -= 10000;
                uzemanyagSzint -= 10;
                Console.WriteLine("A jármű szervizelése megtörtént");
            }
        }
    }
}
