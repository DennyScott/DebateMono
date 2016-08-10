using Debate.Core;

namespace Debate.Scenes
{
    public interface ISceneManager
    {
        void AddScene(string name, GameScene scene);
        void RemoveScene(string name);

        bool HasScene(string name);
        GameScene CurrentScene { get; }
        void LoadScene(string name);
    }
}