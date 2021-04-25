using System;
using System.Drawing;

namespace FiguresLibrary
{
    public class Ellipse : Figure
    {
        public override void MouseClick(Point pos) => Click_TwoPointFigure(pos);
        public override void MouseMove(Point pos) => MouseMove_TwoPointFigure(pos);

        public override bool IsValid => IsValid_TwoPointFigure;

        public override void Draw(Graphics graphics)
        {
            if (Points.Count == 2)
            {
                Point StartPoint = Points[0];
                Point FinishPoint = Points[1];
                Color BrushColor = PenColor;
                int Height = FinishPoint.Y - StartPoint.Y; // вычисляем необходимые параметры через начальные точки
                int Width = FinishPoint.X - StartPoint.X;
                graphics.DrawEllipse(Pen, StartPoint.X, StartPoint.Y, Width, Height); // рисуем эллипс
                graphics.FillEllipse(new SolidBrush(BrushColor), StartPoint.X, StartPoint.Y, Width, Height); // заполняем его цветом
            }
        }
    }
}
