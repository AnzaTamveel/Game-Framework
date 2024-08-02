using System.Drawing;
using System.Windows.Forms;

namespace GameFrameWork01
{
    public class GameObject
    {
        protected PictureBox pb;
        protected IMovement Controller;
        protected ObjectType type;

        public GameObject(Image image, int Left, int Top, IMovement Controller, ObjectType Type)
        {
            this.type = Type;
            Pb = new PictureBox();
            Pb.Image = image;
            Pb.Width = image.Width;
            Pb.Height = image.Height;
            Pb.BackColor = Color.Transparent;
            Pb.Left = Left;
            Pb.Top = Top;
            this.Controller = Controller;

        }
        public GameObject()
        {

        }

        public ObjectType Type { get => type; set => type = value; }
        public PictureBox Pb { get => pb; set => pb = value; }

        public void update()
        {
            this.Pb.Location = Controller.Move(this.Pb.Location);
        }



    }
}
