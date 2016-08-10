#region Using Statements

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

#endregion

namespace Debate.Core
{
    /// <summary>
    /// This is a game component that draw a image.
    /// </summary>
    public class ImageComponent : DrawableGameComponent
    {
        public enum DrawMode
        {
            Center = 1,
            Stretch,
        };

        // Texture to draw
        protected readonly Texture2D Texture;
        // Draw Mode
        protected readonly DrawMode TypeDrawMode;
        // Spritebatch
        protected SpriteBatch SpriteBatch = null;
        // Image Rectangle
        protected Rectangle ImageRect;

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="game">The game object</param>
        /// <param name="texture">Texture to Draw</param>
        /// <param name="typeDrawMode">Draw Mode</param>
        public ImageComponent(Game game, Texture2D texture, DrawMode typeDrawMode)
            : base(game)
        {
            this.Texture = texture;
            this.TypeDrawMode = typeDrawMode;
            // Get the current spritebatch
            SpriteBatch = (SpriteBatch)
                Game.Services.GetService(typeof(SpriteBatch));

            // Create a rectangle with the size and position of the image
            switch (typeDrawMode)
            {
                case DrawMode.Center:
                    ImageRect = new Rectangle((Game.Window.ClientBounds.Width -
                        texture.Width) / 2, (Game.Window.ClientBounds.Height -
                        texture.Height) / 2, texture.Width, texture.Height);
                    break;
                case DrawMode.Stretch:
                    ImageRect = new Rectangle(0, 0, Game.Window.ClientBounds.Width,
                        Game.Window.ClientBounds.Height);
                    break;
            }
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="game">The game object</param>
        /// <param name="texture">Texture to Draw</param>
        /// <param name="imageRect">Rect to draw component in</param>
        public ImageComponent(Game game, Texture2D texture, Rectangle imageRect)
            : base(game)
        {
            this.Texture = texture;
            // Get the current spritebatch
            SpriteBatch = (SpriteBatch)
                Game.Services.GetService(typeof(SpriteBatch));

            ImageRect = imageRect;
        }

        /// <summary>
        /// Allows the game component to draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Draw(GameTime gameTime)
        {
            SpriteBatch.Draw(Texture, ImageRect, Color.White);
            base.Draw(gameTime);
        }
    }
}