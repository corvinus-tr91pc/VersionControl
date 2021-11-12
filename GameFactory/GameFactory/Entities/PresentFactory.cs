﻿using GameFactory.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFactory.Entities
{
    public class PresentFactory : IToyFactory
    {
        public Color PresentBox { get; set; }
        public Color PresentRibbon { get; set; }

        public Toy CreateNew()
        {
            return new Present(PresentRibbon, PresentBox);
        }
    }
}
