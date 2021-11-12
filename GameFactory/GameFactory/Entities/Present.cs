using GameFactory.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFactory.Entities
{
    public class Present : Toy
    {
        public SolidBrush PresentRibbon { get; set; }
        public SolidBrush PresentBox { get; set; }
        public Present(Color ribbon, Color box)
        {
            PresentRibbon = new SolidBrush(ribbon);
            PresentBox = new SolidBrush(box);
        }

        protected override void DrawImage(Graphics g)
        {
            g.FillRectangle(PresentBox, 0, 0, Width, Height);
            g.FillRectangle(PresentRibbon, 0, Width/3, Width, Height/3);
            g.FillRectangle(PresentRibbon, Height/3, 0, Width/3, Height);
        }
    }
}
