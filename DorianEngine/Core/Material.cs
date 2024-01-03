using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace DorianEngine.Core
{
    // NOTE: Material is NOT a component attached to a entity, rather a subcomponent of something like a WavefrontModel
    //       Therefore it belongs into Core and not Components
    public class Material
    {
        // TODO: Communicate this all back-and-forth with the lighting for the shader properties
        //       To be done in the RenderSystem, but must be noted here
        
        // Basic color settings
        public Color DiffuseColor = Color.White;
        public Color SpecularColor = Color.Gray;

        // Specular and opacity settings, both are 0-255
        public float SpecularIntensity = 64f;
        public float Opacity = 0f;

        // Texture, optionally
        public Texture2D Texture = null;

        // Internal stuff for managing everything
        private BasicEffect Effect;
        private GraphicsDevice Device;

        // World, view and projection getters and setters
        public Matrix World
        {
            get
            {
                return Effect.World;
            }
            set
            {
                Effect.World = value;
            }
        }

        public Matrix View
        {
            get
            {
                return Effect.View;
            }
            set
            {
                Effect.View = value;
            }
        }

        public Matrix Projection
        {
            get
            {
                return Effect.Projection;
            }
            set
            {
                Effect.Projection = value;
            }
        }

        // Getter for Effect.CurrentTechnique.Passes
        public EffectPassCollection CurrentTechniquePasses
        {
            get
            {
                return Effect.CurrentTechnique.Passes;
            }
        }

        // Make a new material with specified diffuse, specular, shinyness, opacity and a texture
        public Material(Color diffuseColor, Color specularColor, float specularIntensity, float opacity, Texture2D texture, GraphicsDevice device)
        {
            DiffuseColor = diffuseColor;
            SpecularColor = specularColor;

            SpecularIntensity = specularIntensity;
            Opacity = opacity;

            Texture = texture;

            Device = device;

            Setup();
        }

        // Make a new material with specified diffuse, specular, shinyness and opacity
        public Material(Color diffuseColor, Color specularColor, float specularIntensity, float opacity, GraphicsDevice device)
        {
            DiffuseColor = diffuseColor;
            SpecularColor = specularColor;

            SpecularIntensity = specularIntensity;
            Opacity = opacity;

            Device = device;

            Setup();
        }

        // Make a new material with default settings
        public Material(GraphicsDevice device)
        {
            Device = device;

            Setup();
        }

        // Initial setup logic for BasicEffect
        private void Setup()
        {
            Effect = new BasicEffect(Device);

            Effect.LightingEnabled = true;

            Effect.DiffuseColor = DiffuseColor.ToVector3();
            Effect.SpecularColor = SpecularColor.ToVector3();

            Effect.SpecularPower = SpecularIntensity;
            Effect.Alpha = Opacity;

            if (Texture != null)
            {
                Effect.TextureEnabled = true;
                Effect.Texture = Texture;
            }

            Effect.EnableDefaultLighting(); // DEBUG ONLY
        }
    }
}