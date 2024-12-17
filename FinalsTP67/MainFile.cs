using FinalsTP67;

public class MainFile : ICredits // inheritance
{
    private Credits credits;
    private CampaignStory campaign;



    // Constructor 
    public MainFile(string title, string leader = "", string member1 = "", string member2 = "", string customize = "")
    {
        credits = new Credits(leader, member1, member2);
        campaign = new CampaignStory(title);
       
    }

    

    public void DisplayChapter()
    {
        Console.WriteLine("\nCampaign Menu...");
        campaign.DisplayIntroduction();
        
    }

    // Implement ICredits
    public void DisplayCredits()
    {
        credits.DisplayCredits();
    }

    public void InteractiveCreditsMenu()
    {
        credits.InteractiveCreditsMenu();
    }

    
    public static void DisplayNewGame()
    {
      NEWGAME.RunNewGame();
    }

    public void InteractiveGameMenu()
    {
    }

    // Main method controlling the program flow
    public static void Main(string[] args)
    {
        bool exit = false;
        MainFile mainFileInstance = null;

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Dough Master");
            Console.WriteLine("1. NEW GAME");
            Console.WriteLine("2. LOAD GAME");
            Console.WriteLine("3. CAMPAIGN MODE");
            Console.WriteLine("4. CREDITS");
            Console.WriteLine("5. EXIT");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // New Game
                    DisplayNewGame();
                    break;

                case "2":
                    
                    LoadGame loadGame = new LoadGame();

                    loadGame.LoadMenu();
                    break;

                case "3":
                    // Campaign Mode
                    CampaignStory story = new CampaignStory("The Pizza Quest");
                    story.DisplayAllCampaign();
                    break;

                case "4":
                    // Credits
                    mainFileInstance = new MainFile(
                        "Credits",
                        "Christian Paul Madrigal - Leader of the group, Alpha male inside the CyberZone. May Jowa at yun ang inuuna. Computer science student with great gamble skills pagdating sa coding.",
                        "Michael Jann Mateo - Kung ano ano role inside the group. Amoy matamis paggumagala and dadalhin bag mo. Dalawang beses ni friendzone pero meron Charizard EX sa Pokemon TCG. Computer science student na mabilis magalit if the code is not working.",
                        "Michael Andre Berja - Mabangis. Family driver in the morning, F1 racer sa gabi. Mayonnaise type of person (Ladies choice). Naka macbook mag code. Signature scent: Baccarat Rouge 540. Computer science student with average coding skills basta hindi maingay katabi."
                    );
                    mainFileInstance.InteractiveCreditsMenu();
                    break;

                case "5":
                    exit = true;
                    break;

                default:
                    Console.WriteLine("\nInvalid selection. Please choose a valid option (1-5).");
                    break;
            }

            if (!exit)
            {
                Console.WriteLine("\nPress any key to return to the main menu.");
                Console.ReadKey();
            }
        }
    }
}
