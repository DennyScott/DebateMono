using Debate.Core;

namespace Debate.Scenes
{
    public interface ISceneManager
    {
        void AddScene(DebateScenes name, GameScene scene);
        void RemoveScene(DebateScenes name);

        bool HasScene(DebateScenes name);
        GameScene CurrentScene { get; }
        void LoadScene(DebateScenes name);
    }
}