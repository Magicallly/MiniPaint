
namespace FiguresLibrary
{
    // change absctract class to interface
    /*public abstract class FigureCreator : ICreator
    {
        public abstract Figure Create();
    }*/

    public interface ICreator
    {
        string FigureName { get; }
        Figure Create();
    }
}
