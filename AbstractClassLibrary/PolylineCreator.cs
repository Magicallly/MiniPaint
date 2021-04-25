
namespace FiguresLibrary
{
    public class PolylineCreator : ICreator
    {
        public string FigureName => "Ломаная";
        public Figure Create()
        {
            return new Polyline();
        }
    }
}
