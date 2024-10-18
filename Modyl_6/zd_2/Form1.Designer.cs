namespace zd_2
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
            DeleteButton = new Button();
            UpdateButton = new Button();
            listBoxTasks = new ListBox();
            DueDatePicker = new DateTimePicker();
            TaskNameTxt = new TextBox();
            TaskDescriptionTxt = new TextBox();
            TaskIDTxt = new TextBox();
            IsCompletedCheckBox = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.BackColor = SystemColors.Info;
            AddButton.Location = new Point(12, 2);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 23);
            AddButton.TabIndex = 0;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = SystemColors.Info;
            DeleteButton.Location = new Point(118, 2);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(75, 23);
            DeleteButton.TabIndex = 1;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.BackColor = SystemColors.Info;
            UpdateButton.Location = new Point(217, 2);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(119, 23);
            UpdateButton.TabIndex = 2;
            UpdateButton.Text = "Обновить задачу";
            UpdateButton.UseVisualStyleBackColor = false;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // listBoxTasks
            // 
            listBoxTasks.BackColor = SystemColors.Info;
            listBoxTasks.FormattingEnabled = true;
            listBoxTasks.ItemHeight = 15;
            listBoxTasks.Location = new Point(12, 31);
            listBoxTasks.Name = "listBoxTasks";
            listBoxTasks.Size = new Size(471, 229);
            listBoxTasks.TabIndex = 3;
            // 
            // DueDatePicker
            // 
            DueDatePicker.Location = new Point(12, 332);
            DueDatePicker.Name = "DueDatePicker";
            DueDatePicker.Size = new Size(269, 23);
            DueDatePicker.TabIndex = 4;
            // 
            // TaskNameTxt
            // 
            TaskNameTxt.BackColor = SystemColors.Info;
            TaskNameTxt.Location = new Point(12, 281);
            TaskNameTxt.Name = "TaskNameTxt";
            TaskNameTxt.Size = new Size(117, 23);
            TaskNameTxt.TabIndex = 5;
            // 
            // TaskDescriptionTxt
            // 
            TaskDescriptionTxt.BackColor = SystemColors.Info;
            TaskDescriptionTxt.Location = new Point(200, 281);
            TaskDescriptionTxt.Name = "TaskDescriptionTxt";
            TaskDescriptionTxt.Size = new Size(100, 23);
            TaskDescriptionTxt.TabIndex = 6;
            // 
            // TaskIDTxt
            // 
            TaskIDTxt.BackColor = SystemColors.Info;
            TaskIDTxt.Location = new Point(383, 281);
            TaskIDTxt.Name = "TaskIDTxt";
            TaskIDTxt.Size = new Size(100, 23);
            TaskIDTxt.TabIndex = 7;
            // 
            // IsCompletedCheckBox
            // 
            IsCompletedCheckBox.AutoSize = true;
            IsCompletedCheckBox.BackColor = SystemColors.InactiveCaptionText;
            IsCompletedCheckBox.Location = new Point(489, 49);
            IsCompletedCheckBox.Name = "IsCompletedCheckBox";
            IsCompletedCheckBox.Size = new Size(15, 14);
            IsCompletedCheckBox.TabIndex = 8;
            IsCompletedCheckBox.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Info;
            label1.Location = new Point(12, 263);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 9;
            label1.Text = "Название задачи";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Info;
            label2.Location = new Point(198, 263);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 10;
            label2.Text = "Описание задачи";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Info;
            label3.Location = new Point(12, 314);
            label3.Name = "label3";
            label3.Size = new Size(269, 15);
            label3.TabIndex = 11;
            label3.Text = "Дата к которой задача должна быть выполнена";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Info;
            label4.Location = new Point(489, 31);
            label4.Name = "label4";
            label4.Size = new Size(117, 15);
            label4.TabIndex = 12;
            label4.Text = "Выполнение задачи";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Info;
            label5.Location = new Point(383, 263);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 13;
            label5.Text = "Ввод ID";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Location = new Point(355, 2);
            button1.Name = "button1";
            button1.Size = new Size(128, 23);
            button1.TabIndex = 14;
            button1.Text = "Обновить таблицу";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(607, 363);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(IsCompletedCheckBox);
            Controls.Add(TaskIDTxt);
            Controls.Add(TaskDescriptionTxt);
            Controls.Add(TaskNameTxt);
            Controls.Add(DueDatePicker);
            Controls.Add(listBoxTasks);
            Controls.Add(UpdateButton);
            Controls.Add(DeleteButton);
            Controls.Add(AddButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Tasks";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddButton;
        private Button DeleteButton;
        private Button UpdateButton;
        private ListBox listBoxTasks;
        private DateTimePicker DueDatePicker;
        private TextBox TaskNameTxt;
        private TextBox TaskDescriptionTxt;
        private TextBox TaskIDTxt;
        private CheckBox IsCompletedCheckBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
    }
}
