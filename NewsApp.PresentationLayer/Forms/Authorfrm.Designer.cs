namespace NewsApp.PresentationLayer.Forms
{
    partial class Authorfrm
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
            dataGrid = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_userName = new TextBox();
            txt_email = new TextBox();
            txt_Address = new TextBox();
            btn_Save = new Button();
            pic_profileImage = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_profileImage).BeginInit();
            SuspendLayout();
            // 
            // dataGrid
            // 
            dataGrid.BackgroundColor = Color.White;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Location = new Point(12, 303);
            dataGrid.Name = "dataGrid";
            dataGrid.Size = new Size(639, 200);
            dataGrid.TabIndex = 0;
            dataGrid.RowHeaderMouseDoubleClick += dataGrid_RowHeaderMouseDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 197);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(249, 197);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 1;
            label2.Text = "E-mail";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(475, 197);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 1;
            label3.Text = "Address";
            // 
            // txt_userName
            // 
            txt_userName.Location = new Point(15, 219);
            txt_userName.Name = "txt_userName";
            txt_userName.Size = new Size(145, 23);
            txt_userName.TabIndex = 2;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(249, 219);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(145, 23);
            txt_email.TabIndex = 2;
            // 
            // txt_Address
            // 
            txt_Address.Location = new Point(475, 219);
            txt_Address.Name = "txt_Address";
            txt_Address.Size = new Size(145, 23);
            txt_Address.TabIndex = 2;
            // 
            // btn_Save
            // 
            btn_Save.Location = new Point(15, 261);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(104, 33);
            btn_Save.TabIndex = 3;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // pic_profileImage
            // 
            pic_profileImage.BorderStyle = BorderStyle.Fixed3D;
            pic_profileImage.Location = new Point(253, 12);
            pic_profileImage.Name = "pic_profileImage";
            pic_profileImage.Size = new Size(176, 166);
            pic_profileImage.SizeMode = PictureBoxSizeMode.Zoom;
            pic_profileImage.TabIndex = 4;
            pic_profileImage.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Authorfrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(663, 513);
            Controls.Add(pic_profileImage);
            Controls.Add(btn_Save);
            Controls.Add(txt_Address);
            Controls.Add(txt_email);
            Controls.Add(txt_userName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGrid);
            Name = "Authorfrm";
            ShowIcon = false;
            Text = "Authors";
            Load += Authorfrm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_profileImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGrid;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_userName;
        private TextBox txt_email;
        private TextBox txt_Address;
        private Button btn_Save;
        private PictureBox pic_profileImage;
        private OpenFileDialog openFileDialog1;
    }
}