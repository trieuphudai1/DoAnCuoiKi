using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;
using QuickGraph;
using QuickGraph.Algorithms;
using QuickGraph.Graphviz;
using System.Collections.Specialized;
using QuickGraph.Algorithms.Search;
using System.Windows.Forms.VisualStyles;

namespace Project
{
    public partial class ĐỒ_THỊ : Form
    {
        Random random = new Random();
        private AdjacencyGraph<int, Edge<int>> UndirectedGraph = new AdjacencyGraph<int, Edge<int>>();
        private List<(int, Point)> Position = new List<(int, Point)>();
        private int diameter = 50;
        private Bitmap buffer;
        List<int> visited = new List<int>();
        int index = 0;
        
        public ĐỒ_THỊ()
        {
            InitializeComponent();
            DoubleBuffered = true;
            timer1.Interval = 1000;
            
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Them du lieu vao lsvDSCanh
            string stringEdge = textBox2.Text.Trim();
            textBox2.Text = null;
            ListViewItem item = new ListViewItem(stringEdge);
            lsvDSCanh.Items.Add(item);

            //Them dinh va canh vao do thi
            int u = stringEdge[0] - '0';
            int v = stringEdge[2] - '0';
            UndirectedGraph.AddVertex(u);
            UndirectedGraph.AddVertex(v);
            UndirectedGraph.AddEdge(new Edge<int>(u, v));
            UndirectedGraph.AddEdge(new Edge<int>(v, u));

            //goi event paint de ve do thi
            grBDoThi.Invalidate();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lsvDSCanh.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in lsvDSCanh.SelectedItems)
                    lsvDSCanh.Items.Remove(item);
            }
        }

        public bool isOverlapped(Point newCenter)
        {
            foreach (var item in Position)
            {
                Point p = item.Item2;
                double distance = Math.Sqrt(Math.Pow(p.X - newCenter.X, 2) + Math.Pow(p.Y - newCenter.Y, 2));
                if (distance <= diameter + 25)
                    return true;
            }
            return false;
        }
        private void grBDoThi_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //tim vi tri cac dinh
            foreach (var vertex in UndirectedGraph.Vertices)
            {
                while (true)
                {
                    int x = random.Next(grBDoThi.Width - 50);
                    int y = random.Next(grBDoThi.Height - 50);
                    Point newCenter = new Point();
                    newCenter.X = x + diameter / 2;
                    newCenter.Y = y + diameter / 2;
                    if (!isOverlapped(newCenter))
                    {
                        Position.Add((vertex, newCenter));
                        break;
                    }

                }
            }

            //Xoa dinh va canh
            Point Source = new Point();
            Point Target = new Point();
            foreach (var edge in UndirectedGraph.Edges)
            {
                Source = getPosition(edge.Source, Position);
                Target = getPosition(edge.Target, Position);

                //g.DrawLine(Pens.Black, Source, Target);
                DrawEdge(Source, Target, g);
                DrawVertex(Source, g, Brushes.Blue);
                DrawVertex(Target, g, Brushes.Blue);

                //g.FillEllipse(Brushes.Blue, Source.X - diameter / 2, Source.Y - diameter / 2, diameter, diameter);
                //g.FillEllipse(Brushes.Blue, Target.X - diameter / 2, Target.Y - diameter / 2, diameter, diameter);

                DrawNumber(edge.Source.ToString(), Source, g);
                DrawNumber(edge.Target.ToString(), Target, g);
                //g.DrawString(edge.Source.ToString(), new Font("Arial", 20), Brushes.Red, Source.X - diameter / 4, Source.Y - diameter / 3);
                //g.DrawString(edge.Target.ToString(), new Font("Arial", 20), Brushes.Red, Target.X - diameter / 4, Target.Y - diameter / 3);
            }
        }

        private void DrawVertex(Point Pos, Graphics g, Brush brush)
        {
            g.FillEllipse(brush, Pos.X - diameter / 2, Pos.Y - diameter / 2, diameter, diameter);
        }

        private void DrawEdge(Point Source, Point Target, Graphics g)
        {
            g.DrawLine(Pens.Black, Source, Target);
        }

        private void DrawNumber(string stringNumber, Point Num, Graphics g)
        {
            g.DrawString(stringNumber, new Font("Arial", 20), Brushes.Red, Num.X - diameter / 4, Num.Y - diameter / 3);
        }
        private Point getPosition(int vertex, List<(int, Point)> Position)
        {
            foreach(var p in Position)
            {
                if (p.Item1 == vertex)
                    return p.Item2;
            }

            return new Point(-1, -1);
        }
        private void btnBFS_Click(object sender, EventArgs e)
        {
            visited.Clear();
            buffer = new Bitmap(grBDoThi.Width, grBDoThi.Height);
            var bfsAlgo = new BreadthFirstSearchAlgorithm<int, Edge<int>>(UndirectedGraph);
            bfsAlgo.DiscoverVertex += (vertex) =>
            {
                visited.Add(vertex);

            };
           
            bfsAlgo.Compute(1);

            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics bufferGraphics = Graphics.FromImage(buffer);
            if (index < visited.Count)
            {
                int vertex = visited[index];
                Point temp = getPosition(vertex, Position);
                DrawVertex(temp, bufferGraphics, Brushes.Red);
                using (Graphics g = grBDoThi.CreateGraphics())
                {
                    g.DrawImage(buffer, 0, 0);
                }
                index++;
            } 
            else
            {
                this.Refresh();
                timer1.Stop();
                buffer.Dispose();
                bufferGraphics.Dispose();
                index = 0;
            }
        }

    }
}
