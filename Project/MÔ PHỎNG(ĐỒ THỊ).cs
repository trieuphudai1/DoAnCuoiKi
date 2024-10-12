using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class ĐỒ_THỊ : Form
    {
        public ĐỒ_THỊ()
        {
            InitializeComponent();
        }

        private void DrawArrowhead(Graphics g, Pen pen, Point startPoint, Point endPoint, int arrowLength, int arrowWidth)
        {
            // Tính toán các điểm của mũi tên
            float angle = (float)Math.Atan2(endPoint.Y - startPoint.Y, endPoint.X - startPoint.X);
            float rad = (float)Math.PI / 180.0f;

            PointF[] points =
            {
                endPoint,
                new PointF(endPoint.X - arrowLength * (float)Math.Cos(angle - 30 * rad),
                           endPoint.Y - arrowLength * (float)Math.Sin(angle - 30 * rad)),
                new PointF(endPoint.X - arrowLength * (float)Math.Cos(angle + 30 * rad),
                           endPoint.Y - arrowLength * (float)Math.Sin(angle + 30 * rad))
            };

            // Vẽ mũi tên
            g.FillPolygon(pen.Brush, points);
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                textBoxDuLieu.AppendText(Environment.NewLine);

                string s = textBoxDuLieu.Text.Substring(0, 1);
                Pen p = new Pen(Color.Black, 2);
                Graphics g = this.CreateGraphics();
                Font f = new Font("Time New Roman", 8);
                g.DrawString(s, f, Brushes.Black, 305, 305);
                g.DrawArc(p, 300, 300, 20, 20, 0, 360);

                s = textBoxDuLieu.Text.Substring(2, 1);
                g.DrawString(s, f, Brushes.Black, 505, 205);
                g.DrawArc(p, 500, 200, 20, 20, 0, 360);

                g.DrawLine(p, new Point(320, 310), new Point(500, 210));
                DrawArrowhead(g, p, new Point(320, 310), new Point(500, 210), 10, 10);
                g.Dispose();
                p.Dispose();
            }
        }
    }
}
