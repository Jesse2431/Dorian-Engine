using DorianEngine.Entities;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System;

namespace DorianPlugins.ExamplePlugin.Systems
{
    public class UpdateSystem : DorianEngine.Systems.UpdateSystem
    {
        public UpdateSystem(GraphicsDevice graphicsDevice, List<Entity> _entities) : base(graphicsDevice, _entities)
        {

        }

        public void Update()
        {
            Console.WriteLine("HAHAHA");
        }
    }
}
