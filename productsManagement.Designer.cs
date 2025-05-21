

namespace Auto_Service
{
    partial class productsManagement
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
            productsView = new DataGridView();
            label3 = new Label();
            deleteProductBtn = new Button();
            editProductButton = new Button();
            addProductBtn = new Button();
            exportBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)productsView).BeginInit();
            SuspendLayout();
            // 
            // productsView
            // 
            productsView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsView.Dock = DockStyle.Bottom;
            productsView.Location = new Point(0, 123);
            productsView.Name = "productsView";
            productsView.RowHeadersWidth = 62;
            productsView.Size = new Size(1173, 735);
            productsView.TabIndex = 0;
            productsView.CellContentClick += productsView_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(44, 31);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(233, 54);
            label3.TabIndex = 6;
            label3.Text = "PRODUCTS";
            // 
            // deleteProductBtn
            // 
            deleteProductBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            deleteProductBtn.BackColor = Color.FromArgb(55, 55, 55);
            deleteProductBtn.FlatAppearance.BorderSize = 0;
            deleteProductBtn.FlatStyle = FlatStyle.Flat;
            deleteProductBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteProductBtn.ForeColor = Color.White;
            deleteProductBtn.Location = new Point(979, 38);
            deleteProductBtn.Name = "deleteProductBtn";
            deleteProductBtn.Padding = new Padding(30, 0, 0, 0);
            deleteProductBtn.Size = new Size(157, 54);
            deleteProductBtn.TabIndex = 17;
            deleteProductBtn.Text = "DELETE";
            deleteProductBtn.TextAlign = ContentAlignment.MiddleLeft;
            deleteProductBtn.UseVisualStyleBackColor = false;
            deleteProductBtn.Click += deleteProductBtn_Click;
            // 
            // editProductButton
            // 
            editProductButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            editProductButton.BackColor = Color.FromArgb(55, 55, 55);
            editProductButton.FlatAppearance.BorderSize = 0;
            editProductButton.FlatStyle = FlatStyle.Flat;
            editProductButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editProductButton.ForeColor = Color.White;
            editProductButton.Location = new Point(850, 38);
            editProductButton.Name = "editProductButton";
            editProductButton.Padding = new Padding(30, 0, 0, 0);
            editProductButton.Size = new Size(123, 54);
            editProductButton.TabIndex = 16;
            editProductButton.Text = "EDIT";
            editProductButton.TextAlign = ContentAlignment.MiddleLeft;
            editProductButton.UseVisualStyleBackColor = false;
            editProductButton.Click += editProductButton_Click;
            // 
            // addProductBtn
            // 
            addProductBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addProductBtn.BackColor = Color.FromArgb(55, 55, 55);
            addProductBtn.FlatAppearance.BorderSize = 0;
            addProductBtn.FlatStyle = FlatStyle.Flat;
            addProductBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addProductBtn.ForeColor = Color.White;
            addProductBtn.Location = new Point(723, 38);
            addProductBtn.Name = "addProductBtn";
            addProductBtn.Padding = new Padding(30, 0, 0, 0);
            addProductBtn.Size = new Size(121, 54);
            addProductBtn.TabIndex = 18;
            addProductBtn.Text = "ADD";
            addProductBtn.TextAlign = ContentAlignment.MiddleLeft;
            addProductBtn.UseVisualStyleBackColor = false;
            addProductBtn.Click += addProductBtn_Click;
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
            exportBtn.TabIndex = 20;
            exportBtn.Text = "EXPORT";
            exportBtn.TextAlign = ContentAlignment.MiddleLeft;
            exportBtn.UseVisualStyleBackColor = false;
            exportBtn.Click += exportBtn_Click;
            // 
            // productsManagement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(exportBtn);
            Controls.Add(addProductBtn);
            Controls.Add(deleteProductBtn);
            Controls.Add(editProductButton);
            Controls.Add(label3);
            Controls.Add(productsView);
            Name = "productsManagement";
            Size = new Size(1173, 858);
            Load += productsManagement_Load;
            ((System.ComponentModel.ISupportInitialize)productsView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView productsView;
        private Label label3;
        private Button deleteProductBtn;
        private Button editProductButton;
        private Button addProductBtn;
        private Button exportBtn;
    }
}
