namespace SchereSteinPapier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programieren Sie ein Schere, Stein, Papier Spiel.
            //Der User soll eines der Handzeichen wählen können.
            //Der Computer wählt per Zufall ein eigenes Zeichen.
            //Dem User wird dann ausgegeben, welches Zeichen der Computer gewählt hat und ob man gewonnen, verloren oder ein Unentschieden hat.
            //Danach kann sich der User entscheiden eine weitere Runde zu spielen, oder nicht.

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Spielen wir eine Runde Schere, Stein, Papier");
            bool nochmal = false;
            do
            {
                nochmal = false;
                Console.WriteLine("Bitte wähle Schere, Stein oder Papier");
                string userAuswahl = Console.ReadLine().ToLower();
                string[] cpu = { "schere", "stein", "papier" };
                Random random = new Random();
                string cpuAuswahl = cpu[random.Next(cpu.Length)];

                Console.WriteLine($"Der Computer wählt {cpuAuswahl}");

                if (userAuswahl == cpuAuswahl)
                {
                    Console.WriteLine("Unentschieden");
                }
                else if ((userAuswahl == "schere" &&  cpuAuswahl == "stein") || (userAuswahl == "stein" && cpuAuswahl == "papier") || (userAuswahl == "papier" && cpuAuswahl == "schere"))
                {
                    Console.WriteLine("Du Verlierst!");
                }
                else if ((cpuAuswahl == "schere" && userAuswahl == "stein") || (cpuAuswahl == "stein" && userAuswahl == "papier") || (cpuAuswahl == "papier" && userAuswahl == "schere"))
                {
                    Console.WriteLine("Du Gewinnst!");
                }
                else
                {
                    Console.WriteLine("Deine eingabe war ungültig!");
                }

                Console.WriteLine("Möchtest du erneut Spielen (y/n)");
                string erneut = Console.ReadLine().ToLower();
                if (erneut == "y")
                {
                    nochmal = true;
                }
                else
                {
                    Console.WriteLine("Auf Wiedersehen.");
                    nochmal = false;
                }
            }while (nochmal == true);

        }
    }
}
