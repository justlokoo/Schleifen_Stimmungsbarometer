using System;

class Stimmungsbarometer
{
    static void Main(string[] args)
    {
        // Initialisierung der benötigten Variablen
        int eingabe = 0;
        int anzahlEingaben = 0;
        int gesamtStimmung = 0;

        Console.WriteLine("Geben Sie die Stimmung ein (1 = sehr gut, 5 = sehr schlecht). Geben Sie 0 ein, um das Programm zu beenden und die Ergebnisse anzuzeigen.");

        // Schleife, die läuft, bis der Benutzer 0 eingibt
        do
        {
            Console.Write("Stimmung (1-5, 0 zum Beenden): ");
            eingabe = Convert.ToInt32(Console.ReadLine());

            // Prüft, ob die Eingabe zwischen 1 und 5 liegt
            if (eingabe >= 1 && eingabe <= 5)
            {
                gesamtStimmung += eingabe;
                anzahlEingaben++;
            }
            else if (eingabe != 0)
            {
                Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl zwischen 1 und 5 ein, oder 0 zum Beenden.");
            }

        } while (eingabe != 0);

        Console.WriteLine("Berechnung der Ergebnisse...");

        // Berechnung und Ausgabe der Ergebnisse
        if (anzahlEingaben > 0)
        {
            double durchschnittlicheStimmung = (double)gesamtStimmung / anzahlEingaben;
            Console.WriteLine($"Anzahl der Eingaben: {anzahlEingaben}");
            Console.WriteLine($"Durchschnittliche Stimmung: {durchschnittlicheStimmung:N2}");
        }
        else
        {
            Console.WriteLine("Keine gültigen Eingaben erhalten.");
        }

        // Aufforderung für den Benutzer, eine Taste zu drücken, bevor das Programm endet
        Console.WriteLine("Drücken Sie eine beliebige Taste, um das Programm zu beenden.");
        Console.ReadKey();
    }
}
