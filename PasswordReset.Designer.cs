
namespace Auto_Service
{
    partial class PasswordReset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordReset));
            panel2 = new Panel();
            resetbtn = new Button();
            label3 = new Label();
            confPasswordBox = new TextBox();
            newPasswordBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            emailBox = new TextBox();
            label4 = new Label();
            backBtn = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(resetbtn);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(confPasswordBox);
            panel2.Controls.Add(newPasswordBox);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(emailBox);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(111, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(534, 535);
            panel2.TabIndex = 12;
            panel2.Paint += panel2_Paint;
            // 
            // resetbtn
            // 
            resetbtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            resetbtn.BackColor = Color.FromArgb(255, 128, 0);
            resetbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            resetbtn.ForeColor = Color.White;
            resetbtn.Location = new Point(185, 418);
            resetbtn.Name = "resetbtn";
            resetbtn.Size = new Size(171, 54);
            resetbtn.TabIndex = 21;
            resetbtn.Text = "Reset";
            resetbtn.UseVisualStyleBackColor = false;
            resetbtn.Click += resetbtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.White;
            label3.Location = new Point(117, 299);
            label3.Name = "label3";
            label3.Size = new Size(156, 25);
            label3.TabIndex = 20;
            label3.Text = "Confirm Password";
            // 
            // confPasswordBox
            // 
            confPasswordBox.BackColor = Color.WhiteSmoke;
            confPasswordBox.Location = new Point(117, 327);
            confPasswordBox.Name = "confPasswordBox";
            confPasswordBox.PasswordChar = '*';
            confPasswordBox.Size = new Size(309, 31);
            confPasswordBox.TabIndex = 19;
            // 
            // newPasswordBox
            // 
            newPasswordBox.BackColor = Color.WhiteSmoke;
            newPasswordBox.Location = new Point(117, 249);
            newPasswordBox.Name = "newPasswordBox";
            newPasswordBox.PasswordChar = '*';
            newPasswordBox.Size = new Size(309, 31);
            newPasswordBox.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(117, 221);
            label2.Name = "label2";
            label2.Size = new Size(127, 25);
            label2.TabIndex = 16;
            label2.Text = "New Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(117, 125);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 15;
            label1.Text = "email";
            // 
            // emailBox
            // 
            emailBox.BackColor = Color.WhiteSmoke;
            emailBox.Location = new Point(117, 153);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(309, 31);
            emailBox.TabIndex = 13;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Courier New", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(255, 128, 0);
            label4.Location = new Point(49, 43);
            label4.Name = "label4";
            label4.Size = new Size(429, 54);
            label4.TabIndex = 6;
            label4.Text = "Reset Password";
            // 
            // backBtn
            // 
            backBtn.BackgroundImage = (Image)resources.GetObject("backBtn.BackgroundImage");
            backBtn.FlatAppearance.BorderSize = 0;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Location = new Point(24, 21);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(34, 31);
            backBtn.TabIndex = 13;
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // PasswordReset
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(758, 634);
            Controls.Add(backBtn);
            Controls.Add(panel2);
            MaximizeBox = false;
            MaximumSize = new Size(780, 690);
            MinimizeBox = false;
            MinimumSize = new Size(780, 690);
            Name = "PasswordReset";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Password_Reset";
            Load += Password_Reset_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private TextBox newPasswordBox;
        private Label label2;
        private Label label1;
        private TextBox emailBox;
        private Label label4;
        private Label label3;
        private TextBox confPasswordBox;
        private Button resetbtn;
        private EventHandler emailBox_TextChanged;
        private EventHandler newPasswordBox_TextChanged;
        private EventHandler confPasswordBox_TextChanged;
        private Button backBtn;
    }
}