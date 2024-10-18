namespace zd_1
{
    partial class zd_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(zd_1));
            dateTimePicker1 = new DateTimePicker();
            FirstNametxt = new TextBox();
            DepartmentTxt = new TextBox();
            Positiontxt = new TextBox();
            LastNametxt = new TextBox();
            Salarytxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            AddButton = new Button();
            DeleteButton = new Button();
            EditButton = new Button();
            txtEmployeeID = new TextBox();
            label6 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // FirstNametxt
            // 
            FirstNametxt.Location = new Point(12, 76);
            FirstNametxt.Name = "FirstNametxt";
            FirstNametxt.Size = new Size(100, 23);
            FirstNametxt.TabIndex = 1;
            // 
            // DepartmentTxt
            // 
            DepartmentTxt.Location = new Point(12, 131);
            DepartmentTxt.Name = "DepartmentTxt";
            DepartmentTxt.Size = new Size(100, 23);
            DepartmentTxt.TabIndex = 2;
            // 
            // Positiontxt
            // 
            Positiontxt.Location = new Point(150, 131);
            Positiontxt.Name = "Positiontxt";
            Positiontxt.Size = new Size(102, 23);
            Positiontxt.TabIndex = 3;
            // 
            // LastNametxt
            // 
            LastNametxt.Location = new Point(150, 76);
            LastNametxt.Name = "LastNametxt";
            LastNametxt.Size = new Size(100, 23);
            LastNametxt.TabIndex = 4;
            // 
            // Salarytxt
            // 
            Salarytxt.Location = new Point(12, 182);
            Salarytxt.Name = "Salarytxt";
            Salarytxt.Size = new Size(100, 23);
            Salarytxt.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 58);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 6;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(150, 58);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 7;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(148, 113);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 8;
            label3.Text = "Должность";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 113);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 9;
            label4.Text = "Отдел";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 164);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 10;
            label5.Text = "Зарплата";
            // 
            // AddButton
            // 
            AddButton.Location = new Point(300, 14);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(119, 23);
            AddButton.TabIndex = 11;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(517, 14);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(119, 23);
            DeleteButton.TabIndex = 12;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(726, 12);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(119, 23);
            EditButton.TabIndex = 13;
            EditButton.Text = "Редактировать";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Location = new Point(300, 482);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.Size = new Size(104, 23);
            txtEmployeeID.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(300, 464);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 16;
            label6.Text = "ID сотрудника";
            // 
            // button1
            // 
            button1.Location = new Point(904, 14);
            button1.Name = "button1";
            button1.Size = new Size(119, 23);
            button1.TabIndex = 17;
            button1.Text = "Отобразить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(300, 43);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(730, 403);
            dataGridView1.TabIndex = 18;
            // 
            // zd_1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1035, 517);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(txtEmployeeID);
            Controls.Add(EditButton);
            Controls.Add(DeleteButton);
            Controls.Add(AddButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Salarytxt);
            Controls.Add(LastNametxt);
            Controls.Add(Positiontxt);
            Controls.Add(DepartmentTxt);
            Controls.Add(FirstNametxt);
            Controls.Add(dateTimePicker1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "zd_1";
            Text = "Human Resources Department";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private TextBox FirstNametxt;
        private TextBox DepartmentTxt;
        private TextBox Positiontxt;
        private TextBox LastNametxt;
        private TextBox Salarytxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button AddButton;
        private Button DeleteButton;
        private Button EditButton;
        private TextBox txtEmployeeID;
        private Label label6;
        private Button button1;
        private DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
