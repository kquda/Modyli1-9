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
            button1 = new Button();
            txtPrice = new TextBox();
            txtStock = new TextBox();
            txtParam1 = new TextBox();
            txtParam2 = new TextBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Location = new Point(3, 77);
            button1.Name = "button1";
            button1.Size = new Size(121, 33);
            button1.TabIndex = 0;
            button1.Text = "Кнопка";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(412, 377);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(121, 23);
            txtPrice.TabIndex = 1;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(667, 377);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(121, 23);
            txtStock.TabIndex = 2;
            // 
            // txtParam1
            // 
            txtParam1.Location = new Point(163, 33);
            txtParam1.Name = "txtParam1";
            txtParam1.Size = new Size(124, 23);
            txtParam1.TabIndex = 3;
            // 
            // txtParam2
            // 
            txtParam2.Location = new Point(163, 87);
            txtParam2.Name = "txtParam2";
            txtParam2.Size = new Size(124, 23);
            txtParam2.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(3, 33);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 15);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 6;
            label1.Text = "Выбор товара";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(412, 359);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 7;
            label2.Text = "Стоимость товара";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(667, 359);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 8;
            label3.Text = "Остаток товара";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(163, 15);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 9;
            label4.Text = "Ввод цены";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(163, 69);
            label5.Name = "label5";
            label5.Size = new Size(124, 15);
            label5.TabIndex = 10;
            label5.Text = "Ввод остатока товара";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 412);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(txtParam2);
            Controls.Add(txtParam1);
            Controls.Add(txtStock);
            Controls.Add(txtPrice);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Food_Shop";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtPrice;
        private TextBox txtStock;
        private TextBox txtParam1;
        private TextBox txtParam2;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
