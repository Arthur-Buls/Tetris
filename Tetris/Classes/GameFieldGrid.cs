using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tetris.Interfaces.Objects;
using Tetris.Helpers;
namespace Tetris.Classes
{
    class GameFieldGrid: IDrawable
    {
        public void Draw(Graphics gr)
        {
            var height = gr.VisibleClipBounds.Height-1;
            var width = gr.VisibleClipBounds.Width-1;
            var boxH = height / ConstantHelper.BlockYNumber;
            var boxW = width / ConstantHelper.BlockXNumber;
            

            for (int i=0;i<= ConstantHelper.BlockYNumber; i++)
            {
                gr.DrawLine(ConstantHelper.GridPen, 0, height - boxH * i, width,height-boxH*i);
            }

            for (int i = 0; i <= ConstantHelper.BlockXNumber; i++)
            {
                gr.DrawLine(ConstantHelper.GridPen, width - boxW * i, 0, width-boxW*i, height );
            }
        }
    }
}
