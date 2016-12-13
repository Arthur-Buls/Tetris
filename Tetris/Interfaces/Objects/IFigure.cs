using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris.Interfaces.Objects
{
    public interface IFigure : IObject
    {
        IList<ICoordinates> Parts { get; set; }
    }
}
