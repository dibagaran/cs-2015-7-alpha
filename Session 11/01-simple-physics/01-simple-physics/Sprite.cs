using System;

namespace Project
{
    public class Sprite
    {
        public Vector Position { get; set; }

        public Vector Speed  { get; set; }

        public float Width { get; set; }

        public float Height { get; set; }

        public long Color { get; set; }

        public Sprite ()
        {
            this.Width = 50;
            this.Height = 50;
            this.Position = new Vector (0, 0);
            this.Speed = new Vector (0, 0);
            this.Color = 0xFF0079DA;
        }

        public void Update ()
        {
            this.Position += this.Speed;
        }
    }
}

