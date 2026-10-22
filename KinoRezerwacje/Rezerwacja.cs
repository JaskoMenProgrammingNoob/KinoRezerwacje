using System;
using System.Collections.Generic;
using System.Text;

namespace KinoRezerwacje
{
    public class Rezerwacja
    {
        public required Seans Seans { get; set; }
        public List<Miejsce> Siedzenia { get; set; } = [];
        public required string Imie { get; set; }
        public required string Nazwisko { get; set; }
    }
}
