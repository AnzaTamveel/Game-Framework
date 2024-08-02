using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace GameFrameWork01
{
    public class Bullet : GameObject
    {
      
   


        public Bullet( Image image,  int Left,  int Top, IMovement Controller, ObjectType Type) 
        {
         
            this.type = Type;
            this.Pb = new PictureBox();
            this.Pb.Image = image;
            this.Pb.Width = image.Width;
            this.Pb.Height = image.Height;
            this.Pb.BackColor = Color.Transparent;
            this.Pb.Left = Left;
            this.Pb.Top = Top;
            this.Pb.Visible = true;
            this.Controller  = Controller;
        }



    }
}
