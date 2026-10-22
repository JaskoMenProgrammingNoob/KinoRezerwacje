using System;
using System.Collections.Generic;
using System.Text;

namespace KinoRezerwacje
{
    public class Sala
    {
        public int Numer { get; set; }
        public List<Miejsce> Siedzenia { get; set; } = [];
    }
}
