namespace Auto_Service
{
    partial class employeeManagement
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
            employeesView = new DataGridView();
            label3 = new Label();
            addEmployeeBtn = new Button();
            editEmployeeButton = new Button();
            deleteEmployeeBtn = new Button();
            exportBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)employeesView).BeginInit();
            SuspendLayout();
            // 
            // employeesView
            // 
            employeesView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employeesView.Dock = DockStyle.Bottom;
            employeesView.Location = new Point(0, 123);
            employeesView.Name = "employeesView";
            employeesView.RowHeadersWidth = 62;
            employeesView.Size = new Size(1173, 735);
            employeesView.TabIndex = 0;
            employeesView.CellContentClick += employeesView_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(44, 31);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(243, 54);
            label3.TabIndex = 7;
            label3.Text = "EMPLOYEES";
            // 
            // addEmployeeBtn
            // 
            addEmployeeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addEmployeeBtn.BackColor = Color.FromArgb(55, 55, 55);
            addEmployeeBtn.FlatAppearance.BorderSize = 0;
            addEmployeeBtn.FlatStyle = FlatStyle.Flat;
            addEmployeeBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addEmployeeBtn.ForeColor = Color.White;
            addEmployeeBtn.Location = new Point(723, 38);
            addEmployeeBtn.Name = "addEmployeeBtn";
            addEmployeeBtn.Padding = new Padding(30, 0, 0, 0);
            addEmployeeBtn.Size = new Size(121, 54);
            addEmployeeBtn.TabIndex = 16;
            addEmployeeBtn.Text = "ADD";
            addEmployeeBtn.TextAlign = ContentAlignment.MiddleLeft;
            addEmployeeBtn.UseVisualStyleBackColor = false;
            addEmployeeBtn.Click += addEmployeeBtn_Click;
            // 
            // editEmployeeButton
            // 
            editEmployeeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            editEmployeeButton.BackColor = Color.FromArgb(55, 55, 55);
            editEmployeeButton.FlatAppearance.BorderSize = 0;
            editEmployeeButton.FlatStyle = FlatStyle.Flat;
            editEmployeeButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editEmployeeButton.ForeColor = Color.White;
            editEmployeeButton.Location = new Point(850, 38);
            editEmployeeButton.Name = "editEmployeeButton";
            editEmployeeButton.Padding = new Padding(30, 0, 0, 0);
            editEmployeeButton.Size = new Size(123, 54);
            editEmployeeButton.TabIndex = 17;
            editEmployeeButton.Text = "EDIT";
            editEmployeeButton.TextAlign = ContentAlignment.MiddleLeft;
            editEmployeeButton.UseVisualStyleBackColor = false;
            editEmployeeButton.Click += editEmployeeButton_Click;
            // 
            // deleteEmployeeBtn
            // 
            deleteEmployeeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            deleteEmployeeBtn.BackColor = Color.FromArgb(55, 55, 55);
            deleteEmployeeBtn.FlatAppearance.BorderSize = 0;
            deleteEmployeeBtn.FlatStyle = FlatStyle.Flat;
            deleteEmployeeBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteEmployeeBtn.ForeColor = Color.White;
            deleteEmployeeBtn.Location = new Point(979, 38);
            deleteEmployeeBtn.Name = "deleteEmployeeBtn";
            deleteEmployeeBtn.Padding = new Padding(30, 0, 0, 0);
            deleteEmployeeBtn.Size = new Size(157, 54);
            deleteEmployeeBtn.TabIndex = 18;
            deleteEmployeeBtn.Text = "DELETE";
            deleteEmployeeBtn.TextAlign = ContentAlignment.MiddleLeft;
            deleteEmployeeBtn.UseVisualStyleBackColor = false;
            deleteEmployeeBtn.Click += deleteEmployeeBtn_Click;
            // 
            // exportBtn
            // 
            exportBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            exportBtn.BackColor = Color.FromArgb(55, 55, 55);
            exportBtn.FlatAppearance.BorderSize = 0;
            exportBtn.FlatStyle = FlatStyle.Flat;
            exportBtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exportBtn.ForeColor = Color.White;
            exportBtn.Location = new Point(535, 38);
            exportBtn.Name = "exportBtn";
            exportBtn.Padding = new Padding(30, 0, 0, 0);
            exportBtn.Size = new Size(141, 54);
            exportBtn.TabIndex = 19;
            exportBtn.Text = "EXPORT";
            exportBtn.TextAlign = ContentAlignment.MiddleLeft;
            exportBtn.UseVisualStyleBackColor = false;
            exportBtn.Click += exportBtn_Click;
            // 
            // employeeManagement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(exportBtn);
            Controls.Add(deleteEmployeeBtn);
            Controls.Add(editEmployeeButton);
            Controls.Add(addEmployeeBtn);
            Controls.Add(label3);
            Controls.Add(employeesView);
            Name = "employeeManagement";
            Size = new Size(1173, 858);
            ((System.ComponentModel.ISupportInitialize)employeesView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView employeesView;
        private Label label3;
        private Button addEmployeeBtn;
        private Button editEmployeeButton;
        private Button deleteEmployeeBtn;
        private Button exportBtn;
    }
}
