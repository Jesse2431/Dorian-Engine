using DorianEngine.Core;
using DorianEngine.Entities;
using Microsoft.Xna.Framework.Graphics;
using DorianEngine.Component.Components;
using Sandbox.Scripts;
using DorianEngine.Systems;

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

            // Make a new AutodeskModel and add that component to our entity
            AutodeskModel Model = new AutodeskModel("Debug\\Vehicles\\1987_StarquestTSi.d3m", device);
            ExampleEntity.AddComponent(Model);

            // Make a new BehaviourScript and add that component to our entity
            ExampleScript Script = new ExampleScript();
            ExampleEntity.AddComponent(Script);

            // Add the entity to our entities list
            AddEntity(ExampleEntity);

            // Now add the systems so that the engine can handle what we want
            AddSystem(new RenderSystem(device, Entities));
            AddSystem(new StartupSystem(device, Entities));
        }
    }
}