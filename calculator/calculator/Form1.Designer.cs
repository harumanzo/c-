namespace calculator
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
            display = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            button16 = new Button();
            buttonFloat = new Button();
            buttonAc = new Button();
            button12 = new Button();
            button11 = new Button();
            buttonPlus = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            button7 = new Button();
            buttonEqual = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // display
            // 
            display.Dock = DockStyle.Top;
            display.Font = new Font("맑은 고딕", 24F, FontStyle.Regular, GraphicsUnit.Point);
            display.Location = new Point(0, 0);
            display.Name = "display";
            display.Size = new Size(800, 70);
            display.TabIndex = 0;
            display.Text = "0";
            display.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(button16, 3, 3);
            tableLayoutPanel1.Controls.Add(buttonFloat, 2, 3);
            tableLayoutPanel1.Controls.Add(buttonAc, 0, 3);
            tableLayoutPanel1.Controls.Add(button12, 3, 2);
            tableLayoutPanel1.Controls.Add(button11, 3, 1);
            tableLayoutPanel1.Controls.Add(buttonPlus, 3, 0);
            tableLayoutPanel1.Controls.Add(button3, 2, 0);
            tableLayoutPanel1.Controls.Add(button2, 1, 0);
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Controls.Add(button4, 0, 1);
            tableLayoutPanel1.Controls.Add(button5, 1, 1);
            tableLayoutPanel1.Controls.Add(button6, 2, 1);
            tableLayoutPanel1.Controls.Add(button8, 1, 2);
            tableLayoutPanel1.Controls.Add(button9, 2, 2);
            tableLayoutPanel1.Controls.Add(button0, 1, 3);
            tableLayoutPanel1.Controls.Add(button7, 0, 2);
            tableLayoutPanel1.Location = new Point(0, 83);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(800, 322);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // button16
            // 
            button16.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button16.Location = new Point(603, 243);
            button16.Name = "button16";
            button16.Size = new Size(194, 70);
            button16.TabIndex = 15;
            button16.Text = "÷";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
            // 
            // buttonFloat
            // 
            buttonFloat.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFloat.Location = new Point(403, 243);
            buttonFloat.Name = "buttonFloat";
            buttonFloat.Size = new Size(194, 70);
            buttonFloat.TabIndex = 14;
            buttonFloat.Text = ".";
            buttonFloat.UseVisualStyleBackColor = true;
            buttonFloat.Click += buttonFloat_Click;
            // 
            // buttonAc
            // 
            buttonAc.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAc.Location = new Point(3, 243);
            buttonAc.Name = "buttonAc";
            buttonAc.Size = new Size(194, 70);
            buttonAc.TabIndex = 12;
            buttonAc.Text = "Ac";
            buttonAc.UseVisualStyleBackColor = true;
            buttonAc.Click += buttonAc_Click;
            // 
            // button12
            // 
            button12.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button12.Location = new Point(603, 163);
            button12.Name = "button12";
            button12.Size = new Size(194, 70);
            button12.TabIndex = 11;
            button12.Text = "×";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button11
            // 
            button11.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button11.Location = new Point(603, 83);
            button11.Name = "button11";
            button11.Size = new Size(194, 70);
            button11.TabIndex = 10;
            button11.Text = "-";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // buttonPlus
            // 
            buttonPlus.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPlus.Location = new Point(603, 3);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(194, 70);
            buttonPlus.TabIndex = 9;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // button3
            // 
            button3.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(403, 3);
            button3.Name = "button3";
            button3.Size = new Size(194, 70);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(203, 3);
            button2.Name = "button2";
            button2.Size = new Size(194, 70);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(194, 74);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(3, 83);
            button4.Name = "button4";
            button4.Size = new Size(194, 70);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(203, 83);
            button5.Name = "button5";
            button5.Size = new Size(194, 70);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(403, 83);
            button6.Name = "button6";
            button6.Size = new Size(194, 70);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button8
            // 
            button8.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(203, 163);
            button8.Name = "button8";
            button8.Size = new Size(194, 70);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(403, 163);
            button9.Name = "button9";
            button9.Size = new Size(194, 70);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button0
            // 
            button0.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button0.Location = new Point(203, 243);
            button0.Name = "button0";
            button0.Size = new Size(194, 70);
            button0.TabIndex = 13;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // button7
            // 
            button7.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(3, 163);
            button7.Name = "button7";
            button7.Size = new Size(194, 70);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // buttonEqual
            // 
            buttonEqual.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEqual.Location = new Point(0, 402);
            buttonEqual.Name = "buttonEqual";
            buttonEqual.Size = new Size(800, 92);
            buttonEqual.TabIndex = 2;
            buttonEqual.Text = "=";
            buttonEqual.UseVisualStyleBackColor = true;
            buttonEqual.Click += buttonEqual_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 490);
            Controls.Add(buttonEqual);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(display);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label display;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button16;
        private Button buttonFloat;
        private Button button0;
        private Button buttonAc;
        private Button button12;
        private Button button11;
        private Button buttonPlus;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button buttonEqual;
    }
}