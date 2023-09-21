using adonet_db_videogame;


internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Benvenuto nel nostro sistema di gestione Aeroportuale!");

        while (true)
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
                    break;

                case 3:
                    break;

                case 4:
                    break;

                case 5

                     :break;

                default:
                    Console.WriteLine("Non hai selezionato un'opzione valida!");
                    break;
            }


        }


    }
}