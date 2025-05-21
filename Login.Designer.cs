namespace Auto_Service
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            lgnbtn = new Button();
            Label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            password = new TextBox();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            username = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lgnbtn
            // 
            lgnbtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lgnbtn.BackColor = Color.FromArgb(255, 128, 0);
            lgnbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lgnbtn.ForeColor = Color.White;
            lgnbtn.Location = new Point(185, 365);
            lgnbtn.Name = "lgnbtn";
            lgnbtn.Size = new Size(169, 49);
            lgnbtn.TabIndex = 12;
            lgnbtn.Text = "Login";
            lgnbtn.UseVisualStyleBackColor = false;
            lgnbtn.Click += lgnbtn_Click;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.FlatStyle = FlatStyle.Flat;
            Label3.Location = new Point(252, 35);
            Label3.Name = "Label3";
            Label3.Size = new Size(0, 25);
            Label3.TabIndex = 5;
            Label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Brush Script MT", 36F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(255, 128, 0);
            label4.Location = new Point(153, 28);
            label4.Name = "label4";
            label4.Size = new Size(229, 88);
            label4.TabIndex = 6;
            label4.Text = "Welcome";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(Label3);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(769, 643);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(password);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(username);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(lgnbtn);
            panel2.Location = new Point(111, 90);
            panel2.Name = "panel2";
            panel2.Size = new Size(534, 466);
            panel2.TabIndex = 11;
            panel2.Paint += panel2_Paint;
            // 
            // password
            // 
            password.BackColor = Color.WhiteSmoke;
            password.Location = new Point(117, 249);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(309, 31);
            password.TabIndex = 18;
            password.TextChanged += password_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 7F);
            label5.Location = new Point(314, 283);
            label5.Name = "label5";
            label5.Size = new Size(112, 19);
            label5.TabIndex = 17;
            label5.Text = "Forgot Password";
            label5.Click += label5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(117, 221);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 16;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(117, 140);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 15;
            label1.Text = "Username";
            // 
            // username
            // 
            username.BackColor = Color.WhiteSmoke;
            username.Location = new Point(117, 168);
            username.Name = "username";
            username.Size = new Size(309, 31);
            username.TabIndex = 13;
            username.TextChanged += username_TextChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(758, 634);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlLightLight;
            MaximizeBox = false;
            MaximumSize = new Size(780, 690);
            MinimizeBox = false;
            MinimumSize = new Size(780, 690);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button lgnbtn;
        private Label Label3;
        private Label label4;
        private Panel panel1;
        private Panel panel2;
        private Label label5;
        private Label label2;
        private Label label1;
        private TextBox username;
        private TextBox password;
    }
}
