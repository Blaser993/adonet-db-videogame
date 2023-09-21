using adonet_db_videogame;


internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Benvenuto nel nostro sistema di gestione Aeroportuale!");
        bool program = true;
        while (program)
        {
            Console.WriteLine(@"
            - 1: Inserisci un nuovo videogioco 
            - 2: Ricerca un videogioco per Id
            - 3: Ricerca tramite parola chiave
            - 4: Cancella un videogioco
            - 5: Chiudi il programma
            ");


            Console.Write("Seleziona l'opzione desiderata: ");

            int selectedOption = int.Parse(Console.ReadLine());
            switch (selectedOption)
            {
                case 1:
                    List<Videogame> videogames = VideogameManager.GetGames();

                    Console.WriteLine("Ecco la lista dei videogiochi disponibili:");

                    foreach (Videogame videogame in videogames)
                    {
                        Console.WriteLine($"- {videogame}");
                    }

                    Console.WriteLine();
                    break;

                case 2:

                    Videogame videogameSearch = VideogameManager.SearchGamesFromId();

                    Console.WriteLine("Ecco il videogioco da te richiesto:");

                    if (videogameSearch != null)
                    {
                        Console.WriteLine($"- {videogameSearch}");
                    }
                    else
                    {
                        Console.WriteLine("il videogioco con l'Id richiesto non esiste");
                    }

                    Console.WriteLine();
                    break;

                case 3:

                    List<Videogame> videogames1 = VideogameManager.SearchGamesFromKeyword();

                    Console.WriteLine("Ecco la lista dei risultati:");

                    foreach (Videogame videogame in videogames1)
                    {
                        Console.WriteLine($"- {videogame}");
                    }
                    Console.WriteLine();
                    break;

                case 4:
                    break;

                case 5:
                    program = false;
                    Console.WriteLine("Grazie e arrivederci.");
                     break;

                default:
                    Console.WriteLine("Non hai selezionato un'opzione valida!");
                    break;
            }


        }


    }
}