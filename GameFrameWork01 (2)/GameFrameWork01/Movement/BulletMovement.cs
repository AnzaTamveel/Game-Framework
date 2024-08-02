using System.Drawing;

namespace GameFrameWork01
{
    public class BulletMovement : IMovement
    {

        private int Speed;
        private Direction direction;

        public BulletMovement(int Speed, Direction direction)
        {
            this.Speed = Speed;
            this.direction = direction;
        }

        public Point Move(Point Location)
        {
            if (direction == Direction.Right)
            {
                Location.X += Speed;
            }

            if (direction == Direction.Left)
            {
                Location.X -= Speed;
            }

            return Location;
        }
    }
}
