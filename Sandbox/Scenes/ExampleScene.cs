using DorianEngine.Core;
using DorianEngine.Entities;
using Microsoft.Xna.Framework.Graphics;
using DorianEngine.Component.Components;

namespace Sandbox.Scenes
{
    public class ExampleScene : GameScene
    {
        public ExampleScene(GraphicsDevice device) : base(device)
        {
            // Make a new entity named ExampleEntity and give it a default transform
            Entity ExampleEntity = new Entity
            (
                    "ExampleEntity",
                    new Transform()
            );

            // Make a new DorianModel and add that component to our entity
            DorianModel Model = new DorianModel("Debug\\Vehicles\\1987_StarquestTSi.d3m");
            ExampleEntity.AddComponent(Model);

            // Add the entity to our entities list
            AddEntity(ExampleEntity);
        }
    }
}