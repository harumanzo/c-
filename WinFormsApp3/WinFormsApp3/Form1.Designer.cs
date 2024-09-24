namespace WinFormsApp3
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
            button1 = new Button();
            button2 = new Button();
            textBox = new TextBox();
            SuspendLayout();
            // 
            // display
            // 
            display.Dock = DockStyle.Top;
            display.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point);
            display.Location = new Point(0, 0);
            display.Name = "display";
            display.Size = new Size(609, 41);
            display.TabIndex = 0;
            display.Text = "게임을 시작합니다";
            display.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(0, 128);
            button1.Name = "button1";
            button1.Size = new Size(609, 52);
            button1.TabIndex = 1;
            button1.Text = "게임 시작";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(349, 61);
            button2.Name = "button2";
            button2.Size = new Size(232, 48);
            button2.TabIndex = 2;
            button2.Text = "입력";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox
            // 
            textBox.Font = new Font("맑은 고딕", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox.Location = new Point(50, 61);
            textBox.Name = "textBox";
            textBox.Size = new Size(260, 43);
            textBox.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 177);
            Controls.Add(textBox);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(display);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label display;
        private Button button1;
        private Button button2;
        private TextBox textBox;
    }
}