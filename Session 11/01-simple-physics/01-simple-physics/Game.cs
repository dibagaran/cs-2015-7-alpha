using System;

namespace Project
{
    static class Game
    {
        public static long BackgroundColor { get; set; }

        public static float StageWidth { get; set; }

        public static float StageHeight { get; set; }

        private static Vector gravity = new Vector (0, 9.8f);
        private static float friction = .9f;

        static Game ()
        {
            StageWidth = 800;
            StageHeight = 600;
            BackgroundColor = 0xFFFFFFFF;
        }

        private static Sprite[] sprites = new Sprite[1000];

        public static Sprite[] Sprites{ get { return sprites; } }

        private static int spritesCount = 0;

        public static int SpritesCount{ get { return spritesCount; } }

        public static void Add (Sprite sprite)
        {
            if (spritesCount < sprites.Length)
                sprites [spritesCount++] = sprite;
        }

        public static void Update ()
        {
            for (var i = 0; i < spritesCount; i++) {
                var sprite = sprites [i];

                sprite.Update ();

                if (sprite.Position.X < 0) {
                    sprite.Position.X = 0;
                    sprite.Speed.X *= -1;
                    sprite.Speed *= friction;
                }

                if (sprite.Position.X > StageWidth - sprite.Width) {
                    sprite.Position.X = StageWidth - sprite.Width;
                    sprite.Speed.X *= -1;
                    sprite.Speed *= friction;
                }

                if (sprite.Position.Y < 0) {
                    sprite.Position.Y = 0;
                    sprite.Speed.Y *= -1;
                    sprite.Speed *= friction;
                }

                if (sprite.Position.Y > StageHeight - sprite.Height) {
                    sprite.Position.Y = StageHeight - sprite.Height;
                    sprite.Speed.Y *= -1;
                    sprite.Speed *= friction;
                }

                sprite.Speed += gravity;
            }
        }
    }
}

