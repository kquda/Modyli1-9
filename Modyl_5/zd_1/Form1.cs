namespace zd_1
{
    public partial class Form1 : Form
    {
        private bool drawing = false; // ���� ���������
        private Point startPoint;      // ��������� ����� ��� ������
        private string shape = "";     // ��������� ������
        private Bitmap drawingBitmap;  // ����� ��� ���������
        private Graphics graphics;     // ����������� ������
        private Color currentColor;    // ������� ����
        private Point lastPoint; // ��� �������� ��������� ����� ��� ��������� ���������
        private bool isFreeDrawingEnabled = false; // ���� ��� ���������� ���������

        public Form1()
        {
            InitializeComponent();

            panel1 = new BufferedPanel
            {
                Dock = DockStyle.Fill
            };
            this.Controls.Add(panel1);

            drawingBitmap = new Bitmap(panel1.Width, panel1.Height); // �������� ������
            graphics = Graphics.FromImage(drawingBitmap);            // �������� ������� � ������
            graphics.Clear(Color.White);                             // ��������� ����
            currentColor = Color.Black;                              // ��������� ���������� �����

            // �������� ������� ����
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            panel1.Paint += panel1_Paint; // ���������� ������� ��� ���������
        }

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shape = "Circle";
        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shape = "Square";
        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shape = "Line";
        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            panel1.Invalidate();
            shape = ""; // ����� ��������� ������
        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (isFreeDrawingEnabled) // ���������, ������� �� ����� ���������� ���������
            {
                drawing = true; // �������� ���������
                lastPoint = e.Location; // ������������� ��������� �����
            }
            else
            {
                drawing = true; // ������� ���������
                startPoint = e.Location; // ��������� ����� ��� ������
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                if (isFreeDrawingEnabled) // ���� ������� ����� ���������� ���������
                {
                    Pen pen = new Pen(Color.Black, 2);
                    graphics.DrawLine(pen, lastPoint, e.Location); // ������ ����� �� ��������� ����� �� �������
                    lastPoint = e.Location; // ��������� ��������� �����
                    panel1.Invalidate(); // ����������� ������
                    pen.Dispose();
                }
                else // ���� �� ��������� ���������
                {
                    panel1.Invalidate(); // ����� ��������� ���������
                    DrawShape(e.Location, true); // ��������� ��������� ������
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(drawingBitmap, 0, 0); // ��������� ������ �� ������
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false; // ���������� ���������
            if (isFreeDrawingEnabled)
            {
                // ����� ����� �������� ������ ��� ���������� ���������� ���������, ���� ����������
            }
            else if (!string.IsNullOrEmpty(shape)) // ��������� ��������� ������ �� ������
            {
                DrawShape(e.Location, false); // ����������� ������
                panel1.Invalidate(); // ���������� ������
            }
        }

        private void DrawShape(Point endPoint, bool isTemporary)
        {
            Pen pen = new Pen(currentColor, 2);
            switch (shape)
            {
                case "Line":
                    if (isTemporary)
                    {
                        graphics.Clear(Color.White); // ����� ������ ��� ��������� ���������
                        graphics.DrawLine(pen, startPoint, endPoint); // ������ ��������� �����
                    }
                    else
                    {
                        graphics.DrawLine(pen, startPoint, endPoint); // ���������� �����
                    }
                    break;
                case "Circle":
                    if (isTemporary)
                    {
                        graphics.Clear(Color.White); // ����� ������ ��� ��������� ���������
                        int radius = Math.Min(Math.Abs(endPoint.X - startPoint.X), Math.Abs(endPoint.Y - startPoint.Y));
                        graphics.DrawEllipse(pen, startPoint.X, startPoint.Y, radius, radius); // ������ ��������� ����
                    }
                    else
                    {
                        int radius = Math.Min(Math.Abs(endPoint.X - startPoint.X), Math.Abs(endPoint.Y - startPoint.Y));
                        graphics.DrawEllipse(pen, startPoint.X, startPoint.Y, radius, radius); // ���������� ����
                    }
                    break;
                case "Square":
                    if (isTemporary)
                    {
                        graphics.Clear(Color.White); // ����� ������ ��� ��������� ���������
                        int side = Math.Min(Math.Abs(endPoint.X - startPoint.X), Math.Abs(endPoint.Y - startPoint.Y));
                        graphics.DrawRectangle(pen, new Rectangle(startPoint.X, startPoint.Y, side, side)); // ������ ��������� �������
                    }
                    else
                    {
                        int side = Math.Min(Math.Abs(endPoint.X - startPoint.X), Math.Abs(endPoint.Y - startPoint.Y));
                        graphics.DrawRectangle(pen, new Rectangle(startPoint.X, startPoint.Y, side, side)); // ���������� �������
                    }
                    break;
                case "ArtLine":
                    graphics.DrawLine(pen, startPoint, endPoint);
                    break;
                case "ArtCircle":
                    int artRadius = Math.Min(Math.Abs(endPoint.X - startPoint.X), Math.Abs(endPoint.Y - startPoint.Y));
                    graphics.DrawEllipse(pen, startPoint.X, startPoint.Y, artRadius, artRadius);
                    break;
                case "ArtSquare":
                    int artSide = Math.Min(Math.Abs(endPoint.X - startPoint.X), Math.Abs(endPoint.Y - startPoint.Y));
                    graphics.DrawRectangle(pen, new Rectangle(startPoint.X, startPoint.Y, artSide, artSide));
                    break;
            }

            pen.Dispose();
            if (!isTemporary)
            {
                panel1.Invalidate(); // ���������� ������ ��� ���������
            }
        }

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                currentColor = colorDialog.Color; // ��������� ���������� �����
            }
        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shape = "ArtCircle";
        }

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shape = "ArtSquare";
        }

        private void ��������ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            shape = "ArtLine";
        }

        private void �����������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isFreeDrawingEnabled = !isFreeDrawingEnabled; // ������������ ��������� ���������� ���������
            �����������������ToolStripMenuItem.Checked = isFreeDrawingEnabled; // ��������� ��������� ������ ����
            shape = "";
        }
    }
}
