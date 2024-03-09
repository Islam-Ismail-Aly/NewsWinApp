namespace NewsApp.PresentationLayer
{
    partial class Mainfrm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txt_Title = new TextBox();
            txt_Breif = new TextBox();
            txt_Description = new TextBox();
            cb_Author = new ComboBox();
            cb_Catalog = new ComboBox();
            dateTime = new DateTimePicker();
            dataGrid = new DataGridView();
            btn_Save = new Button();
            btn_Update = new Button();
            btn_Delete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 28);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 105);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 0;
            label2.Text = "Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(304, 28);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 0;
            label3.Text = "Breif";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(304, 105);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 0;
            label4.Text = "Author";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(548, 28);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 0;
            label5.Text = "Description";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(548, 105);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 0;
            label6.Text = "Catalog";
            // 
            // txt_Title
            // 
            txt_Title.Location = new Point(41, 25);
            txt_Title.Name = "txt_Title";
            txt_Title.Size = new Size(223, 23);
            txt_Title.TabIndex = 1;
            // 
            // txt_Breif
            // 
            txt_Breif.Location = new Point(345, 25);
            txt_Breif.Multiline = true;
            txt_Breif.Name = "txt_Breif";
            txt_Breif.Size = new Size(174, 50);
            txt_Breif.TabIndex = 1;
            // 
            // txt_Description
            // 
            txt_Description.Location = new Point(624, 25);
            txt_Description.Multiline = true;
            txt_Description.Name = "txt_Description";
            txt_Description.Size = new Size(174, 50);
            txt_Description.TabIndex = 1;
            // 
            // cb_Author
            // 
            cb_Author.FormattingEnabled = true;
            cb_Author.Location = new Point(354, 105);
            cb_Author.Name = "cb_Author";
            cb_Author.Size = new Size(121, 23);
            cb_Author.TabIndex = 2;
            // 
            // cb_Catalog
            // 
            cb_Catalog.FormattingEnabled = true;
            cb_Catalog.Location = new Point(602, 102);
            cb_Catalog.Name = "cb_Catalog";
            cb_Catalog.Size = new Size(121, 23);
            cb_Catalog.TabIndex = 2;
            // 
            // dateTime
            // 
            dateTime.Location = new Point(41, 102);
            dateTime.Name = "dateTime";
            dateTime.Size = new Size(223, 23);
            dateTime.TabIndex = 3;
            // 
            // dataGrid
            // 
            dataGrid.BackgroundColor = Color.White;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Location = new Point(9, 213);
            dataGrid.Name = "dataGrid";
            dataGrid.Size = new Size(802, 253);
            dataGrid.TabIndex = 4;
            dataGrid.RowHeaderMouseDoubleClick += dataGrid_RowHeaderMouseDoubleClick;
            // 
            // btn_Save
            // 
            btn_Save.BackColor = Color.SkyBlue;
            btn_Save.FlatAppearance.BorderSize = 0;
            btn_Save.FlatStyle = FlatStyle.Flat;
            btn_Save.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btn_Save.ForeColor = Color.White;
            btn_Save.Location = new Point(16, 159);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(104, 35);
            btn_Save.TabIndex = 5;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = false;
            btn_Save.Click += btn_Save_Click;
            // 
            // btn_Update
            // 
            btn_Update.BackColor = Color.SkyBlue;
            btn_Update.FlatAppearance.BorderSize = 0;
            btn_Update.FlatStyle = FlatStyle.Flat;
            btn_Update.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btn_Update.ForeColor = Color.White;
            btn_Update.Location = new Point(173, 159);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(104, 35);
            btn_Update.TabIndex = 5;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = false;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.BackColor = Color.SkyBlue;
            btn_Delete.FlatAppearance.BorderSize = 0;
            btn_Delete.FlatStyle = FlatStyle.Flat;
            btn_Delete.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btn_Delete.ForeColor = Color.White;
            btn_Delete.Location = new Point(332, 159);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(104, 35);
            btn_Delete.TabIndex = 5;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = false;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // Mainfrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(820, 478);
            Controls.Add(btn_Delete);
            Controls.Add(btn_Update);
            Controls.Add(btn_Save);
            Controls.Add(dataGrid);
            Controls.Add(dateTime);
            Controls.Add(cb_Catalog);
            Controls.Add(cb_Author);
            Controls.Add(txt_Description);
            Controls.Add(txt_Breif);
            Controls.Add(txt_Title);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Mainfrm";
            ShowIcon = false;
            Text = "Main";
            Load += Mainfrm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_Title;
        private TextBox txt_Breif;
        private TextBox txt_Description;
        private ComboBox cb_Author;
        private ComboBox cb_Catalog;
        private DateTimePicker dateTime;
        private DataGridView dataGrid;
        private Button btn_Save;
        private Button btn_Update;
        private Button btn_Delete;
    }
}
