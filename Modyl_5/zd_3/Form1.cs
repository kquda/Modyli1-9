using System.Windows.Forms;

namespace zd_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                listBox.Items.Add(textBox1.Text);
                textBox1.Clear(); // ������� ���� �����
            }
            else
            {
                MessageBox.Show("������� ������!", "������");
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                listBox.Items.Remove(listBox.SelectedItem);
            }
            else
            {
                MessageBox.Show("�������� ������ ��� ��������!", "������");
            }
        }

        private void buttonComplete_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                string selectedTask = listBox.SelectedItem.ToString();
                listBox.Items[listBox.SelectedIndex] = "[���������] " + selectedTask;
            }
            else
            {
                MessageBox.Show("�������� ������ ��� ������� ��� �����������!", "������");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ��������� ����������
            listBox.SelectionMode = SelectionMode.One;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "�� ������������� ������ �����?",
            "������������� ������",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Error);

            if (result == DialogResult.Yes)
            {
                this.Close(); // �������� ����� ��� ������� "��"
            }
        }
    }
}
