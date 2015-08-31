using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Project
{
    public class GameWindow : Form
    {
        public GameWindow ()
        {
            this.TopMost = true;
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        protected override void OnLoad (EventArgs e)
        {
            base.OnLoad (e);

            this.Location = new Point (0, 0);
            Game.StageWidth = this.Width = Screen.PrimaryScreen.Bounds.Width;
            Game.StageHeight = this.Height = Screen.PrimaryScreen.Bounds.Height;

            var timer = new Timer{ Interval = 10 };
            timer.Tick += delegate {
                Game.Update ();
                Invalidate ();
            };
            timer.Start ();
        }

        protected override void OnKeyUp (KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close ();
            else
                base.OnKeyUp (e);
        }

        private Random random = new Random ();

        protected override void OnMouseUp (MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {
                var size = random.Next (20, 150);
                var speedX = random.Next (-25, 25);

                var color =
                    0xFF000000 +
                    random.Next (32, 256) * 0x10000 +
                    random.Next (32, 256) * 0x100 +
                    random.Next (32, 256);

                Game.Add (new Sprite {
                    Position = new Vector (e.X - size / 2, e.Y - size / 2),
                    Speed = new Vector (speedX, -50),
                    Width = size,
                    Height = size,
                    Color = color
                });
            } else if (e.Button == MouseButtons.Right)
                Close ();
            else
                base.OnMouseUp (e);
        }

        protected override void OnPaint (PaintEventArgs e)
        {
            var context = e.Graphics;
            context.SmoothingMode = SmoothingMode.AntiAlias;
            context.Clear (Color.FromArgb ((int)Game.BackgroundColor));
            for (var i = 0; i < Game.SpritesCount; i++) {
                var sprite = Game.Sprites [i];
                using (var brush = new SolidBrush (Color.FromArgb ((int)sprite.Color)))
                    context.FillEllipse (brush, new RectangleF (sprite.Position.X, sprite.Position.Y, sprite.Width, sprite.Height));
            }
            var legend =
                "Count: " + Game.SpritesCount + Environment.NewLine +
                "Left Click: Add New Sprite" + Environment.NewLine +
                "Right click: Exit";
            context.DrawString (legend, SystemFonts.DialogFont, Brushes.Black, 20, 20);
        }
    }
}
