using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {


        }

        private void MainPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            var graphics = MainPictureBox.CreateGraphics();

            graphics.DrawRectangle(Pens.Red, new Rectangle(e.X-50, e.Y-50, 100, 100));
        }
    }
}
