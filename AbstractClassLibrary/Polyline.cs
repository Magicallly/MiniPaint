using System;
using System.Drawing;

namespace FiguresLibrary
{
    public class Polyline : Figure
    {
        public override void MouseClick(Point pos) => Click_MultiPointFigure(pos);
        public override void MouseMove(Point pos) => MouseMove_MultiPointFigure(pos);

        public override bool IsValid => Points.Count > 1;

        public override void Draw(Graphics graphics)
        {
            Points.Add(MousePos);
            if (Points.Count > 1)
            {
                graphics.DrawLines(Pen, Points.ToArray());
            }
            Points.RemoveAt(Points.Count - 1);
        }

    }
    
}
