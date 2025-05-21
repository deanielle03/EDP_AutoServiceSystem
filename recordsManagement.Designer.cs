namespace Auto_Service
{
    partial class recordsManagement
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
            vehiclestab = new TabPage();
            vehiclesView = new DataGridView();
            servicestab = new TabPage();
            servicesView = new DataGridView();
            repairstab = new TabPage();
            repairsView = new DataGridView();
            expensestab = new TabPage();
            expensesView = new DataGridView();
            customerstab = new TabPage();
            customersView = new DataGridView();
            tabControl = new TabControl();
            vehiclestab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)vehiclesView).BeginInit();
            servicestab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)servicesView).BeginInit();
            repairstab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)repairsView).BeginInit();
            expensestab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)expensesView).BeginInit();
            customerstab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customersView).BeginInit();
            tabControl.SuspendLayout();
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
            label3.Size = new Size(203, 54);
            label3.TabIndex = 3;
            label3.Text = "RECORDS";
            // 
            // vehiclestab
            // 
            vehiclestab.BackColor = Color.Black;
            vehiclestab.Controls.Add(vehiclesView);
            vehiclestab.Cursor = Cursors.Hand;
            vehiclestab.Location = new Point(4, 34);
            vehiclestab.Name = "vehiclestab";
            vehiclestab.Padding = new Padding(3);
            vehiclestab.Size = new Size(1159, 709);
            vehiclestab.TabIndex = 7;
            vehiclestab.Text = "Vehicles";
            // 
            // vehiclesView
            // 
            vehiclesView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            vehiclesView.Dock = DockStyle.Fill;
            vehiclesView.Location = new Point(3, 3);
            vehiclesView.Name = "vehiclesView";
            vehiclesView.RowHeadersWidth = 62;
            vehiclesView.Size = new Size(1153, 703);
            vehiclesView.TabIndex = 0;
            vehiclesView.CellContentClick += vehiclesView_CellContentClick;
            // 
            // servicestab
            // 
            servicestab.BackColor = Color.Black;
            servicestab.Controls.Add(servicesView);
            servicestab.Cursor = Cursors.Hand;
            servicestab.Location = new Point(4, 34);
            servicestab.Name = "servicestab";
            servicestab.Padding = new Padding(3);
            servicestab.Size = new Size(1159, 709);
            servicestab.TabIndex = 6;
            servicestab.Text = "Services";
            // 
            // servicesView
            // 
            servicesView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            servicesView.Dock = DockStyle.Fill;
            servicesView.Location = new Point(3, 3);
            servicesView.Name = "servicesView";
            servicesView.RowHeadersWidth = 62;
            servicesView.Size = new Size(1153, 703);
            servicesView.TabIndex = 0;
            // 
            // repairstab
            // 
            repairstab.BackColor = Color.Black;
            repairstab.Controls.Add(repairsView);
            repairstab.Cursor = Cursors.Hand;
            repairstab.Location = new Point(4, 34);
            repairstab.Name = "repairstab";
            repairstab.Padding = new Padding(3);
            repairstab.Size = new Size(1159, 709);
            repairstab.TabIndex = 4;
            repairstab.Text = "Repairs";
            // 
            // repairsView
            // 
            repairsView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            repairsView.Dock = DockStyle.Fill;
            repairsView.Location = new Point(3, 3);
            repairsView.Name = "repairsView";
            repairsView.RowHeadersWidth = 62;
            repairsView.Size = new Size(1153, 703);
            repairsView.TabIndex = 0;
            repairsView.CellContentClick += repairsView_CellContentClick_1;
            // 
            // expensestab
            // 
            expensestab.BackColor = Color.Black;
            expensestab.Controls.Add(expensesView);
            expensestab.Cursor = Cursors.Hand;
            expensestab.Location = new Point(4, 34);
            expensestab.Name = "expensestab";
            expensestab.Padding = new Padding(3);
            expensestab.Size = new Size(1159, 709);
            expensestab.TabIndex = 3;
            expensestab.Text = "Expenses";
            // 
            // expensesView
            // 
            expensesView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            expensesView.Dock = DockStyle.Fill;
            expensesView.Location = new Point(3, 3);
            expensesView.Name = "expensesView";
            expensesView.RowHeadersWidth = 62;
            expensesView.Size = new Size(1153, 703);
            expensesView.TabIndex = 0;
            // 
            // customerstab
            // 
            customerstab.BackColor = Color.Black;
            customerstab.Controls.Add(customersView);
            customerstab.Cursor = Cursors.Hand;
            customerstab.Location = new Point(4, 34);
            customerstab.Name = "customerstab";
            customerstab.Padding = new Padding(3);
            customerstab.Size = new Size(1159, 709);
            customerstab.TabIndex = 0;
            customerstab.Text = "Customers";
            // 
            // customersView
            // 
            customersView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customersView.Dock = DockStyle.Fill;
            customersView.Location = new Point(3, 3);
            customersView.Name = "customersView";
            customersView.RowHeadersWidth = 62;
            customersView.Size = new Size(1153, 703);
            customersView.TabIndex = 0;
            customersView.CellContentClick += customersView_CellContentClick;
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Controls.Add(customerstab);
            tabControl.Controls.Add(expensestab);
            tabControl.Controls.Add(repairstab);
            tabControl.Controls.Add(servicestab);
            tabControl.Controls.Add(vehiclestab);
            tabControl.Location = new Point(4, 106);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1167, 747);
            tabControl.TabIndex = 4;
            // 
            // recordsManagement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveCaptionText;
            Controls.Add(tabControl);
            Controls.Add(label3);
            Name = "recordsManagement";
            Size = new Size(1173, 858);
            Load += recordsManagement_Load;
            vehiclestab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)vehiclesView).EndInit();
            servicestab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)servicesView).EndInit();
            repairstab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)repairsView).EndInit();
            expensestab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)expensesView).EndInit();
            customerstab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)customersView).EndInit();
            tabControl.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TabPage vehiclestab;
        private TabPage servicestab;
        private TabPage repairstab;
        private TabPage expensestab;
        private TabPage customerstab;
        private DataGridView customersView;
        private TabControl tabControl;
        private DataGridView expensesView;
        private DataGridView vehiclesView;
        private DataGridView servicesView;
        private DataGridView repairsView;
    }
}
