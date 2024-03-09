namespace NewsApp.PresentationLayer.Forms
{
    partial class ForgetPasswordfrm
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
            txt_yourEmail = new TextBox();
            txt_getEmail = new TextBox();
            label2 = new Label();
            btn_GetPassword = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter your e-mail:";
            // 
            // txt_yourEmail
            // 
            txt_yourEmail.Font = new Font("Segoe UI", 9.5F);
            txt_yourEmail.Location = new Point(119, 27);
            txt_yourEmail.Name = "txt_yourEmail";
            txt_yourEmail.Size = new Size(158, 24);
            txt_yourEmail.TabIndex = 1;
            // 
            // txt_getEmail
            // 
            txt_getEmail.Font = new Font("Segoe UI", 9.5F);
            txt_getEmail.Location = new Point(119, 75);
            txt_getEmail.Name = "txt_getEmail";
            txt_getEmail.ReadOnly = true;
            txt_getEmail.Size = new Size(158, 24);
            txt_getEmail.TabIndex = 1;
            txt_getEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 78);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 0;
            label2.Text = "Your password:";
            // 
            // btn_GetPassword
            // 
            btn_GetPassword.Location = new Point(145, 119);
            btn_GetPassword.Name = "btn_GetPassword";
            btn_GetPassword.Size = new Size(105, 32);
            btn_GetPassword.TabIndex = 2;
            btn_GetPassword.Text = "Get Password";
            btn_GetPassword.UseVisualStyleBackColor = true;
            btn_GetPassword.Click += btn_GetPassword_Click;
            // 
            // ForgetPasswordfrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 167);
            Controls.Add(btn_GetPassword);
            Controls.Add(txt_getEmail);
            Controls.Add(txt_yourEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ForgetPasswordfrm";
            ShowIcon = false;
            Text = "Forget Password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_yourEmail;
        private TextBox txt_getEmail;
        private Label label2;
        private Button btn_GetPassword;
    }
}