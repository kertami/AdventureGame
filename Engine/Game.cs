using SmallGameTutorial.Scenes;

namespace SmallGameTutorial
{
    public class Game
    {        
        public IScene CurrentScene;

        public Game()
        {
            CurrentScene = new GameStart();
        }

        public IScene NextScene(string action)
        {
            if (action.ToLower().Contains("left"))
            {
                CurrentScene = CurrentScene.GoLeft();
            }
            else if (action.ToLower().Contains("right"))
            {
                CurrentScene = CurrentScene.GoRight();
            }
            else if (action.ToLower().Contains("forward"))
            {
                CurrentScene = CurrentScene.GoForward();
            }
            else if (action.ToLower().Contains("backwards"))
            {
                CurrentScene = CurrentScene.GoBackward();
            }
            else if (!string.IsNullOrEmpty(action))
            {
                CurrentScene = CurrentScene.DoAction(action);
            }


            return CurrentScene;
        }
    }
}
