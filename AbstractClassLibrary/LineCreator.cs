
namespace FiguresLibrary
{
    public class LineCreator : ICreator
    {
        public string FigureName => "Линия";
        public  Figure Create()
        {
            return new Line();
        }
    }
}
