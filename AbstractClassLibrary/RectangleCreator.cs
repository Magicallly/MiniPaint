
namespace FiguresLibrary
{
    public class RectangleCreator : ICreator
    {
        public string FigureName => "Прямоугольник";
        public  Figure Create()
        {
            return new Rectangle();
        }
    }
}
