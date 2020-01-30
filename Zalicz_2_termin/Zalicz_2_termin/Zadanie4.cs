using System;
using System.Collections.Generic;
using System.Text;

namespace Zalicz_2_termin
{

       public class ZamekPin : IZamek
        {
            public void Otworz()
            {
                string pin;
                Console.WriteLine("Podaj PIN:");
                pin = Console.ReadLine();
            if(pin=="1234")
            {
                Console.WriteLine("Witaj");
            }
                
            }

            public void Zamknij()
            {
            
            }
        }
        public class ZamekElektroniczny : IZamek
        {
            public void Otworz()
            {
                string haslo="open";
                string karta;  
                Console.WriteLine("Podaj Kartę:");
                karta = Console.ReadLine();
                if (karta==haslo)
                {
                    Console.WriteLine("Witaj");
                }

            }

            public void Zamknij()
            {
                
            }
        }
    }

