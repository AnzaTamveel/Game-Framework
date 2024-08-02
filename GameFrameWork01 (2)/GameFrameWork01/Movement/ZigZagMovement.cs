using System.Drawing;
using System.Windows.Forms;

namespace GameFrameWork01.Movement
{
    public class ZigZagMovement : IMovement
    {
        private int speed;
        private Point boundary;
        private Direction direction;
        private int count;
        private int maxCount = 10;

        public ZigZagMovement(int speed, Point boundary, Direction direction)
        {
            this.speed = speed;
            this.boundary = boundary;
            this.direction = direction;
            this.count = 0;
        }

        public Point Move(Point location)
        {
            count = (count + 1) % maxCount;

            if (direction == Direction.Right)
            {
                location.X += speed;
                if (count < maxCount / 2)
                {
                    location.Y -= speed;
                }
                else
                {
                    location.Y += speed;
                }
            }
            else
            {
                location.X -= speed;
                if (count < maxCount / 2)
                {
                    location.Y += speed;
                }
                else
                {
                    location.Y -= speed;
                }
            }
            if (location.X >= boundary.X || location.X <= 0)
            {
                if (direction == Direction.Right)
                {
                    direction = Direction.Left;
                }
                else
                {
                    direction = Direction.Right;
                }
            }

            return location;
        }
    }
}
