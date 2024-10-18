namespace zd_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            AddButton = new Button();
            SearchButton = new Button();
            EditButton = new Button();
            DeleteButton = new Button();
            listBoxBooks = new ListBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.BackColor = SystemColors.ActiveBorder;
            AddButton.Location = new Point(12, 12);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(122, 41);
            AddButton.TabIndex = 0;
            AddButton.Text = "Добавить книгу";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // SearchButton
            // 
            SearchButton.BackColor = SystemColors.ActiveBorder;
            SearchButton.Location = new Point(140, 12);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(119, 41);
            SearchButton.TabIndex = 1;
            SearchButton.Text = "Найти книгу";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // EditButton
            // 
            EditButton.BackColor = SystemColors.ActiveBorder;
            EditButton.Location = new Point(390, 12);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(119, 41);
            EditButton.TabIndex = 2;
            EditButton.Text = "Редактировать";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = SystemColors.ActiveBorder;
            DeleteButton.Location = new Point(265, 12);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(119, 41);
            DeleteButton.TabIndex = 3;
            DeleteButton.Text = "Удалить книгу";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // listBoxBooks
            // 
            listBoxBooks.BackColor = SystemColors.ActiveBorder;
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.ItemHeight = 15;
            listBoxBooks.Location = new Point(244, 59);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(265, 289);
            listBoxBooks.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ActiveBorder;
            textBox1.Location = new Point(12, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(226, 23);
            textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(528, 361);
            Controls.Add(textBox1);
            Controls.Add(listBoxBooks);
            Controls.Add(DeleteButton);
            Controls.Add(EditButton);
            Controls.Add(SearchButton);
            Controls.Add(AddButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Library";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddButton;
        private Button SearchButton;
        private Button EditButton;
        private Button DeleteButton;
        private ListBox listBoxBooks;
        private TextBox textBox1;
    }
}
