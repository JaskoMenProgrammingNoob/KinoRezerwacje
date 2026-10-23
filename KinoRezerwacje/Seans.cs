using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Xml.Schema;

namespace KinoRezerwacje
{
    public class Seans
    {
        public required Film Film { get; set; }
        public required Sala Sala { get; set; }
        public required DateTime Godzina { get; set; }
        public List<Rezerwacja> Rezerwacje { get; set; } = [];

        public bool CzyJestWolne(Miejsce szukane)
        {
            foreach (Rezerwacja rezerwacja in Rezerwacje)
            {
                foreach (Miejsce miejsce in rezerwacja.Siedzenia)
                {
                    if (miejsce.Rzad == szukane.Rzad && miejsce.Numer == szukane.Numer)
                        return false;
                }
            }

            return true;
        }
        // rezerwowanie 
        public Rezerwacja? Zarezerwuj(string imie, string nazwisko, List<Miejsce> siedzenia)
        {
            foreach (Miejsce miejsce in siedzenia)
            {
                if (!CzyJestWolne(miejsce))
                {
                    return null;
                }

            }
            Rezerwacja rezerwacja = new Rezerwacja
            {
                Seans = this,
                Imie = imie,
                Nazwisko = nazwisko
            };
            rezerwacja.Siedzenia.AddRange(siedzenia);
            Rezerwacje.Add(rezerwacja);
            return rezerwacja;
        }
        public List<Miejsce> WolneMiejsca()
        {
            List<Miejsce> wolne = new List<Miejsce>();
            foreach (Miejsce miejsce in Sala.Siedzenia)
            {
                if(CzyJestWolne(miejsce))
                {
                    wolne.Add(miejsce);
                       
                }
            }
            return wolne;
        }
        public bool AnulujRezerwacje(Rezerwacja rezerwacja)
        {
            
            return Rezerwacje.Remove(rezerwacja);
        }
    }
}
