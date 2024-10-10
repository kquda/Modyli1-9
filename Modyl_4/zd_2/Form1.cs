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
            comboBox1.SelectedIndex = 0;  // Устанавока начального выбора

            txtPrice.ReadOnly = true;
            txtStock.ReadOnly = true;

            // Привязка обработчика к кнопке
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
                        double priceKg = double.Parse(txtParam1.Text); // Получение цены за килограмм
                        int stockKg = int.Parse(txtParam2.Text); // Получение остатка товара в килограммах
                        product = new Fruit("Fruit", priceKg, stockKg); // Создание объекта класса Fruit
                        break;

                    case "Vegetable":
                        double vegPriceKg = double.Parse(txtParam1.Text); // Получение цены за килограмм
                        int vegStockKg = int.Parse(txtParam2.Text); // Получение остатка товара в килограммах
                        product = new Vegetable("Vegetable", vegPriceKg, vegStockKg); // Создание объекта класса Vegetable
                        break;

                    case "Drink":
                        double priceLiter = double.Parse(txtParam1.Text); // Получение цены за литр
                        int stockLiters = int.Parse(txtParam2.Text); // Получение остатка товара в литрах
                        product = new Drink("Drink", priceLiter, stockLiters); // Создание объекта класса Drink
                        break;

                    default:
                        MessageBox.Show("Выберите правильный тип товара."); // Сообщение об ошибке при неправильном выборе
                        return;
                }

                Random random = new Random();
                int randomPercentage = random.Next(1, 21);
                int randomSold = random.Next(1, product.RestProduct() + 1);

                // Расчет конечной цены с учетом случайного процента
                double finalPrice = product.PriceProduct() * (1 + randomPercentage / 100.0);
                // Расчет остатка на складе после продажи
                int finalStock = product.RestProduct() - randomSold;

                txtPrice.Text = finalPrice.ToString("F2"); // Форматирование для отображения двух знаков после запятой
                txtStock.Text = finalStock.ToString(); // Вывод остатка товара
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректные числовые значения."); // Сообщение об ошибке при вводе некорректных значений
            }
        }
    }
}
