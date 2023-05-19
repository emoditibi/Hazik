namespace Pizzazo
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
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            Feltétek = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            numericUpDown5 = new NumericUpDown();
            numericUpDown4 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.Location = new Point(14, 81);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(118, 23);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Kolbász +100";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox2.Location = new Point(14, 128);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(91, 23);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Sajt +100";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox3.Location = new Point(14, 172);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(136, 23);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Pepperoni +100";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // Feltétek
            // 
            Feltétek.AutoSize = true;
            Feltétek.BackColor = Color.Maroon;
            Feltétek.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            Feltétek.Location = new Point(14, 16);
            Feltétek.Name = "Feltétek";
            Feltétek.Size = new Size(202, 37);
            Feltétek.TabIndex = 3;
            Feltétek.Text = "Plusz Feltétek:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(Feltétek);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(checkBox3);
            panel1.Controls.Add(checkBox2);
            panel1.Location = new Point(269, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 207);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Maroon;
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(numericUpDown5);
            panel2.Controls.Add(numericUpDown4);
            panel2.Controls.Add(numericUpDown3);
            panel2.Controls.Add(numericUpDown2);
            panel2.Controls.Add(numericUpDown1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(826, 77);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 392);
            panel2.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.LightGray;
            button1.Location = new Point(180, 348);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 14;
            button1.Text = "Rendelés";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(56, 328);
            label7.Name = "label7";
            label7.Size = new Size(55, 19);
            label7.TabIndex = 13;
            label7.Text = "Hawaii";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(44, 268);
            label6.Name = "label6";
            label6.Size = new Size(76, 19);
            label6.TabIndex = 12;
            label6.Text = "Magyaros";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(44, 200);
            label5.Name = "label5";
            label5.Size = new Size(77, 19);
            label5.TabIndex = 11;
            label5.Text = "Húsimádó";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(51, 128);
            label4.Name = "label4";
            label4.Size = new Size(70, 19);
            label4.TabIndex = 10;
            label4.Text = "SonGoKu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(44, 61);
            label3.Name = "label3";
            label3.Size = new Size(84, 19);
            label3.TabIndex = 9;
            label3.Text = "Margherita";
            // 
            // numericUpDown5
            // 
            numericUpDown5.Location = new Point(25, 350);
            numericUpDown5.Name = "numericUpDown5";
            numericUpDown5.Size = new Size(120, 23);
            numericUpDown5.TabIndex = 8;
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(25, 290);
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(120, 23);
            numericUpDown4.TabIndex = 7;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(25, 222);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(120, 23);
            numericUpDown3.TabIndex = 6;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(25, 152);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(25, 83);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 16);
            label1.Name = "label1";
            label1.Size = new Size(106, 37);
            label1.TabIndex = 3;
            label1.Text = "Pizzák:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(615, 25);
            label2.Name = "label2";
            label2.Size = new Size(161, 28);
            label2.TabIndex = 6;
            label2.Text = "Tibi  Papa Pizza";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(269, 299);
            label8.Name = "label8";
            label8.Size = new Size(148, 37);
            label8.TabIndex = 7;
            label8.Text = "Végösszeg:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(410, 299);
            label9.Name = "label9";
            label9.Size = new Size(0, 37);
            label9.TabIndex = 8;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(410, 299);
            label10.Name = "label10";
            label10.Size = new Size(107, 37);
            label10.TabIndex = 9;
            label10.Text = "000000";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(510, 299);
            label11.Name = "label11";
            label11.Size = new Size(44, 37);
            label11.TabIndex = 10;
            label11.Text = "FT";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Maroon;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1420, 685);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            Name = "Form1";
            Text = "Program";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Label Feltétek;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private NumericUpDown numericUpDown5;
        private NumericUpDown numericUpDown4;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private Button button1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}