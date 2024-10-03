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






        }
    }
}
