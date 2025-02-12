//Primo Esercizio Creo la classe ContoCorrente
using ConsoleApp1.Models;

ContoCorrente myConto1 = new ContoCorrente(1122245, "Walter", "Antonelli", "Intesa San Paolo", 2000);
ContoCorrente myCont2 = new ContoCorrente(3737622, "Pinko", "Pallino", "IsyBank Data", 500);

myConto1.ApriConto(myConto1.IdConto);
myConto1.ApriConto(myConto1.IdConto);

myConto1.VisualizzaContoCorrente();

myCont2.ApriConto(myCont2.IdConto);

myCont2.VisualizzaContoCorrente();

string[] nomi = new string[4] { myConto1.NameConto, myCont2.NameConto, "Francesco", "Rosaria" };

Console.WriteLine("Scrivi Persona da Trovare");
Console.ForegroundColor = ConsoleColor.White;

string? userName = Console.ReadLine();

for(int i = 0; i < nomi.Length; i++)
{
    if (userName == null || userName == "" || userName != " ") {
        Console.WriteLine("Nessun Nome Scritto !! ");
    }

    if (userName == nomi[i]) { Console.WriteLine("Nome trovato --> " + nomi[i]); }

    if (userName != nomi[i]) { Console.WriteLine("Nessun Nome Trovato !"); }

}



