namespace Project_Trips_Forms
{
    partial class UserScreen
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
            ShowTrips = new DataGridView();
            MyOrdersDGV = new DataGridView();
            LabelName = new Label();
            CreateOrder = new Button();
            btnBack_user = new Button();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)ShowTrips).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MyOrdersDGV).BeginInit();
            SuspendLayout();
            // 
            // ShowTrips
            // 
            ShowTrips.BackgroundColor = SystemColors.ButtonHighlight;
            ShowTrips.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ShowTrips.Location = new Point(31, 130);
            ShowTrips.Margin = new Padding(3, 4, 3, 4);
            ShowTrips.Name = "ShowTrips";
            ShowTrips.RowHeadersWidth = 51;
            ShowTrips.RowTemplate.Height = 25;
            ShowTrips.Size = new Size(931, 159);
            ShowTrips.TabIndex = 0;
            ShowTrips.CellContentClick += ShowTrips_CellContentClick;
            // 
            // MyOrdersDGV
            // 
            MyOrdersDGV.BackgroundColor = SystemColors.ButtonHighlight;
            MyOrdersDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MyOrdersDGV.Location = new Point(34, 360);
            MyOrdersDGV.Margin = new Padding(3, 4, 3, 4);
            MyOrdersDGV.Name = "MyOrdersDGV";
            MyOrdersDGV.RowHeadersWidth = 51;
            MyOrdersDGV.RowTemplate.Height = 25;
            MyOrdersDGV.Size = new Size(582, 159);
            MyOrdersDGV.TabIndex = 1;
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.Font = new Font("Segoe UI Symbol", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            LabelName.ForeColor = SystemColors.ActiveCaptionText;
            LabelName.Location = new Point(453, 9);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(87, 46);
            LabelName.TabIndex = 3;
            LabelName.Text = "user";
            LabelName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CreateOrder
            // 
            CreateOrder.BackColor = Color.DarkSalmon;
            CreateOrder.Font = new Font("Segoe UI Symbol", 15F, FontStyle.Bold, GraphicsUnit.Point);
            CreateOrder.Location = new Point(657, 360);
            CreateOrder.Margin = new Padding(3, 4, 3, 4);
            CreateOrder.Name = "CreateOrder";
            CreateOrder.Size = new Size(305, 159);
            CreateOrder.TabIndex = 2;
            CreateOrder.Text = "Create order";
            CreateOrder.UseVisualStyleBackColor = false;
            CreateOrder.Click += CreateOrder_Click;
            // 
            // btnBack_user
            // 
            btnBack_user.Font = new Font("Segoe MDL2 Assets", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack_user.ForeColor = SystemColors.ActiveCaptionText;
            btnBack_user.Location = new Point(7, 547);
            btnBack_user.Name = "btnBack_user";
            btnBack_user.Size = new Size(51, 48);
            btnBack_user.TabIndex = 5;
            btnBack_user.Text = "👈";
            btnBack_user.UseVisualStyleBackColor = true;
            btnBack_user.Click += btnBack_user_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(34, 67);
            label2.Name = "label2";
            label2.Size = new Size(241, 59);
            label2.TabIndex = 6;
            label2.Text = "Future trips:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(34, 297);
            label1.Name = "label1";
            label1.Size = new Size(208, 59);
            label1.TabIndex = 7;
            label1.Text = "My orders:";
            // 
            // UserScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(1003, 600);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(btnBack_user);
            Controls.Add(CreateOrder);
            Controls.Add(LabelName);
            Controls.Add(MyOrdersDGV);
            Controls.Add(ShowTrips);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserScreen";
            Text = "UserScreen";
            ((System.ComponentModel.ISupportInitialize)ShowTrips).EndInit();
            ((System.ComponentModel.ISupportInitialize)MyOrdersDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ShowTrips;
        private DataGridView MyOrdersDGV;
        private Label LabelName;
        private Button CreateOrder;
        private Button btnBack_user;
        private Label label2;
        private Label label1;
    }
}