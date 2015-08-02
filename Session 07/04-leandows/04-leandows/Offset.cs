using System;

namespace Project
{
    public class Offset
    {
        private int left;
        public int Left {
            get {
                return this.left;
            }
        }

        private int top;
        public int Top {
            get {
                return this.top;
            }
        }

        public Offset (int left, int top)
        {
            this.left = left;
            this.top = top;
        }
    }
}

