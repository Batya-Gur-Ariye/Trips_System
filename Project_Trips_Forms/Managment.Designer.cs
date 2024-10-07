using Project_Trips_Data.Models;

namespace Project_Trips_Forms
{
    partial class Managment
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
            OrderPerTrip = new Button();
            AllTripsDGV = new DataGridView();
            OrderPerTripDGV = new DataGridView();
            AddOrderBtn = new Button();
            UpdateOrderBtn = new Button();
            NameTrip = new TextBox();
            description = new TextBox();
            startdate = new DateTimePicker();
            endDate = new DateTimePicker();
            NumParticipants = new TextBox();
            NameLabel = new Label();
            submitAddOrder = new Button();
            submitUpdateTrip = new Button();
            lblStartDt = new Label();
            lblEndDt = new Label();
            status = new ComboBox();
            btnBack = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)AllTripsDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OrderPerTripDGV).BeginInit();
            SuspendLayout();
            // 
            // OrderPerTrip
            // 
            OrderPerTrip.BackColor = Color.DarkSalmon;
            OrderPerTrip.Font = new Font("Segoe UI Symbol", 10F, FontStyle.Bold, GraphicsUnit.Point);
            OrderPerTrip.Location = new Point(204, 180);
            OrderPerTrip.Margin = new Padding(3, 4, 3, 4);
            OrderPerTrip.Name = "OrderPerTrip";
            OrderPerTrip.Size = new Size(102, 100);
            OrderPerTrip.TabIndex = 0;
            OrderPerTrip.Text = "orders Per Trip";
            OrderPerTrip.UseVisualStyleBackColor = false;
            OrderPerTrip.Click += OrderPerTrip_Click;
            // 
            // AllTripsDGV
            // 
            AllTripsDGV.BackgroundColor = SystemColors.ButtonHighlight;
            AllTripsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AllTripsDGV.Location = new Point(116, 35);
            AllTripsDGV.Margin = new Padding(3, 4, 3, 4);
            AllTripsDGV.Name = "AllTripsDGV";
            AllTripsDGV.RowHeadersWidth = 51;
            AllTripsDGV.RowTemplate.Height = 25;
            AllTripsDGV.Size = new Size(932, 138);
            AllTripsDGV.TabIndex = 1;
            // 
            // OrderPerTripDGV
            // 
            OrderPerTripDGV.BackgroundColor = SystemColors.ButtonHighlight;
            OrderPerTripDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderPerTripDGV.Location = new Point(312, 181);
            OrderPerTripDGV.Margin = new Padding(3, 4, 3, 4);
            OrderPerTripDGV.Name = "OrderPerTripDGV";
            OrderPerTripDGV.RowHeadersWidth = 51;
            OrderPerTripDGV.RowTemplate.Height = 25;
            OrderPerTripDGV.Size = new Size(636, 100);
            OrderPerTripDGV.TabIndex = 1;
            // 
            // AddOrderBtn
            // 
            AddOrderBtn.BackColor = Color.DarkSalmon;
            AddOrderBtn.Font = new Font("Segoe UI Symbol", 10F, FontStyle.Bold, GraphicsUnit.Point);
            AddOrderBtn.Location = new Point(105, 295);
            AddOrderBtn.Margin = new Padding(3, 4, 3, 4);
            AddOrderBtn.Name = "AddOrderBtn";
            AddOrderBtn.Size = new Size(444, 55);
            AddOrderBtn.TabIndex = 2;
            AddOrderBtn.Text = "Add trip";
            AddOrderBtn.UseVisualStyleBackColor = false;
            AddOrderBtn.Click += AddOrderBtn_Click;
            // 
            // UpdateOrderBtn
            // 
            UpdateOrderBtn.BackColor = Color.DarkSalmon;
            UpdateOrderBtn.Font = new Font("Segoe UI Symbol", 10F, FontStyle.Bold, GraphicsUnit.Point);
            UpdateOrderBtn.Location = new Point(555, 295);
            UpdateOrderBtn.Margin = new Padding(3, 4, 3, 4);
            UpdateOrderBtn.Name = "UpdateOrderBtn";
            UpdateOrderBtn.Size = new Size(443, 55);
            UpdateOrderBtn.TabIndex = 2;
            UpdateOrderBtn.Text = "Update trip";
            UpdateOrderBtn.UseVisualStyleBackColor = false;
            UpdateOrderBtn.Click += UpdateOrderBtn_Click;
            // 
            // NameTrip
            // 
            NameTrip.Font = new Font("Segoe UI Symbol", 8F, FontStyle.Regular, GraphicsUnit.Point);
            NameTrip.Location = new Point(105, 362);
            NameTrip.Margin = new Padding(3, 4, 3, 4);
            NameTrip.Name = "NameTrip";
            NameTrip.PlaceholderText = "Name trip";
            NameTrip.Size = new Size(892, 25);
            NameTrip.TabIndex = 3;
            NameTrip.Visible = false;
            // 
            // description
            // 
            description.Font = new Font("Segoe UI Symbol", 8F, FontStyle.Regular, GraphicsUnit.Point);
            description.Location = new Point(105, 398);
            description.Margin = new Padding(3, 4, 3, 4);
            description.Name = "description";
            description.PlaceholderText = "description";
            description.Size = new Size(892, 25);
            description.TabIndex = 3;
            description.Visible = false;
            // 
            // startdate
            // 
            startdate.DropDownAlign = LeftRightAlignment.Right;
            startdate.Font = new Font("Segoe UI Symbol", 8F, FontStyle.Regular, GraphicsUnit.Point);
            startdate.Format = DateTimePickerFormat.Short;
            startdate.Location = new Point(106, 504);
            startdate.Margin = new Padding(3, 4, 3, 4);
            startdate.Name = "startdate";
            startdate.Size = new Size(891, 25);
            startdate.TabIndex = 4;
            startdate.Value = new DateTime(2024, 2, 7, 0, 0, 0, 0);
            startdate.Visible = false;
            // 
            // endDate
            // 
            endDate.DropDownAlign = LeftRightAlignment.Right;
            endDate.Font = new Font("Segoe UI Symbol", 8F, FontStyle.Regular, GraphicsUnit.Point);
            endDate.Format = DateTimePickerFormat.Short;
            endDate.Location = new Point(105, 541);
            endDate.Margin = new Padding(3, 4, 3, 4);
            endDate.Name = "endDate";
            endDate.Size = new Size(891, 25);
            endDate.TabIndex = 4;
            endDate.TabStop = false;
            endDate.Value = new DateTime(2024, 2, 7, 0, 0, 0, 0);
            endDate.Visible = false;
            // 
            // NumParticipants
            // 
            NumParticipants.Font = new Font("Segoe UI Symbol", 8F, FontStyle.Regular, GraphicsUnit.Point);
            NumParticipants.Location = new Point(106, 470);
            NumParticipants.Margin = new Padding(3, 4, 3, 4);
            NumParticipants.Name = "NumParticipants";
            NumParticipants.PlaceholderText = "Num Of Participants";
            NumParticipants.Size = new Size(892, 25);
            NumParticipants.TabIndex = 3;
            NumParticipants.Visible = false;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.FlatStyle = FlatStyle.Flat;
            NameLabel.Font = new Font("Segoe UI Symbol", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            NameLabel.ForeColor = SystemColors.ActiveCaptionText;
            NameLabel.Location = new Point(3, 9);
            NameLabel.MaximumSize = new Size(114, 133);
            NameLabel.MinimumSize = new Size(23, 27);
            NameLabel.Name = "NameLabel";
            NameLabel.RightToLeft = RightToLeft.Yes;
            NameLabel.Size = new Size(91, 46);
            NameLabel.TabIndex = 100;
            NameLabel.Text = "User";
            NameLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // submitAddOrder
            // 
            submitAddOrder.BackColor = Color.DarkSalmon;
            submitAddOrder.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            submitAddOrder.Location = new Point(397, 583);
            submitAddOrder.Margin = new Padding(3, 4, 3, 4);
            submitAddOrder.Name = "submitAddOrder";
            submitAddOrder.Size = new Size(339, 44);
            submitAddOrder.TabIndex = 2;
            submitAddOrder.Text = "Submit";
            submitAddOrder.UseVisualStyleBackColor = false;
            submitAddOrder.Visible = false;
            submitAddOrder.Click += SubmitBtn_Click;
            // 
            // submitUpdateTrip
            // 
            submitUpdateTrip.BackColor = Color.DarkSalmon;
            submitUpdateTrip.Font = new Font("Segoe UI Symbol", 10F, FontStyle.Bold, GraphicsUnit.Point);
            submitUpdateTrip.Location = new Point(397, 583);
            submitUpdateTrip.Margin = new Padding(3, 4, 3, 4);
            submitUpdateTrip.Name = "submitUpdateTrip";
            submitUpdateTrip.Size = new Size(341, 44);
            submitUpdateTrip.TabIndex = 2;
            submitUpdateTrip.Text = "Submit";
            submitUpdateTrip.UseVisualStyleBackColor = false;
            submitUpdateTrip.Visible = false;
            submitUpdateTrip.Click += submitUpdateTrip_Click;
            // 
            // lblStartDt
            // 
            lblStartDt.AllowDrop = true;
            lblStartDt.AutoSize = true;
            lblStartDt.BackColor = Color.Snow;
            lblStartDt.Font = new Font("Segoe UI Symbol", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblStartDt.Location = new Point(864, 508);
            lblStartDt.Name = "lblStartDt";
            lblStartDt.Size = new Size(71, 19);
            lblStartDt.TabIndex = 102;
            lblStartDt.Text = "Start Date";
            lblStartDt.Visible = false;
            // 
            // lblEndDt
            // 
            lblEndDt.AutoSize = true;
            lblEndDt.BackColor = Color.Snow;
            lblEndDt.Font = new Font("Segoe UI Symbol", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblEndDt.Location = new Point(867, 545);
            lblEndDt.Name = "lblEndDt";
            lblEndDt.Size = new Size(65, 19);
            lblEndDt.TabIndex = 103;
            lblEndDt.Text = "End Date";
            lblEndDt.Visible = false;
            // 
            // status
            // 
            status.BackColor = SystemColors.HighlightText;
            status.DropDownStyle = ComboBoxStyle.DropDownList;
            status.Font = new Font("Segoe UI Symbol", 8F, FontStyle.Regular, GraphicsUnit.Point);
            status.FormattingEnabled = true;
            status.IntegralHeight = false;
            status.Location = new Point(105, 432);
            status.Margin = new Padding(3, 4, 3, 4);
            status.Name = "status";
            status.Size = new Size(893, 25);
            status.TabIndex = 0;
            status.Visible = false;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe MDL2 Assets", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = SystemColors.ActiveCaptionText;
            btnBack.Location = new Point(12, 583);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(55, 44);
            btnBack.TabIndex = 104;
            btnBack.Text = "👈";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(519, -7);
            label1.Name = "label1";
            label1.Size = new Size(137, 42);
            label1.TabIndex = 105;
            label1.Text = "Our trips:";
            // 
            // Managment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(1100, 634);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(lblEndDt);
            Controls.Add(lblStartDt);
            Controls.Add(status);
            Controls.Add(NameLabel);
            Controls.Add(endDate);
            Controls.Add(startdate);
            Controls.Add(NumParticipants);
            Controls.Add(description);
            Controls.Add(NameTrip);
            Controls.Add(submitUpdateTrip);
            Controls.Add(submitAddOrder);
            Controls.Add(UpdateOrderBtn);
            Controls.Add(AddOrderBtn);
            Controls.Add(OrderPerTripDGV);
            Controls.Add(AllTripsDGV);
            Controls.Add(OrderPerTrip);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Managment";
            Text = "Managment";
            ((System.ComponentModel.ISupportInitialize)AllTripsDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)OrderPerTripDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button OrderPerTrip;
        private DataGridView AllTripsDGV;
        private DataGridView OrderPerTripDGV;
        private Button AddOrderBtn;
        private Button UpdateOrderBtn;
        private TextBox NameTrip;
        private TextBox description;
        private DateTimePicker startdate;
        private DateTimePicker endDate;
        private TextBox NumParticipants;
        private Label NameLabel;
        private Button submitAddOrder;
        private Button submitUpdateTrip;
        private Label lblStartDt;
        private Label lblEndDt;
        private ComboBox status;
        private TextBox txtnameUp;
        private TextBox textBox1;
        private Button btnBack;
        private Label label1;
    }
}