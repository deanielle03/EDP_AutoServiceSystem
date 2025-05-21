
namespace Auto_Service
{
    partial class dashboardWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboardWindow));
            logo = new PictureBox();
            panel3 = new Panel();
            logoutbtn = new Button();
            label1 = new Label();
            serviceHistoryBtn = new Button();
            sidebar = new Panel();
            employeesBtn = new Button();
            productBtn = new Button();
            bookingQBtn = new Button();
            recordsBtn = new Button();
            dashboardBtn = new Button();
            panelContainer = new Panel();
            booking_ID = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            phone_number = new DataGridViewTextBoxColumn();
            service = new DataGridViewTextBoxColumn();
            created_At = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            panel3.SuspendLayout();
            sidebar.SuspendLayout();
            SuspendLayout();
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(33, 18);
            logo.Name = "logo";
            logo.Size = new Size(95, 55);
            logo.TabIndex = 2;
            logo.TabStop = false;
            logo.Click += pictureBox1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 128, 0);
            panel3.Controls.Add(logo);
            panel3.Controls.Add(logoutbtn);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1478, 86);
            panel3.TabIndex = 1;
            // 
            // logoutbtn
            // 
            logoutbtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            logoutbtn.BackColor = Color.FromArgb(255, 128, 0);
            logoutbtn.Cursor = Cursors.Hand;
            logoutbtn.FlatAppearance.BorderSize = 0;
            logoutbtn.FlatStyle = FlatStyle.Flat;
            logoutbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            logoutbtn.ForeColor = Color.White;
            logoutbtn.Location = new Point(1318, 18);
            logoutbtn.MaximumSize = new Size(121, 49);
            logoutbtn.Name = "logoutbtn";
            logoutbtn.Size = new Size(121, 49);
            logoutbtn.TabIndex = 1;
            logoutbtn.Text = "Logout";
            logoutbtn.UseVisualStyleBackColor = false;
            logoutbtn.Click += logoutBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(124, 16);
            label1.Name = "label1";
            label1.Size = new Size(153, 45);
            label1.TabIndex = 0;
            label1.Text = "yourCars";
            // 
            // serviceHistoryBtn
            // 
            serviceHistoryBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            serviceHistoryBtn.BackColor = Color.FromArgb(55, 55, 55);
            serviceHistoryBtn.FlatAppearance.BorderSize = 0;
            serviceHistoryBtn.FlatStyle = FlatStyle.Flat;
            serviceHistoryBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            serviceHistoryBtn.ForeColor = Color.White;
            serviceHistoryBtn.Location = new Point(0, 196);
            serviceHistoryBtn.Name = "serviceHistoryBtn";
            serviceHistoryBtn.Padding = new Padding(30, 0, 0, 0);
            serviceHistoryBtn.Size = new Size(299, 82);
            serviceHistoryBtn.TabIndex = 2;
            serviceHistoryBtn.Text = "SERVICE HISTORY";
            serviceHistoryBtn.TextAlign = ContentAlignment.MiddleLeft;
            serviceHistoryBtn.UseVisualStyleBackColor = false;
            serviceHistoryBtn.Click += serviceHistoryBtn_Click;
            // 
            // sidebar
            // 
            sidebar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            sidebar.BackColor = Color.FromArgb(40, 40, 40);
            sidebar.Controls.Add(employeesBtn);
            sidebar.Controls.Add(productBtn);
            sidebar.Controls.Add(bookingQBtn);
            sidebar.Controls.Add(recordsBtn);
            sidebar.Controls.Add(dashboardBtn);
            sidebar.Controls.Add(serviceHistoryBtn);
            sidebar.Location = new Point(0, 86);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(299, 857);
            sidebar.TabIndex = 2;
            // 
            // employeesBtn
            // 
            employeesBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            employeesBtn.BackColor = Color.FromArgb(55, 55, 55);
            employeesBtn.FlatAppearance.BorderColor = Color.White;
            employeesBtn.FlatAppearance.BorderSize = 0;
            employeesBtn.FlatStyle = FlatStyle.Flat;
            employeesBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            employeesBtn.ForeColor = Color.White;
            employeesBtn.Location = new Point(0, 372);
            employeesBtn.Name = "employeesBtn";
            employeesBtn.Padding = new Padding(30, 0, 0, 0);
            employeesBtn.Size = new Size(299, 82);
            employeesBtn.TabIndex = 8;
            employeesBtn.Text = "EMPLOYEES";
            employeesBtn.TextAlign = ContentAlignment.MiddleLeft;
            employeesBtn.UseVisualStyleBackColor = false;
            employeesBtn.Click += employeesBtn_Click;
            // 
            // productBtn
            // 
            productBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            productBtn.BackColor = Color.FromArgb(55, 55, 55);
            productBtn.FlatAppearance.BorderColor = Color.White;
            productBtn.FlatAppearance.BorderSize = 0;
            productBtn.FlatStyle = FlatStyle.Flat;
            productBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productBtn.ForeColor = Color.White;
            productBtn.Location = new Point(0, 284);
            productBtn.Name = "productBtn";
            productBtn.Padding = new Padding(30, 0, 0, 0);
            productBtn.Size = new Size(299, 82);
            productBtn.TabIndex = 7;
            productBtn.Text = "PRODUCTS";
            productBtn.TextAlign = ContentAlignment.MiddleLeft;
            productBtn.UseVisualStyleBackColor = false;
            productBtn.Click += productBtn_Click;
            // 
            // bookingQBtn
            // 
            bookingQBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bookingQBtn.BackColor = Color.FromArgb(55, 55, 55);
            bookingQBtn.FlatAppearance.BorderColor = Color.White;
            bookingQBtn.FlatAppearance.BorderSize = 0;
            bookingQBtn.FlatStyle = FlatStyle.Flat;
            bookingQBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookingQBtn.ForeColor = Color.White;
            bookingQBtn.Location = new Point(0, 108);
            bookingQBtn.Name = "bookingQBtn";
            bookingQBtn.Padding = new Padding(30, 0, 0, 0);
            bookingQBtn.Size = new Size(299, 82);
            bookingQBtn.TabIndex = 6;
            bookingQBtn.Text = "BOOKING QUEUE";
            bookingQBtn.TextAlign = ContentAlignment.MiddleLeft;
            bookingQBtn.UseVisualStyleBackColor = false;
            bookingQBtn.Click += bookingQBtn_Click;
            // 
            // recordsBtn
            // 
            recordsBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            recordsBtn.BackColor = Color.FromArgb(55, 55, 55);
            recordsBtn.FlatAppearance.BorderColor = Color.White;
            recordsBtn.FlatAppearance.BorderSize = 0;
            recordsBtn.FlatStyle = FlatStyle.Flat;
            recordsBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            recordsBtn.ForeColor = Color.White;
            recordsBtn.Location = new Point(0, 460);
            recordsBtn.Name = "recordsBtn";
            recordsBtn.Padding = new Padding(30, 0, 0, 0);
            recordsBtn.Size = new Size(299, 82);
            recordsBtn.TabIndex = 5;
            recordsBtn.Text = "RECORDS";
            recordsBtn.TextAlign = ContentAlignment.MiddleLeft;
            recordsBtn.UseVisualStyleBackColor = false;
            recordsBtn.Click += recordsBtn_Click;
            // 
            // dashboardBtn
            // 
            dashboardBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dashboardBtn.BackColor = Color.FromArgb(55, 55, 55);
            dashboardBtn.FlatAppearance.BorderSize = 0;
            dashboardBtn.FlatStyle = FlatStyle.Flat;
            dashboardBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboardBtn.ForeColor = Color.White;
            dashboardBtn.Location = new Point(0, 20);
            dashboardBtn.Name = "dashboardBtn";
            dashboardBtn.Padding = new Padding(30, 0, 0, 0);
            dashboardBtn.Size = new Size(299, 82);
            dashboardBtn.TabIndex = 4;
            dashboardBtn.Text = "DASHBOARD";
            dashboardBtn.TextAlign = ContentAlignment.MiddleLeft;
            dashboardBtn.UseVisualStyleBackColor = false;
            dashboardBtn.Click += dashboardBtn_Click;
            // 
            // panelContainer
            // 
            panelContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelContainer.Location = new Point(305, 86);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1173, 858);
            panelContainer.TabIndex = 3;
            panelContainer.Paint += panelContainer_Paint;
            // 
            // booking_ID
            // 
            booking_ID.MinimumWidth = 8;
            booking_ID.Name = "booking_ID";
            booking_ID.Width = 150;
            // 
            // name
            // 
            name.MinimumWidth = 8;
            name.Name = "name";
            name.Width = 150;
            // 
            // phone_number
            // 
            phone_number.MinimumWidth = 8;
            phone_number.Name = "phone_number";
            phone_number.Width = 150;
            // 
            // service
            // 
            service.MinimumWidth = 8;
            service.Name = "service";
            service.Width = 150;
            // 
            // created_At
            // 
            created_At.MinimumWidth = 8;
            created_At.Name = "created_At";
            created_At.Width = 150;
            // 
            // status
            // 
            status.MinimumWidth = 8;
            status.Name = "status";
            status.Width = 150;
            // 
            // dashboardWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1478, 944);
            Controls.Add(panelContainer);
            Controls.Add(sidebar);
            Controls.Add(panel3);
            MinimumSize = new Size(1500, 1000);
            Name = "dashboardWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Auto Service System";
            WindowState = FormWindowState.Maximized;
            Load += recordsForm_Load;
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            sidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private Button logoutbtn;
        private Button serviceHistoryBtn;
        private Panel sidebar;
        private Button recordsBtn;
        private Button dashboardBtn;
        private PictureBox logo;
        private Panel panelContainer;
        private Label label1;
        private Button bookingQBtn;
        private DataGridViewTextBoxColumn booking_ID;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn phone_number;
        private DataGridViewTextBoxColumn service;
        private DataGridViewTextBoxColumn created_At;
        private DataGridViewTextBoxColumn status;
        private Button employeesBtn;
        private Button productBtn;
    }
}