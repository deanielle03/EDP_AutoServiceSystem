namespace Auto_Service
{
    partial class bookingForm
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
            label12 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label4 = new Label();
            cancelBtn = new Button();
            submitBtn = new Button();
            SuspendLayout();
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(128, 166);
            label12.Name = "label12";
            label12.Size = new Size(88, 28);
            label12.TabIndex = 32;
            label12.Text = "Service :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(255, 128, 0);
            label3.Location = new Point(47, 25);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(251, 28);
            label3.TabIndex = 24;
            label3.Text = "BOOKING INFORMATION";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(217, 166);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(365, 33);
            comboBox1.TabIndex = 31;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(217, 73);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(365, 31);
            textBox1.TabIndex = 25;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(217, 120);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(365, 31);
            textBox3.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(95, 73);
            label1.Name = "label1";
            label1.Size = new Size(121, 28);
            label1.TabIndex = 28;
            label1.Text = "First Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(92, 120);
            label4.Name = "label4";
            label4.Size = new Size(124, 28);
            label4.TabIndex = 30;
            label4.Text = "Mobile No. :";
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.Transparent;
            cancelBtn.FlatAppearance.BorderColor = Color.White;
            cancelBtn.FlatAppearance.BorderSize = 2;
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelBtn.ForeColor = Color.White;
            cancelBtn.Location = new Point(300, 227);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(134, 45);
            cancelBtn.TabIndex = 33;
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
            submitBtn.Location = new Point(448, 227);
            submitBtn.MaximumSize = new Size(134, 45);
            submitBtn.MinimumSize = new Size(134, 45);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(134, 45);
            submitBtn.TabIndex = 34;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = false;
            submitBtn.Click += submitBtn_Click;
            // 
            // bookingForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            ClientSize = new Size(634, 307);
            Controls.Add(submitBtn);
            Controls.Add(cancelBtn);
            Controls.Add(label12);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(label4);
            MaximizeBox = false;
            MaximumSize = new Size(656, 363);
            MinimizeBox = false;
            MinimumSize = new Size(656, 363);
            Name = "bookingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Booking Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label12;
        private Label label3;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox3;
        private Label label1;
        private Label label4;
        private Button cancelBtn;
        private Button submitBtn;
    }
}