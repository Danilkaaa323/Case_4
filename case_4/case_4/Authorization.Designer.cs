namespace case_4
{
    partial class Authorization
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            label1 = new Label();
            login_textBox = new TextBox();
            password_textBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            Enter_button = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(39, 25);
            label1.Name = "label1";
            label1.Size = new Size(193, 37);
            label1.TabIndex = 0;
            label1.Text = "Авторизация";
            // 
            // login_textBox
            // 
            login_textBox.Cursor = Cursors.IBeam;
            login_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            login_textBox.Location = new Point(39, 107);
            login_textBox.Name = "login_textBox";
            login_textBox.Size = new Size(193, 29);
            login_textBox.TabIndex = 1;
            // 
            // password_textBox
            // 
            password_textBox.Cursor = Cursors.IBeam;
            password_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            password_textBox.Location = new Point(39, 179);
            password_textBox.Name = "password_textBox";
            password_textBox.Size = new Size(193, 29);
            password_textBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.White;
            label2.Location = new Point(39, 89);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 3;
            label2.Text = "Логин";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.White;
            label3.Location = new Point(39, 161);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 4;
            label3.Text = "Пароль";
            // 
            // Enter_button
            // 
            Enter_button.Cursor = Cursors.Hand;
            Enter_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Enter_button.Location = new Point(92, 232);
            Enter_button.Name = "Enter_button";
            Enter_button.Size = new Size(84, 31);
            Enter_button.TabIndex = 5;
            Enter_button.Text = "Войти";
            Enter_button.UseVisualStyleBackColor = true;
            Enter_button.Click += Enter_button_Click;
            // 
            // Authorization
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(274, 292);
            Controls.Add(Enter_button);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(password_textBox);
            Controls.Add(login_textBox);
            Controls.Add(label1);
            Name = "Authorization";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox login_textBox;
        private TextBox password_textBox;
        private Label label2;
        private Label label3;
        private Button Enter_button;
    }
}