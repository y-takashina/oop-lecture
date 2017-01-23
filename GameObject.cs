using System;
using System.Drawing;

namespace OopLecture
{
    class GameObject
    {
        public int X;
        public int Y;
        public int W;
        public int H;
        public bool IsAlive;

        public GameObject(int x, int y, int w = 20, int h = 20)
        {
            X = x;
            Y = y;
            W = w;
            H = h;
            IsAlive = true;
        }

        public void Move(int x, int y)
        {
            X += x;
            Y += y;
        }

        public void RandomWalk()
        {
            var rand = new Random(DateTime.Now.Millisecond);
            X += rand.Next(10) - 5;
            Y += rand.Next(10) - 5;
        }

        public bool Intersects(GameObject obj)
        {
            return X < obj.X + obj.W && X + W > obj.X &&
                   Y < obj.Y + obj.H && Y + H > obj.Y;
        }

        public void Die()
        {
            IsAlive = false;
        }

        public void Draw(Graphics g)
        {
            Console.WriteLine("x: " + X + ", y: " + Y);
            g.FillRectangle(Brushes.Red, X - W/2, Y - H/2, W, H);
        }
    }
}