using System;
using System.Collections.Generic;
using System.Text;

namespace Zalicz_2_termin
{
    public class Test
    {
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public bool Powodzenie { get; set; }
        public int Id { get; set; }
        public string Tester { get; set; }

        public Test(string uname, string uopis, bool trafn,
                      int uid, string tname)
        {
            Nazwa = uname;
            Opis = uopis;
            Powodzenie = trafn;
            Id = uid;
            Tester = tname;
        }


        public void Deconstruct(out string uname, out bool trafn)
        {
            trafn = true;
            uname = Nazwa;
            trafn = Powodzenie;
        }

        public void Deconstruct(out string uname, out string uopis, out bool trafn, out int uid, out string tname)
        {
            uname = Nazwa;
            uopis = Opis;
            trafn = Powodzenie;
            uid = Id;
            tname = Tester;
        }
        class Zadanie2
        {
        }
    }
}
