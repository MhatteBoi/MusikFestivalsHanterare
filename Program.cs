using static System.Console;
namespace MusikFestivalsHanterare
{
    internal class Program
    {
        //gör 3 sub classer (artist, stage och schedule) och en main class (ManagerClass) som tar alla metoder
        static void Main(string[] args)
        {
            bool tool = true;
            // skapa en meny som är lätt att navigera och har tydliga instruktioner
            DateTime startTime = new DateTime(1995, 12, 20, 15, 12, 12);

            ManagerClass Manager = new();

            // kanske göra input till lowerCase så att det inte blir case sensitive?

            do
            {
                // main menue
                WriteLine("Välkommen till Festivals Hanteraren! Välj vad du vill göra genom att klicka på respektive nummer!");
                WriteLine("==================================================================================================");
                WriteLine("1: Lägg till artist");
                WriteLine("2: Lägg till låtar till setList för de olika artisterna");
                WriteLine("3: Ta bort artist");
                WriteLine("4: Lägg in scen namn och kapacitet");
                WriteLine("5: Lägg till Artist till scen med tid för spelning");
                WriteLine("6: Ta bort artisten från scen");
                WriteLine("7: visa alla scheman med artister");
                WriteLine("8: visa alla artister");
                WriteLine("9: visa alla scener");
                WriteLine("0: Avsluta");
                WriteLine("===================================================================================================");

                int userInput = int.Parse(Console.ReadLine());

                switch (userInput)
                {
                    //add artist
                    case 1:
                        Console.Clear();
                        WriteLine("Ange artist att lägga in i listan");
                        Write("Artist: ");
                        string? inputArtist = Console.ReadLine();
                        Manager.AddArtist(inputArtist);
                    break;

                    //add songs to setList
                    case 2:
                        Console.Clear();
                        WriteLine("lägg in låtar som artisten ska spela, Vilken artist ska du lägga in låtar till?");
                        string? artistName = Console.ReadLine();
                        WriteLine("Hur många låtar ska artisten spela?");
                        Write("Antal låtar: ");
                        int antal = int.Parse(Console.ReadLine());
                        // Create a list to store the songs
                        List<string> setList = new List<string>();

                        for (int i = 0; i < antal; i++)
                        {
                            Write("Låtar: ");
                            string song = Console.ReadLine();

                            // Add each song to the setList
                            setList.Add(song);
                        }

                        
                        Manager.AddSongToSetList(artistName, setList);
                        break;

                        //remove artist
                    case 3:
                        Console.Clear();
                        WriteLine("Ange artist som inte ska spela längre");
                        Write("Artist: ");
                        string? removeArtist = Console.ReadLine();
                        Manager.RemoveArtist(removeArtist);
                        break;

                        //add stage and capacity
                    case 4:
                        Console.Clear();
                        WriteLine("ange kapacitet och namn på scen");
                        Write("Kapacitet: ");
                        int cap = int.Parse(Console.ReadLine());
                        Write("Scen: ");
                        string? stage = Console.ReadLine();
                        Manager.AddStageNameAndCap(cap, stage);
                        break;

                        //add artist to specific stage
                    case 5:
                        Console.Clear();
                        WriteLine("Ange artist, scen och tiden de ska spela!");
                        Write("Artist: ");
                        string? AddArtist = Console.ReadLine();
                        Write("Scen: ");
                        string? ScenNamn = Console.ReadLine();
                        Write("År: ");
                        int år = int.Parse(Console.ReadLine());
                        Write("månad: ");
                        int månad = int.Parse(Console.ReadLine());
                        Write("dag: ");
                        int dag = int.Parse(Console.ReadLine());
                        Write("timme: ");
                        int timme = int.Parse(Console.ReadLine());
                        Write("minut: ");
                        int minut = int.Parse(Console.ReadLine());
                        Write("sekund: ");
                        int sekund = int.Parse(Console.ReadLine());
                        DateTime date = new DateTime(år, månad, dag, timme, minut, sekund);

                        Manager.AddArtistToStage(AddArtist, ScenNamn, date);
                        break;
                        
                        //remove artist from stage
                    case 6:
                        Console.Clear();
                        WriteLine("Ange artist och scen så vi tar bort rätt artist ");
                        Write("Artist: ");
                        string artist = Console.ReadLine();
                        Write("Scen: ");
                        string scen = Console.ReadLine();
                        Manager.RemoveArtistFromStage(artist, scen);
                        break;
                        
                    case 7:
                        Console.Clear();
                        Manager.ShowScheduleAll();
                        break;
                        
                    case 8:
                        Console.Clear();
                        Manager.ShowArtist();
                        break;
                        
                    case 9:
                        Console.Clear();
                        Manager.ShowStage();
                        break;
                        
                    case 0:
                        Console.Clear();
                        WriteLine("Hejdå!");
                        Thread.Sleep(2000);
                        tool = false;
                    break;
                }
            }
            while (tool);
            


        }
    }
}
