using System.Collections.Generic;
using Debate.Core;
using Microsoft.Xna.Framework;

namespace Debate.Scenes
{
    public class SceneManager : ISceneManager
    {
        private readonly Dictionary<string, GameScene> _scenes;
        private readonly GameComponentCollection _component;
        

        public SceneManager(GameComponentCollection component)
        {
            _scenes = new Dictionary<string, GameScene>();
            _component = component;
        }

        public GameScene CurrentScene { get; protected set; }

        public void AddScene(string name, GameScene scene)
        {
            _scenes.Add(name, scene);
            _component.Add(scene);
        }

        public void RemoveScene(string name)
        {
            _scenes.Remove(name);
            _component.Remove(_scenes[name]);
        }

        public bool HasScene(string name)
        {
            return _scenes.ContainsKey(name);
        }


        public void LoadScene(string name)
        {
            if (!HasScene(name)) return;

            CurrentScene?.Hide();
            CurrentScene = _scenes[name];
            CurrentScene.Show();
        }
    }
}