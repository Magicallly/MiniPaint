using FiguresLibrary;

namespace Trapezoid
{
    class FigureCreator : ICreator
    {
        public string FigureName => "Трапеция";
        public Figure Create()
        {
            return new TrapezoidFigure();
        }
    }
}
