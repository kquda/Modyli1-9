namespace zd_1
{
    public partial class Form1 : Form
    {
        private bool drawing = false; // Флаг рисования
        private Point startPoint;      // Начальная точка для фигуры
        private string shape = "";     // Выбранная фигура
        private Bitmap drawingBitmap;  // Холст для рисования
        private Graphics graphics;     // Графический объект
        private Color currentColor;    // Текущий цвет
        private Point lastPoint; // Для хранения последней точки при свободном рисовании
        private bool isFreeDrawingEnabled = false; // Флаг для свободного рисования

        public Form1()
        {
            InitializeComponent();

            panel1 = new BufferedPanel
            {
                Dock = DockStyle.Fill
            };
            this.Controls.Add(panel1);

            drawingBitmap = new Bitmap(panel1.Width, panel1.Height); // Создание холста
            graphics = Graphics.FromImage(drawingBitmap);            // Привязка графики к холсту
            graphics.Clear(Color.White);                             // Установка фона
            currentColor = Color.Black;                              // Установка начального цвета

            // Привязка событий мыши
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            panel1.Paint += panel1_Paint; // Добавление события для отрисовки
        }

        private void кругToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shape = "Circle";
        }

        private void квадратToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shape = "Square";
        }

        private void линияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shape = "Line";
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            panel1.Invalidate();
            shape = ""; // Сброс выбранной фигуры
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (isFreeDrawingEnabled) // Проверяем, включен ли режим свободного рисования
            {
                drawing = true; // Начинаем рисование
                lastPoint = e.Location; // Устанавливаем последнюю точку
            }
            else
            {
                drawing = true; // Обычное рисование
                startPoint = e.Location; // Начальная точка для фигуры
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                if (isFreeDrawingEnabled) // Если активен режим свободного рисования
                {
                    Pen pen = new Pen(Color.Black, 2);
                    graphics.DrawLine(pen, lastPoint, e.Location); // Рисуем линию от последней точки до текущей
                    lastPoint = e.Location; // Обновляем последнюю точку
                    panel1.Invalidate(); // Перерисовка панели
                    pen.Dispose();
                }
                else // Если не свободное рисование
                {
                    panel1.Invalidate(); // Сброс временной отрисовки
                    DrawShape(e.Location, true); // Временная отрисовка фигуры
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(drawingBitmap, 0, 0); // Отрисовка холста на панели
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false; // Завершение рисования
            if (isFreeDrawingEnabled)
            {
                // Здесь можно добавить логику для завершения свободного рисования, если необходимо
            }
            else if (!string.IsNullOrEmpty(shape)) // Отрисовка выбранной фигуры на холсте
            {
                DrawShape(e.Location, false); // Закрепление фигуры
                panel1.Invalidate(); // Обновление панели
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
                        graphics.Clear(Color.White); // Сброс холста для временной отрисовки
                        graphics.DrawLine(pen, startPoint, endPoint); // Рисуем временную линию
                    }
                    else
                    {
                        graphics.DrawLine(pen, startPoint, endPoint); // Закрепляем линию
                    }
                    break;
                case "Circle":
                    if (isTemporary)
                    {
                        graphics.Clear(Color.White); // Сброс холста для временной отрисовки
                        int radius = Math.Min(Math.Abs(endPoint.X - startPoint.X), Math.Abs(endPoint.Y - startPoint.Y));
                        graphics.DrawEllipse(pen, startPoint.X, startPoint.Y, radius, radius); // Рисуем временный круг
                    }
                    else
                    {
                        int radius = Math.Min(Math.Abs(endPoint.X - startPoint.X), Math.Abs(endPoint.Y - startPoint.Y));
                        graphics.DrawEllipse(pen, startPoint.X, startPoint.Y, radius, radius); // Закрепляем круг
                    }
                    break;
                case "Square":
                    if (isTemporary)
                    {
                        graphics.Clear(Color.White); // Сброс холста для временной отрисовки
                        int side = Math.Min(Math.Abs(endPoint.X - startPoint.X), Math.Abs(endPoint.Y - startPoint.Y));
                        graphics.DrawRectangle(pen, new Rectangle(startPoint.X, startPoint.Y, side, side)); // Рисуем временный квадрат
                    }
                    else
                    {
                        int side = Math.Min(Math.Abs(endPoint.X - startPoint.X), Math.Abs(endPoint.Y - startPoint.Y));
                        graphics.DrawRectangle(pen, new Rectangle(startPoint.X, startPoint.Y, side, side)); // Закрепляем квадрат
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
                panel1.Invalidate(); // Обновление панели для отрисовки
            }
        }

        private void цветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                currentColor = colorDialog.Color; // Установка выбранного цвета
            }
        }

        private void артКругToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shape = "ArtCircle";
        }

        private void артКвадратToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shape = "ArtSquare";
        }

        private void артЛинияToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            shape = "ArtLine";
        }

        private void свобдноеРисованиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isFreeDrawingEnabled = !isFreeDrawingEnabled; // Переключение состояния свободного рисования
            свобдноеРисованиеToolStripMenuItem.Checked = isFreeDrawingEnabled; // Обновляем состояние пункта меню
            shape = "";
        }
    }
}
