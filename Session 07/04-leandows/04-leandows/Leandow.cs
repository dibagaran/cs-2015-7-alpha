using System;

namespace Project
{
    public class Leandow
    {
        //TODO: Don't let the leandow size become bigger than the desktop.
        //TODO: Don't let the leandow title become bigger than the title bar.
        //TODO: Implement a drag and drop mechanism for leandows using arrow keys.

        public string Title{ get; set; }
        public Size Size{ get; set; }
        public Offset Offset{ get; set; }

        public Leandow (string title, Size size, Offset offset)
        {
            this.Title = title;
            this.Size = size;
            this.Offset = offset;
        }

        public Leandow (string title, int width, int height, int offsetX, int offsetY)
        {
            this.Title = title;
            this.Size = new Size (width, height);
            this.Offset = new Offset (offsetX, offsetY);
        }
    }
}

