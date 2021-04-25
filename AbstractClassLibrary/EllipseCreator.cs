
namespace FiguresLibrary
{
    public class EllipseCreator : ICreator
    {
        public string FigureName => "Эллипс";
        public Figure Create()
        {
            return new Ellipse();
        }
    }
}
