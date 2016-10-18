using Debate.Core;
using Debate.Core.EventSystem;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Debate.Scenes
{
    public class MainMenuScene : GameScene
    {
        protected ImageComponent titleBackground, title;
        protected SpriteBatch spriteBatch = null;
        private Game _game;

        public MainMenuScene(Game game) : base(game)
        {
            _game = game;
        }

        protected override void LoadContent()
        {
            base.LoadContent();
            var titleBackgroundTexture = Game.Content.Load<Texture2D>("title-background");
            var titleTexture = Game.Content.Load<Texture2D>("title");

            this.titleBackground = new ImageComponent(_game, titleBackgroundTexture, ImageComponent.DrawMode.Stretch);
            this.title = new ImageComponent(_game, titleTexture, ImageComponent.DrawMode.Center);

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