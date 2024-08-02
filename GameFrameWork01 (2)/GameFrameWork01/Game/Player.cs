using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace GameFrameWork01
{
    public class Player : GameObject , ICollision
    {
        
        private List<Bullet> MyFire = new List<Bullet>();
        private Image bulletIamge;
        private int Points = 100;
        ProgressBar Progressbar;
        private Form Container;
        Game game;
        public Player(ProgressBar Progressbar ,  Image image, int Left, int Top, IMovement Controller, ObjectType Type , Image FireImage , Form Container) : base(image, Left, Top, Controller, Type)
        {
            this.Progressbar = Progressbar;
            this.Progressbar.Value = 100;
            bulletIamge = FireImage;
            this.type = Type;
            this.Pb = new PictureBox();
            this.Pb.Image = image;
            this.Pb.Width = image.Width;
            this.Pb.Height = image.Height;
            this.Pb.BackColor = Color.Transparent;
            this.Pb.Left = Left;
            this.Pb.Top = Top;
            this.Controller = Controller;
            this.Container = Container;
            game =   Game.GetGameInctance(Container);
        }
        public void Fire()
        {
            Bullet Bullet =  new Bullet(bulletIamge , Pb.Right+ 5 , Pb.Top + 23 , new BulletMovement( 10 , Direction.Right ) , ObjectType.Bullet ) ;
            MyFire.Add(Bullet);
            game.AddgameObjectsList(Bullet);
            Container.Controls.Add(Bullet.Pb);
            Timer resetTimer = new Timer();
            resetTimer.Interval = 500;
            resetTimer.Tick += delegate
            {
        
                resetTimer.Stop();
                resetTimer.Dispose();
            };
            resetTimer.Start();
        }

        public void IncreasePoint()
        {
            if (this.Progressbar.Value  + 1 < 100)
            {
                this.Progressbar.Value++;
            }
        }

        public int DecreasePoints()
        {

            if (this.Progressbar.Value - 1  > 0)
            {
                this.Progressbar.Value--;
            }
            return this.Progressbar.Value;
        }
    }
}
