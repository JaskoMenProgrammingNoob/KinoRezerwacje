
using KinoRezerwacje;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Film film = new Film
        {
            Tytul = "Diuna",
            Opis = "Film przygodowy",
            Dlugosc = 60,
            Ocena = 6,
            
        };
        Sala sala = new Sala
        {
            
            
            Numer = 5
        };
        sala.Siedzenia.Add(new Miejsce { Rzad = 1, Numer = 1 });
        sala.Siedzenia.Add(new Miejsce { Rzad = 1, Numer = 2 });
        sala.Siedzenia.Add(new Miejsce { Rzad = 2, Numer = 1 });

        Seans seans = new Seans
        {
            Film = film,
            Sala = sala,

             Godzina = new DateTime(2026,10,10,10,23,43)
        };

        //Console.WriteLine(seans.CzyJestWolne(sala.Siedzenia[2]));
        //Console.WriteLine(seans.CzyJestWolne(sala.Siedzenia[0]));


        List<Miejsce> wybrane = new List<Miejsce>();
        wybrane.Add(sala.Siedzenia[2]);
        Rezerwacja? rezerwacjaJana = seans.Zarezerwuj("Jan", "Krolikowski", wybrane);
        Console.WriteLine(seans.Zarezerwuj("Zbigniew", "Maciwoda", wybrane));

        //List<Miejsce> wolneMiejsca = new List<Miejsce>();
        List<Miejsce> wolne = seans.WolneMiejsca();
        foreach(Miejsce miejsce in wolne)
        {
            Console.WriteLine($"Numer: {miejsce.Numer} Rząd: {miejsce.Rzad}");
            
        }
        Console.WriteLine($"Miejsca wolne: {wolne.Count}");
        
        Console.WriteLine(seans.CzyJestWolne(sala.Siedzenia[2]));
        Console.WriteLine(seans.AnulujRezerwacje(rezerwacjaJana));
        Console.WriteLine(seans.CzyJestWolne(sala.Siedzenia[2]));
    }
}
