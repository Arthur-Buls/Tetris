using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris.Interfaces.Objects
{
    public interface IObject : IDrawable
    {
        bool IsVisible { get; set; }
        ICoordinates Coordinates { get; set; }
        IGameField GameField { get; set; }

        /// <summary>
        /// Move to particular coordinates
        /// </summary>
        /// <param name="offset">Exact coordinates to move on</param>
        /// <returns></returns>
        ICoordinates Move(ICoordinates newCoordinates);

        /// <summary>
        /// Shift object on exact offset
        /// </summary>
        /// <param name="offset">Offset</param>
        /// <returns>null if shift is completed, existing object if it</returns>
        bool Shift(ICoordinates offset);
    }
}
