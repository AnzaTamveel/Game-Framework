using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFrameWork01
{
    public  class VerticalPatrol : IMovement
    {
        private int Speed;
        private Point Boundary1;
        private Point Boundary2;
        private Direction direction;
        public VerticalPatrol(int Speed, Point Boundary1, Point Boundary2, Direction direction) 
        {
            this.Speed = Speed;
            this.direction = direction;
            this.Boundary1 = Boundary1;
            this.Boundary2 = Boundary2;
        }

        public  Point Move(Point location)
        {
            if (location.Y >= Boundary2.Y)
            {
                direction = Direction.Up;
            }
            else if (location.Y + Speed <= Boundary1.Y)
            {
                direction = Direction.Down;
            }

            if (direction == Direction.Up)
            {
                location.Y -= Speed;
            }
            else
            {
                location.Y += Speed;
            }
            return location;
        }

       
    }
}
