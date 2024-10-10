namespace zd_1
{
    public partial class Figure : Form
    {
        public Figure()
        {
            InitializeComponent();
            txtPerimeter.ReadOnly = true;
            txtArea.ReadOnly = true;
            comboBox1.Items.Add("Circle");
            comboBox1.Items.Add("Rectangle");
            comboBox1.Items.Add("Triangle");
            comboBox1.SelectedIndex = 0;
            // Привязка обработчика изменения выбранной фигуры
            comboBox1.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);

            // Изначальное скрытие лишнего поля
            SetupFigureInputs();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetupFigureInputs();
            IFigure figure;

            try
            {
                switch (comboBox1.SelectedItem.ToString())
                {
                    case "Circle":
                        double radius = double.Parse(txtParam1.Text); // Получение радиуса
                        figure = new Circle(radius);  // Создание круга
                        break;

                    case "Rectangle":
                        double width = double.Parse(txtParam1.Text);  // Получение ширины
                        double height = double.Parse(txtParam2.Text); // Получение высоты
                        figure = new Rectangle(width, height); // Создание прямоугольника
                        break;
                          
                    case "Triangle":
                        double sideA = double.Parse(txtParam1.Text);  // Получение стороны A
                        double sideB = double.Parse(txtParam2.Text);  // Получение стороны B
                        double sideC = double.Parse(txtParam3.Text);  // Получение стороны C
                        figure = new Triangle(sideA, sideB, sideC);   // Создание треугольника
                        break;

                    default:
                        MessageBox.Show("Пожалуйста, выберите правильную цифру.");
                        return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите действительные числовые значения.");
            }
        }

        private void SetupFigureInputs()
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Circle":
                    txtParam1.Visible = true;    
                    txtParam2.Visible = false;    
                    txtParam3.Visible = false;
                    break;

                case "Rectangle":
                    txtParam1.Visible = true;     
                    txtParam2.Visible = true;
                    txtParam3.Visible = false;    
                    break;

                case "Triangle":
                    txtParam1.Visible = true;    
                    txtParam2.Visible = true;
                    txtParam3.Visible = true;
                    break;
            }

            // Очистка текстовых полей каждый раз при изменении фигуры
            txtParam1.Text = "";
            txtParam2.Text = "";
            txtParam3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IFigure figure;

            try
            {
                switch (comboBox1.SelectedItem.ToString())
                {
                    case "Circle":
                        double radius = double.Parse(txtParam1.Text);  
                        figure = new Circle(radius);  
                        break;

                    case "Rectangle":
                        double width = double.Parse(txtParam1.Text);  
                        double height = double.Parse(txtParam2.Text);  
                        figure = new Rectangle(width, height);  
                        break;

                    case "Triangle":
                        double sideA = double.Parse(txtParam1.Text);  
                        double sideB = double.Parse(txtParam2.Text);  
                        double sideC = double.Parse(txtParam3.Text);  
                        figure = new Triangle(sideA, sideB, sideC);  
                        break;

                    default:
                        MessageBox.Show("Пожалуйста, выберите правильную фигуру.");
                        return;
                }

                txtPerimeter.Text = figure.CalculatePerimeter().ToString();
                txtArea.Text = figure.CalculateArea().ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите действительные числовые значения.");
            }
        }
    }
}
