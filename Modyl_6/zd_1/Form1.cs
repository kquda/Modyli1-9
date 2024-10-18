namespace zd_1
{
    public partial class zd_1 : Form
    {
        public zd_1()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Employee newEmployee = new Employee
            {
                FirstName = FirstNametxt.Text,
                LastName = LastNametxt.Text,
                Position = Positiontxt.Text,
                Department = DepartmentTxt.Text,
                HireDate = dateTimePicker1.Value,
                Salary = Convert.ToDecimal(Salarytxt.Text)
            };

            EmployeeService employeeService = new EmployeeService();
            employeeService.AddEmployee(newEmployee);

            MessageBox.Show("Сотрудник добавлен.");
            ClearFields();
        }

        // Метод для очистки полей формы
        private void ClearFields()
        {
            FirstNametxt.Text = "";
            LastNametxt.Text = "";
            Positiontxt.Text = "";
            DepartmentTxt.Text = "";
            Salarytxt.Text = "";
            txtEmployeeID.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int employeeId = Convert.ToInt32(txtEmployeeID.Text);
            EmployeeService employeeService = new EmployeeService();
            employeeService.DeleteEmployee(employeeId);

            MessageBox.Show("Сотрудник удален.");
            ClearFields();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Employee updatedEmployee = new Employee
            {
                EmployeeID = Convert.ToInt32(txtEmployeeID.Text),
                FirstName = FirstNametxt.Text,
                LastName = LastNametxt.Text,
                Position = Positiontxt.Text,
                Department = DepartmentTxt.Text,
                HireDate = dateTimePicker1.Value,
                Salary = Convert.ToDecimal(Salarytxt.Text)
            };

            EmployeeService employeeService = new EmployeeService();
            employeeService.EditEmployee(updatedEmployee);

            MessageBox.Show("Сотрудник обновлен.");
            ClearFields();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeService employeeService = new EmployeeService();
            List<Employee> employees = employeeService.GetAllEmployees();

            // Привязываем список сотрудников к DataGridView
            dataGridView1.DataSource = employees;
        }
    }
}
