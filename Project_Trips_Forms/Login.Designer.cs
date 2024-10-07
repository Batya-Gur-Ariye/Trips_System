namespace Project_Trips_Forms
{
    partial class Login
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
            UserName = new TextBox();
            Password = new TextBox();
            RegistBtn = new Button();
            groupBox1 = new GroupBox();
            enterBtn = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // UserName
            // 
            UserName.BackColor = Color.DarkSalmon;
            UserName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            UserName.Location = new Point(59, 506);
            UserName.Margin = new Padding(3, 4, 3, 4);
            UserName.Name = "UserName";
            UserName.PlaceholderText = "User name";
            UserName.Size = new Size(223, 27);
            UserName.TabIndex = 0;
            UserName.TextAlign = HorizontalAlignment.Center;
            UserName.Visible = false;
            // 
            // Password
            // 
            Password.BackColor = Color.DarkSalmon;
            Password.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Password.ForeColor = SystemColors.ActiveCaptionText;
            Password.Location = new Point(58, 539);
            Password.Margin = new Padding(3, 4, 3, 4);
            Password.Name = "Password";
            Password.PlaceholderText = "Password";
            Password.Size = new Size(223, 27);
            Password.TabIndex = 0;
            Password.TextAlign = HorizontalAlignment.Center;
            Password.UseSystemPasswordChar = true;
            Password.Visible = false;
            // 
            // RegistBtn
            // 
            RegistBtn.BackColor = Color.DarkSalmon;
            RegistBtn.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RegistBtn.ForeColor = SystemColors.ButtonHighlight;
            RegistBtn.Location = new Point(47, 395);
            RegistBtn.Margin = new Padding(3, 4, 3, 4);
            RegistBtn.Name = "RegistBtn";
            RegistBtn.Size = new Size(247, 39);
            RegistBtn.TabIndex = 1;
            RegistBtn.Text = "Register";
            RegistBtn.UseVisualStyleBackColor = false;
            RegistBtn.Click += RegistBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonHighlight;
            groupBox1.Controls.Add(enterBtn);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(RegistBtn);
            groupBox1.Controls.Add(Password);
            groupBox1.Controls.Add(UserName);
            groupBox1.Location = new Point(291, -20);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(341, 623);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // enterBtn
            // 
            enterBtn.BackColor = Color.DarkSalmon;
            enterBtn.Font = new Font("Segoe UI Symbol", 10F, FontStyle.Bold, GraphicsUnit.Point);
            enterBtn.ForeColor = SystemColors.ButtonHighlight;
            enterBtn.Location = new Point(97, 577);
            enterBtn.Margin = new Padding(3, 4, 3, 4);
            enterBtn.Name = "enterBtn";
            enterBtn.Size = new Size(141, 31);
            enterBtn.TabIndex = 1;
            enterBtn.Text = "enter";
            enterBtn.UseVisualStyleBackColor = false;
            enterBtn.Visible = false;
            enterBtn.Click += EnterBtn_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSalmon;
            button1.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(47, 442);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(247, 39);
            button1.TabIndex = 1;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += LoginBtn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(914, 600);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            Text = "Login";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox UserName;
        private TextBox Password;
        private Button RegistBtn;
        private GroupBox groupBox1;
        private Button button1;
        private Button enterBtn;
    }
}