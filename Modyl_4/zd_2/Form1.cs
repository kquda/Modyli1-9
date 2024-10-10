namespace zd_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Fruit");
            comboBox1.Items.Add("Vegetable");
            comboBox1.Items.Add("Drink");
            comboBox1.SelectedIndex = 0;  // ���������� ���������� ������

            txtPrice.ReadOnly = true;
            txtStock.ReadOnly = true;

            // �������� ����������� � ������
            button1.Click += new EventHandler(button1_Click);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IProduct product;

            try
            {
                switch (comboBox1.SelectedItem.ToString())
                {
                    case "Fruit":
                        double priceKg = double.Parse(txtParam1.Text); // ��������� ���� �� ���������
                        int stockKg = int.Parse(txtParam2.Text); // ��������� ������� ������ � �����������
                        product = new Fruit("Fruit", priceKg, stockKg); // �������� ������� ������ Fruit
                        break;

                    case "Vegetable":
                        double vegPriceKg = double.Parse(txtParam1.Text); // ��������� ���� �� ���������
                        int vegStockKg = int.Parse(txtParam2.Text); // ��������� ������� ������ � �����������
                        product = new Vegetable("Vegetable", vegPriceKg, vegStockKg); // �������� ������� ������ Vegetable
                        break;

                    case "Drink":
                        double priceLiter = double.Parse(txtParam1.Text); // ��������� ���� �� ����
                        int stockLiters = int.Parse(txtParam2.Text); // ��������� ������� ������ � ������
                        product = new Drink("Drink", priceLiter, stockLiters); // �������� ������� ������ Drink
                        break;

                    default:
                        MessageBox.Show("�������� ���������� ��� ������."); // ��������� �� ������ ��� ������������ ������
                        return;
                }

                Random random = new Random();
                int randomPercentage = random.Next(1, 21);
                int randomSold = random.Next(1, product.RestProduct() + 1);

                // ������ �������� ���� � ������ ���������� ��������
                double finalPrice = product.PriceProduct() * (1 + randomPercentage / 100.0);
                // ������ ������� �� ������ ����� �������
                int finalStock = product.RestProduct() - randomSold;

                txtPrice.Text = finalPrice.ToString("F2"); // �������������� ��� ����������� ���� ������ ����� �������
                txtStock.Text = finalStock.ToString(); // ����� ������� ������
            }
            catch (FormatException)
            {
                MessageBox.Show("������� ���������� �������� ��������."); // ��������� �� ������ ��� ����� ������������ ��������
            }
        }
    }
}
