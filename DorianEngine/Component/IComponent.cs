﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace DorianEngine.Component
{
    public interface IComponent
    {
        // Function for loading/setting in anything of the component
        public void Setup();

        // Function for updating anything in the component
        public void Update(GameTime gameTime);
    }
}