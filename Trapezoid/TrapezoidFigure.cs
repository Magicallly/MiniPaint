using System;
using System.Drawing;
using FiguresLibrary;

namespace Trapezoid
{
    class TrapezoidFigure : Figure
    {
        public override void MouseClick(Point pos)
        {
            switch (Points.Count)
            {
                case 0:
                    Points.Add(pos);
                    break;
                case 1:
                    Points.Add(pos);
                    break;
                case 2:
                    Points.Add(new Point(pos.X, Points[1].Y));
                    break;
                case 3:
                    Points.Add(new Point(pos.X, Points[0].Y));
                    break;
                case 4:
                    Points[3] = new Point(pos.X, Points[0].Y);
                    break;
            }
        }

        public override void MouseMove(Point pos) => MousePos = pos;

        public override bool IsValid => Points.Count == 4;

        public override void Draw(Graphics graphics)
        {
            bool temporary = false;
            if (Points.Count < 4)
            {
                temporary = true;
            }
            MouseClick(MousePos);
            if (2 <= Points.Count && Points.Count < 4)
            {
                graphics.DrawLines(Pen, Points.ToArray());
            }
            if (Points.Count == 4)
            {
                graphics.DrawPolygon(Pen, Points.ToArray());
                graphics.FillPolygon(new SolidBrush(PenColor), Points.ToArray());
            }
            if (temporary)
            {
                Points.RemoveAt(Points.Count - 1);
            }
        }
    }
}
