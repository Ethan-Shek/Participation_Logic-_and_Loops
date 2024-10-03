namespace Participation_Logic_and_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string playerName = "adventurer";
            string userChoice = "NONE";

            Console.WriteLine("Welcome to te jungle \n We got fun and games \nWe got everything you want \nHoney, we know the names \n");

            Console.WriteLine("Wait... I don't actually know your name.");
            Console.WriteLine("What is your name?");
            Console.WriteLine("[Please enter your name, then press 'ENTER' on the keyboard]");

            playerName = Console.ReadLine();
            Console.WriteLine("\nWelcome to the jungle " + playerName + "!");

            Console.WriteLine("" +
                "We approach a clearing in the jungle\n" +
                "There seems to be a trail to the left...\n" +
                "And a cave entrance to the right.\n");

            Console.WriteLine("Which path do you chose?");
            Console.WriteLine("Type left 'left'  to choose the path and go left or type 'right' to choose the cave and go right.");

            playerName = Console.ReadLine();
            Console.WriteLine("\nYou chose: " + userChoice + "\n");

            while(userChoice != "left" && userChoice != "right" && userChoice != "up")
            {
                Console.WriteLine("Please enter either 'left', 'right', or our SUPER DUPER secret answer of 'down'.");
                userChoice = Console.ReadLine();
                Console.WriteLine("\nYou chose: " + userChoice + "\n");
            }

            if (userChoice == "left")
            {
                Console.WriteLine("You take the path to the left. It leads you out to the jungle. You are safe to adventure.");
            }
            else if (userChoice == "right")
            {
                Console.WriteLine("You take the path to the right. It leads you into a cave. There is a cave in and you are LOST");
            }
            else if (userChoice == "down")
            {
                Console.WriteLine("'down' seriously?!? 'down' I mean you can go down but you'll be here for a long time. GET TO DIGINGING ");
            }
            else
            {
                Console.WriteLine("I honestly don't know how you got here. Congrats.");
            }






        }
    }
}
