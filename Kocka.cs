using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LV2
{
    class Kocka : Linija
    {
       
        public Kocka() { }
        public Kocka(Color Boja, Point Koordinata1, Point Koordinata2)
            : base(Boja, Koordinata1, Koordinata2) { }
       

        public override void DrawGrafObj(Graphics graphics, Pen pen)
        {
            Rectangle rect = new Rectangle(koordinata1.X, koordinata1.Y, koordinata2.X - koordinata1.X, koordinata2.Y - koordinata1.Y);
            graphics.DrawRectangle(pen, rect);
        }
    }
}
