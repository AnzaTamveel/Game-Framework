using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace GameFrameWork01
{
    public class Enemy : GameObject , ICollision
    {
        private int X;
        private int Y;
        private int Points = 100;
        public Enemy(int x, int y, Image image, int Left, int Top, IMovement Controller, ObjectType Type) :base(image , Left , Top , Controller , Type)
        {
            this.X = x;
            this.Y = y;
            this.type = Type;
            this.Pb = new PictureBox();
            this.Pb.Image = image;
            this.Pb.Width = image.Width;
            this.Pb.Height = image.Height;
            this.Pb.BackColor = Color.Transparent;
            this.Pb.Left = Left;
            this.Pb.Top = Top;
            this.Controller = Controller;
        }

        public void IncreasePoint()
        {
            if (this.Points + 1 < 100)
            {
                this.Points++;
            }
        }

        public int DecreasePoints()
        {

            if (this.Points - 1 > 0)
            {
                this.Points -= 10;
            }

            return this.Points;
        }
    }
}
