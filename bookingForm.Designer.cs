﻿namespace Auto_Service
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
            serviceNameBooking = new ComboBox();
            fNameBooking = new TextBox();
            phoneNumBooking = new TextBox();
            label1 = new Label();
            label4 = new Label();
            cancelBtn = new Button();
            submitBtn = new Button();
            label2 = new Label();
            statusDDown = new ComboBox();
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
            // serviceNameBooking
            // 
            serviceNameBooking.DropDownStyle = ComboBoxStyle.DropDownList;
            serviceNameBooking.FormattingEnabled = true;
            serviceNameBooking.Location = new Point(217, 166);
            serviceNameBooking.Name = "serviceNameBooking";
            serviceNameBooking.Size = new Size(365, 33);
            serviceNameBooking.TabIndex = 31;
            serviceNameBooking.SelectedIndexChanged += serviceNameBooking_SelectedIndexChanged;
            // 
            // fNameBooking
            // 
            fNameBooking.Location = new Point(217, 73);
            fNameBooking.Name = "fNameBooking";
            fNameBooking.Size = new Size(365, 31);
            fNameBooking.TabIndex = 25;
            // 
            // phoneNumBooking
            // 
            phoneNumBooking.Location = new Point(217, 120);
            phoneNumBooking.Name = "phoneNumBooking";
            phoneNumBooking.Size = new Size(365, 31);
            phoneNumBooking.TabIndex = 27;
            phoneNumBooking.TextChanged += phoneNumBooking_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(139, 73);
            label1.Name = "label1";
            label1.Size = new Size(77, 28);
            label1.TabIndex = 28;
            label1.Text = "Name :";
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
            cancelBtn.Location = new Point(300, 283);
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
            submitBtn.Location = new Point(448, 283);
            submitBtn.MaximumSize = new Size(134, 45);
            submitBtn.MinimumSize = new Size(134, 45);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(134, 45);
            submitBtn.TabIndex = 34;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = false;
            submitBtn.Click += submitBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(138, 216);
            label2.Name = "label2";
            label2.Size = new Size(78, 28);
            label2.TabIndex = 35;
            label2.Text = "Status :";
            // 
            // statusDDown
            // 
            statusDDown.DropDownStyle = ComboBoxStyle.DropDownList;
            statusDDown.FormattingEnabled = true;
            statusDDown.Location = new Point(217, 216);
            statusDDown.Name = "statusDDown";
            statusDDown.Size = new Size(365, 33);
            statusDDown.TabIndex = 36;
            // 
            // bookingForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            ClientSize = new Size(634, 358);
            Controls.Add(statusDDown);
            Controls.Add(label2);
            Controls.Add(submitBtn);
            Controls.Add(cancelBtn);
            Controls.Add(label12);
            Controls.Add(label3);
            Controls.Add(serviceNameBooking);
            Controls.Add(fNameBooking);
            Controls.Add(phoneNumBooking);
            Controls.Add(label1);
            Controls.Add(label4);
            MaximizeBox = false;
            MaximumSize = new Size(656, 414);
            MinimizeBox = false;
            MinimumSize = new Size(656, 414);
            Name = "bookingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Booking Form";
            Load += bookingForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label12;
        private Label label3;
        private ComboBox serviceNameBooking;
        private TextBox fNameBooking;
        private TextBox phoneNumBooking;
        private Label label1;
        private Label label4;
        private Button cancelBtn;
        private Button submitBtn;
        private Label label2;
        private ComboBox statusDDown;
    }
}