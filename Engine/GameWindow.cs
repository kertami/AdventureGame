using System;

namespace SmallGameTutorial
{
    public class GameWindow
    {
        public string Line { get; set; }

        public GameWindow()
        {
            Console.WriteLine("Loading Game...");
            Console.Title = "Super Cool Game";

            Line = new string('*', Console.WindowWidth);

            Console.WriteLine("Game started!");
        }

        public void Draw(IScene scene)
        {
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(Line);
            WriteLine("");
            WriteLine("You are standing " + scene.SceneLocation);
            WriteLine("");
            WriteLine(scene.Description);
            WriteLine("");
            WriteLine("What would you like to do?");
            WriteLine("");
            Console.WriteLine(Line);
            if (!String.IsNullOrEmpty(scene.SceneFeedback))
            {
                Console.WriteLine("");
                Console.WriteLine(scene.SceneFeedback);
                Console.WriteLine("");
            }
            Console.WriteLine();
        }

        public static void WriteLine(string text)
        {
            var fill = new string(' ', Console.WindowWidth - text.Length - 3);
            var toWrite = $"* {text}{fill}*";

            Console.WriteLine(toWrite);
        }
    }
}
