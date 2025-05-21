namespace Auto_Service
{
    partial class serviceHistory
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
            servicesView = new DataGridView();
            exportBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)servicesView).BeginInit();
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
            label3.Size = new Size(357, 54);
            label3.TabIndex = 4;
            label3.Text = "SERVICE HISTORY";
            // 
            // servicesView
            // 
            servicesView.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            servicesView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            servicesView.Location = new Point(3, 120);
            servicesView.Name = "servicesView";
            servicesView.RowHeadersWidth = 62;
            servicesView.Size = new Size(1170, 735);
            servicesView.TabIndex = 5;
            servicesView.CellContentClick += servicesView_CellContentClick;
            // 
            // exportBtn
            // 
            exportBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            exportBtn.BackColor = Color.FromArgb(55, 55, 55);
            exportBtn.FlatAppearance.BorderSize = 0;
            exportBtn.FlatStyle = FlatStyle.Flat;
            exportBtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exportBtn.ForeColor = Color.White;
            exportBtn.Location = new Point(977, 31);
            exportBtn.Name = "exportBtn";
            exportBtn.Padding = new Padding(30, 0, 0, 0);
            exportBtn.Size = new Size(141, 54);
            exportBtn.TabIndex = 13;
            exportBtn.Text = "EXPORT";
            exportBtn.TextAlign = ContentAlignment.MiddleLeft;
            exportBtn.UseVisualStyleBackColor = false;
            exportBtn.Click += exportBtn_Click;
            // 
            // serviceHistory
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            Controls.Add(exportBtn);
            Controls.Add(servicesView);
            Controls.Add(label3);
            Name = "serviceHistory";
            Size = new Size(1173, 858);
            Load += serviceHistory_Load;
            ((System.ComponentModel.ISupportInitialize)servicesView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private DataGridView servicesView;
        private Button exportBtn;
    }
}
