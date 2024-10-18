namespace zd_2
{
    public partial class Form1 : Form
    {
        private TaskService taskService;
        public Form1()
        {
            InitializeComponent();
            string connectionString = "Server=DESKTOP-JPH55P0\\SQLEXPRESS;Database=TasksBD;Integrated Security=true;"; // ������� ������ ����������� � ���� ������
            taskService = new TaskService(connectionString);
            DisplayTasks(); // ����� ���� ����� ��� �������� �����
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Task newTask = new Task
            {
                TaskName = TaskNameTxt.Text,
                TaskDescription = TaskDescriptionTxt.Text,
                DueDate = DueDatePicker.Value,
                IsCompleted = IsCompletedCheckBox.Checked
            };

            // ���������� ��� ������������ taskService
            taskService.AddTask(newTask);

            MessageBox.Show("������ ���������.");
            ClearFields();
        }

        // ����� ��� ����������� ����� �� �����
        private void DisplayTasks()
        {
            listBoxTasks.Items.Clear(); // ������� ListBox ����� �����������
            var tasks = taskService.GetAllTasks(); // ��������� ���� �����

            foreach (var task in tasks)
            {
                var taskDescription = task.TaskDescription; // ����������� ���������� ��������
                var taskStatus = task.IsCompleted ? "���������" : "�� ���������"; // ������ ������

                // ���������� ������ � ListBox
                listBoxTasks.Items.Add($"ID: {task.TaskID}, ��������: {task.TaskName}, ��������: {taskDescription}, ����: {task.DueDate.ToShortDateString()}, ������: {taskStatus}");
            }
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TaskIDTxt.Text, out int taskId))
            {
                taskService.DeleteTask(taskId); // �������� ������
                DisplayTasks(); // ���������� ������ �����
            }
            else
            {
                MessageBox.Show("������� ���������� ID ������ ��� ��������.");
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TaskIDTxt.Text, out int taskId))
            {
                Task updatedTask = new Task
                {
                    TaskID = taskId,
                    TaskName = TaskNameTxt.Text,
                    TaskDescription = TaskDescriptionTxt.Text,
                    DueDate = DueDatePicker.Value,
                    IsCompleted = IsCompletedCheckBox.Checked
                };

                taskService.UpdateTask(updatedTask); // ���������� ������
                DisplayTasks(); // ���������� ������ �����
            }
            else
            {
                MessageBox.Show("������� ���������� ID ������ ��� ����������.");
            }
        }
        private void ClearFields()
        {
            TaskIDTxt.Text = "";
            TaskNameTxt.Text = "";
            TaskDescriptionTxt.Text = "";
            IsCompletedCheckBox.Checked = false;
            DueDatePicker.Value = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayTasks(); // ���������� ������ �����
        }
    }
}
