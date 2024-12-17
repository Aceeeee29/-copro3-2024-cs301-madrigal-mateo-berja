public struct Credits
{
    //encapsulation
    private string Leader { get; set; }
    private string Member1 { get; set; }
    private string Member2 { get; set; }

    //constructor
    public Credits(string leader, string member1, string member2)
    {
        this.Leader = leader;
        this.Member1 = member1;
        this.Member2 = member2; // this keyword 
    }

    public void DisplayCredits()
    {
        Console.Clear();
        Console.WriteLine("CREDITS");
        Console.WriteLine($"Leader: {Leader}");
        Console.WriteLine("\nMembers:");
        Console.WriteLine($"- {Member1}");
        Console.WriteLine($"- {Member2}");
    }

    public void InteractiveCreditsMenu()
    {
        while (true)
        {
            try
            {
                DisplayCredits();
                Console.WriteLine("\nDo you want to return to the main menu?" +
                    "\n[1]Yes" +
                    "\n[2]No\n");
                string choice = Console.ReadLine().Trim();

                if (choice == "1")
                {
                    break;
                }
                else if (choice == "2")
                {
                    Console.WriteLine("Take your time! Press any key to continue viewing credits...");
                    Console.ReadKey();
                }
                else
                {
                    throw new InvalidOperationException("Invalid input. Please type 1 or 2.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine("Press any key to try again...");
                Console.ReadKey();
            }
        }
    }
}