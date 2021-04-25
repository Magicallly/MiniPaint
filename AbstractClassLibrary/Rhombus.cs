using System;
using System.Drawing;

namespace FiguresLibrary
{
    public class Rhombus : Figure
    {
        public override void MouseClick(Point pos) => Click_MultiPointFigure(pos);
        public override void MouseMove(Point pos) => MouseMove_MultiPointFigure(pos);

        public override bool IsValid => Points.Count > 1;

        public override void Draw(Graphics graphics)
        {

            Points.Add(MousePos);
            if (Points.Count > 1)
            {
                graphics.DrawPolygon(Pen, Points.ToArray());
                graphics.FillPolygon(new SolidBrush(PenColor), Points.ToArray());
            }
            Points.RemoveAt(Points.Count - 1);
        }
    }
}
