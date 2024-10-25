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
namespace Rtf_Documents // Макарчик В.В
{
    public partial class Form1 : Form
    {
        private string currentFilePath = null; // Поле для хранения пути к текущему файлу
        private Image currentImage;
        private DataGridView dataGridView;
        private ContextMenuStrip contextMenuStripRichTextBox;


        public Form1()
        {
            InitializeComponent();
            InitializeShortcuts();

            dataGridView = new DataGridView();
            dataGridView.AutoGenerateColumns = true;
            dataGridView.Visible = false; // Скрыть DataGridView по умолчанию

            // Создание ContextMenuStrip для RichTextBox
            contextMenuStripRichTextBox = new ContextMenuStrip();
            ToolStripMenuItem добавитьDataGridViewItem = new ToolStripMenuItem("Добавить DataGridView");
            добавитьDataGridViewItem.Click += ДобавитьDataGridViewItem_Click;
            contextMenuStripRichTextBox.Items.Add(добавитьDataGridViewItem);

            // Привязка ContextMenuStrip к RichTextBox
            rtfTextBox.ContextMenuStrip = contextMenuStripRichTextBox;
        }

        private void ДобавитьDataGridViewItem_Click(object sender, EventArgs e)
        {
            // Если таблица уже существует, сначала удалить её
            if (dataGridView != null)
            {
                this.Controls.Remove(dataGridView);
                dataGridView.Dispose();
            }

            // Создание нового экземпляра DataGridView
            dataGridView = new DataGridView();
            dataGridView.AutoGenerateColumns = true;
            dataGridView.Visible = true;

            // Получение позиции курсора в RichTextBox
            Point position = rtfTextBox.PointToClient(Cursor.Position);

            // Установка позиции DataGridView
            dataGridView.Location = position;

            // Добавление DataGridView на форму
            this.Controls.Add(dataGridView);

            // Перемещение DataGridView на передний план
            dataGridView.BringToFront();
        }

        // Метод для добавления столбцов в DataGridView
        private void ДобавитьСтолбецToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Добавление столбца в DataGridView
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            dataGridView.Columns.Add(column);
        }

        // Метод для добавления строк в DataGridView
        private void ДобавитьСтрокуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Добавление строки в DataGridView
            dataGridView.Rows.Add();
        }

        // Инициализация меню с пунктами для добавления строк и столбцов
        private void InitializeMenuStrip()
        {
            ToolStripMenuItem добавитьСтолбецItem = new ToolStripMenuItem("Добавить столбец");
            ToolStripMenuItem добавитьСтрокуItem = new ToolStripMenuItem("Добавить строку");

            добавитьСтолбецItem.Click += ДобавитьСтолбецToolStripMenuItem_Click;
            добавитьСтрокуItem.Click += ДобавитьСтрокуToolStripMenuItem_Click;

            menuStrip1.Items.Add(добавитьСтолбецItem);
            menuStrip1.Items.Add(добавитьСтрокуItem);
        }

        private void InitializeShortcuts()
        {
            // Настройка горячих клавиш
            создатьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            открытьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            сохранитьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            сохранитьКакToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            выходИзПрограммыToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Q;
            копироватьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            вставитьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            удалитьToolStripMenuItem.ShortcutKeys = Keys.Delete;
            выделитьВсеToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            вырезатьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            отменитьToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.Z;
            вернутьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
            переносПоСловамToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.W;
            поискПоСловуToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
            шрифтToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.T;
            оПрограммеToolStripMenuItem.ShortcutKeys = Keys.F1;
            таблицаToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.T;
            изображениеToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.I;

            // Проверка, чтобы показать сочетания клавиш
            создатьToolStripMenuItem.ShowShortcutKeys = true;
            открытьToolStripMenuItem.ShowShortcutKeys = true;
            сохранитьToolStripMenuItem.ShowShortcutKeys = true;
            сохранитьКакToolStripMenuItem.ShowShortcutKeys = true;
            выходИзПрограммыToolStripMenuItem.ShowShortcutKeys = true;
            копироватьToolStripMenuItem.ShowShortcutKeys = true;
            вставитьToolStripMenuItem.ShowShortcutKeys = true;
            удалитьToolStripMenuItem.ShowShortcutKeys = true;
            выделитьВсеToolStripMenuItem.ShowShortcutKeys = true;
            вырезатьToolStripMenuItem.ShowShortcutKeys = true;
            отменитьToolStripMenuItem1.ShowShortcutKeys = true;
            вернутьToolStripMenuItem.ShowShortcutKeys = true;
            переносПоСловамToolStripMenuItem.ShowShortcutKeys = true;
            поискПоСловуToolStripMenuItem.ShowShortcutKeys = true;
            шрифтToolStripMenuItem.ShowShortcutKeys = true;
            оПрограммеToolStripMenuItem.ShowShortcutKeys = true;
            таблицаToolStripMenuItem.ShowShortcutKeys = true;
            изображениеToolStripMenuItem.ShowShortcutKeys = true;

        }

        // Обработчик события "Отменить"
        private void отменитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (rtfTextBox.CanUndo)
            {
                rtfTextBox.Undo();
            }
        }

        // Обработчик события "Вернуть"
        private void вернутьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (rtfTextBox.CanRedo)
            {
                rtfTextBox.Redo();
            }
        }

        // Обработчик события "Сохранить"
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveDocument();
        }

        // Обработчик события "Сохранить как"
        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveDocumentAs();
        }

        // Обработчик события "Открыть"
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDocument();
        }

        // Обработчик события "Создать новый документ"
        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateNewDocument();
        }

        // Открытие документа
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
                    // Запоминание пути к открытому файлу
                    currentFilePath = openFileDialog.FileName;
                    rtfTextBox.LoadFile(currentFilePath, RichTextBoxStreamType.RichText);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading file: " + ex.Message);
                }
            }
        }

        // Создание нового документа
        private void CreateNewDocument()
        {
            // Создание нового пустого RTF-документа
            rtfTextBox.Clear(); // Очистка содержимого RichTextBox
            rtfTextBox.Rtf = "{\\rtf1}"; // Установка заголовок RTF-документа
            currentFilePath = null; // Обнуение пути к текущему файлу
        }

        // Сохранение изменений по комбинации клавиш Ctrl+S
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.S))
            {
                SaveDocument();
                return true; // Предотвращение передачи события дальше
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        // Сохранение документа
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
                    MessageBox.Show("Ошибка сохранения файла: " + ex.Message);
                }
            }
        }

        // Сохранение документа с выбором пути
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
                    MessageBox.Show("Ошибка сохранения файла: " + ex.Message);
                }
            }
        }

        // Обработчик события "Выход из программы"
        private void выходИзПрограммыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Выход из программы9
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtfTextBox.Copy(); // Копирование текста
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtfTextBox.Paste(); // Вставка текста
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(rtfTextBox.SelectedText))
            {
                rtfTextBox.SelectedText = ""; // Удаление выделенного текста
            }
        }

        private void выделитьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtfTextBox.SelectAll(); // Выделение всего текста
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtfTextBox.Cut(); // Вырезать весь текст
        }

        private void переносПоСловамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Переключаем свойство WordWrap компонента RichTextBox
            rtfTextBox.WordWrap = !rtfTextBox.WordWrap;

            // Обновляем состояние пункта меню
            переносПоСловамToolStripMenuItem.Checked = rtfTextBox.WordWrap;
        }

        private void поискПоСловуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string searchWord = searchTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(searchWord))
            {
                HighlightSearchResults(searchWord);
            }
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtfTextBox.SelectionLength > 0)
            {
                using (FontDialog fontDialog = new FontDialog())
                {
                    fontDialog.ShowColor = true;

                    // Устанавливаем текущие шрифт и цвет в диалоге выбора шрифта
                    if (rtfTextBox.SelectionFont != null)
                    {
                        fontDialog.Font = rtfTextBox.SelectionFont;
                    }
                    if (rtfTextBox.SelectionColor != null)
                    {
                        fontDialog.Color = rtfTextBox.SelectionColor;
                    }

                    // Открываем диалог выбора шрифта
                    if (fontDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Применяем выбранный шрифт и цвет к выделенному тексту
                        rtfTextBox.SelectionFont = fontDialog.Font;
                        rtfTextBox.SelectionColor = fontDialog.Color;
                    }
                }
            }
            else
            {
                // Выводим сообщение об ошибке
                MessageBox.Show("Для изменения текста необходимо сначала выделить его.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Метод для подсветки результатов поиска
        private void HighlightSearchResults(string searchWord)
        {
            int startIndex = 0;
            rtfTextBox.SelectionBackColor = rtfTextBox.BackColor; // Сброс предыдущего выделения

            while (startIndex < rtfTextBox.Text.Length)
            {
                int wordStartIndex = rtfTextBox.Find(searchWord, startIndex, RichTextBoxFinds.None);
                if (wordStartIndex != -1)
                {
                    rtfTextBox.Select(wordStartIndex, searchWord.Length);
                    rtfTextBox.SelectionBackColor = Color.Yellow; // Выделение цветом
                    startIndex = wordStartIndex + searchWord.Length;
                }
                else
                {
                    break;
                }
            }

            rtfTextBox.DeselectAll();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа была разработана учащимся группы 2ПОИТ22, Макарчик Владимиром.\nДата создания программы: 10.04.2024 \nИдеи для улучшения и усовершенствования программы писать на почту создателя (bskabikank@mail.ru)", "Памятка");
        }

        private void изображениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertImage();
        }

        // Метод для вставки изображения
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
                    MessageBox.Show("Ошибка при вставке изображения: " + ex.Message);
                }
            }
        }

        // Метод для вставки преобразованного изображения в RichTextBox
        private void InsertTransformedImage(Image image)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    // Сохранение изображения в MemoryStream в формате PNG
                    image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    byte[] imageBytes = ms.ToArray();

                    // Создание RTF-кода для вставки изображения
                    StringBuilder rtf = new StringBuilder();
                    rtf.Append(@"{\rtf1\ansi\ansicpg1251{\pict\pngblip\picw");
                    rtf.Append(image.Width * 15); // Ширина в единицах, используемых в RTF (1/20 дюйма)
                    rtf.Append(@"\pich");
                    rtf.Append(image.Height * 15); // Высота в единицах, используемых в RTF (1/20 дюйма)
                    rtf.Append(" ");
                    foreach (byte b in imageBytes)
                    {
                        rtf.Append(b.ToString("x2"));
                    }
                    rtf.Append("}}");

                    // Вставка изображения в RichTextBox
                    rtfTextBox.SelectedRtf = rtf.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при вставке изображения: " + ex.Message);
            }
        }

        private void добавитьСтрокуToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (dataGridView == null || dataGridView.Columns.Count == 0)
            {
                MessageBox.Show("Сначала нужно добавить хотя бы один столбец!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Прерывание выполнение метода, если столбцов нет
            }
            // Добавляем строку в DataGridView
            dataGridView.Rows.Add();
        }

        private void добавитьСтолбецToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Добавляем столбец в DataGridView
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            dataGridView.Columns.Add(column);
        }

        private void удалитьТаблицуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView != null)
            {
                this.Controls.Remove(dataGridView);
                dataGridView.Dispose();
                dataGridView = null;
            }
        }

        private void увеличитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView != null)
            {
                dataGridView.Width += 50; // Увеличиваем ширину на 50 пикселей
                dataGridView.Height += 50; // Увеличиваем высоту на 50 пикселей
            }
        }

        private void уменьшитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView != null)
            {
                dataGridView.Width = Math.Max(50, dataGridView.Width - 50); // Уменьшаем ширину на 50 пикселей, но не меньше 50 пикселей
                dataGridView.Height = Math.Max(50, dataGridView.Height - 50); // Уменьшаем высоту на 50 пикселей, но не меньше 50 пикселей
            }
        }
    }
}