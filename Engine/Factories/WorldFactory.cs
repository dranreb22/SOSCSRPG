﻿using System;
using System.Collections.Generic;
using System.Text;
using Engine.Models;

namespace Engine.Factories
{
    internal class WorldFactory
    {
        internal World CreateWorld()
        {
            World newWorld = new World();
            newWorld.AddLocation(0, -1, "Home", "This is your home.", "/Engine;component/Images/Locations/Home");

            return newWorld;
        }
    }
}
