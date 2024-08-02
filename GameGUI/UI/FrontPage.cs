using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GameFrameWork01;
using GameFrameWork01.Movement;
using MyGameGUI.UI;

namespace MyGameGUI
{
    public partial class FrontPage : Form
    {
        Game game;
        List<PictureBox> walls = new List<PictureBox>();
        public FrontPage()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            game = Game.GetGameInctance(this);
            AddHurdlesList();
            Point Boundary = new Point(this.Width , this.Height);

            game.AddGameObject(Resource1.Enemy1, Width - 120 , Height - 100  ,new VerticalPatrol(8, new Point(Width , Height / 2 + 40) , new Point(Width, Height - 150) , Direction.Down)  , ObjectType.Enemy );
            game.AddGameObject(Resource1.Enemy2, Width  - 120 , Height / 2 - 110   ,new HorizontalPetrol(8, new Point(Width / 2  + 120, Height / 2 - 110), new Point(Width - 120, Height / 2 - 110), Direction.Right)  , ObjectType.Enemy );
            game.AddGameObject(Resource1.Enemy3, 20, 100, new ZigZagMovement(8, new Point(Width - 320, Height), Direction.Right), ObjectType.Enemy);
            KeyboardMovement PlayerMovement = new KeyboardMovement(walls, 8, Boundary);
            game.AddPlayer( Player_Health ,Resource1.Player, 40, Height - 180, PlayerMovement, ObjectType.Player , Resource1.Bullet);
            CollisionDetection C1 = new CollisionDetection(ObjectType.Enemy , ObjectType.Bullet , GameAction.DecresePoint);
            CollisionDetection C2 = new CollisionDetection(ObjectType.Player , ObjectType.Enemy, GameAction.DecresePoint);
            game.AddCollision(C1);
            game.AddCollision(C2);
            CounterSet();
           
        }

        private void CounterSet()
        {
            playercount.Text = game.returnobjectcounts(ObjectType.Player).ToString();
            enemyCount.Text = game.returnobjectcounts(ObjectType.Enemy).ToString();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            game.Update();
            CounterSet();
            if (enemyCount.Text == "0")
            {

                this.Hide();
                WinGame win = new WinGame(Player_Health.Value.ToString());
                timer1.Stop();
                win.Show();
            }
            if (playercount.Text == "0")
            {
                this.Hide();
                Lose win = new Lose();
                timer1.Stop();
                win.Show();
            }
        }
        private void AddHurdlesList()
        {
            
            walls = new List<PictureBox> {b3, w1, w2, w3, w4 , w5 , w6};
        }

   
    }
}
