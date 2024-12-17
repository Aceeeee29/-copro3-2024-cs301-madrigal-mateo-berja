using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace FinalsTP67
{
    public class NEWGAME
    {
        public static void RunNewGame()
        {

            SqlConnection ConnectionNaMaangas;
            string databaseconnectionstring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=""D:\PROGRAMMING\2ND YEAR COMPROG\FINALSTP3\FINALSTP67\DATABASE1.MDF"";Integrated Security=True";
            try
            {

                while (true)
                {
                    Console.Clear();
                    //intro
                    Console.WriteLine("Starting your game...");
                    Console.WriteLine("Please Customize Your Character Pizza Style");
                    ConnectionNaMaangas = new SqlConnection(databaseconnectionstring);
                    ConnectionNaMaangas.Open();

                    //Mascot Details
                    Console.WriteLine("Character Details: ");
                    Console.WriteLine("Enter Your Character Name: ");
                    string name = Console.ReadLine();

                    if (name == "") { throw new ArgumentException("Bawal Empty input."); }
                    if (IsValidString(name)) { }
                    else { throw new ArgumentException("Invalid input. Please ensure it contains only letters and is no more than 20 characters and no less than 4 characters."); }

                    Console.WriteLine("\nWhat gender do you like?");
                    Console.WriteLine("1. Male");
                    Console.WriteLine("2. Female");
                    Console.WriteLine("3. Transgender");
                    Console.WriteLine("4. Gender Neutral");
                    Console.WriteLine("5. Other");
                    string gender = Console.ReadLine();
                    string usergender = "";
                    if (gender == "") { throw new ArgumentException("Bawal Empty input."); }
                    if (gender != "1" && gender != "2" && gender != "3" && gender != "4" && gender != "5") { throw new ArgumentException("Wala sa choices."); }


                    switch (gender)
                    {
                        case "1":
                            usergender = "Male";
                            break;
                        case "2":
                            usergender = "Female";
                            break;
                        case "3":
                            usergender = "Transgender";
                            break;
                        case "4":
                            usergender = "Gender Neutral";
                            break;
                        case "5":
                            usergender = "Other";
                            break;
                    }

                    Console.WriteLine("\nWhat sauce do you want?");
                    Console.WriteLine("1. Marinara");
                    Console.WriteLine("2. Pesto Sauce");
                    Console.WriteLine("3. Alfredo / White Sauce");
                    Console.WriteLine("4. Romesco Sauce");
                    Console.WriteLine("5. Spicy Red Sauce");
                    Console.WriteLine("6. Garlic and Oil Sauce");
                    string sauce = Console.ReadLine();
                    string usersauce = "";
                    if (sauce == "") { throw new ArgumentException("Bawal Empty input."); }
                    if (sauce != "1" && sauce != "2" && sauce != "3" && sauce != "4" && sauce != "5" && sauce != "6") { throw new ArgumentException("Wala sa choices."); }
                    switch (sauce)
                    {
                        case "1":
                            usersauce = "Marinara";
                            break;
                        case "2":
                            usersauce = "Pesto";
                            break;
                        case "3":
                            usersauce = "Alfredo";
                            break;
                        case "4":
                            usersauce = "Romesco";
                            break;
                        case "5":
                            usersauce = "SpicyRed";
                            break;
                        case "6":
                            usersauce = "Garlic/Oil";
                            break;
                    }
                    Console.WriteLine("\nWhat type of crust? ");
                    Console.WriteLine("1. Thin Crust");
                    Console.WriteLine("2. Thick Crust");
                    Console.WriteLine("3. Cheese Crust");
                    Console.WriteLine("4. Sausage Crust");
                    Console.WriteLine("5. Mozzarella Crust");
                    string crust = Console.ReadLine();
                    string usercrust = "";
                    if (crust == "") { throw new ArgumentException("Bawal Empty input."); }
                    if (crust != "1" && crust != "2" && crust != "3" && crust != "4" && crust != "5") { throw new ArgumentException("Wala sa choices."); }
                    switch (crust)
                    {
                        case "1":
                            usercrust = "Thin";
                            break;
                        case "2":
                            usercrust = "Thick";
                            break;
                        case "3":
                            usercrust = "Cheese";
                            break;
                        case "4":
                            usercrust = "Sausage";
                            break;
                        case "5":
                            usercrust = "Mozzarella";
                            break;
                    }
                    Console.WriteLine("\nPlease choose the cheese(s) of your choice: ");
                    Console.WriteLine("1. Cheddar");
                    Console.WriteLine("2. Mozzarella");
                    Console.WriteLine("3. Monty Jack");
                    Console.WriteLine("4. Parmigiano-Reggiano");
                    Console.WriteLine("5. Provolone");
                    string cheeses = "";

                    string cheese = Console.ReadLine();
                    if (cheese != "1" && cheese != "2" && cheese != "3" && cheese != "4" && cheese != "5") { throw new ArgumentException("Wala sa choices."); }
                    if (cheese == "") { throw new ArgumentException("Bawal Empty input."); }
                    switch (cheese)
                    {
                        case "1":
                            cheeses = "Cheddar";
                            break;
                        case "2":
                            cheeses = "Mozzarella";
                            break;
                        case "3":
                            cheeses = "Monty Jack";
                            break;
                        case "4":
                            cheeses = "Parmigiano-Reggiano";
                            break;
                        case "5":
                            cheeses = "Provolone";
                            break;
                    }



                    Console.WriteLine("\nWhat are your meat toppings");
                    Console.WriteLine("1. Pepperoni");
                    Console.WriteLine("2. Sausage");
                    Console.WriteLine("3. Bacon");
                    Console.WriteLine("4. Ham");
                    Console.WriteLine("5. Chicken");
                    Console.WriteLine("6. Beef");

                    string meats = "";

                    string meat = Console.ReadLine();
                    if (meat == "") { throw new ArgumentException("Bawal Empty input."); }
                    if (meat != "1" && meat != "2" && meat != "3" && meat != "4" && meat != "5" && meat != "6") { throw new ArgumentException("Wala sa choices."); }
                    switch (meat)
                    {
                        case "1":
                            meats = "Pepperoni";
                            break;
                        case "2":
                            meats = "Sausage";
                            break;
                        case "3":
                            meats = "Bacon";
                            break;
                        case "4":
                            meats = "Ham";
                            break;
                        case "5":
                            meats = "Chicken";
                            break;
                        case "6":
                            meats = "Beef";
                            break;
                    }


                    Console.WriteLine("\nWhat are your non meat toppings? ");
                    Console.WriteLine("1. Onions");
                    Console.WriteLine("2. Black Olives");
                    Console.WriteLine("3. Basil");
                    Console.WriteLine("4. Pepper");
                    Console.WriteLine("5. Spinach");
                    Console.WriteLine("6. Mushrooms");
                    Console.WriteLine("7. Garlic");
                    Console.WriteLine("8. Sundried Tomato");

                    string nonMeats = "";

                    string nonMeat = Console.ReadLine();
                    if (nonMeat == "") { throw new ArgumentException("Bawal Empty input."); }
                    if (nonMeat != "1" && nonMeat != "2" && nonMeat != "3" && nonMeat != "4" && nonMeat != "5" && nonMeat != "6" && nonMeat != "7" && nonMeat != "8") { throw new ArgumentException("Wala sa choices."); }

                    switch (nonMeat)
                    {
                        case "1":
                            nonMeats = "Onions";
                            break;
                        case "2":
                            nonMeats = "Black-Olives";
                            break;
                        case "3":
                            nonMeats = "Basil";
                            break;
                        case "4":
                            nonMeats = "Pepper";
                            break;
                        case "5":
                            nonMeats = "Spinach";
                            break;
                        case "6":
                            nonMeats = "Mushroom";
                            break;
                        case "7":
                            nonMeats = "Garlic";
                            break;
                        case "8":
                            nonMeats = "Sundried-Tomato";
                            break;

                    }


                    Console.WriteLine("\nFace Details: ");
                    Console.WriteLine("What is the size of the eyes? ");
                    Console.WriteLine("1. Round Eyes");
                    Console.WriteLine("2. Almond Eyes");
                    Console.WriteLine("3. Monolid Eyes");
                    Console.WriteLine("4. Potruding Eyes");
                    Console.WriteLine("5. Down Turned Eyes");
                    Console.WriteLine("6. Up Turned Eyes");
                    Console.WriteLine("7. Close Set Eyes");
                    Console.WriteLine("8. Wide Set Eyes");
                    string eyes = Console.ReadLine();
                    string usereyes = "";
                    if (eyes == "") { throw new ArgumentException("Bawal Empty input."); }
                    if (eyes != "1" && eyes != "2" && eyes != "3" && eyes != "4" && eyes != "5" && eyes != "6" && eyes != "7" && eyes != "8") { throw new ArgumentException("Wala sa choices."); }
                    switch (eyes)
                    {
                        case "1":
                            usereyes = "Round Eyes";
                            break;
                        case "2":
                            usereyes = "Almond Eyes";
                            break;
                        case "3":
                            usereyes = "Monolid Eyes";
                            break;
                        case "4":
                            usereyes = "Potruding Eyes";
                            break;
                        case "5":
                            usereyes = "Down Turned Eyes";
                            break;
                        case "6":
                            usereyes = "Up Turned Eyes";
                            break;
                        case "7":
                            usereyes = "Close Set Eyes";
                            break;
                        case "8":
                            usereyes = "Wide Set Eyes";
                            break;
                    }
                    Console.WriteLine("\nWhat is the color of eyes? ");
                    Console.WriteLine("1. Brown");
                    Console.WriteLine("2. Amber");
                    Console.WriteLine("3. Black");
                    Console.WriteLine("4. Blue");
                    Console.WriteLine("5. Gray");
                    Console.WriteLine("6. Green");
                    Console.WriteLine("7. Hazel");
                    Console.WriteLine("8. Red");
                    string color = Console.ReadLine();
                    string usercolor = "";
                    if (color == "") { throw new ArgumentException("Bawal Empty input."); }
                    if (color != "1" && color != "2" && color != "3" && color != "4" && color != "5" && color != "6" && color != "7" && color != "8") { throw new ArgumentException("Wala sa choices."); }
                    switch (color)
                    {
                        case "1":
                            usercolor = "Brown";
                            break;
                        case "2":
                            usercolor = "Amber";
                            break;
                        case "3":
                            usercolor = "Black";
                            break;
                        case "4":
                            usercolor = "Blue";
                            break;
                        case "5":
                            usercolor = "Gray";
                            break;
                        case "6":
                            usercolor = "Green";
                            break;
                        case "7":
                            usercolor = "Hazel";
                            break;
                        case "8":
                            usercolor = "Red";
                            break;
                    }
                    Console.WriteLine("\nWhat kind of eyebrow do you like? ");
                    Console.WriteLine("1. S-shaped");
                    Console.WriteLine("2. Hard Angled");
                    Console.WriteLine("3. Soft Angled");
                    Console.WriteLine("4. Straight");
                    Console.WriteLine("5. Rounded");
                    string eyeBrow = Console.ReadLine();
                    string usereyeBrow = "";
                    if (eyeBrow == "") { throw new ArgumentException("Bawal Empty input."); }
                    if (eyeBrow != "1" && eyeBrow != "2" && eyeBrow != "3" && eyeBrow != "4" && eyeBrow != "5") { throw new ArgumentException("Wala sa choices."); }
                    switch (eyeBrow)
                    {
                        case "1":
                            usereyeBrow = "S-shaped";
                            break;
                        case "2":
                            usereyeBrow = "Hard Angled";
                            break;
                        case "3":
                            usereyeBrow = "Soft Angled";
                            break;
                        case "4":
                            usereyeBrow = "Straight";
                            break;
                        case "5":
                            usereyeBrow = "Rounded";
                            break;
                    }
                    Console.WriteLine("\nType of lashes");
                    Console.WriteLine("1. None");
                    Console.WriteLine("2. Squirrel");
                    Console.WriteLine("3. Natural");
                    Console.WriteLine("4. Open Eye");
                    Console.WriteLine("5. Oat Eye");
                    Console.WriteLine("6. Baby doll");
                    Console.WriteLine("7. Kim-k");
                    string lashes = Console.ReadLine();
                    string userlashes = "";
                    if (lashes == "") { throw new ArgumentException("Bawal Empty input."); }
                    switch (lashes)
                    {
                        case "1":
                            userlashes = "None";
                            break;
                        case "2":
                            userlashes = "Squirrel";
                            break;
                        case "3":
                            userlashes = "Natural";
                            break;
                        case "4":
                            userlashes = "Open Eye";
                            break;
                        case "5":
                            userlashes = "Oat Eye";
                            break;
                        case "6":
                            userlashes = "Baby doll";
                            break;
                        case "7":
                            userlashes = "Kim-k";
                            break;
                    }
                    Console.WriteLine("\nType of nose");
                    Console.WriteLine("1. Greek Nose");
                    Console.WriteLine("2. Celestial Nose");
                    Console.WriteLine("3. Hawk Nose");
                    Console.WriteLine("4. Bulbous Nose");
                    Console.WriteLine("5. Fleshy Nose");
                    Console.WriteLine("6. Up Turned Nose");
                    Console.WriteLine("7. Button Nose");
                    string nose = Console.ReadLine();
                    string usernose = "";
                    if (nose == "") { throw new ArgumentException("Bawal Empty input."); }
                    if (nose != "1" && nose != "2" && nose != "3" && nose != "4" && nose != "5" && nose != "6" && nose != "7") { throw new ArgumentException("Wala sa choices."); }
                    switch (nose)
                    {
                        case "1":
                            usernose = "Greek Nose";
                            break;
                        case "2":
                            usernose = "Celestrial Nose";
                            break;
                        case "3":
                            usernose = "Hawk Nose";
                            break;
                        case "4":
                            usernose = "Bulbous Nose";
                            break;
                        case "5":
                            usernose = "Fleshy Nose";
                            break;
                        case "6":
                            usernose = "Up Turned Nose";
                            break;
                        case "7":
                            usernose = "Button Nose";
                            break;
                    }
                    Console.WriteLine("\nType of Lips");
                    Console.WriteLine("1. Full Lips");
                    Console.WriteLine("2. Heavy Upper Lips");
                    Console.WriteLine("3. Wide Lips");
                    Console.WriteLine("4. Heavy Lower Lips");
                    Console.WriteLine("5. Thin Lips");
                    Console.WriteLine("6. Heart Shaped Lips");
                    Console.WriteLine("7. Downward Turned Lips");
                    string lips = Console.ReadLine();
                    string userlips = "";
                    if (lips == "") { throw new ArgumentException("Bawal Empty input."); }
                    if (lips != "1" && lips != "2" && lips != "3" && lips != "4" && lips != "5" && lips != "6" && lips != "7") { throw new ArgumentException("Wala sa choices."); }
                    switch (lips)
                    {
                        case "1":
                            userlips = "Full Lips";
                            break;
                        case "2":
                            userlips = "Heavy Upper Lips";
                            break;
                        case "3":
                            userlips = "Wide Lips";
                            break;
                        case "4":
                            userlips = "Heavy Lower Lips";
                            break;
                        case "5":
                            userlips = "Thin Lips";
                            break;
                        case "6":
                            userlips = "Heart Shaped Lips";
                            break;
                        case "7":
                            userlips = "Downward Turned Lips";
                            break;
                    }
                    Console.WriteLine("\nType of Ears");
                    Console.WriteLine("1. Oblique");
                    Console.WriteLine("2. Rectangular");
                    Console.WriteLine("3. Round");
                    Console.WriteLine("4. Triangular");
                    Console.WriteLine("5. Oval");
                    string ears = Console.ReadLine();
                    string userears = "";
                    if (ears == "") { throw new ArgumentException("Bawal Empty input."); }
                    if (ears != "1" && ears != "2" && ears != "3" && ears != "4" && ears != "5") { throw new ArgumentException("Wala sa choices."); }
                    switch (ears)
                    {
                        case "1":
                            userears = "Oblique";
                            break;
                        case "2":
                            userears = "Rectangular";
                            break;
                        case "3":
                            userears = "Round";
                            break;
                        case "4":
                            userears = "Triangular";
                            break;
                        case "5":
                            userears = "Oval";
                            break;
                    }
                    Console.WriteLine("\nOutfit Details: ");
                    Console.WriteLine("What type of hat do you like? ");
                    Console.WriteLine("1. Baseball Cap");
                    Console.WriteLine("2. Cloche Hat");
                    Console.WriteLine("3. Fedora");
                    Console.WriteLine("4. Cowboy");
                    Console.WriteLine("5. Bucket Hat");
                    Console.WriteLine("6. Beanie");
                    string hat = Console.ReadLine();
                    string userhat = "";
                    if (hat == "") { throw new ArgumentException("Bawal Empty input."); }
                    if (hat != "1" && hat != "2" && hat != "3" && hat != "4" && hat != "5" && hat != "6") { throw new ArgumentException("Wala sa choices."); }
                    switch (hat)
                    {
                        case "1":
                            userhat = "Baseball Cap";
                            break;
                        case "2":
                            userhat = "Cloche Hat";
                            break;
                        case "3":
                            userhat = "Fedora";
                            break;
                        case "4":
                            userhat = "Cowboy";
                            break;
                        case "5":
                            userhat = "Bucket Hat";
                            break;
                        case "6":
                            userhat = "Beanie";
                            break;
                    }
                    Console.Write("\nDo you want to add glasses to your character?" +
                        "\n[1]Yes" +
                        "\n[2]No\n");
                    string response1 = Console.ReadLine().ToLower();
                    bool addGlasses = response1 == "1";
                    if (response1 == "") { throw new ArgumentException("Bawal Empty input."); }
                    if (response1 != "1" && response1 != "2") { throw new ArgumentException("Wala sa choices."); }
                    if (addGlasses)
                    {
                        response1 = "Yes";
                        Console.WriteLine("You have chosen to add glasses to your character.");
                    }
                    else
                    {
                        response1 = "No";
                        Console.WriteLine("You have chosen not to add glasses to your character.");
                    }

                    Console.Write("\nDo you want to add necktie to your character?" +
                        "\n[1]Yes" +
                        "\n[2]No\n");
                    string response = Console.ReadLine().ToLower();
                    bool addnecktie = response == "1";
                    if (response == "") { throw new ArgumentException("Bawal Empty input."); }
                    if (response != "1" && response != "2") { throw new ArgumentException("Wala sa choices."); }
                    if (addnecktie)
                    {
                        response = "Yes";
                        Console.WriteLine("You have chosen to add necktie to your character.");
                    }
                    else
                    {
                        response = "No";
                        Console.WriteLine("You have chosen not to add necktie to your character.");
                    }

                    Console.WriteLine("\nWhat is the color of your gloves? ");
                    Console.WriteLine("1. Red");
                    Console.WriteLine("2. Black");
                    Console.WriteLine("3. Blue");
                    Console.WriteLine("4. White");
                    Console.WriteLine("5. Green");
                    Console.WriteLine("6. Yellow");
                    Console.WriteLine("7. Pink");
                    string gloves = Console.ReadLine();
                    string usergloves = "";

                    if (gloves == "") { throw new ArgumentException("Bawal Empty input."); }
                    if (gloves != "1" && gloves != "2" && gloves != "3" && gloves != "4" && gloves != "5" && gloves != "6" && gloves != "7") { throw new ArgumentException("Wala sa choices."); }
                    switch (gloves)
                    {
                        case "1":
                            usergloves = "Red";
                            break;
                        case "2":
                            usergloves = "Black";
                            break;
                        case "3":
                            usergloves = "Blue";
                            break;
                        case "4":
                            usergloves = "White";
                            break;
                        case "5":
                            usergloves = "Green";
                            break;
                        case "6":
                            usergloves = "Yellow";
                            break;
                        case "7":
                            usergloves = "Pink";
                            break;
                    }
                    Console.WriteLine("\nWhat type of shoes do you like? ");
                    Console.WriteLine("1. Boots");
                    Console.WriteLine("2. Leather");
                    Console.WriteLine("3. Sneakers");
                    Console.WriteLine("4. Sandals");
                    Console.WriteLine("5. Flipflops");
                    Console.WriteLine("6. Loafers");
                    string shoes = Console.ReadLine();
                    string usershoes = "";

                    if (shoes == "") { throw new ArgumentException("Bawal Empty input."); }
                    if (shoes != "1" && shoes != "2" && shoes != "3" && shoes != "4" && shoes != "5" && shoes != "6") { throw new ArgumentException("Wala sa choices."); }

                    switch (shoes)
                    {
                        case "1":
                            usershoes = "Boots";
                            break;
                        case "2":
                            usershoes = "Leather";
                            break;
                        case "3":
                            usershoes = "Sneaker";
                            break;
                        case "4":
                            usershoes = "Sandals";
                            break;
                        case "5":
                            usershoes = "Flipflops";
                            break;
                        case "6":
                            usershoes = "Loafers";
                            break;
                    }
                    Console.WriteLine("\nOthers: ");
                    Console.Write("Do you want have a sidekick?" +
                        "\n[1]Yes" +
                        "\n[2]No\n");
                    string response2 = Console.ReadLine().ToLower();
                    bool addSideKick = response2 == "1";

                    if (response2 == "") { throw new ArgumentException("Bawal Empty input."); }
                    if (response2 != "1" && response2 != "2") { throw new ArgumentException("Wala sa choices."); }
                    if (addSideKick)
                    {
                        response2 = "Yes";
                        Console.WriteLine("You have chosen to add sidekick with your character.");
                    }
                    else
                    {
                        response2 = "No";
                        Console.WriteLine("You have chosen not to add sidekick with your character.");
                    }

                    Console.WriteLine("\nBudgeting Starter Tools: ");
                    int budget = 300;
                    Console.WriteLine("Distribute your $300 budget to equip your chef with tools for the kitchen");
                    Console.WriteLine("1. Basic Oven: $200");
                    Console.WriteLine("2. Pizza Cutter Set: $50");
                    Console.WriteLine("3. Mixing Bowls: $30");
                    Console.WriteLine("4. Rolling Pins: $20");
                    Console.WriteLine("5. High End Mixer: $300");
                    Console.WriteLine("6. Knife Set: $100");
                    Console.WriteLine("7. Spatula Set: $50");
                    Console.WriteLine("8. Ingredient Storage Containers: $50");

                    bool boolers = true;
                    string totaltool = "";
                    while (boolers)
                    {
                        Console.WriteLine("Choose a tool by entering the corresponding number (1-8) or type 'exit' to finish:");
                        string tools = Console.ReadLine();
                        if (tools == "") { throw new ArgumentException("Bawal Empty input."); }

                        if (tools.ToLower() == "exit")
                        {
                            boolers = false;
                            break;
                        }

                        int cost = 0;
                        string toolName = "";
                        switch (tools)
                        {
                            case "1":
                                toolName = "Basic Oven";
                                totaltool += "Basic Oven, ";
                                cost = 200;
                                break;
                            case "2":
                                toolName = "Pizza Cutter Set";
                                totaltool += "Pizza Cutter Set, ";
                                cost = 50;
                                break;
                            case "3":
                                toolName = "Mixing Bowls";
                                totaltool += "Mixing Bowls, ";
                                cost = 30;
                                break;
                            case "4":
                                toolName = "Rolling Pins";
                                totaltool += "Rolling Pins, ";
                                cost = 20;
                                break;
                            case "5":
                                toolName = "High End Mixer";
                                totaltool += "High End Mixer, ";
                                cost = 300;
                                break;
                            case "6":
                                toolName = "Knife Set";
                                totaltool += "Knife Set, ";
                                cost = 100;
                                break;
                            case "7":
                                toolName = "Spatula Set";
                                totaltool += "Spatula Set, ";
                                cost = 50;
                                break;
                            case "8":
                                toolName = "Ingredient Storage Containers";
                                totaltool += "Ingredient Storage Containers, ";
                                cost = 50;
                                break;
                            default:
                                Console.WriteLine("Invalid selection. Please choose a valid option.");
                                continue;
                        }

                        if (budget >= cost)
                        {
                            budget -= cost;
                            Console.WriteLine($"You selected: {toolName}. Cost: ${cost}");
                            Console.WriteLine($"Remaining budget: ${budget}");
                        }
                        else
                        {
                            Console.WriteLine($"You cannot afford {toolName}. Remaining budget: ${budget}");
                        }
                    }

                    if (totaltool.Length > 0)
                    {
                        totaltool = totaltool.Substring(0, totaltool.Length - 2);
                    }


                    EncapNewGame NG = new EncapNewGame(name, usergender, usersauce, usercrust, cheeses, meats, nonMeats, usereyes, usercolor, usereyeBrow, userlashes, usernose, userlips, userears, userhat, usergloves, usershoes);

                    Console.Clear();
                    Console.WriteLine("Character Created!");

                    Console.WriteLine("Your Character: ");
                    Console.WriteLine($"Character name: {NG.getName()}");
                    Console.WriteLine($"Gender: {NG.getGender()}");
                    Console.WriteLine($"Sauce: {NG.getSauce()}");
                    Console.WriteLine($"Crust: {NG.getCrust()}");
                    Console.WriteLine($"Cheese(s): {NG.getCheese()}");
                    Console.WriteLine($"Meat toppings: {NG.getMeat()}");
                    Console.WriteLine($"Non-meat toppings: {NG.getNonMeat()}");
                    Console.WriteLine($"Eyes: {NG.getFaceDetails()}");
                    Console.WriteLine($"Eye color: {NG.getEyecolor()}");
                    Console.WriteLine($"Eyebrow: {NG.getEyeBrow()}");
                    Console.WriteLine($"Eyelashes: {NG.getEyeLashes()}");
                    Console.WriteLine($"Nose: {NG.getNose()}");
                    Console.WriteLine($"Lips: {NG.getLips()}");
                    Console.WriteLine($"Ears: {NG.getEars()}");
                    Console.WriteLine($"Hat: {NG.getHat()}");
                    Console.WriteLine($"With glasses: {response1}");
                    Console.WriteLine($"With necktie: {response}");
                    Console.WriteLine($"Gloves: {NG.getGloves()}");
                    Console.WriteLine($"Shoes: {NG.getShoes()}");
                    Console.WriteLine($"With sidekick: {response2}");
                    Console.WriteLine($"Your tools: {totaltool} ");



                    string insertdatapizza = "INSERT INTO dbo.PIZZA (user_name, user_gender, user_sauce, user_crust, user_cheese, user_meat, user_nonmeat, user_eyes, user_color, user_eyebrow, user_eyelashes, user_nose, user_lips, user_ears, user_hat, with_glasses, with_necktie, user_gloves, user_shoes, with_sidekick, user_totaltool) VALUES(' "+NG.getName() +" ',' "+ NG.getGender() +" ',' "+ NG.getSauce() +" ',' "+ NG.getCrust() +" ',' "+ NG.getCheese() +" ', ' "+ NG.getMeat() +" ',' "+ NG.getNonMeat() +" ',' "+ NG.getFaceDetails() +" ',' "+ NG.getEyecolor() +" ',' "+ NG.getEyeBrow() +" ',' "+ NG.getEyeLashes() +" ',' "+ NG.getNose() +" ',' "+ NG.getLips() +" ',' "+ NG.getEars() +" ',' "+ NG.getHat() +" ',' "+ response1 +" ',' "+ response +" ',' "+ NG.getGloves() +" ',' "+ NG.getShoes() +" ',' "+ response2 +" ',' "+ totaltool +" ')";
                    SqlCommand insertdatagamer = new SqlCommand(insertdatapizza, ConnectionNaMaangas);
                    insertdatagamer.ExecuteNonQuery();
                    Console.WriteLine("Saved Succesfully");


                    Console.WriteLine("Go back ba sa main menu?" +
                        "\n[1]Yes" +
                        "\n[2]No\n");
                    string goback = Console.ReadLine();

                    if (goback.ToLower() == "1")
                    {
                        break;
                    }
                    else if (goback.ToLower() == "2")
                    {
                        continue;
                    }
                }
            }
            catch (ArgumentException x) { Console.WriteLine(x.Message); }
        }
        static bool IsValidString(string input)
        {
            return Regex.IsMatch(input, "^[a-zA-Z ]{4,20}$") && input.Trim().Length > 0;
        }
    }
}

