using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFrameWork01
{
    public   class HorizontalPetrol : IMovement
    {
        private int Speed;
        private Point Boundary1;
        private Point Boundary2;
        private Direction direction;

        public HorizontalPetrol(int Speed, Point Boundary1, Point Boundary2, Direction direction)
        {
            this.Speed = Speed;
            this.Boundary1 = Boundary1;
            this.Boundary2 = Boundary2;
            this.direction = direction;
        }

        public Point Move(Point Location)
        {
            if(Location.X >= Boundary2.X)
            {
                direction = Direction.Right;
            }
            else if(Location.X + Speed <= Boundary1.X)
            {
                direction = Direction.Left;
            }

           

            if (direction == Direction.Right)
            {
                Location.X -= Speed;
            }
            else
            {
                Location.X += Speed;
            }
            return Location;
        }
    }
}
