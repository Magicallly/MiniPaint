using System;
using System.Drawing;

namespace FiguresLibrary
{
    public class Rectangle : Figure
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

                int Height = Math.Abs(FinishPoint.Y - StartPoint.Y); // вычисляем необходимые параметры через начальные точки
                int Width = Math.Abs(FinishPoint.X - StartPoint.X);

                int StartX = Math.Min(StartPoint.X, FinishPoint.X); // вычисляем верхний левый угол
                int StartY = Math.Min(FinishPoint.Y, StartPoint.Y);

                graphics.DrawRectangle(Pen, StartX, StartY, Width, Height);  // рисуем прямоугольник
                graphics.FillRectangle(new SolidBrush(BrushColor), StartX, StartY, Width, Height); // заполняем его цветом
            }
        }
    }
}
