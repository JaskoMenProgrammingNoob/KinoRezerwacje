using System;
using System.Collections.Generic;
using System.Text;

namespace KinoRezerwacje
{
    public class Seans
    {
        public required Film Film { get; set; } 
        public required Sala Sala { get; set; }
        public required DateTime Godzina { get; set; }
        public List<Rezerwacja> Rezerwacje { get; set; } = [];

        public bool CzyJestWolne( Miejsce szukane)
        {
            foreach(Rezerwacja rezerwacja in Rezerwacje)
            {
                foreach(Miejsce miejsce in rezerwacja.Siedzenia)
                {
                    if (miejsce.Rzad == szukane.Rzad && miejsce.Numer == szukane.Numer)
                        return false;
                }
            }

            return true;
        }
    }
}
