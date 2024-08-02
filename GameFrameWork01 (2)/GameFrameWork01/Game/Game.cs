using GameFrameWork01.Movement;
using System.Collections.Generic;

using System.Drawing;
using System.Windows.Forms;


namespace GameFrameWork01
{
    public class Game
    {
        static Game Instance;


        public static Game GetGameInctance(Form Container)
        {
            if (Instance == null)
            {
                Instance = new Game(Container);

            }
            return Instance;
        }
        
        public Game()
        {

        }
        List<GameObject> gameObjectsList;
        List<PictureBox> HurdlesList = new List<PictureBox>();
        List<CollisionDetection> CollisionsPerformed = new List<CollisionDetection>();
        Form Container;
        public void AddgameObjectsList(GameObject Object)
        {
            gameObjectsList.Add(Object);
        }
        public void AddCollision(CollisionDetection Collision)
        {
            CollisionsPerformed.Add(Collision);
        }
        public List<PictureBox> GetHurdleList()
        {
            return HurdlesList;
        }
        public void AddhurdleList(List<PictureBox> Hurdles)
        {
            for (int i = 0; i < Hurdles.Count; i++)
            {
                HurdlesList.Add(Hurdles[i]);
            }
        }
        public int returnobjectcounts(ObjectType type)
        {
            int count = 0;
            for (int i = 0; i < gameObjectsList.Count; i++)
            {
                if (gameObjectsList[i].Type == type)
                {
                    count++;
                }
            }
            return count;
        }
        private Game(Form Container)
        {
            this.Container = Container;
            this.gameObjectsList = new List<GameObject>();
        }
        public void AddPlayer(ProgressBar Progressbar,  Image image, int Left, int Top, KeyboardMovement Controller, ObjectType Type, Image FireImage)
        {
            if (Type == ObjectType.Player)
            {
                Player player = new Player( Progressbar,  image, Left, Top, Controller, Type , FireImage , this.Container);
                Controller.Player = player;
                gameObjectsList.Add(player);
                Container.Controls.Add(player.Pb);

            }
        }
        public void AddGameObject(Image image, int Left, int Top, IMovement Controller, ObjectType Type)
        {


            if (Type == ObjectType.Enemy)
            {
                Enemy enemy = new Enemy(Left, Top, image, Left, Top, Controller, Type);
                gameObjectsList.Add(enemy);
                Container.Controls.Add(enemy.Pb);
            }
        

        }

        public void Update()
        {
            for (int i = 0; i < gameObjectsList.Count; i++)
            {
                gameObjectsList[i].update();
            }
        
            foreach (CollisionDetection Col in CollisionsPerformed)
            {
                int index =  Col.CheckCollision(gameObjectsList);
                if (index >= 0)
                {
                    Container.Controls.Remove(gameObjectsList[index].Pb);
                    gameObjectsList.RemoveAt(index);

                }
            }
        }
    }
}
