using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LV2
{
    class Elipsa : Kruznica
    {
        public Point koordinata2 { get; set; }
        public Elipsa() { }
        public Elipsa(Color Boja, Point Koordinata1, Point Koordinata2, int Radijus)
            : base(Boja, Koordinata1, Radijus)
        {
            koordinata2 = Koordinata2;
        }
        public override void DrawGrafObj(Graphics graphics, Pen pen)
        {
            Rectangle rect = new Rectangle(koordinata1.X, koordinata1.Y, koordinata2.X - koordinata1.X, koordinata2.Y - koordinata1.Y);
            graphics.DrawEllipse(pen, rect);
        }
    }
}
