using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLibrary
{
    public class FigureList
    {
        public List<ICreator> AllCreators = new List<ICreator>();

        public List<Figure> ReadyFigures = new List<Figure> { };
        public List<Figure> UndoFigures = new List<Figure> { };
    }
}
