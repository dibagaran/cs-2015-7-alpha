using System;

namespace Project
{
    public class Size
    {
        private int width;
        public int Width {
            get {
                return this.width;
            }
        }

        private int height;
        public int Height {
            get {
                return this.height;
            }
        }

        public Size (int width, int height)
        {
            this.width = width;
            this.height = height;
        }
    }
}

