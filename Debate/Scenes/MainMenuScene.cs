using Debate.Core;
using Debate.Core.EventSystem;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Debate.Scenes
{
    public class MainMenuScene : GameScene
    {
        protected ImageComponent titleBackground, title;
        protected SpriteBatch spriteBatch = null;

        public MainMenuScene(Game game, Texture2D titleBackground, Texture2D title) : base(game)
        {
            this.titleBackground = new ImageComponent(game, titleBackground, ImageComponent.DrawMode.Stretch);
            this.title = new ImageComponent(game, title, ImageComponent.DrawMode.Center);

            Components.Add(this.titleBackground);
            Components.Add(this.title);
        }

        public override void Show()
        {
            base.Show();
        }

        public override void Hide()
        {
            base.Hide();
        }

        /// <summary>
        /// Allows the game component to draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Draw(GameTime gameTime)
        {
            // Draw all game components
            base.Draw(gameTime);
        }
    }
}