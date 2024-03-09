namespace NewsApp.PresentationLayer.Forms
{
    partial class ChangePasswordfrm
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
            txt_OldPass = new TextBox();
            label2 = new Label();
            txt_newPass = new TextBox();
            label3 = new Label();
            txt_confirmPass = new TextBox();
            btn_changePass = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 43);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 0;
            label1.Text = "Old Password:";
            // 
            // txt_OldPass
            // 
            txt_OldPass.Location = new Point(129, 40);
            txt_OldPass.Name = "txt_OldPass";
            txt_OldPass.Size = new Size(127, 23);
            txt_OldPass.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 88);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 0;
            label2.Text = "New Password:";
            // 
            // txt_newPass
            // 
            txt_newPass.Location = new Point(129, 85);
            txt_newPass.Name = "txt_newPass";
            txt_newPass.Size = new Size(127, 23);
            txt_newPass.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 131);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 0;
            label3.Text = "Confirm Password:";
            // 
            // txt_confirmPass
            // 
            txt_confirmPass.Location = new Point(129, 128);
            txt_confirmPass.Name = "txt_confirmPass";
            txt_confirmPass.Size = new Size(127, 23);
            txt_confirmPass.TabIndex = 1;
            // 
            // btn_changePass
            // 
            btn_changePass.BackColor = Color.LightGray;
            btn_changePass.FlatAppearance.BorderColor = Color.LightGray;
            btn_changePass.FlatAppearance.BorderSize = 0;
            btn_changePass.FlatStyle = FlatStyle.Flat;
            btn_changePass.Location = new Point(92, 171);
            btn_changePass.Name = "btn_changePass";
            btn_changePass.Size = new Size(121, 33);
            btn_changePass.TabIndex = 2;
            btn_changePass.Text = "change password";
            btn_changePass.UseVisualStyleBackColor = false;
            btn_changePass.Click += btn_changePass_Click;
            // 
            // ChangePasswordfrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(305, 225);
            Controls.Add(btn_changePass);
            Controls.Add(txt_confirmPass);
            Controls.Add(label3);
            Controls.Add(txt_newPass);
            Controls.Add(label2);
            Controls.Add(txt_OldPass);
            Controls.Add(label1);
            Name = "ChangePasswordfrm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Change Password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_OldPass;
        private Label label2;
        private TextBox txt_newPass;
        private Label label3;
        private TextBox txt_confirmPass;
        private Button btn_changePass;
    }
}