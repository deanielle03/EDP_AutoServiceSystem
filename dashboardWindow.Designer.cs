
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
            transactionHistoryBtn = new Button();
            serviceHistoryBtn = new Button();
            sidebar = new Panel();
            recordsBtn = new Button();
            dashboardBtn = new Button();
            panelContainer = new Panel();
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
            // transactionHistoryBtn
            // 
            transactionHistoryBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            transactionHistoryBtn.BackColor = Color.FromArgb(55, 55, 55);
            transactionHistoryBtn.FlatAppearance.BorderSize = 0;
            transactionHistoryBtn.FlatStyle = FlatStyle.Flat;
            transactionHistoryBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            transactionHistoryBtn.ForeColor = Color.White;
            transactionHistoryBtn.Location = new Point(0, 286);
            transactionHistoryBtn.Name = "transactionHistoryBtn";
            transactionHistoryBtn.Padding = new Padding(30, 0, 0, 0);
            transactionHistoryBtn.Size = new Size(299, 82);
            transactionHistoryBtn.TabIndex = 3;
            transactionHistoryBtn.Text = "TRANSACTION HISTORY";
            transactionHistoryBtn.TextAlign = ContentAlignment.MiddleLeft;
            transactionHistoryBtn.UseVisualStyleBackColor = false;
            transactionHistoryBtn.Click += transactionHistoryBtn_Click;
            // 
            // serviceHistoryBtn
            // 
            serviceHistoryBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            serviceHistoryBtn.BackColor = Color.FromArgb(55, 55, 55);
            serviceHistoryBtn.FlatAppearance.BorderSize = 0;
            serviceHistoryBtn.FlatStyle = FlatStyle.Flat;
            serviceHistoryBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            serviceHistoryBtn.ForeColor = Color.White;
            serviceHistoryBtn.Location = new Point(0, 198);
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
            sidebar.Controls.Add(recordsBtn);
            sidebar.Controls.Add(dashboardBtn);
            sidebar.Controls.Add(serviceHistoryBtn);
            sidebar.Controls.Add(transactionHistoryBtn);
            sidebar.Location = new Point(0, 86);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(299, 857);
            sidebar.TabIndex = 2;
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
            recordsBtn.Location = new Point(0, 110);
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
        private Button transactionHistoryBtn;
        private Panel sidebar;
        private Button recordsBtn;
        private Button dashboardBtn;
        private PictureBox logo;
        private Panel panelContainer;
        private Label label1;
    }
}