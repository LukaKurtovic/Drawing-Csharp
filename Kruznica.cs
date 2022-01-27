using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LV2
{
    class Kruznica : GrafObj
    {
        public int radijus;

        public Kruznica() { }

        public Kruznica(Color Boja, Point Koordinata1, int Radijus)
            : base(Boja, Koordinata1)
        {
            this.radijus = Radijus;
        }

        public override void DrawGrafObj(Graphics graphics, Pen pen)
        {
            Rectangle rect = new Rectangle(koordinata1.X - radijus, koordinata1.Y - radijus, radijus * 2, radijus * 2);
            graphics.DrawEllipse(pen, rect);
        }
    }
}
