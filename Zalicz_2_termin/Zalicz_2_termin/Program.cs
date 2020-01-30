using System;

namespace Zalicz_2_termin
{
        class Program
        {


            static void Main(string[] args)
            {

                var obiekt = new Test("Jan", "As", true, 20, "TestJan");
                var (uname, uopis, trafn, uid, tname) = obiekt;
                Console.WriteLine(obiekt.Nazwa+"|"+obiekt.Opis+"|"+obiekt.Id+"|"+obiekt.Powodzenie+"|"+obiekt.Opis);
            ZamekPin klucz = new ZamekPin();
            klucz.Otworz();
            klucz.Zamknij();
            ZamekElektroniczny karta_id = new ZamekElektroniczny();
            karta_id.Otworz();
            karta_id.Zamknij();
            }
        }
}

