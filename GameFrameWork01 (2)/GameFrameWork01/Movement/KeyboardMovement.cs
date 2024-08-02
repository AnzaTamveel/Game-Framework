using System.Collections.Generic;
using System.Windows.Forms;

namespace GameFrameWork01.Movement
{
    public class KeyboardMovement : IMovement
    {
        private int speed;
        private List<PictureBox> Walls;
        private System.Drawing.Point boundary;
        private int gravitySpeed = 10;
        private Player player;
        public Player Player { get => player; set => player = value; }

        public KeyboardMovement(List<PictureBox> walls, int speed, System.Drawing.Point boundary, Player player)
        {
            this.speed = speed;
            this.Walls = walls;
            this.boundary = boundary;
            this.Player = player;
        }
        public KeyboardMovement(List<PictureBox> walls, int speed, System.Drawing.Point boundary)
        {
            this.speed = speed;
            this.Walls = walls;
            this.boundary = boundary;

        }

        public void FallUnderGravity(ref System.Drawing.Point Location)
        {
            bool Fall = true;

            foreach (PictureBox wall in Walls)
            {
                if (IsColliding(new System.Drawing.Point(Location.X, Location.Y +15+ gravitySpeed), wall))
                {
                    Fall = false;
                }
            }
            if (Fall)
            {
                Location.Y += gravitySpeed;
            }
        }
        public System.Drawing.Point Move(System.Drawing.Point location)
        {

            System.Drawing.Point newLocation = new System.Drawing.Point(location.X, location.Y);
            if (EZInput.Keyboard.IsKeyPressed(EZInput.Key.UpArrow))
            {
                newLocation.Y -= 15;
            }
            
            if (EZInput.Keyboard.IsKeyPressed(EZInput.Key.DownArrow))
            {
                newLocation.Y += speed;
            }
            
            if (EZInput.Keyboard.IsKeyPressed(EZInput.Key.LeftArrow))
            {
                newLocation.X -= speed;
            }
            
            if (EZInput.Keyboard.IsKeyPressed(EZInput.Key.RightArrow))
            {
                newLocation.X += speed;
            }
            if (EZInput.Keyboard.IsKeyPressed(EZInput.Key.Space))
            {
                Player.Fire();
            }


            newLocation = AdjustForCollisions(newLocation);
            FallUnderGravity(ref newLocation);
            return newLocation;
        }

        private System.Drawing.Point AdjustForCollisions(System.Drawing.Point newLocation)
        {

            foreach (PictureBox wall in Walls)
            {

                if (IsColliding(newLocation, wall))
                {

                    if (EZInput.Keyboard.IsKeyPressed(EZInput.Key.UpArrow))
                    {
                        newLocation.Y = wall.Bottom + 1;
                    }
                    else if (EZInput.Keyboard.IsKeyPressed(EZInput.Key.DownArrow))
                    {
                        newLocation.Y = wall.Top - 65;
                    }
                    else if (EZInput.Keyboard.IsKeyPressed(EZInput.Key.LeftArrow))
                    {
                        newLocation.X = wall.Right + 1;
                    }
                    else if (EZInput.Keyboard.IsKeyPressed(EZInput.Key.RightArrow))
                    {
                        newLocation.X = wall.Left - 65;
                    }
                }
            }


            if (newLocation.X < 0)
            {
                newLocation.X = 0;
            }
            else if (newLocation.X > boundary.X)
            {
                newLocation.X = boundary.X;
            }

            if (newLocation.Y < 0)
            {
                newLocation.Y = 0;
            }
            else if (newLocation.Y > boundary.Y)
            {
                newLocation.Y = boundary.Y;
            }

            return newLocation;
        }

        private bool IsColliding(System.Drawing.Point location, PictureBox wall)
        {
            return location.X < wall.Right &&
                   location.X + 65 > wall.Left &&
                   location.Y < wall.Bottom &&
                   location.Y + 65 > wall.Top;
        }
    }
}
