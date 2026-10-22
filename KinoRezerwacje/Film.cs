using System;
using System.Collections.Generic;
using System.Text;

namespace KinoRezerwacje
{
    public class Film
    {
        public required string Tytul { get; set; }
        public string Opis { get; set; } = "";
        public int Dlugosc { get; set; }
        public int Ocena { get; set; }
    }
}
