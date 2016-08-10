using System.Collections.Generic;
using Debate.Core;
using Microsoft.Xna.Framework;

namespace Debate.Scenes
{
    public class SceneManager : ISceneManager
    {
        private readonly Dictionary<string, GameScene> _scenes;
        private readonly GameComponentCollection _component;
        
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="component"></param>
        public SceneManager(GameComponentCollection component)
        {
            _scenes = new Dictionary<string, GameScene>();
            _component = component;
        }

        /// <summary>
        /// Current Scene player is in.
        /// </summary>
        public GameScene CurrentScene { get; protected set; }

        /// <summary>
        /// Add a new scene to the scene manager. If key already exists,
        /// this will overwrite the previous scene.
        /// </summary>
        /// <param name="name">Key to find the scene under</param>
        /// <param name="scene">Stored Game Scene</param>
        public void AddScene(string name, GameScene scene)
        {
            _scenes.Add(name, scene);
            _component.Add(scene);
        }

        /// <summary>
        /// Remove a given scene from the scene manager with the passed
        /// key.
        /// </summary>
        /// <param name="name">Key to find the scene</param>
        public void RemoveScene(string name)
        {
            _scenes.Remove(name);
            _component.Remove(_scenes[name]);
        }

        /// <summary>
        /// Does Scene Manager have a scene with the passed key value.
        /// </summary>
        /// <param name="name">Key value to search for</param>
        /// <returns></returns>
        public bool HasScene(string name) => _scenes.ContainsKey(name);

        /// <summary>
        /// Load a scene with the given key. If the scene does not exist,
        /// don't do anything. Otherwise hide the current scene, change the current
        /// scene, and show the new scene.
        /// </summary>
        /// <param name="name">Key to load the scene</param>
        public void LoadScene(string name)
        {
            if (!HasScene(name)) return;

            CurrentScene?.Hide();
            CurrentScene = _scenes[name];
            CurrentScene.Show();
        }
    }
}