using System.Collections.Generic;
using System.Windows.Forms;

namespace GameFrameWork01
{
    public class CollisionDetection
    {
        ObjectType Object;
        ObjectType CollisionWith;
        GameAction Action;
        public CollisionDetection(ObjectType Object, ObjectType CollisionWith, GameAction Action)
        {
            this.Object = Object;
            this.CollisionWith = CollisionWith;
            this.Action = Action;
        }

        public int CheckCollision(List<GameObject> gameObjectsList)
        {
            for (int x = 0; x < gameObjectsList.Count; x++)
            {
                if (gameObjectsList[x].Type == Object)
                {
                    for (int y = 0; y < gameObjectsList.Count; y++)
                    {


                        if (gameObjectsList[y].Type == CollisionWith && gameObjectsList[x] != gameObjectsList[y])
                        {
                            if (gameObjectsList[x].Pb.Bounds.IntersectsWith(gameObjectsList[y].Pb.Bounds))
                            {
                                if (gameObjectsList[x] is Player)
                                {
                                    Player player = (Player)gameObjectsList[x];
                                    if (Action == GameAction.IncreasePoint)
                                    {
                                        player.IncreasePoint();
                                    }
                                    else if (Action == GameAction.DecresePoint)
                                    {
                                        int points = player.DecreasePoints();
                                        if (points <= 5)
                                        {

                                            return x;
                                        }
                                    }
                                }
                                else if (gameObjectsList[x] is Enemy)
                                {
                                    Enemy enemy = (Enemy)gameObjectsList[x];
                                    if (Action == GameAction.IncreasePoint)
                                    {
                                        enemy.IncreasePoint();
                                    }
                                    else if (Action == GameAction.DecresePoint)
                                    {
                                        int points = enemy.DecreasePoints();
                                        if (points <= 0)
                                        {
                                         //   MessageBox.Show("if true");
                                            enemy.Pb.Visible = false;
                                            return x;
                                        }
                                    }


                                }

                                if (Object == ObjectType.Enemy && CollisionWith == ObjectType.Bullet)
                                {

                                    if (gameObjectsList[y] is Bullet)
                                    {
                                          Bullet bullet = (Bullet)gameObjectsList[y];
                                         bullet.Pb.Visible = false;

                                        return y;
                                    }


                                }
                            }

                           


                        }
                    }
                }
            }
            return -1;
        }

    }
}

