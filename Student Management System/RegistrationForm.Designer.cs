namespace Student_Management_System
{
    partial class RegistrationForm
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
            label1 = new Label();
            textBox_Fname = new TextBox();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
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
            button_clear = new Button();
            button_add = new Button();
            panel1 = new Panel();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_student).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(15, 345);
            label1.Name = "label1";
            label1.Size = new Size(130, 23);
            label1.TabIndex = 1;
            label1.Text = "First Name : ";
            // 
            // textBox_Fname
            // 
            textBox_Fname.Location = new Point(149, 342);
            textBox_Fname.Name = "textBox_Fname";
            textBox_Fname.Size = new Size(184, 32);
            textBox_Fname.TabIndex = 2;
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            guna2DataGridView1.BackgroundColor = Color.Gainsboro;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridView1.ColumnHeadersHeight = 4;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.Location = new Point(12, 12);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.RowHeadersWidth = 51;
            guna2DataGridView1.Size = new Size(870, 312);
            guna2DataGridView1.TabIndex = 3;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.BackColor = Color.Gainsboro;
            guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            guna2DataGridView1.ThemeStyle.ReadOnly = false;
            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = SystemColors.MenuHighlight;
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 33;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.MenuHighlight;
            label2.Location = new Point(360, 345);
            label2.Name = "label2";
            label2.Size = new Size(131, 23);
            label2.TabIndex = 4;
            label2.Text = "Last Name : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.MenuHighlight;
            label3.Location = new Point(72, 404);
            label3.Name = "label3";
            label3.Size = new Size(71, 23);
            label3.TabIndex = 6;
            label3.Text = "DOB : ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(149, 399);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(412, 32);
            dateTimePicker1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.MenuHighlight;
            label4.Location = new Point(37, 462);
            label4.Name = "label4";
            label4.Size = new Size(102, 23);
            label4.TabIndex = 8;
            label4.Text = "Gender : ";
            // 
            // radioButton_male
            // 
            radioButton_male.AutoSize = true;
            radioButton_male.Location = new Point(149, 458);
            radioButton_male.Name = "radioButton_male";
            radioButton_male.Size = new Size(80, 27);
            radioButton_male.TabIndex = 9;
            radioButton_male.TabStop = true;
            radioButton_male.Text = "Male";
            radioButton_male.UseVisualStyleBackColor = true;
            // 
            // radioButton_female
            // 
            radioButton_female.AutoSize = true;
            radioButton_female.Location = new Point(229, 458);
            radioButton_female.Name = "radioButton_female";
            radioButton_female.Size = new Size(104, 27);
            radioButton_female.TabIndex = 10;
            radioButton_female.TabStop = true;
            radioButton_female.Text = "Female";
            radioButton_female.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.MenuHighlight;
            label5.Location = new Point(37, 511);
            label5.Name = "label5";
            label5.Size = new Size(106, 23);
            label5.TabIndex = 11;
            label5.Text = "Address : ";
            // 
            // textBox_address
            // 
            textBox_address.Location = new Point(149, 508);
            textBox_address.Name = "textBox_address";
            textBox_address.Size = new Size(516, 32);
            textBox_address.TabIndex = 12;
            // 
            // textBox_Lname
            // 
            textBox_Lname.Location = new Point(497, 342);
            textBox_Lname.Name = "textBox_Lname";
            textBox_Lname.Size = new Size(168, 32);
            textBox_Lname.TabIndex = 13;
            // 
            // pictureBox_student
            // 
            pictureBox_student.Location = new Point(713, 330);
            pictureBox_student.Name = "pictureBox_student";
            pictureBox_student.Size = new Size(141, 165);
            pictureBox_student.TabIndex = 14;
            pictureBox_student.TabStop = false;
            // 
            // button_upload
            // 
            button_upload.BackColor = Color.Green;
            button_upload.Location = new Point(713, 503);
            button_upload.Name = "button_upload";
            button_upload.Size = new Size(141, 38);
            button_upload.TabIndex = 15;
            button_upload.Text = "Upload";
            button_upload.UseVisualStyleBackColor = false;
            button_upload.Click += button_upload_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label6.ForeColor = SystemColors.MenuHighlight;
            label6.Location = new Point(402, 466);
            label6.Name = "label6";
            label6.Size = new Size(89, 23);
            label6.TabIndex = 16;
            label6.Text = "Phone : ";
            // 
            // textBox_phone
            // 
            textBox_phone.ForeColor = SystemColors.MenuHighlight;
            textBox_phone.Location = new Point(497, 463);
            textBox_phone.Name = "textBox_phone";
            textBox_phone.Size = new Size(168, 32);
            textBox_phone.TabIndex = 17;
            // 
            // button_clear
            // 
            button_clear.BackColor = Color.Orange;
            button_clear.Location = new Point(566, 553);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(141, 38);
            button_clear.TabIndex = 18;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = false;
            button_clear.Click += button_clear_Click;
            // 
            // button_add
            // 
            button_add.BackColor = SystemColors.MenuHighlight;
            button_add.ForeColor = SystemColors.HighlightText;
            button_add.Location = new Point(713, 553);
            button_add.Name = "button_add";
            button_add.Size = new Size(141, 38);
            button_add.TabIndex = 19;
            button_add.Text = "Add";
            button_add.UseVisualStyleBackColor = false;
            button_add.Click += button_add_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(894, 58);
            panel1.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.HighlightText;
            label7.Location = new Point(360, 12);
            label7.Name = "label7";
            label7.Size = new Size(157, 27);
            label7.TabIndex = 0;
            label7.Text = "Registaration";
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 603);
            Controls.Add(panel1);
            Controls.Add(button_add);
            Controls.Add(button_clear);
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
            Controls.Add(guna2DataGridView1);
            Controls.Add(textBox_Fname);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.MenuHighlight;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            Name = "RegistrationForm";
            Text = "c";
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_student).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_Fname;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
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
        private Button button_clear;
        private Button button_add;
        private Panel panel1;
        private Label label7;
    }
}