namespace WinFormsApp2
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
            Identity = new TextBox();
            password = new TextBox();
            signinbutton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(352, 44);
            label1.Name = "label1";
            label1.Size = new Size(122, 46);
            label1.TabIndex = 0;
            label1.Text = "로그인";
            // 
            // Identity
            // 
            Identity.Font = new Font("맑은 고딕", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Identity.Location = new Point(298, 125);
            Identity.Name = "Identity";
            Identity.Size = new Size(233, 43);
            Identity.TabIndex = 1;
            Identity.Text = "아이디";
            // 
            // password
            // 
            password.Font = new Font("맑은 고딕", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            password.Location = new Point(298, 188);
            password.Name = "password";
            password.Size = new Size(233, 43);
            password.TabIndex = 2;
            password.Text = "비밀번호";
            password.UseSystemPasswordChar = true;
            // 
            // signinbutton
            // 
            signinbutton.Font = new Font("맑은 고딕", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            signinbutton.Location = new Point(368, 256);
            signinbutton.Name = "signinbutton";
            signinbutton.Size = new Size(94, 46);
            signinbutton.TabIndex = 3;
            signinbutton.Text = "확인";
            signinbutton.UseVisualStyleBackColor = true;
            signinbutton.Click += signinbutton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(signinbutton);
            Controls.Add(password);
            Controls.Add(Identity);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Identity;
        private TextBox password;
        private Button signinbutton;
    }
}