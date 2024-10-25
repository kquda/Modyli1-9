namespace Rtf_Documents
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьКакToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            создатьToolStripMenuItem = new ToolStripMenuItem();
            выходИзПрограммыToolStripMenuItem = new ToolStripMenuItem();
            вставкаToolStripMenuItem = new ToolStripMenuItem();
            таблицаToolStripMenuItem = new ToolStripMenuItem();
            добавитьСтрокуToolStripMenuItem = new ToolStripMenuItem();
            добавитьСтолбецToolStripMenuItem = new ToolStripMenuItem();
            удалитьТаблицуToolStripMenuItem = new ToolStripMenuItem();
            изображениеToolStripMenuItem = new ToolStripMenuItem();
            правкаToolStripMenuItem = new ToolStripMenuItem();
            отменитьToolStripMenuItem1 = new ToolStripMenuItem();
            копироватьToolStripMenuItem = new ToolStripMenuItem();
            вставитьToolStripMenuItem = new ToolStripMenuItem();
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            выделитьВсеToolStripMenuItem = new ToolStripMenuItem();
            вернутьToolStripMenuItem = new ToolStripMenuItem();
            вырезатьToolStripMenuItem = new ToolStripMenuItem();
            форматToolStripMenuItem = new ToolStripMenuItem();
            переносПоСловамToolStripMenuItem = new ToolStripMenuItem();
            поискПоСловуToolStripMenuItem = new ToolStripMenuItem();
            searchTextBox = new ToolStripTextBox();
            шрифтToolStripMenuItem = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            rtfTextBox = new RichTextBox();
            toolTip1 = new ToolTip(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            изменитьРазмерыToolStripMenuItem = new ToolStripMenuItem();
            увеличитьToolStripMenuItem = new ToolStripMenuItem();
            уменьшитьToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, вставкаToolStripMenuItem, правкаToolStripMenuItem, форматToolStripMenuItem, справкаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1287, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { сохранитьToolStripMenuItem, сохранитьКакToolStripMenuItem, открытьToolStripMenuItem, создатьToolStripMenuItem, выходИзПрограммыToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(48, 20);
            fileToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(193, 22);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            сохранитьToolStripMenuItem.Click += сохранитьToolStripMenuItem_Click;
            // 
            // сохранитьКакToolStripMenuItem
            // 
            сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            сохранитьКакToolStripMenuItem.Size = new Size(193, 22);
            сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            сохранитьКакToolStripMenuItem.Click += сохранитьКакToolStripMenuItem_Click;
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(193, 22);
            открытьToolStripMenuItem.Text = "Открыть";
            открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
            // 
            // создатьToolStripMenuItem
            // 
            создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            создатьToolStripMenuItem.Size = new Size(193, 22);
            создатьToolStripMenuItem.Text = "Создать";
            создатьToolStripMenuItem.Click += создатьToolStripMenuItem_Click;
            // 
            // выходИзПрограммыToolStripMenuItem
            // 
            выходИзПрограммыToolStripMenuItem.Name = "выходИзПрограммыToolStripMenuItem";
            выходИзПрограммыToolStripMenuItem.Size = new Size(193, 22);
            выходИзПрограммыToolStripMenuItem.Text = "Выход из программы";
            выходИзПрограммыToolStripMenuItem.Click += выходИзПрограммыToolStripMenuItem_Click;
            // 
            // вставкаToolStripMenuItem
            // 
            вставкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { таблицаToolStripMenuItem, изображениеToolStripMenuItem });
            вставкаToolStripMenuItem.Name = "вставкаToolStripMenuItem";
            вставкаToolStripMenuItem.Size = new Size(61, 20);
            вставкаToolStripMenuItem.Text = "Вставка";
            // 
            // таблицаToolStripMenuItem
            // 
            таблицаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { добавитьСтрокуToolStripMenuItem, добавитьСтолбецToolStripMenuItem, удалитьТаблицуToolStripMenuItem, изменитьРазмерыToolStripMenuItem });
            таблицаToolStripMenuItem.Name = "таблицаToolStripMenuItem";
            таблицаToolStripMenuItem.Size = new Size(180, 22);
            таблицаToolStripMenuItem.Text = "Таблица";
            // 
            // добавитьСтрокуToolStripMenuItem
            // 
            добавитьСтрокуToolStripMenuItem.Name = "добавитьСтрокуToolStripMenuItem";
            добавитьСтрокуToolStripMenuItem.Size = new Size(180, 22);
            добавитьСтрокуToolStripMenuItem.Text = "Добавить строку";
            добавитьСтрокуToolStripMenuItem.Click += добавитьСтрокуToolStripMenuItem_Click_1;
            // 
            // добавитьСтолбецToolStripMenuItem
            // 
            добавитьСтолбецToolStripMenuItem.Name = "добавитьСтолбецToolStripMenuItem";
            добавитьСтолбецToolStripMenuItem.Size = new Size(180, 22);
            добавитьСтолбецToolStripMenuItem.Text = "Добавить столбец";
            добавитьСтолбецToolStripMenuItem.Click += добавитьСтолбецToolStripMenuItem_Click_1;
            // 
            // удалитьТаблицуToolStripMenuItem
            // 
            удалитьТаблицуToolStripMenuItem.Name = "удалитьТаблицуToolStripMenuItem";
            удалитьТаблицуToolStripMenuItem.Size = new Size(180, 22);
            удалитьТаблицуToolStripMenuItem.Text = "Удалить таблицу";
            удалитьТаблицуToolStripMenuItem.Click += удалитьТаблицуToolStripMenuItem_Click;
            // 
            // изображениеToolStripMenuItem
            // 
            изображениеToolStripMenuItem.Name = "изображениеToolStripMenuItem";
            изображениеToolStripMenuItem.Size = new Size(180, 22);
            изображениеToolStripMenuItem.Text = "Изображение";
            изображениеToolStripMenuItem.Click += изображениеToolStripMenuItem_Click;
            // 
            // правкаToolStripMenuItem
            // 
            правкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { отменитьToolStripMenuItem1, копироватьToolStripMenuItem, вставитьToolStripMenuItem, удалитьToolStripMenuItem, выделитьВсеToolStripMenuItem, вернутьToolStripMenuItem, вырезатьToolStripMenuItem });
            правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            правкаToolStripMenuItem.Size = new Size(59, 20);
            правкаToolStripMenuItem.Text = "Правка";
            // 
            // отменитьToolStripMenuItem1
            // 
            отменитьToolStripMenuItem1.Name = "отменитьToolStripMenuItem1";
            отменитьToolStripMenuItem1.Size = new Size(180, 22);
            отменитьToolStripMenuItem1.Text = "Отменить";
            отменитьToolStripMenuItem1.Click += отменитьToolStripMenuItem1_Click;
            // 
            // копироватьToolStripMenuItem
            // 
            копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            копироватьToolStripMenuItem.Size = new Size(180, 22);
            копироватьToolStripMenuItem.Text = "Копировать";
            копироватьToolStripMenuItem.Click += копироватьToolStripMenuItem_Click;
            // 
            // вставитьToolStripMenuItem
            // 
            вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            вставитьToolStripMenuItem.Size = new Size(180, 22);
            вставитьToolStripMenuItem.Text = "Вставить";
            вставитьToolStripMenuItem.Click += вставитьToolStripMenuItem_Click;
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(180, 22);
            удалитьToolStripMenuItem.Text = "Удалить";
            удалитьToolStripMenuItem.Click += удалитьToolStripMenuItem_Click;
            // 
            // выделитьВсеToolStripMenuItem
            // 
            выделитьВсеToolStripMenuItem.Name = "выделитьВсеToolStripMenuItem";
            выделитьВсеToolStripMenuItem.Size = new Size(180, 22);
            выделитьВсеToolStripMenuItem.Text = "Выделить все";
            выделитьВсеToolStripMenuItem.Click += выделитьВсеToolStripMenuItem_Click;
            // 
            // вернутьToolStripMenuItem
            // 
            вернутьToolStripMenuItem.Name = "вернутьToolStripMenuItem";
            вернутьToolStripMenuItem.Size = new Size(180, 22);
            вернутьToolStripMenuItem.Text = "Вернуть";
            вернутьToolStripMenuItem.Click += вернутьToolStripMenuItem_Click_1;
            // 
            // вырезатьToolStripMenuItem
            // 
            вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            вырезатьToolStripMenuItem.Size = new Size(180, 22);
            вырезатьToolStripMenuItem.Text = "Вырезать";
            вырезатьToolStripMenuItem.Click += вырезатьToolStripMenuItem_Click;
            // 
            // форматToolStripMenuItem
            // 
            форматToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { переносПоСловамToolStripMenuItem, поискПоСловуToolStripMenuItem, шрифтToolStripMenuItem });
            форматToolStripMenuItem.Name = "форматToolStripMenuItem";
            форматToolStripMenuItem.Size = new Size(62, 20);
            форматToolStripMenuItem.Text = "Формат";
            // 
            // переносПоСловамToolStripMenuItem
            // 
            переносПоСловамToolStripMenuItem.Name = "переносПоСловамToolStripMenuItem";
            переносПоСловамToolStripMenuItem.Size = new Size(183, 22);
            переносПоСловамToolStripMenuItem.Text = "Перенос по словам";
            переносПоСловамToolStripMenuItem.Click += переносПоСловамToolStripMenuItem_Click;
            // 
            // поискПоСловуToolStripMenuItem
            // 
            поискПоСловуToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { searchTextBox });
            поискПоСловуToolStripMenuItem.Name = "поискПоСловуToolStripMenuItem";
            поискПоСловуToolStripMenuItem.Size = new Size(183, 22);
            поискПоСловуToolStripMenuItem.Text = "Поиск по слову";
            поискПоСловуToolStripMenuItem.ToolTipText = "Чтобы убрать выделение нужно нажать сочетание клавиш Ctrl + Z";
            поискПоСловуToolStripMenuItem.Click += поискПоСловуToolStripMenuItem_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(100, 23);
            // 
            // шрифтToolStripMenuItem
            // 
            шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            шрифтToolStripMenuItem.Size = new Size(183, 22);
            шрифтToolStripMenuItem.Text = "Шрифт";
            шрифтToolStripMenuItem.Click += шрифтToolStripMenuItem_Click;
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { оПрограммеToolStripMenuItem });
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(65, 20);
            справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(149, 22);
            оПрограммеToolStripMenuItem.Text = "О программе";
            оПрограммеToolStripMenuItem.Click += оПрограммеToolStripMenuItem_Click;
            // 
            // rtfTextBox
            // 
            rtfTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtfTextBox.Location = new Point(0, 27);
            rtfTextBox.Name = "rtfTextBox";
            rtfTextBox.Size = new Size(1287, 706);
            rtfTextBox.TabIndex = 1;
            rtfTextBox.Text = "";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // изменитьРазмерыToolStripMenuItem
            // 
            изменитьРазмерыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { увеличитьToolStripMenuItem, уменьшитьToolStripMenuItem });
            изменитьРазмерыToolStripMenuItem.Name = "изменитьРазмерыToolStripMenuItem";
            изменитьРазмерыToolStripMenuItem.Size = new Size(180, 22);
            изменитьРазмерыToolStripMenuItem.Text = "Изменить размеры";
            // 
            // увеличитьToolStripMenuItem
            // 
            увеличитьToolStripMenuItem.Name = "увеличитьToolStripMenuItem";
            увеличитьToolStripMenuItem.Size = new Size(180, 22);
            увеличитьToolStripMenuItem.Text = "Увеличить";
            увеличитьToolStripMenuItem.Click += увеличитьToolStripMenuItem_Click;
            // 
            // уменьшитьToolStripMenuItem
            // 
            уменьшитьToolStripMenuItem.Name = "уменьшитьToolStripMenuItem";
            уменьшитьToolStripMenuItem.Size = new Size(180, 22);
            уменьшитьToolStripMenuItem.Text = "Уменьшить";
            уменьшитьToolStripMenuItem.Click += уменьшитьToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1287, 733);
            Controls.Add(rtfTextBox);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(549, 306);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ERD";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private RichTextBox rtfTextBox;
        private ToolStripMenuItem вставкаToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem создатьToolStripMenuItem;
        private ToolStripMenuItem правкаToolStripMenuItem;
        private ToolStripMenuItem таблицаToolStripMenuItem;
        private ToolStripMenuItem изображениеToolStripMenuItem;
        private ToolStripMenuItem отменитьToolStripMenuItem1;
        private ToolStripMenuItem копироватьToolStripMenuItem;
        private ToolStripMenuItem вставитьToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ToolStripMenuItem выделитьВсеToolStripMenuItem;
        private ToolStripMenuItem форматToolStripMenuItem;
        private ToolStripMenuItem переносПоСловамToolStripMenuItem;
        private ToolStripMenuItem поискПоСловуToolStripMenuItem;
        private ToolStripMenuItem шрифтToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private ToolStripMenuItem вернутьToolStripMenuItem;
        private ToolStripMenuItem выходИзПрограммыToolStripMenuItem;
        private ToolStripMenuItem вырезатьToolStripMenuItem;
        private ToolStripTextBox searchTextBox;
        private ToolTip toolTip1;
        private ToolStripMenuItem добавитьСтрокуToolStripMenuItem;
        private ToolStripMenuItem добавитьСтолбецToolStripMenuItem;
        private ToolStripMenuItem удалитьТаблицуToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem изменитьРазмерыToolStripMenuItem;
        private ToolStripMenuItem увеличитьToolStripMenuItem;
        private ToolStripMenuItem уменьшитьToolStripMenuItem;
    }
}
