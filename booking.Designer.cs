namespace Auto_Service
{
    partial class booking
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
            bookingView = new DataGridView();
            label3 = new Label();
            editBookingBtn = new Button();
            addBookingBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)bookingView).BeginInit();
            SuspendLayout();
            // 
            // bookingView
            // 
            bookingView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bookingView.Dock = DockStyle.Bottom;
            bookingView.GridColor = Color.Black;
            bookingView.Location = new Point(0, 123);
            bookingView.Name = "bookingView";
            bookingView.RowHeadersWidth = 62;
            bookingView.Size = new Size(1173, 735);
            bookingView.TabIndex = 0;
            bookingView.CellContentClick += bookingView_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(44, 31);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(349, 54);
            label3.TabIndex = 5;
            label3.Text = "BOOKING QUEUE";
            // 
            // editBookingBtn
            // 
            editBookingBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            editBookingBtn.BackColor = Color.FromArgb(55, 55, 55);
            editBookingBtn.FlatAppearance.BorderSize = 0;
            editBookingBtn.FlatStyle = FlatStyle.Flat;
            editBookingBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editBookingBtn.ForeColor = Color.White;
            editBookingBtn.Location = new Point(894, 38);
            editBookingBtn.Name = "editBookingBtn";
            editBookingBtn.Padding = new Padding(30, 0, 0, 0);
            editBookingBtn.Size = new Size(216, 54);
            editBookingBtn.TabIndex = 13;
            editBookingBtn.Text = "EDIT BOOKING";
            editBookingBtn.TextAlign = ContentAlignment.MiddleLeft;
            editBookingBtn.UseVisualStyleBackColor = false;
            editBookingBtn.Click += editBookingBtn_Click;
            // 
            // addBookingBtn
            // 
            addBookingBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addBookingBtn.BackColor = Color.FromArgb(55, 55, 55);
            addBookingBtn.FlatAppearance.BorderSize = 0;
            addBookingBtn.FlatStyle = FlatStyle.Flat;
            addBookingBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addBookingBtn.ForeColor = Color.White;
            addBookingBtn.Location = new Point(659, 38);
            addBookingBtn.Name = "addBookingBtn";
            addBookingBtn.Padding = new Padding(30, 0, 0, 0);
            addBookingBtn.Size = new Size(216, 54);
            addBookingBtn.TabIndex = 14;
            addBookingBtn.Text = "ADD BOOKING";
            addBookingBtn.TextAlign = ContentAlignment.MiddleLeft;
            addBookingBtn.UseVisualStyleBackColor = false;
            addBookingBtn.Click += addBookingBtn_Click;
            // 
            // booking
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(addBookingBtn);
            Controls.Add(editBookingBtn);
            Controls.Add(label3);
            Controls.Add(bookingView);
            Name = "booking";
            Size = new Size(1173, 858);
            ((System.ComponentModel.ISupportInitialize)bookingView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridViewTextBoxColumn booking_id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn phone_number;
        private DataGridViewTextBoxColumn service;
        private DataGridViewTextBoxColumn created_At;
        private DataGridViewTextBoxColumn status;
        private DataGridViewButtonColumn action;
        private DataGridView bookingView;
        private Label label3;
        private DataGridViewButtonColumn add_action;
        private DataGridViewButtonColumn edit_action;
        private Button editBookingBtn;
        private Button addBookingBtn;
    }
}
