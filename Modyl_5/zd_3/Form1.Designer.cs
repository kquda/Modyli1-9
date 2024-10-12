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
            buttonAdd = new Button();
            buttonDel = new Button();
            buttonComplete = new Button();
            listBox = new ListBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = SystemColors.Info;
            buttonAdd.Location = new Point(12, 12);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(95, 45);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDel
            // 
            buttonDel.BackColor = SystemColors.Info;
            buttonDel.Location = new Point(128, 15);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(95, 42);
            buttonDel.TabIndex = 1;
            buttonDel.Text = "Удалить";
            buttonDel.UseVisualStyleBackColor = false;
            buttonDel.Click += buttonDel_Click;
            // 
            // buttonComplete
            // 
            buttonComplete.BackColor = SystemColors.Info;
            buttonComplete.Location = new Point(242, 15);
            buttonComplete.Name = "buttonComplete";
            buttonComplete.Size = new Size(95, 42);
            buttonComplete.TabIndex = 2;
            buttonComplete.Text = "Отметить как выполнено";
            buttonComplete.UseVisualStyleBackColor = false;
            buttonComplete.Click += buttonComplete_Click;
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Location = new Point(392, 130);
            listBox.Name = "listBox";
            listBox.Size = new Size(265, 199);
            listBox.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            textBox1.Location = new Point(12, 144);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(325, 23);
            textBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 118);
            label1.Name = "label1";
            label1.Size = new Size(123, 23);
            label1.TabIndex = 5;
            label1.Text = "Ввод  задачи";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(392, 107);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 6;
            label2.Text = "Список задач";
            // 
            // buttonExit
            // 
            buttonExit.BackColor = SystemColors.Info;
            buttonExit.Location = new Point(354, 15);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(95, 42);
            buttonExit.TabIndex = 7;
            buttonExit.Text = "Выход";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonExit);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(listBox);
            Controls.Add(buttonComplete);
            Controls.Add(buttonDel);
            Controls.Add(buttonAdd);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task Accounting";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAdd;
        private Button buttonDel;
        private Button buttonComplete;
        private ListBox listBox;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Button buttonExit;
    }
}
