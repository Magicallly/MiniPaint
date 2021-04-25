
namespace FiguresLibrary
{
    public class RhombusCreator : ICreator
    {
        public string FigureName => "Многоугольник";
        public Figure Create()
        {
            return new Rhombus();
        }
    }
}