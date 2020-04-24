using System;

namespace SmallGameTutorial
{
    public interface IScene
    {
        public ConsoleColor BackgroundColor { get; set; }
        public string SceneLocation { get; set; }
        public string Description { get; set; }
        public string SceneFeedback { get; set; }

        public IScene GoLeft();
        public IScene GoRight();
        public IScene GoForward();
        public IScene GoBackward();

        public IScene DoAction(string action);
    }
}
