namespace zd_5
{
    public partial class Form1 : Form
    {
        private string currentOperation = "";  // Операция
        private double firstNumber = 0;        // Первое число
        private double secondNumber = 0;       // Второе число
        private bool isOperationClicked = false;  // Флаг нажатия на операцию
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonProcent_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(textBoxDisplay.Text);
            textBoxDisplay.Text = (firstNumber / 100).ToString();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Clear();  
            firstNumber = 0;
            secondNumber = 0;
            currentOperation = "";
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text.Length > 0)
            {
                textBoxDisplay.Text = textBoxDisplay.Text.Remove(textBoxDisplay.Text.Length - 1, 1);
            }
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(textBoxDisplay.Text);
            currentOperation = "/";
            isOperationClicked = true;
        }

        private void buttonNum1_Click(object sender, EventArgs e)
        {
            if (isOperationClicked)
            {
                textBoxDisplay.Clear();  // Очистка текстового поля для ввода второго числа
                isOperationClicked = false;
            }
            textBoxDisplay.Text += "1";
        }

        private void buttonNum2_Click(object sender, EventArgs e)
        {
            if (isOperationClicked)
            {
                textBoxDisplay.Clear();  
                isOperationClicked = false;
            }
            textBoxDisplay.Text += "2";
        }

        private void buttonNum3_Click(object sender, EventArgs e)
        {
            if (isOperationClicked)
            {
                textBoxDisplay.Clear();  
                isOperationClicked = false;
            }
            textBoxDisplay.Text += "3";
        }

        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(textBoxDisplay.Text);
            currentOperation = "*";
            isOperationClicked = true;
        }

        private void buttonNum4_Click(object sender, EventArgs e)
        {
            if (isOperationClicked)
            {
                textBoxDisplay.Clear();  
                isOperationClicked = false;
            }
            textBoxDisplay.Text += "4";
        }

        private void buttonNum5_Click(object sender, EventArgs e)
        {
            if (isOperationClicked)
            {
                textBoxDisplay.Clear();  
                isOperationClicked = false;
            }
            textBoxDisplay.Text += "5";
        }

        private void buttonNum6_Click(object sender, EventArgs e)
        {
            if (isOperationClicked)
            {
                textBoxDisplay.Clear();  
                isOperationClicked = false;
            }
            textBoxDisplay.Text += "6";
        }

        private void buttonSubtraction_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(textBoxDisplay.Text);
            currentOperation = "-";
            isOperationClicked = true;
        }

        private void buttonNum7_Click(object sender, EventArgs e)
        {
            if (isOperationClicked)
            {
                textBoxDisplay.Clear();  
                isOperationClicked = false;
            }
            textBoxDisplay.Text += "7";
        }

        private void buttonNum8_Click(object sender, EventArgs e)
        {
            if (isOperationClicked)
            {
                textBoxDisplay.Clear();  
                isOperationClicked = false;
            }
            textBoxDisplay.Text += "8";
        }

        private void buttonNum9_Click(object sender, EventArgs e)
        {
            if (isOperationClicked)
            {
                textBoxDisplay.Clear();  
                isOperationClicked = false;
            }
            textBoxDisplay.Text += "9";
        }

        private void buttonAddition_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(textBoxDisplay.Text);
            currentOperation = "+";
            isOperationClicked = true;
        }

        private void buttonNum0_Click(object sender, EventArgs e)
        {
            if (isOperationClicked)
            {
                textBoxDisplay.Clear();  
                isOperationClicked = false;
            }
            textBoxDisplay.Text += "0";
        }

        private void buttonEqually_Click(object sender, EventArgs e)
        {
            secondNumber = double.Parse(textBoxDisplay.Text);
            double result = 0;

            switch (currentOperation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    if (secondNumber != 0)
                        result = firstNumber / secondNumber;
                    else
                        MessageBox.Show("Деление на ноль невозможно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            textBoxDisplay.Text = result.ToString();
            firstNumber = result;
            currentOperation = "";
        }
    }
}
