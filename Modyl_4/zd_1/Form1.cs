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
            // �������� ����������� ��������� ��������� ������
            comboBox1.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);

            // ����������� ������� ������� ����
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
                        double radius = double.Parse(txtParam1.Text); // ��������� �������
                        figure = new Circle(radius);  // �������� �����
                        break;

                    case "Rectangle":
                        double width = double.Parse(txtParam1.Text);  // ��������� ������
                        double height = double.Parse(txtParam2.Text); // ��������� ������
                        figure = new Rectangle(width, height); // �������� ��������������
                        break;
                          
                    case "Triangle":
                        double sideA = double.Parse(txtParam1.Text);  // ��������� ������� A
                        double sideB = double.Parse(txtParam2.Text);  // ��������� ������� B
                        double sideC = double.Parse(txtParam3.Text);  // ��������� ������� C
                        figure = new Triangle(sideA, sideB, sideC);   // �������� ������������
                        break;

                    default:
                        MessageBox.Show("����������, �������� ���������� �����.");
                        return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("����������, ������� �������������� �������� ��������.");
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

            // ������� ��������� ����� ������ ��� ��� ��������� ������
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
                        MessageBox.Show("����������, �������� ���������� ������.");
                        return;
                }

                txtPerimeter.Text = figure.CalculatePerimeter().ToString();
                txtArea.Text = figure.CalculateArea().ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("����������, ������� �������������� �������� ��������.");
            }
        }
    }
}
