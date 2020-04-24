using System;

namespace SmallGameTutorial.Scenes
{
    public class GameStart : IScene
    {
        public ConsoleColor BackgroundColor { get; set; }
        public string SceneLocation { get; set; }
        public string Description { get; set; }
        public string SceneFeedback { get; set; }

        public GameStart()
        {
            BackgroundColor = ConsoleColor.Green;
            SceneLocation = "in front of a dense forest";
            Description = "You see a path leading through the forest";
        }

        public IScene GoLeft()
        {
            SceneFeedback = "I can not go that way.";

            return this;
        }

        public IScene GoRight()
        {
            SceneFeedback = "I can not go that way.";

            return this;
        }

        public IScene GoForward()
        {
            SceneFeedback = "I can not go that way.";

            return this;
        }

        public IScene GoBackward()
        {
            SceneFeedback = "I can not go that way.";

            return this;
        }

        public IScene DoAction(string action)
        {
            SceneFeedback = "I don't know how to do that.";

            return this;
        }
    }
}
