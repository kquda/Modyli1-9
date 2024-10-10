namespace zd_1
{
    partial class Figure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Figure));
            comboBox1 = new ComboBox();
            label1 = new Label();
            txtParam1 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            txtArea = new TextBox();
            txtPerimeter = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtParam2 = new TextBox();
            txtParam3 = new TextBox();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 27);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 1;
            label1.Text = "Выбор фигуры";
            // 
            // txtParam1
            // 
            txtParam1.Location = new Point(153, 27);
            txtParam1.Name = "txtParam1";
            txtParam1.Size = new Size(161, 23);
            txtParam1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 9);
            label2.Name = "label2";
            label2.Size = new Size(161, 15);
            label2.TabIndex = 3;
            label2.Text = "Поле для ввода параметров";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Location = new Point(353, 26);
            button1.Name = "button1";
            button1.Size = new Size(104, 23);
            button1.TabIndex = 4;
            button1.Text = "Вычислить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtArea
            // 
            txtArea.Location = new Point(353, 80);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(104, 23);
            txtArea.TabIndex = 5;
            // 
            // txtPerimeter
            // 
            txtPerimeter.Location = new Point(353, 133);
            txtPerimeter.Name = "txtPerimeter";
            txtPerimeter.Size = new Size(104, 23);
            txtPerimeter.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(353, 62);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 7;
            label3.Text = "Площадь";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(353, 115);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 8;
            label4.Text = "Периметр";
            // 
            // txtParam2
            // 
            txtParam2.Location = new Point(153, 59);
            txtParam2.Name = "txtParam2";
            txtParam2.Size = new Size(161, 23);
            txtParam2.TabIndex = 9;
            // 
            // txtParam3
            // 
            txtParam3.Location = new Point(153, 88);
            txtParam3.Name = "txtParam3";
            txtParam3.Size = new Size(161, 23);
            txtParam3.TabIndex = 10;
            // 
            // Figure
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(508, 243);
            Controls.Add(txtParam3);
            Controls.Add(txtParam2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtPerimeter);
            Controls.Add(txtArea);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(txtParam1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Figure";
            Text = "Shapes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private TextBox txtParam1;
        private Label label2;
        private Button button1;
        private TextBox txtArea;
        private TextBox txtPerimeter;
        private Label label3;
        private Label label4;
        private TextBox txtParam2;
        private TextBox txtParam3;
    }
}
