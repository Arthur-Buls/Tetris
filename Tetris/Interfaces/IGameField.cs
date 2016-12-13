using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tetris.Interfaces.Objects;

namespace Tetris.Interfaces
{
    public interface IGameField
    {
        Graphics NextFigureGraphics { get; set; }
        Graphics MainGraphics { get; set; }
        IList<IObject> Objects { get; set; }
        IObject NextObject { get; set; }

        IDrawable FieldGrid { get; set; }
        
        /// <summary>
        /// Display all objects on Main Graphics
        /// </summary>
        void Draw();

        /// <summary>
        /// React on timer tick
        /// </summary>
        void Tick();
    }
}
