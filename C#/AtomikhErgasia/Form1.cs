using System.Drawing.Imaging;

namespace AtomikhErgasia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Width = 800;
            this.Height = 600;
            bitmap = new Bitmap(space.Width, space.Height);
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            space.Image = bitmap;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Bitmap bitmap;
        Graphics graphics;
        bool draw = false;
        Point px, py, startPoint, stopPoint;
        PointF[] shape;
        Pen pen = new Pen(Color.Black, 3);
        Pen erase = new Pen(Color.White, 50);
        int index;
        int x, y, sX, sY, cX, cY;
        ColorDialog colorDialog = new ColorDialog();
        Color new_color;

        private void space_MouseDown(object sender, MouseEventArgs e)
        {
            draw = true;
            py = e.Location;
            startPoint = e.Location;
            cX = e.X;
            cY = e.Y;
            stopPoint = e.Location;
        }

        private void space_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw)
            {

                if (index == 1)
                {
                    px = e.Location;
                    graphics.DrawLine(pen, px, py);
                    py = px;
                }
                if (index == 2)
                {
                    px = e.Location;
                    graphics.DrawLine(erase, px, py);
                    py = px;
                }
            }
            space.Refresh();

            x = e.X;
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;
        }

        private void space_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;

            sX = x - cX;
            sY = y - cY;

            if (index == 3)
            {
                graphics.DrawEllipse(pen, cX, cY, sX, sY);
            }
            if (index == 4)
            {
                createPolygon(startPoint, e.Location, 90);
            }
            if (index == 5)
            {
                graphics.DrawRectangle(pen, cX, cY, sX, sY);
            }
            if (index == 6)
            {
                DrawTriangle(startPoint, e.Location);
            }
            if (index == 7)
            {
                if (sX > sY)
                {
                    sX = sY;
                }
                else
                {
                    sY = sX;
                }
                graphics.DrawRectangle(pen, cX, cY, sX, sY);
            }
            if (index == 8)
            {
                createPolygon(startPoint, e.Location, 5);
            }
            if (index == 9)
            {
                createPolygon(startPoint, e.Location, 6);
            }
            if (index == 10)
            {
                createPolygon(startPoint, e.Location, 7);
            }
            if (index == 11)
            {
                createPolygon(startPoint, e.Location, 8);
            }
            if (index == 12)
            {
                createPolygon(startPoint, e.Location, 9);
            }
        }

        private void eraser_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void ellipse_Click(object sender, EventArgs e)
        {
            index = 3;
        }


        private void createPolygon(Point start, Point stop, int sides)
        {
            var x0 = (start.X + stop.X) / 2;
            var y0 = (start.Y + stop.Y) / 2;

            shape = new PointF[sides];

            float angle = 360 / sides;

            float r = (float)Math.Sqrt(Math.Pow((start.X - stop.X), 2) + Math.Pow((start.Y - stop.Y), 2)) / 2;

            for (int a = 0; a < sides; a++)
            {
                shape[a] = new PointF(
                    x0 + r * (float)Math.Cos(a * angle * Math.PI / 180f),
                    y0 + r * (float)Math.Sin(a * angle * Math.PI / 180f));
            }

            graphics.DrawPolygon(pen, shape);
            space.Refresh();
        }

        private void circle_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void rectangle_Click(object sender, EventArgs e)
        {
            index = 5;
        }

        private void triangle_Click(object sender, EventArgs e)
        {
            index = 6;
        }

        private void square_Click(object sender, EventArgs e)
        {
            index = 7;
        }

        private void pentagon_Click(object sender, EventArgs e)
        {
            index = 8;
        }

        private void hexagon_Click(object sender, EventArgs e)
        {
            index = 9;
        }

        private void heptagon_Click(object sender, EventArgs e)
        {
            index = 10;
        }

        private void octagon_Click(object sender, EventArgs e)
        {
            index = 11;
        }

        private void nonagon_Click(object sender, EventArgs e)
        {
            index = 12;
        }
        private void DrawTriangle(Point start, Point stop)
        {
            Point point1 = new Point(start.X, start.Y);
            Point point2 = new Point(start.X, stop.Y);
            Point point3 = new Point(stop.X, stop.Y);
            graphics.DrawLine(pen, point1, point2);
            graphics.DrawLine(pen, point2, point3);
            graphics.DrawLine(pen, point3, point1);
        }

        private void space_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            if (draw)
            {
                if (index == 3)
                {
                    graphics.DrawEllipse(pen, cX, cY, sX, sY);
                }
                if (index == 4)
                {
                    createPolygon(startPoint, stopPoint, 90);
                }
                if (index == 5)
                {
                    graphics.DrawRectangle(pen, cX, cY, sX, sY);
                }
                if (index == 6)
                {
                    DrawTriangle(startPoint, stopPoint);
                }
                if (index == 7)
                {
                    if (sX > sY)
                    {
                        sX = sY;
                    }
                    else
                    {
                        sY = sX;
                    }
                    graphics.DrawRectangle(pen, cX, cY, sX, sY);
                }
                if (index == 8)
                {
                    createPolygon(startPoint, stopPoint, 5);
                }
                if (index == 9)
                {
                    createPolygon(startPoint, stopPoint, 6);
                }
                if (index == 10)
                {
                    createPolygon(startPoint, stopPoint, 7);
                }
                if (index == 11)
                {
                    createPolygon(startPoint, stopPoint, 8);
                }
                if (index == 12)
                {
                    createPolygon(startPoint, stopPoint, 9);
                }
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            space.Image = bitmap;
            index = 0;
        }

        static Point set_point(PictureBox pictureBox, Point point)
        {
            float pX = 1f * pictureBox.Image.Width / pictureBox.Width;
            float pY = 1f * pictureBox.Image.Height / pictureBox.Height;
            return new Point((int)(point.X * pX), (int)(point.Y * pX));
        }

        private void color_palette_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = set_point(color_palette, e.Location);
            color_pick.BackColor = ((Bitmap)color_palette.Image).GetPixel(point.X, point.Y);
            new_color = color_pick.BackColor;
            pen.Color = color_pick.BackColor;
        }

        private void save_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Image(*.jpg)|*.jpg|(*.*|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm = bitmap.Clone(new Rectangle(0, 0, space.Width, space.Height), bitmap.PixelFormat);
                btm.Save(sfd.FileName, ImageFormat.Jpeg);
                MessageBox.Show("File saved");
            }
        }
    }
}