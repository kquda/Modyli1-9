using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Drawing2D;
using static Rtf_Documents.Form1;
namespace Rtf_Documents // �������� �.�
{
    public partial class Form1 : Form
    {
        private string currentFilePath = null; // ���� ��� �������� ���� � �������� �����
        private Image currentImage;
        private DataGridView dataGridView;
        private ContextMenuStrip contextMenuStripRichTextBox;


        public Form1()
        {
            InitializeComponent();
            InitializeShortcuts();

            dataGridView = new DataGridView();
            dataGridView.AutoGenerateColumns = true;
            dataGridView.Visible = false; // ������ DataGridView �� ���������

            // �������� ContextMenuStrip ��� RichTextBox
            contextMenuStripRichTextBox = new ContextMenuStrip();
            ToolStripMenuItem ��������DataGridViewItem = new ToolStripMenuItem("�������� DataGridView");
            ��������DataGridViewItem.Click += ��������DataGridViewItem_Click;
            contextMenuStripRichTextBox.Items.Add(��������DataGridViewItem);

            // �������� ContextMenuStrip � RichTextBox
            rtfTextBox.ContextMenuStrip = contextMenuStripRichTextBox;
        }

        private void ��������DataGridViewItem_Click(object sender, EventArgs e)
        {
            // ���� ������� ��� ����������, ������� ������� �
            if (dataGridView != null)
            {
                this.Controls.Remove(dataGridView);
                dataGridView.Dispose();
            }

            // �������� ������ ���������� DataGridView
            dataGridView = new DataGridView();
            dataGridView.AutoGenerateColumns = true;
            dataGridView.Visible = true;

            // ��������� ������� ������� � RichTextBox
            Point position = rtfTextBox.PointToClient(Cursor.Position);

            // ��������� ������� DataGridView
            dataGridView.Location = position;

            // ���������� DataGridView �� �����
            this.Controls.Add(dataGridView);

            // ����������� DataGridView �� �������� ����
            dataGridView.BringToFront();
        }

        // ����� ��� ���������� �������� � DataGridView
        private void ���������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ���������� ������� � DataGridView
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            dataGridView.Columns.Add(column);
        }

        // ����� ��� ���������� ����� � DataGridView
        private void ��������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ���������� ������ � DataGridView
            dataGridView.Rows.Add();
        }

        // ������������� ���� � �������� ��� ���������� ����� � ��������
        private void InitializeMenuStrip()
        {
            ToolStripMenuItem ���������������Item = new ToolStripMenuItem("�������� �������");
            ToolStripMenuItem ��������������Item = new ToolStripMenuItem("�������� ������");

            ���������������Item.Click += ���������������ToolStripMenuItem_Click;
            ��������������Item.Click += ��������������ToolStripMenuItem_Click;

            menuStrip1.Items.Add(���������������Item);
            menuStrip1.Items.Add(��������������Item);
        }

        private void InitializeShortcuts()
        {
            // ��������� ������� ������
            �������ToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            �������ToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            ���������ToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            ������������ToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            ����������������ToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Q;
            ����������ToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            ��������ToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            �������ToolStripMenuItem.ShortcutKeys = Keys.Delete;
            �����������ToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            ��������ToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            ��������ToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.Z;
            �������ToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
            ���������������ToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.W;
            ������������ToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
            �����ToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.T;
            ����������ToolStripMenuItem.ShortcutKeys = Keys.F1;
            �������ToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.T;
            �����������ToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.I;

            // ��������, ����� �������� ��������� ������
            �������ToolStripMenuItem.ShowShortcutKeys = true;
            �������ToolStripMenuItem.ShowShortcutKeys = true;
            ���������ToolStripMenuItem.ShowShortcutKeys = true;
            ������������ToolStripMenuItem.ShowShortcutKeys = true;
            ����������������ToolStripMenuItem.ShowShortcutKeys = true;
            ����������ToolStripMenuItem.ShowShortcutKeys = true;
            ��������ToolStripMenuItem.ShowShortcutKeys = true;
            �������ToolStripMenuItem.ShowShortcutKeys = true;
            �����������ToolStripMenuItem.ShowShortcutKeys = true;
            ��������ToolStripMenuItem.ShowShortcutKeys = true;
            ��������ToolStripMenuItem1.ShowShortcutKeys = true;
            �������ToolStripMenuItem.ShowShortcutKeys = true;
            ���������������ToolStripMenuItem.ShowShortcutKeys = true;
            ������������ToolStripMenuItem.ShowShortcutKeys = true;
            �����ToolStripMenuItem.ShowShortcutKeys = true;
            ����������ToolStripMenuItem.ShowShortcutKeys = true;
            �������ToolStripMenuItem.ShowShortcutKeys = true;
            �����������ToolStripMenuItem.ShowShortcutKeys = true;

        }

        // ���������� ������� "��������"
        private void ��������ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (rtfTextBox.CanUndo)
            {
                rtfTextBox.Undo();
            }
        }

        // ���������� ������� "�������"
        private void �������ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (rtfTextBox.CanRedo)
            {
                rtfTextBox.Redo();
            }
        }

        // ���������� ������� "���������"
        private void ���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveDocument();
        }

        // ���������� ������� "��������� ���"
        private void ������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveDocumentAs();
        }

        // ���������� ������� "�������"
        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDocument();
        }

        // ���������� ������� "������� ����� ��������"
        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateNewDocument();
        }

        // �������� ���������
        private void OpenDocument()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "RTF Files (*.rtf)|*.rtf|All Files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // ����������� ���� � ��������� �����
                    currentFilePath = openFileDialog.FileName;
                    rtfTextBox.LoadFile(currentFilePath, RichTextBoxStreamType.RichText);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading file: " + ex.Message);
                }
            }
        }

        // �������� ������ ���������
        private void CreateNewDocument()
        {
            // �������� ������ ������� RTF-���������
            rtfTextBox.Clear(); // ������� ����������� RichTextBox
            rtfTextBox.Rtf = "{\\rtf1}"; // ��������� ��������� RTF-���������
            currentFilePath = null; // �������� ���� � �������� �����
        }

        // ���������� ��������� �� ���������� ������ Ctrl+S
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.S))
            {
                SaveDocument();
                return true; // �������������� �������� ������� ������
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        // ���������� ���������
        private void SaveDocument()
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                SaveDocumentAs();
            }
            else
            {
                try
                {
                    rtfTextBox.SaveFile(currentFilePath, RichTextBoxStreamType.RichText);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("������ ���������� �����: " + ex.Message);
                }
            }
        }

        // ���������� ��������� � ������� ����
        private void SaveDocumentAs()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "RTF Files (*.rtf)|*.rtf|All Files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    currentFilePath = saveFileDialog.FileName;
                    rtfTextBox.SaveFile(currentFilePath, RichTextBoxStreamType.RichText);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("������ ���������� �����: " + ex.Message);
                }
            }
        }

        // ���������� ������� "����� �� ���������"
        private void ����������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // ����� �� ���������9
        }

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtfTextBox.Copy(); // ����������� ������
        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtfTextBox.Paste(); // ������� ������
        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(rtfTextBox.SelectedText))
            {
                rtfTextBox.SelectedText = ""; // �������� ����������� ������
            }
        }

        private void �����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtfTextBox.SelectAll(); // ��������� ����� ������
        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtfTextBox.Cut(); // �������� ���� �����
        }

        private void ���������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ����������� �������� WordWrap ���������� RichTextBox
            rtfTextBox.WordWrap = !rtfTextBox.WordWrap;

            // ��������� ��������� ������ ����
            ���������������ToolStripMenuItem.Checked = rtfTextBox.WordWrap;
        }

        private void ������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string searchWord = searchTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(searchWord))
            {
                HighlightSearchResults(searchWord);
            }
        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtfTextBox.SelectionLength > 0)
            {
                using (FontDialog fontDialog = new FontDialog())
                {
                    fontDialog.ShowColor = true;

                    // ������������� ������� ����� � ���� � ������� ������ ������
                    if (rtfTextBox.SelectionFont != null)
                    {
                        fontDialog.Font = rtfTextBox.SelectionFont;
                    }
                    if (rtfTextBox.SelectionColor != null)
                    {
                        fontDialog.Color = rtfTextBox.SelectionColor;
                    }

                    // ��������� ������ ������ ������
                    if (fontDialog.ShowDialog() == DialogResult.OK)
                    {
                        // ��������� ��������� ����� � ���� � ����������� ������
                        rtfTextBox.SelectionFont = fontDialog.Font;
                        rtfTextBox.SelectionColor = fontDialog.Color;
                    }
                }
            }
            else
            {
                // ������� ��������� �� ������
                MessageBox.Show("��� ��������� ������ ���������� ������� �������� ���.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ����� ��� ��������� ����������� ������
        private void HighlightSearchResults(string searchWord)
        {
            int startIndex = 0;
            rtfTextBox.SelectionBackColor = rtfTextBox.BackColor; // ����� ����������� ���������

            while (startIndex < rtfTextBox.Text.Length)
            {
                int wordStartIndex = rtfTextBox.Find(searchWord, startIndex, RichTextBoxFinds.None);
                if (wordStartIndex != -1)
                {
                    rtfTextBox.Select(wordStartIndex, searchWord.Length);
                    rtfTextBox.SelectionBackColor = Color.Yellow; // ��������� ������
                    startIndex = wordStartIndex + searchWord.Length;
                }
                else
                {
                    break;
                }
            }

            rtfTextBox.DeselectAll();
        }

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("��������� ���� ����������� �������� ������ 2����22, �������� ����������.\n���� �������� ���������: 10.04.2024 \n���� ��� ��������� � ������������������ ��������� ������ �� ����� ��������� (bskabikank@mail.ru)", "�������");
        }

        private void �����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertImage();
        }

        // ����� ��� ������� �����������
        private void InsertImage()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif;*.tif;*.tiff";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image img = Image.FromFile(openFileDialog.FileName);
                    currentImage = img;
                    InsertTransformedImage(currentImage);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("������ ��� ������� �����������: " + ex.Message);
                }
            }
        }

        // ����� ��� ������� ���������������� ����������� � RichTextBox
        private void InsertTransformedImage(Image image)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    // ���������� ����������� � MemoryStream � ������� PNG
                    image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    byte[] imageBytes = ms.ToArray();

                    // �������� RTF-���� ��� ������� �����������
                    StringBuilder rtf = new StringBuilder();
                    rtf.Append(@"{\rtf1\ansi\ansicpg1251{\pict\pngblip\picw");
                    rtf.Append(image.Width * 15); // ������ � ��������, ������������ � RTF (1/20 �����)
                    rtf.Append(@"\pich");
                    rtf.Append(image.Height * 15); // ������ � ��������, ������������ � RTF (1/20 �����)
                    rtf.Append(" ");
                    foreach (byte b in imageBytes)
                    {
                        rtf.Append(b.ToString("x2"));
                    }
                    rtf.Append("}}");

                    // ������� ����������� � RichTextBox
                    rtfTextBox.SelectedRtf = rtf.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("������ ��� ������� �����������: " + ex.Message);
            }
        }

        private void ��������������ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (dataGridView == null || dataGridView.Columns.Count == 0)
            {
                MessageBox.Show("������� ����� �������� ���� �� ���� �������!", "��������������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // ���������� ���������� ������, ���� �������� ���
            }
            // ��������� ������ � DataGridView
            dataGridView.Rows.Add();
        }

        private void ���������������ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // ��������� ������� � DataGridView
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            dataGridView.Columns.Add(column);
        }

        private void ��������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView != null)
            {
                this.Controls.Remove(dataGridView);
                dataGridView.Dispose();
                dataGridView = null;
            }
        }

        private void ���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView != null)
            {
                dataGridView.Width += 50; // ����������� ������ �� 50 ��������
                dataGridView.Height += 50; // ����������� ������ �� 50 ��������
            }
        }

        private void ���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView != null)
            {
                dataGridView.Width = Math.Max(50, dataGridView.Width - 50); // ��������� ������ �� 50 ��������, �� �� ������ 50 ��������
                dataGridView.Height = Math.Max(50, dataGridView.Height - 50); // ��������� ������ �� 50 ��������, �� �� ������ 50 ��������
            }
        }
    }
}