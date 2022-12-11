using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace SortingTrainingProgram
{
    public class Tile
    {
        public static int Size = 70;
        public static Color _default = Color.FromArgb(161, 214, 153);
        public int _x { get; set; }
        public int _y { get; set; }
        public TextBox _textBox { get; set; }
        public System.Windows.Forms.Label _Label { get; set; }
        public Tile(int x, int y)
        {
            _x = x;
            _y = y;
            _Label = new Label
            {
                Location = new Point(_x, _y),
                Size = new Size(Size, Size)
            };
        }
        public Tile() { }
        public void DrawLines(Graphics g, Tile tile)
        {

            Pen p = new Pen(Color.Aqua, 5);
            g.DrawLine(p, _x + 25, _y, _x + 25, _y - 30);
            g.DrawLine(p, _x + 25, _y - 30, tile._x + 25, tile._y - 30);
            g.DrawLine(p, tile._x + 25, tile._y - 30, tile._x + 25, tile._y);
            g.DrawLine(p, _x + 25, _y, _x + 25, _y + 90);
            g.DrawLine(p, _x + 25, _y + 90, tile._x + 25, tile._y + 90);
            g.DrawLine(p, tile._x + 25, tile._y + 90, tile._x + 25, tile._y);
        }

    }
}
