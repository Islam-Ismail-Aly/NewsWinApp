namespace NewsApp.PresentationLayer
{
    partial class Loginfrm
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
            label1 = new Label();
            label2 = new Label();
            txt_Username = new TextBox();
            txt_Password = new TextBox();
            btn_Login = new Button();
            lbl_forgetPassword = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 185);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 245);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 0;
            label2.Text = "Password";
            // 
            // txt_Username
            // 
            txt_Username.BorderStyle = BorderStyle.FixedSingle;
            txt_Username.Location = new Point(39, 203);
            txt_Username.Name = "txt_Username";
            txt_Username.Size = new Size(172, 23);
            txt_Username.TabIndex = 0;
            // 
            // txt_Password
            // 
            txt_Password.BorderStyle = BorderStyle.FixedSingle;
            txt_Password.Location = new Point(39, 263);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(172, 23);
            txt_Password.TabIndex = 1;
            txt_Password.UseSystemPasswordChar = true;
            // 
            // btn_Login
            // 
            btn_Login.BackColor = Color.DodgerBlue;
            btn_Login.FlatAppearance.BorderSize = 0;
            btn_Login.FlatStyle = FlatStyle.Flat;
            btn_Login.ForeColor = Color.WhiteSmoke;
            btn_Login.Location = new Point(76, 329);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(102, 31);
            btn_Login.TabIndex = 2;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_Login_Click;
            // 
            // lbl_forgetPassword
            // 
            lbl_forgetPassword.AutoSize = true;
            lbl_forgetPassword.Font = new Font("Segoe UI", 8F, FontStyle.Underline);
            lbl_forgetPassword.ForeColor = Color.DodgerBlue;
            lbl_forgetPassword.Location = new Point(44, 290);
            lbl_forgetPassword.Name = "lbl_forgetPassword";
            lbl_forgetPassword.Size = new Size(97, 13);
            lbl_forgetPassword.TabIndex = 3;
            lbl_forgetPassword.Text = "forget password?";
            lbl_forgetPassword.Click += lbl_forgetPassword_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(50, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Loginfrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(272, 382);
            Controls.Add(pictureBox1);
            Controls.Add(btn_Login);
            Controls.Add(txt_Password);
            Controls.Add(txt_Username);
            Controls.Add(lbl_forgetPassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Loginfrm";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Loginfrm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_Username;
        private TextBox txt_Password;
        private Button btn_Login;
        private Label lbl_forgetPassword;
        private PictureBox pictureBox1;
    }
}