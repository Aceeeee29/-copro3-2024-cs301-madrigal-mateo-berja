using System;

public abstract class CampaignBase
{
    // Encapsulation: Abstract property
    public abstract string Title { get; set; }

    // Abstract method to display an introduction
    public abstract void DisplayIntroduction();

    // Abstract method to display a chapter
    public abstract void DisplayChapter(int chapterNumber, string chapterTitle, string content);

    // Abstract method to get user input
    public abstract string GetUserInput(string prompt);

    // Abstract method to display all campaign content
    public abstract void DisplayAllCampaign();
}

public class CampaignStory : CampaignBase
{
    // Encapsulation: Concrete implementation of Title property
    public override string Title { get; set; }

    // Constructor
    public CampaignStory(string title)
    {
        this.Title = title;
    }

    // Overriding abstract methods
    public override void DisplayIntroduction()
    {
        Console.WriteLine("\nIntroduction to the campaign...");
    }

    public override void DisplayChapter(int chapterNumber, string chapterTitle, string content)
    {
        Console.Clear();
        Console.WriteLine($"\nChapter {chapterNumber}: {chapterTitle}");
        Console.WriteLine(content);
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }

    public override string GetUserInput(string prompt)
    {
        Console.WriteLine(prompt);
        return Console.ReadLine().Trim().ToLower();
    }

    public override void DisplayAllCampaign()
    {
        while (true)
        {
            try
            {
                DisplayIntroduction();

                DisplayChapter(1, "A Dream Beyond the Crust", "In the cozy little town of Crusthaven, where the streets smelled of fresh " +
               "herbs and melted cheese, lived a pizza chef known as Doughy Dan. With his flour-dusted apron and a twinkle in his " +
               "eye, Dan was beloved for his pizzas, but he carried a secret ambition: to become the Dough Master, a title only given to those who could craft the legendary Unity Pizza.\r\n\r\nThe recipe for the Unity Pizza was said to require three magical ingredients hidden in far-off lands. One stormy night, as Dan cleaned his kitchen, he discovered a hidden compartment in his rolling pin. Inside was an ancient map marked with the locations of the ingredients.\r\n\r\nDan stared at the map, heart pounding. “This is it! My chance to be the greatest pizza maker in history!” he declared. He grabbed his rolling pin, packed his pizza paddle, and set off into the unknown.");
                DisplayChapter(2, "Trials in the Flour Fields", "Dan’s first stop was the Flour Fields, a sprawling plain of golden wheat that swayed like ocean waves. Here, he sought the Sacred Grain, a flour so fine it could make dough as soft as clouds.\r\n\r\nAs Dan wandered the fields, a booming voice called out, “Who dares enter my domain?” It was the Flour Guardian, a towering figure made entirely of dough. “If you want the Sacred Grain, you must prove your skills!”\r\n\r\nThe guardian challenged Dan to a dough-kneading duel. They worked side by side, kneading, tossing, and stretching dough at lightning speed. Sweat dripped from Dan’s brow, but his passion kept him going. Finally, the Flour Guardian stepped back, impressed.\r\n\r\n“You have the hands of a true chef. Take the Sacred Grain and use it well,” the Guardian said.");
                DisplayChapter(3, "Scaling the Cheese Peaks", "Next, Dan climbed the Cheese Peaks, towering mountains where the air smelled of dairy and the rocks were made of aged cheddar. He was searching for the Moonlit Mozzarella, a cheese that glowed faintly in the dark.\r\n\r\nAt the summit, Dan encountered the Cheese Warden, a wise and ancient brie who spoke in riddles. “To claim the Moonlit Mozzarella, you must master the art of the perfect cheese pull,” said the Warden.\r\n\r\nDan worked tirelessly, stretching cheese until it formed silky strands that danced in the moonlight. The Warden, clearly impressed, handed him the glowing mozzarella. “Your determination shines brighter than this cheese. Go forth, young chef.");
                DisplayChapter(4, "The Tomato Trial", "The final stop on Dan’s journey was the Crimson Canopy, a dense forest of vibrant tomato plants. Somewhere within lay the Heart of the Vine, a tomato so flavorful it could make any sauce irresistible.\r\n\r\nDeep in the forest, Dan faced the Tomato Keeper, a spirited tomato with a sharp tongue. “If you want the Heart of the Vine, show me what makes your pizzas special!”\r\n\r\nDan didn’t hesitate. He rolled out dough, spread sauce with care, and crafted a mini pizza with the simplest ingredients he had. The Keeper took one bite and sighed. “This is pizza made with heart. The Heart of the Vine is yours.");
                DisplayChapter(5, "The Unity Pizza", "With the Sacred Grain, Moonlit Mozzarella, and Heart of the Vine in hand, Dan returned to his pizzeria. The entire town of Crusthaven gathered to watch as he prepared the Unity Pizza.\r\n\r\nDan worked with precision, kneading the dough, spreading the vibrant sauce, and layering the cheese. When the pizza emerged from the oven, it glowed with warmth, and its aroma filled the air.\r\n\r\nThe first slice was shared between two long-feuding families in the town. As they tasted it, their eyes lit up, and they laughed together for the first time in years. The Unity Pizza had done what its name promised—it brought people together.\r\n\r\nFrom that day on, Doughy Dan was known as the Dough Master, a chef who proved that passion and hard work could unite even the most divided hearts.\r\n\r\nThe End.");

                

                string choice = GetUserInput("Do you want to go back to the Main menu?" +
                    "\n[1]Yes" +
                    "\n[2]No\n ");

                if (choice == "1")
                {
                    break;
                }
                else if (choice == "2")
                {
                    Console.WriteLine("Take your time! Press any key to restart the campaign story");
                    Console.ReadKey();
                }
                else
                {
                    // Exception handling
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
