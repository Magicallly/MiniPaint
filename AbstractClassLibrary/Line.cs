using System;
using System.Drawing;

namespace FiguresLibrary
{
    public class Line : Figure
    {
        public override void MouseClick(Point pos) => Click_TwoPointFigure(pos);
        public override void MouseMove(Point pos) => MouseMove_TwoPointFigure(pos);

        public override bool IsValid => IsValid_TwoPointFigure;

        public override void Draw(Graphics graphics)
        {
            if (Points.Count == 2)
            {
                graphics.DrawLine(Pen, Points[0], Points[1]);
            }
        }
    }
}
