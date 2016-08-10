using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;

namespace Debate.Core
{
    public abstract class GameScene : DrawableGameComponent
    {
        protected GameScene(Game game) : base(game)
        {
            Components = new List<GameComponent>();
            Visible = false;
            Enabled = false;
        }

        /// <summary>
        /// Show the scene
        /// </summary>
        public virtual void Show()
        {
            Visible = true;
            Enabled = true;
        }

        /// <summary>
        /// Hide the scene
        /// </summary>
        public virtual void Hide()
        {
            Visible = false;
            Enabled = false;
        }

        /// <summary>
        /// Components of Game Scene
        /// </summary>
        public List<GameComponent> Components { get; }

        /// <summary>
        /// Allows the game component to update itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Update(GameTime gameTime)
        {
            // Update the child GameComponents
            foreach (var component in Components.Where(component => component.Enabled))
                component.Update(gameTime);


            base.Update(gameTime);
        }

        /// <summary>
        /// Allows the game component draw your content in game screen
        /// </summary>
        public override void Draw(GameTime gameTime)
        {
            // Draw the child GameComponents (if drawable)
            foreach (var gc in Components)
            {
                var component = gc as DrawableGameComponent;

                if ((component != null) && component.Visible)
                    component.Draw(gameTime);
            }
            base.Draw(gameTime);
        }
    }
}