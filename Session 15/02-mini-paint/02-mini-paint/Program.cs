using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Project
{
    class Program
    {
        [STAThread]
        public static void Main ()
        {
            Application.Run (new Canvas ());
        }
    }

    class Canvas : Form
    {
        private Polyline[] polylines = new Polyline[1000];
        private int currentPolyline = 0;
        private bool drawing = false;
        private Random random = new Random ();

        public Canvas ()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.White;
            this.DoubleBuffered = true;

            //Handling Events
            this.MouseDown += Canvas_MouseDown;
            this.MouseUp += Canvas_MouseUp;
            this.MouseMove += Canvas_MouseMove;
            this.Paint += Canvas_Paint;
        }

        private void Canvas_MouseDown (object sender, MouseEventArgs e)
        {
            drawing = true;

            var a = random.Next (32, 256);
            var r = random.Next (0, 256);
            var g = random.Next (0, 256);
            var b = random.Next (0, 256);

            var polyline = new Polyline (Color.FromArgb (a, r, g, b), random.Next (1, 10));
            polyline.Add (e.Location);
            polylines [currentPolyline++] = polyline;
        }

        private void Canvas_MouseUp (object sender, MouseEventArgs e)
        {
            polylines [currentPolyline - 1].Add (e.Location);
            drawing = false;
        }

        private void Canvas_MouseMove (object sender, MouseEventArgs e)
        {
            if (drawing) {
                polylines [currentPolyline - 1].Add (e.Location);
                Invalidate ();
            }
        }

        private void Canvas_Paint (object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            for (int i = 0; i < currentPolyline; i++) {
                var path = new GraphicsPath ();
                for (int j = 1; j < polylines [i].NoOfPoints; j++)
                    path.AddLine (polylines [i] [j - 1], polylines [i] [j]);
                using (var pen = new Pen (polylines [i].Color, polylines [i].Width))
                    e.Graphics.DrawPath (pen, path);
            }
        }
    }

    class Polyline
    {
        private Point[] points = new Point[1000];
        private int currentPoint = 0;

        public int NoOfPoints {
            get {
                return currentPoint;
            }
        }

        //Indexer
        public Point this [int index] {
            get {
                if (index >= currentPoint)
                    throw new ArgumentOutOfRangeException ();
                
                return points [index];
            }
        }

        public Color Color{ get; set; }

        public int Width{ get; set; }

        public Polyline (Color color, int width)
        {
            this.Color = color;
            this.Width = width;
        }

        public void Add (Point point)
        {
            if (currentPoint >= points.Length)
                throw new IndexOutOfRangeException ();

            points [currentPoint++] = point;
        }
    }
}
