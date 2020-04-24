using System;

namespace SmallGameTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            GameWindow window = new GameWindow();
            Game game = new Game();

            string command = "";

            do
            {
                window.Draw(game.NextScene(command));

                command = Console.ReadLine();
            } while (!command.ToLower().Contains("quit") && !command.ToLower().Contains("exit"));

            Environment.Exit(0);
        }
    }
}
