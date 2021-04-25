using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.Serialization;

namespace FiguresLibrary
{
    [DataContract]
    public abstract class Figure
    { 
        [DataMember]
        public List<Point> Points = new List<Point>();
        [DataMember]
        public Point MousePos = new Point(0, 0);

        protected bool IsValid_TwoPointFigure => Points.Count == 2 && Points[0] != Points[1];
        public virtual bool IsValid => true;

        protected void Click_TwoPointFigure(Point pos)
        {
            if (Points.Count == 0)
            {
                Points.Add(pos);
            }
        }
        protected void MouseMove_TwoPointFigure(Point pos)
        {
            if (Points.Count == 1)
            {
                Points.Add(pos);
            }
            if (Points.Count == 2)
            {
                Points[1] = pos;
            }
        }

        protected void Click_MultiPointFigure(Point pos)
        {
            Points.Add(pos);
        }
        protected void MouseMove_MultiPointFigure(Point pos)
        {
            MousePos = pos;
        }

        abstract public void MouseClick(Point pos);
        abstract public void MouseMove(Point pos);

        abstract public void Draw(Graphics graphics);

        [DataMember]
        public Color PenColor { get; set; }
        [DataMember]
        public float PenWidth { get; set; }
        public Pen Pen {
            get
            {
                return new Pen(PenColor, PenWidth);
            }
            set
            {
                PenColor = value.Color;
                PenWidth = value.Width;
            }
        }
    }
}
