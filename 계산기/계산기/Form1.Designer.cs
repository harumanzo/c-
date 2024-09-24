namespace 계산기
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
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            button16 = new Button();
            buttonPoint = new Button();
            buttonZero = new Button();
            buttonAC = new Button();
            button12 = new Button();
            button8 = new Button();
            buttonSix = new Button();
            buttonFive = new Button();
            buttonFour = new Button();
            button4 = new Button();
            buttonOne = new Button();
            buttonTwo = new Button();
            buttonNine = new Button();
            buttonThree = new Button();
            buttonEight = new Button();
            buttonseven = new Button();
            button1 = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(801, 78);
            label1.TabIndex = 0;
            label1.Text = "0";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(button16, 3, 3);
            tableLayoutPanel1.Controls.Add(buttonPoint, 2, 3);
            tableLayoutPanel1.Controls.Add(buttonZero, 1, 3);
            tableLayoutPanel1.Controls.Add(buttonAC, 0, 3);
            tableLayoutPanel1.Controls.Add(button12, 3, 2);
            tableLayoutPanel1.Controls.Add(button8, 3, 1);
            tableLayoutPanel1.Controls.Add(buttonSix, 2, 1);
            tableLayoutPanel1.Controls.Add(buttonFive, 1, 1);
            tableLayoutPanel1.Controls.Add(buttonFour, 0, 1);
            tableLayoutPanel1.Controls.Add(button4, 3, 0);
            tableLayoutPanel1.Controls.Add(buttonOne, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonTwo, 1, 0);
            tableLayoutPanel1.Controls.Add(buttonNine, 2, 2);
            tableLayoutPanel1.Controls.Add(buttonThree, 2, 0);
            tableLayoutPanel1.Controls.Add(buttonEight, 1, 2);
            tableLayoutPanel1.Controls.Add(buttonseven, 0, 2);
            tableLayoutPanel1.Location = new Point(0, 81);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(800, 368);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // button16
            // 
            button16.Font = new Font("맑은 고딕", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            button16.Location = new Point(603, 279);
            button16.Name = "button16";
            button16.Size = new Size(194, 86);
            button16.TabIndex = 15;
            button16.Text = "÷";
            button16.UseVisualStyleBackColor = true;
            // 
            // buttonPoint
            // 
            buttonPoint.Font = new Font("맑은 고딕", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPoint.Location = new Point(403, 279);
            buttonPoint.Name = "buttonPoint";
            buttonPoint.Size = new Size(194, 86);
            buttonPoint.TabIndex = 14;
            buttonPoint.Text = ".";
            buttonPoint.UseVisualStyleBackColor = true;
            // 
            // buttonZero
            // 
            buttonZero.Font = new Font("맑은 고딕", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            buttonZero.Location = new Point(203, 279);
            buttonZero.Name = "buttonZero";
            buttonZero.Size = new Size(194, 86);
            buttonZero.TabIndex = 13;
            buttonZero.Text = "0";
            buttonZero.UseVisualStyleBackColor = true;
            // 
            // buttonAC
            // 
            buttonAC.Font = new Font("맑은 고딕", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAC.Location = new Point(3, 279);
            buttonAC.Name = "buttonAC";
            buttonAC.Size = new Size(194, 86);
            buttonAC.TabIndex = 12;
            buttonAC.Text = "AC";
            buttonAC.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Font = new Font("맑은 고딕", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            button12.Location = new Point(603, 187);
            button12.Name = "button12";
            button12.Size = new Size(194, 86);
            button12.TabIndex = 11;
            button12.Text = "×";
            button12.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Font = new Font("맑은 고딕", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(603, 95);
            button8.Name = "button8";
            button8.Size = new Size(194, 86);
            button8.TabIndex = 7;
            button8.Text = "-";
            button8.UseVisualStyleBackColor = true;
            // 
            // buttonSix
            // 
            buttonSix.Font = new Font("맑은 고딕", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSix.Location = new Point(403, 95);
            buttonSix.Name = "buttonSix";
            buttonSix.Size = new Size(194, 86);
            buttonSix.TabIndex = 6;
            buttonSix.Text = "6";
            buttonSix.UseVisualStyleBackColor = true;
            buttonSix.Click += button7_Click;
            // 
            // buttonFive
            // 
            buttonFive.Font = new Font("맑은 고딕", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFive.Location = new Point(203, 95);
            buttonFive.Name = "buttonFive";
            buttonFive.Size = new Size(194, 86);
            buttonFive.TabIndex = 5;
            buttonFive.Text = "5";
            buttonFive.UseVisualStyleBackColor = true;
            // 
            // buttonFour
            // 
            buttonFour.Font = new Font("맑은 고딕", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFour.Location = new Point(3, 95);
            buttonFour.Name = "buttonFour";
            buttonFour.Size = new Size(194, 86);
            buttonFour.TabIndex = 4;
            buttonFour.Text = "4";
            buttonFour.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("맑은 고딕", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(603, 3);
            button4.Name = "button4";
            button4.Size = new Size(194, 86);
            button4.TabIndex = 3;
            button4.Text = " ＋";
            button4.UseVisualStyleBackColor = true;
            // 
            // buttonOne
            // 
            buttonOne.Font = new Font("맑은 고딕", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            buttonOne.Location = new Point(3, 3);
            buttonOne.Name = "buttonOne";
            buttonOne.Size = new Size(194, 86);
            buttonOne.TabIndex = 8;
            buttonOne.Text = "1";
            buttonOne.UseVisualStyleBackColor = true;
            buttonOne.Click += buttonOne_Click;
            // 
            // buttonTwo
            // 
            buttonTwo.Font = new Font("맑은 고딕", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            buttonTwo.Location = new Point(203, 3);
            buttonTwo.Name = "buttonTwo";
            buttonTwo.Size = new Size(194, 86);
            buttonTwo.TabIndex = 9;
            buttonTwo.Text = "2";
            buttonTwo.UseVisualStyleBackColor = true;
            // 
            // buttonNine
            // 
            buttonNine.Font = new Font("맑은 고딕", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            buttonNine.Location = new Point(403, 187);
            buttonNine.Name = "buttonNine";
            buttonNine.Size = new Size(194, 86);
            buttonNine.TabIndex = 2;
            buttonNine.Text = "9";
            buttonNine.UseVisualStyleBackColor = true;
            // 
            // buttonThree
            // 
            buttonThree.Font = new Font("맑은 고딕", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            buttonThree.Location = new Point(403, 3);
            buttonThree.Name = "buttonThree";
            buttonThree.Size = new Size(194, 86);
            buttonThree.TabIndex = 10;
            buttonThree.Text = "3";
            buttonThree.UseVisualStyleBackColor = true;
            // 
            // buttonEight
            // 
            buttonEight.Font = new Font("맑은 고딕", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEight.Location = new Point(203, 187);
            buttonEight.Name = "buttonEight";
            buttonEight.Size = new Size(194, 86);
            buttonEight.TabIndex = 1;
            buttonEight.Text = "8";
            buttonEight.UseVisualStyleBackColor = true;
            // 
            // buttonseven
            // 
            buttonseven.Font = new Font("맑은 고딕", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            buttonseven.Location = new Point(3, 187);
            buttonseven.Name = "buttonseven";
            buttonseven.Size = new Size(194, 86);
            buttonseven.TabIndex = 0;
            buttonseven.Text = "7";
            buttonseven.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("맑은 고딕", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(0, 452);
            button1.Name = "button1";
            button1.Size = new Size(800, 73);
            button1.TabIndex = 2;
            button1.Text = "=";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 521);
            Controls.Add(button1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button16;
        private Button buttonPoint;
        private Button buttonZero;
        private Button buttonAC;
        private Button button12;
        private Button buttonThree;
        private Button buttonTwo;
        private Button buttonOne;
        private Button button8;
        private Button buttonSix;
        private Button buttonFive;
        private Button buttonFour;
        private Button button4;
        private Button buttonNine;
        private Button buttonEight;
        private Button buttonseven;
        private Button button1;
    }
}