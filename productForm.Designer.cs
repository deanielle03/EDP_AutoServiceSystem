namespace Auto_Service
{
    partial class productForm
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
            label3 = new Label();
            productName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            productPrice = new TextBox();
            label4 = new Label();
            productQuantity = new TextBox();
            cancelBtn = new Button();
            submitBtn = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(255, 128, 0);
            label3.Location = new Point(47, 25);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(252, 28);
            label3.TabIndex = 25;
            label3.Text = "PRODUCT INFORMATION";
            // 
            // productName
            // 
            productName.Location = new Point(217, 73);
            productName.Name = "productName";
            productName.Size = new Size(365, 31);
            productName.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(139, 73);
            label1.Name = "label1";
            label1.Size = new Size(77, 28);
            label1.TabIndex = 30;
            label1.Text = "Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(149, 120);
            label2.Name = "label2";
            label2.Size = new Size(67, 28);
            label2.TabIndex = 31;
            label2.Text = "Price :";
            // 
            // productPrice
            // 
            productPrice.Location = new Point(217, 118);
            productPrice.Name = "productPrice";
            productPrice.Size = new Size(365, 31);
            productPrice.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(115, 166);
            label4.Name = "label4";
            label4.Size = new Size(101, 28);
            label4.TabIndex = 33;
            label4.Text = "Quantity :";
            // 
            // productQuantity
            // 
            productQuantity.Location = new Point(217, 166);
            productQuantity.Name = "productQuantity";
            productQuantity.Size = new Size(365, 31);
            productQuantity.TabIndex = 34;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.Transparent;
            cancelBtn.FlatAppearance.BorderColor = Color.White;
            cancelBtn.FlatAppearance.BorderSize = 2;
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelBtn.ForeColor = Color.White;
            cancelBtn.Location = new Point(300, 228);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(134, 45);
            cancelBtn.TabIndex = 35;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // submitBtn
            // 
            submitBtn.BackColor = Color.FromArgb(255, 128, 0);
            submitBtn.FlatAppearance.BorderSize = 0;
            submitBtn.FlatStyle = FlatStyle.Flat;
            submitBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            submitBtn.ForeColor = Color.White;
            submitBtn.Location = new Point(448, 228);
            submitBtn.MaximumSize = new Size(134, 45);
            submitBtn.MinimumSize = new Size(134, 45);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(134, 45);
            submitBtn.TabIndex = 36;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = false;
            submitBtn.Click += submitBtn_Click;
            // 
            // productForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(634, 300);
            Controls.Add(submitBtn);
            Controls.Add(cancelBtn);
            Controls.Add(productQuantity);
            Controls.Add(label4);
            Controls.Add(productPrice);
            Controls.Add(label2);
            Controls.Add(productName);
            Controls.Add(label1);
            Controls.Add(label3);
            MaximizeBox = false;
            MaximumSize = new Size(656, 356);
            MinimizeBox = false;
            MinimumSize = new Size(656, 356);
            Name = "productForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "productForm";
            Load += productForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox productName;
        private Label label1;
        private Label label2;
        private TextBox productPrice;
        private Label label4;
        private TextBox productQuantity;
        private Button cancelBtn;
        private Button submitBtn;
    }
}