namespace Project_Trips_Forms
{
    partial class Registration
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
            components = new System.ComponentModel.Container();
            bgDetails = new GroupBox();
            passTxt = new TextBox();
            UserNameTxt = new TextBox();
            PassManTxt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            IsAdminCb = new ComboBox();
            EaTXt = new TextBox();
            PnTXt = new TextBox();
            LnTXt = new TextBox();
            FnTXt = new TextBox();
            idTXt = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripComboBox1 = new ToolStripComboBox();
            btnBack = new Button();
            RegistrationBtn = new Button();
            bgDetails.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // bgDetails
            // 
            bgDetails.Controls.Add(passTxt);
            bgDetails.Controls.Add(UserNameTxt);
            bgDetails.Controls.Add(PassManTxt);
            bgDetails.Controls.Add(label2);
            bgDetails.Controls.Add(label1);
            bgDetails.Controls.Add(IsAdminCb);
            bgDetails.Controls.Add(EaTXt);
            bgDetails.Controls.Add(PnTXt);
            bgDetails.Controls.Add(LnTXt);
            bgDetails.Controls.Add(FnTXt);
            bgDetails.Controls.Add(idTXt);
            bgDetails.Location = new Point(61, 37);
            bgDetails.Name = "bgDetails";
            bgDetails.Size = new Size(315, 493);
            bgDetails.TabIndex = 0;
            bgDetails.TabStop = false;
            bgDetails.Text = "User's details";
            // 
            // passTxt
            // 
            passTxt.Location = new Point(41, 420);
            passTxt.Name = "passTxt";
            passTxt.PlaceholderText = "Password";
            passTxt.Size = new Size(233, 27);
            passTxt.TabIndex = 5;
            // 
            // UserNameTxt
            // 
            UserNameTxt.Location = new Point(41, 388);
            UserNameTxt.Name = "UserNameTxt";
            UserNameTxt.PlaceholderText = "UserName";
            UserNameTxt.Size = new Size(233, 27);
            UserNameTxt.TabIndex = 4;
            // 
            // PassManTxt
            // 
            PassManTxt.Location = new Point(64, 312);
            PassManTxt.Name = "PassManTxt";
            PassManTxt.PlaceholderText = "Manager paswword";
            PassManTxt.Size = new Size(182, 27);
            PassManTxt.TabIndex = 3;
            PassManTxt.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 365);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 2;
            label2.Text = "Your login details:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 255);
            label1.Name = "label1";
            label1.Size = new Size(142, 20);
            label1.TabIndex = 2;
            label1.Text = "Are you a manager?";
            // 
            // IsAdminCb
            // 
            IsAdminCb.FormattingEnabled = true;
            IsAdminCb.Text = "False";
            IsAdminCb.Items.AddRange(new object[] { false, true });
            IsAdminCb.Location = new Point(36, 278);
            IsAdminCb.Name = "IsAdminCb";
            IsAdminCb.Size = new Size(238, 28);
            IsAdminCb.TabIndex = 1;
            IsAdminCb.SelectedIndexChanged += IsAdminCb_SelectedIndexChanged;
            // 
            // EaTXt
            // 
            EaTXt.Location = new Point(36, 210);
            EaTXt.Name = "EaTXt";
            EaTXt.PlaceholderText = "Email";
            EaTXt.Size = new Size(238, 27);
            EaTXt.TabIndex = 0;
            // 
            // PnTXt
            // 
            PnTXt.Location = new Point(36, 170);
            PnTXt.Name = "PnTXt";
            PnTXt.PlaceholderText = "Phone number";
            PnTXt.Size = new Size(238, 27);
            PnTXt.TabIndex = 0;
            // 
            // LnTXt
            // 
            LnTXt.Location = new Point(36, 129);
            LnTXt.Name = "LnTXt";
            LnTXt.PlaceholderText = "LastName";
            LnTXt.Size = new Size(238, 27);
            LnTXt.TabIndex = 0;
            // 
            // FnTXt
            // 
            FnTXt.Location = new Point(36, 87);
            FnTXt.Name = "FnTXt";
            FnTXt.PlaceholderText = "FirstName";
            FnTXt.Size = new Size(238, 27);
            FnTXt.TabIndex = 0;
            // 
            // idTXt
            // 
            idTXt.Location = new Point(36, 45);
            idTXt.Name = "idTXt";
            idTXt.PlaceholderText = "ID";
            idTXt.Size = new Size(238, 27);
            idTXt.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripComboBox1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(182, 36);
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(121, 28);
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe MDL2 Assets", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = SystemColors.ActiveCaptionText;
            btnBack.Location = new Point(3, 554);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(43, 42);
            btnBack.TabIndex = 3;
            btnBack.Text = "👈";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // RegistrationBtn
            // 
            RegistrationBtn.Location = new Point(102, 552);
            RegistrationBtn.Name = "RegistrationBtn";
            RegistrationBtn.Size = new Size(233, 29);
            RegistrationBtn.TabIndex = 2;
            RegistrationBtn.Text = "Registration";
            RegistrationBtn.UseVisualStyleBackColor = true;
            RegistrationBtn.Click += Registration_Click;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(432, 600);
            Controls.Add(btnBack);
            Controls.Add(RegistrationBtn);
            Controls.Add(bgDetails);
            Name = "Registration";
            Text = "Registration";
            bgDetails.ResumeLayout(false);
            bgDetails.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox bgDetails;
        private TextBox EaTXt;
        private TextBox PnTXt;
        private TextBox LnTXt;
        private TextBox FnTXt;
        private TextBox idTXt;
        private Label label1;
        private ComboBox IsAdminCb;
        private TextBox PassManTxt;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripComboBox toolStripComboBox1;
        private DomainUpDown domainUpDown1;
        private TextBox UserNameTxt;
        private TextBox passTxt;
        private Label label2;
        private Button button2;
        private Button btnBack;
        private Button RegistrationBtn;
    }
}