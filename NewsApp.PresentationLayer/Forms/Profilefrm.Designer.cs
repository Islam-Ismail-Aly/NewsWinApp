namespace NewsApp.PresentationLayer
{
    partial class Profilefrm
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
            pic_profileImage = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_AuthorName = new TextBox();
            txt_AuthorEmail = new TextBox();
            txt_AuthorAddress = new TextBox();
            btn_Main = new Button();
            lbl_forgetPassword = new Label();
            lbl_changePassword = new Label();
            btn_authorfrm = new Button();
            ((System.ComponentModel.ISupportInitialize)pic_profileImage).BeginInit();
            SuspendLayout();
            // 
            // pic_profileImage
            // 
            pic_profileImage.Location = new Point(71, 12);
            pic_profileImage.Name = "pic_profileImage";
            pic_profileImage.Size = new Size(192, 170);
            pic_profileImage.SizeMode = PictureBoxSizeMode.Zoom;
            pic_profileImage.TabIndex = 0;
            pic_profileImage.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 217);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 262);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 303);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 1;
            label3.Text = "Address:";
            // 
            // txt_AuthorName
            // 
            txt_AuthorName.BackColor = Color.MediumTurquoise;
            txt_AuthorName.BorderStyle = BorderStyle.None;
            txt_AuthorName.Font = new Font("Segoe UI", 10F);
            txt_AuthorName.ForeColor = Color.White;
            txt_AuthorName.Location = new Point(82, 214);
            txt_AuthorName.Name = "txt_AuthorName";
            txt_AuthorName.ReadOnly = true;
            txt_AuthorName.Size = new Size(179, 18);
            txt_AuthorName.TabIndex = 2;
            txt_AuthorName.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_AuthorEmail
            // 
            txt_AuthorEmail.BackColor = Color.MediumTurquoise;
            txt_AuthorEmail.BorderStyle = BorderStyle.None;
            txt_AuthorEmail.Font = new Font("Segoe UI", 10F);
            txt_AuthorEmail.ForeColor = Color.White;
            txt_AuthorEmail.Location = new Point(82, 259);
            txt_AuthorEmail.Name = "txt_AuthorEmail";
            txt_AuthorEmail.ReadOnly = true;
            txt_AuthorEmail.Size = new Size(179, 18);
            txt_AuthorEmail.TabIndex = 2;
            txt_AuthorEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_AuthorAddress
            // 
            txt_AuthorAddress.BackColor = Color.MediumTurquoise;
            txt_AuthorAddress.BorderStyle = BorderStyle.None;
            txt_AuthorAddress.Font = new Font("Segoe UI", 10F);
            txt_AuthorAddress.ForeColor = Color.White;
            txt_AuthorAddress.Location = new Point(82, 303);
            txt_AuthorAddress.Name = "txt_AuthorAddress";
            txt_AuthorAddress.ReadOnly = true;
            txt_AuthorAddress.Size = new Size(179, 18);
            txt_AuthorAddress.TabIndex = 2;
            txt_AuthorAddress.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_Main
            // 
            btn_Main.BackColor = Color.LightSeaGreen;
            btn_Main.FlatAppearance.BorderSize = 0;
            btn_Main.FlatStyle = FlatStyle.Flat;
            btn_Main.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btn_Main.ForeColor = Color.White;
            btn_Main.Location = new Point(21, 359);
            btn_Main.Name = "btn_Main";
            btn_Main.Size = new Size(118, 35);
            btn_Main.TabIndex = 6;
            btn_Main.Text = "News App";
            btn_Main.UseVisualStyleBackColor = false;
            btn_Main.Click += btn_Main_Click;
            // 
            // lbl_forgetPassword
            // 
            lbl_forgetPassword.AutoSize = true;
            lbl_forgetPassword.Font = new Font("Segoe UI", 8F, FontStyle.Underline);
            lbl_forgetPassword.ForeColor = Color.DodgerBlue;
            lbl_forgetPassword.Location = new Point(10, 435);
            lbl_forgetPassword.Name = "lbl_forgetPassword";
            lbl_forgetPassword.Size = new Size(97, 13);
            lbl_forgetPassword.TabIndex = 7;
            lbl_forgetPassword.Text = "forget password?";
            lbl_forgetPassword.Click += lbl_forgetPassword_Click;
            // 
            // lbl_changePassword
            // 
            lbl_changePassword.AutoSize = true;
            lbl_changePassword.Font = new Font("Segoe UI", 8F, FontStyle.Underline);
            lbl_changePassword.ForeColor = Color.DodgerBlue;
            lbl_changePassword.Location = new Point(227, 435);
            lbl_changePassword.Name = "lbl_changePassword";
            lbl_changePassword.Size = new Size(103, 13);
            lbl_changePassword.TabIndex = 7;
            lbl_changePassword.Text = "change password?";
            lbl_changePassword.Click += lbl_changePassword_Click;
            // 
            // btn_authorfrm
            // 
            btn_authorfrm.BackColor = Color.LightSeaGreen;
            btn_authorfrm.FlatAppearance.BorderSize = 0;
            btn_authorfrm.FlatStyle = FlatStyle.Flat;
            btn_authorfrm.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btn_authorfrm.ForeColor = Color.White;
            btn_authorfrm.Location = new Point(199, 359);
            btn_authorfrm.Name = "btn_authorfrm";
            btn_authorfrm.Size = new Size(118, 35);
            btn_authorfrm.TabIndex = 6;
            btn_authorfrm.Text = "Authors";
            btn_authorfrm.UseVisualStyleBackColor = false;
            btn_authorfrm.Click += btn_authorfrm_Click;
            // 
            // Profilefrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(340, 463);
            Controls.Add(lbl_changePassword);
            Controls.Add(lbl_forgetPassword);
            Controls.Add(btn_authorfrm);
            Controls.Add(btn_Main);
            Controls.Add(txt_AuthorAddress);
            Controls.Add(txt_AuthorEmail);
            Controls.Add(txt_AuthorName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pic_profileImage);
            Name = "Profilefrm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profile";
            Load += Profilefrm_Load;
            ((System.ComponentModel.ISupportInitialize)pic_profileImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pic_profileImage;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_AuthorName;
        private TextBox txt_AuthorEmail;
        private TextBox txt_AuthorAddress;
        private Button btn_Main;
        private Label lbl_forgetPassword;
        private Label lbl_changePassword;
        private Button btn_authorfrm;
    }
}