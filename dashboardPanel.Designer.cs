namespace Auto_Service
{
    partial class dashboardPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label3 = new Label();
            totalBookingsPanel = new Panel();
            label1 = new Label();
            totalBookingsLabel = new Label();
            totalCustomerPanel = new Panel();
            label4 = new Label();
            totalCustomerLabel = new Label();
            totalExpensesPanel = new Panel();
            label6 = new Label();
            totalExpensesLabel = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label8 = new Label();
            addServiceBtn = new Button();
            serviceHistoryView = new DataGridView();
            totalBookingsPanel.SuspendLayout();
            totalCustomerPanel.SuspendLayout();
            totalExpensesPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)serviceHistoryView).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(44, 31);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(272, 54);
            label3.TabIndex = 4;
            label3.Text = "DASHBOARD";
            // 
            // totalBookingsPanel
            // 
            totalBookingsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            totalBookingsPanel.BackColor = SystemColors.Window;
            totalBookingsPanel.Controls.Add(label1);
            totalBookingsPanel.Controls.Add(totalBookingsLabel);
            totalBookingsPanel.Location = new Point(10, 10);
            totalBookingsPanel.Margin = new Padding(10);
            totalBookingsPanel.Name = "totalBookingsPanel";
            totalBookingsPanel.Padding = new Padding(10);
            totalBookingsPanel.Size = new Size(277, 119);
            totalBookingsPanel.TabIndex = 5;
            totalBookingsPanel.Paint += totalBookingsPanel_Paint_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Bottom;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 77);
            label1.Name = "label1";
            label1.Size = new Size(210, 32);
            label1.TabIndex = 0;
            label1.Text = "TOTAL BOOKINGS";
            label1.Click += label1_Click;
            // 
            // totalBookingsLabel
            // 
            totalBookingsLabel.AutoSize = true;
            totalBookingsLabel.BackColor = Color.Transparent;
            totalBookingsLabel.Dock = DockStyle.Top;
            totalBookingsLabel.FlatStyle = FlatStyle.Flat;
            totalBookingsLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalBookingsLabel.ForeColor = Color.Black;
            totalBookingsLabel.Location = new Point(10, 10);
            totalBookingsLabel.Name = "totalBookingsLabel";
            totalBookingsLabel.Size = new Size(69, 54);
            totalBookingsLabel.TabIndex = 1;
            totalBookingsLabel.Text = "20";
            totalBookingsLabel.Click += label2_Click;
            // 
            // totalCustomerPanel
            // 
            totalCustomerPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            totalCustomerPanel.BackColor = Color.White;
            totalCustomerPanel.Controls.Add(label4);
            totalCustomerPanel.Controls.Add(totalCustomerLabel);
            totalCustomerPanel.Location = new Point(307, 10);
            totalCustomerPanel.Margin = new Padding(10);
            totalCustomerPanel.Name = "totalCustomerPanel";
            totalCustomerPanel.Padding = new Padding(10);
            totalCustomerPanel.Size = new Size(277, 119);
            totalCustomerPanel.TabIndex = 6;
            totalCustomerPanel.Paint += totalCustomerPanel_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Bottom;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(10, 77);
            label4.Name = "label4";
            label4.Size = new Size(226, 32);
            label4.TabIndex = 0;
            label4.Text = "TOTAL CUSTOMERS";
            // 
            // totalCustomerLabel
            // 
            totalCustomerLabel.AutoSize = true;
            totalCustomerLabel.BackColor = Color.Transparent;
            totalCustomerLabel.Dock = DockStyle.Fill;
            totalCustomerLabel.FlatStyle = FlatStyle.Flat;
            totalCustomerLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalCustomerLabel.ForeColor = Color.Black;
            totalCustomerLabel.Location = new Point(10, 10);
            totalCustomerLabel.Name = "totalCustomerLabel";
            totalCustomerLabel.Size = new Size(234, 54);
            totalCustomerLabel.TabIndex = 1;
            totalCustomerLabel.Text = "Php 75,000";
            // 
            // totalExpensesPanel
            // 
            totalExpensesPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            totalExpensesPanel.BackColor = Color.White;
            totalExpensesPanel.Controls.Add(label6);
            totalExpensesPanel.Controls.Add(totalExpensesLabel);
            totalExpensesPanel.Location = new Point(604, 10);
            totalExpensesPanel.Margin = new Padding(10);
            totalExpensesPanel.Name = "totalExpensesPanel";
            totalExpensesPanel.Padding = new Padding(10);
            totalExpensesPanel.Size = new Size(277, 119);
            totalExpensesPanel.TabIndex = 7;
            totalExpensesPanel.Paint += totalExpensesPanel_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Bottom;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(10, 77);
            label6.Name = "label6";
            label6.Size = new Size(198, 32);
            label6.TabIndex = 0;
            label6.Text = "TOTAL EXPENSES";
            // 
            // totalExpensesLabel
            // 
            totalExpensesLabel.AutoSize = true;
            totalExpensesLabel.BackColor = Color.Transparent;
            totalExpensesLabel.Dock = DockStyle.Fill;
            totalExpensesLabel.FlatStyle = FlatStyle.Flat;
            totalExpensesLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalExpensesLabel.ForeColor = Color.Black;
            totalExpensesLabel.Location = new Point(10, 10);
            totalExpensesLabel.Name = "totalExpensesLabel";
            totalExpensesLabel.Size = new Size(234, 54);
            totalExpensesLabel.TabIndex = 1;
            totalExpensesLabel.Text = "Php 25,000";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.2211F));
            tableLayoutPanel1.Controls.Add(totalCustomerPanel, 1, 0);
            tableLayoutPanel1.Controls.Add(totalExpensesPanel, 2, 0);
            tableLayoutPanel1.Controls.Add(totalBookingsPanel, 0, 0);
            tableLayoutPanel1.Location = new Point(138, 133);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(891, 139);
            tableLayoutPanel1.TabIndex = 8;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(151, 379);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.Yes;
            label8.Size = new Size(178, 32);
            label8.TabIndex = 10;
            label8.Text = "Service History";
            // 
            // addServiceBtn
            // 
            addServiceBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addServiceBtn.BackColor = Color.FromArgb(55, 55, 55);
            addServiceBtn.FlatAppearance.BorderSize = 0;
            addServiceBtn.FlatStyle = FlatStyle.Flat;
            addServiceBtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addServiceBtn.ForeColor = Color.White;
            addServiceBtn.Location = new Point(831, 31);
            addServiceBtn.Name = "addServiceBtn";
            addServiceBtn.Padding = new Padding(30, 0, 0, 0);
            addServiceBtn.Size = new Size(188, 54);
            addServiceBtn.TabIndex = 12;
            addServiceBtn.Text = "ADD SERVICE";
            addServiceBtn.TextAlign = ContentAlignment.MiddleLeft;
            addServiceBtn.UseVisualStyleBackColor = false;
            addServiceBtn.Click += addServiceBtn_Click_1;
            // 
            // serviceHistoryView
            // 
            serviceHistoryView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            serviceHistoryView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            serviceHistoryView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            serviceHistoryView.Location = new Point(138, 433);
            serviceHistoryView.Name = "serviceHistoryView";
            serviceHistoryView.RowHeadersWidth = 62;
            serviceHistoryView.Size = new Size(891, 339);
            serviceHistoryView.TabIndex = 14;
            serviceHistoryView.CellContentClick += serviceHistoryView_CellContentClick;
            // 
            // dashboardPanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            Controls.Add(addServiceBtn);
            Controls.Add(serviceHistoryView);
            Controls.Add(label8);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label3);
            Margin = new Padding(10);
            Name = "dashboardPanel";
            Size = new Size(1173, 851);
            Load += dashboardPanel_Load;
            totalBookingsPanel.ResumeLayout(false);
            totalBookingsPanel.PerformLayout();
            totalCustomerPanel.ResumeLayout(false);
            totalCustomerPanel.PerformLayout();
            totalExpensesPanel.ResumeLayout(false);
            totalExpensesPanel.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)serviceHistoryView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Panel totalBookingsPanel;
        private Label label1;
        private Label totalBookingsLabel;
        private Panel totalCustomerPanel;
        private Label label4;
        private Label totalCustomerLabel;
        private Panel totalExpensesPanel;
        private Label label6;
        private Label totalExpensesLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label8;
        private Panel panel15;
        private Panel panel14;
        private Button addServiceBtn;
        private DataGridView serviceHistoryView;
    }
}
