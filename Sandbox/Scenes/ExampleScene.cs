using DorianEngine.Core;
using DorianEngine.Entities;
using Microsoft.Xna.Framework.Graphics;
using DorianEngine.Component.Components;
using DorianEngine.Component;
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

            // Make a new WavefrontModel, give it a material and add that component to our entity
            WavefrontModel SampleModel = new WavefrontModel("Debug\\StarquestTSi_1987.obj", device);
            SampleModel.Model.Material = new Material(device);
            ExampleEntity.AddComponent(SampleModel);

            // Make a new BehaviourScript and add that component to our entity
            BehaviourScript SampleScript = new ExampleScript();
            ExampleEntity.AddComponent(SampleScript);

            // Add the entity to our entities list
            AddEntity(ExampleEntity);

            // CAMERA
            Entity camera = new Entity("CAMERA", new Transform());
            camera.AddComponent(new Camera(device, 45f));

            AddEntity(camera);
            // END OF CAMERA

            // Now add the systems so that the engine can handle what we want
            AddSystem(new RenderSystem(device, Entities, Lighting));
            AddSystem(new StartupSystem(device, Entities));
            AddSystem(new UpdateSystem(device, Entities));
        }
    }
}