namespace Student_Management_System
{
    partial class ManageStudentForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label7 = new Label();
            DataGridView_student = new Guna.UI2.WinForms.Guna2DataGridView();
            panel2 = new Panel();
            label1 = new Label();
            textBox_Fname = new TextBox();
            label2 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            radioButton_male = new RadioButton();
            radioButton_female = new RadioButton();
            label5 = new Label();
            textBox_address = new TextBox();
            textBox_Lname = new TextBox();
            pictureBox_student = new PictureBox();
            button_upload = new Button();
            label6 = new Label();
            textBox_phone = new TextBox();
            button_update = new Button();
            button_delete = new Button();
            button_clear = new Button();
            button_search = new Button();
            textBox_search = new TextBox();
            textBox_id = new TextBox();
            label8 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_student).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_student).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(894, 49);
            panel1.TabIndex = 40;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.HighlightText;
            label7.Location = new Point(360, 12);
            label7.Name = "label7";
            label7.Size = new Size(197, 27);
            label7.TabIndex = 0;
            label7.Text = "Manage Student";
            // 
            // DataGridView_student
            // 
            DataGridView_student.AllowUserToAddRows = false;
            DataGridView_student.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            DataGridView_student.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DataGridView_student.BackgroundColor = Color.Gainsboro;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridView_student.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridView_student.ColumnHeadersHeight = 4;
            DataGridView_student.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DataGridView_student.DefaultCellStyle = dataGridViewCellStyle3;
            DataGridView_student.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView_student.Location = new Point(12, 99);
            DataGridView_student.Name = "DataGridView_student";
            DataGridView_student.RowHeadersVisible = false;
            DataGridView_student.RowHeadersWidth = 51;
            DataGridView_student.RowTemplate.Height = 80;
            DataGridView_student.Size = new Size(870, 222);
            DataGridView_student.TabIndex = 24;
            DataGridView_student.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DataGridView_student.ThemeStyle.AlternatingRowsStyle.Font = null;
            DataGridView_student.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DataGridView_student.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DataGridView_student.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DataGridView_student.ThemeStyle.BackColor = Color.Gainsboro;
            DataGridView_student.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView_student.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DataGridView_student.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridView_student.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataGridView_student.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DataGridView_student.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataGridView_student.ThemeStyle.HeaderStyle.Height = 4;
            DataGridView_student.ThemeStyle.ReadOnly = false;
            DataGridView_student.ThemeStyle.RowsStyle.BackColor = Color.White;
            DataGridView_student.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridView_student.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataGridView_student.ThemeStyle.RowsStyle.ForeColor = SystemColors.MenuHighlight;
            DataGridView_student.ThemeStyle.RowsStyle.Height = 80;
            DataGridView_student.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DataGridView_student.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            DataGridView_student.CellContentClick += DataGridView_student_CellContentClick;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.MenuHighlight;
            panel2.Location = new Point(12, 319);
            panel2.Name = "panel2";
            panel2.Size = new Size(870, 14);
            panel2.TabIndex = 41;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(15, 351);
            label1.Name = "label1";
            label1.Size = new Size(130, 23);
            label1.TabIndex = 22;
            label1.Text = "First Name : ";
            // 
            // textBox_Fname
            // 
            textBox_Fname.Location = new Point(149, 348);
            textBox_Fname.Name = "textBox_Fname";
            textBox_Fname.Size = new Size(184, 32);
            textBox_Fname.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.MenuHighlight;
            label2.Location = new Point(360, 351);
            label2.Name = "label2";
            label2.Size = new Size(131, 23);
            label2.TabIndex = 25;
            label2.Text = "Last Name : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.MenuHighlight;
            label3.Location = new Point(72, 410);
            label3.Name = "label3";
            label3.Size = new Size(71, 23);
            label3.TabIndex = 26;
            label3.Text = "DOB : ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(149, 405);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(412, 32);
            dateTimePicker1.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.MenuHighlight;
            label4.Location = new Point(37, 468);
            label4.Name = "label4";
            label4.Size = new Size(102, 23);
            label4.TabIndex = 28;
            label4.Text = "Gender : ";
            // 
            // radioButton_male
            // 
            radioButton_male.AutoSize = true;
            radioButton_male.Location = new Point(149, 464);
            radioButton_male.Name = "radioButton_male";
            radioButton_male.Size = new Size(80, 27);
            radioButton_male.TabIndex = 29;
            radioButton_male.TabStop = true;
            radioButton_male.Text = "Male";
            radioButton_male.UseVisualStyleBackColor = true;
            // 
            // radioButton_female
            // 
            radioButton_female.AutoSize = true;
            radioButton_female.Location = new Point(229, 464);
            radioButton_female.Name = "radioButton_female";
            radioButton_female.Size = new Size(105, 27);
            radioButton_female.TabIndex = 30;
            radioButton_female.TabStop = true;
            radioButton_female.Text = "Female";
            radioButton_female.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.MenuHighlight;
            label5.Location = new Point(37, 517);
            label5.Name = "label5";
            label5.Size = new Size(106, 23);
            label5.TabIndex = 31;
            label5.Text = "Address : ";
            // 
            // textBox_address
            // 
            textBox_address.Location = new Point(149, 514);
            textBox_address.Name = "textBox_address";
            textBox_address.Size = new Size(240, 32);
            textBox_address.TabIndex = 32;
            // 
            // textBox_Lname
            // 
            textBox_Lname.Location = new Point(497, 348);
            textBox_Lname.Name = "textBox_Lname";
            textBox_Lname.Size = new Size(168, 32);
            textBox_Lname.TabIndex = 33;
            // 
            // pictureBox_student
            // 
            pictureBox_student.BackColor = SystemColors.ControlLight;
            pictureBox_student.Location = new Point(713, 339);
            pictureBox_student.Name = "pictureBox_student";
            pictureBox_student.Size = new Size(141, 162);
            pictureBox_student.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_student.TabIndex = 34;
            pictureBox_student.TabStop = false;
            // 
            // button_upload
            // 
            button_upload.BackColor = Color.LimeGreen;
            button_upload.Location = new Point(713, 509);
            button_upload.Name = "button_upload";
            button_upload.Size = new Size(141, 38);
            button_upload.TabIndex = 35;
            button_upload.Text = "Upload";
            button_upload.UseVisualStyleBackColor = false;
            button_upload.Click += button_upload_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label6.ForeColor = SystemColors.MenuHighlight;
            label6.Location = new Point(402, 472);
            label6.Name = "label6";
            label6.Size = new Size(89, 23);
            label6.TabIndex = 36;
            label6.Text = "Phone : ";
            // 
            // textBox_phone
            // 
            textBox_phone.ForeColor = SystemColors.MenuHighlight;
            textBox_phone.Location = new Point(497, 469);
            textBox_phone.Name = "textBox_phone";
            textBox_phone.Size = new Size(168, 32);
            textBox_phone.TabIndex = 37;
            // 
            // button_update
            // 
            button_update.BackColor = Color.Coral;
            button_update.Location = new Point(566, 559);
            button_update.Name = "button_update";
            button_update.Size = new Size(141, 38);
            button_update.TabIndex = 38;
            button_update.Text = "Update";
            button_update.UseVisualStyleBackColor = false;
            button_update.Click += button_update_Click;
            // 
            // button_delete
            // 
            button_delete.BackColor = Color.Red;
            button_delete.ForeColor = SystemColors.HighlightText;
            button_delete.Location = new Point(713, 559);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(141, 38);
            button_delete.TabIndex = 39;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = false;
            // 
            // button_clear
            // 
            button_clear.BackColor = Color.Orange;
            button_clear.Location = new Point(420, 559);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(141, 38);
            button_clear.TabIndex = 42;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = false;
            button_clear.Click += button_clear_Click;
            // 
            // button_search
            // 
            button_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_search.BackColor = Color.Orange;
            button_search.Location = new Point(741, 55);
            button_search.Name = "button_search";
            button_search.Size = new Size(141, 38);
            button_search.TabIndex = 43;
            button_search.Text = "Search";
            button_search.UseVisualStyleBackColor = false;
            button_search.Click += button_search_Click;
            // 
            // textBox_search
            // 
            textBox_search.Location = new Point(566, 60);
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(168, 32);
            textBox_search.TabIndex = 44;
            // 
            // textBox_id
            // 
            textBox_id.ForeColor = SystemColors.MenuHighlight;
            textBox_id.Location = new Point(497, 514);
            textBox_id.Name = "textBox_id";
            textBox_id.Size = new Size(168, 32);
            textBox_id.TabIndex = 46;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label8.ForeColor = SystemColors.MenuHighlight;
            label8.Location = new Point(402, 517);
            label8.Name = "label8";
            label8.Size = new Size(81, 23);
            label8.TabIndex = 45;
            label8.Text = "Id No : ";
            // 
            // ManageStudentForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 603);
            Controls.Add(textBox_id);
            Controls.Add(label8);
            Controls.Add(textBox_search);
            Controls.Add(button_search);
            Controls.Add(button_clear);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button_delete);
            Controls.Add(button_update);
            Controls.Add(textBox_phone);
            Controls.Add(label6);
            Controls.Add(button_upload);
            Controls.Add(pictureBox_student);
            Controls.Add(textBox_Lname);
            Controls.Add(textBox_address);
            Controls.Add(label5);
            Controls.Add(radioButton_female);
            Controls.Add(radioButton_male);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(DataGridView_student);
            Controls.Add(textBox_Fname);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ManageStudentForm";
            Text = "ManageStudentForm";
            Load += ManageStudentForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_student).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_student).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label7;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_student;
        private Panel panel2;
        private Label label1;
        private TextBox textBox_Fname;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private RadioButton radioButton_male;
        private RadioButton radioButton_female;
        private Label label5;
        private TextBox textBox_address;
        private TextBox textBox_Lname;
        private PictureBox pictureBox_student;
        private Button button_upload;
        private Label label6;
        private TextBox textBox_phone;
        private Button button_update;
        private Button button_delete;
        private Button button_clear;
        private Button button_search;
        private TextBox textBox_search;
        private TextBox textBox_id;
        private Label label8;
    }
}