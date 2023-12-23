using DorianEngine.Entities;
using DorianEngine.Systems;
using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace DorianEngine.Core
{
    public abstract class SceneManager
    {
        public List<Entity> Entities = new List<Entity>();
        public List<BaseSystem> Systems = new List<BaseSystem>();

        public virtual void LoadContent()
        {
            foreach (BaseSystem system in Systems)
            {
                system.LoadContent();
            }
        }

        public virtual void Update(GameTime gameTime)
        {
            foreach (BaseSystem system in Systems)
            {
                system.Update(gameTime);
            }
        }

        public virtual void Draw(GameTime gameTime)
        {
            foreach (BaseSystem system in Systems)
            {
                system.Draw(gameTime);
            }
        }

        public void AddSystem(BaseSystem system)
        {
            Systems.Add(system);
        }
    }
}