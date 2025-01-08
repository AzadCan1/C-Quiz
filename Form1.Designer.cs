namespace Quiz
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
            comboBox1 = new ComboBox();
            label2 = new Label();
            ScoreList = new ListBox();
            textBox1 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            comboBox3 = new ComboBox();
            label5 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Flaggen, Land", "Flaggen, Huaptstadt", "Land, Haupstadtadt", "Land, Flagge", "Hauptstadt, Flagge", "Hauptstadt, Land" });
            comboBox1.Location = new Point(128, 351);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 354);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 10;
            label2.Text = "QuizWählen";
            // 
            // ScoreList
            // 
            ScoreList.FormattingEnabled = true;
            ScoreList.ItemHeight = 15;
            ScoreList.Location = new Point(532, 61);
            ScoreList.Name = "ScoreList";
            ScoreList.Size = new Size(212, 304);
            ScoreList.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(129, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(120, 23);
            textBox1.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(129, 127);
            button1.Name = "button1";
            button1.Size = new Size(120, 23);
            button1.TabIndex = 13;
            button1.Text = "Speichern";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 52);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 14;
            label3.Text = "Spielername";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 131);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 15;
            label4.Text = "SpielerSpeichern";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(128, 271);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 274);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 17;
            label5.Text = "SpielerWählen";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(129, 86);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(120, 23);
            textBox2.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(comboBox3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(ScoreList);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBox1;
        private Label label1;
        private ComboBox comboBox2;
        private Label label2;
        private ListBox ScoreList;
        private TextBox textBox1;
        private Button button1;
        private Label label3;
        private Label label4;
        private ComboBox comboBox3;
        private Label label5;
        private TextBox textBox2;
    }
}
