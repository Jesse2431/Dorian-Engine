using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SpriteFontPlus;
using System.IO;

namespace DorianEngine.Component.Components
{
    public class TextComponentGUI : BaseComponent
    {
        public string Text = "Hello, world!";
        public Color Color = new Color(0, 0, 0);

        public SpriteFont FontFamily;
        public float FontSize;

        public Vector2 Position = new Vector2(150, 150);
        public Vector2 Rotation = new Vector2(0, 0);

        public TextComponentGUI(string text, Color color, /*SpriteFont fontFamily*/GraphicsDevice device, float fontSize)
        {
            Text = text;
            Color = color;
            //FontFamily = fontFamily;
            FontSize = fontSize;

            TtfFontBakerResult fontBakeResult = TtfFontBaker.Bake(File.ReadAllBytes(@"C:\\Windows\\Fonts\arial.ttf"), 25, 1024, 1024, new[]
            {
                CharacterRange.BasicLatin,
                CharacterRange.Latin1Supplement,
                CharacterRange.LatinExtendedA,
                CharacterRange.Cyrillic
            }
            );

            SpriteFont font = fontBakeResult.CreateSpriteFont(device);
        }

        public void LoadFont(GraphicsDevice device, string path)
        {
            Texture2D fontTexture2D = Texture2D.FromFile(device, path);
            //FontFamily = new SpriteFont(device, TitleContainer.OpenStream(path));
            // TODO: Implement loading font from Texture2D
            //       FontFamily = new SpriteFont(fontTexture2D, FontSize);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.DrawString(FontFamily, Text, Position, Color);
            spriteBatch.End();
        }
    }
}