
namespace Student_Management_System
{
    partial class MainForm
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
            panel_slide = new Panel();
            button_exit = new Button();
            panel_scoreSubmenu = new Panel();
            button_scorePrint = new Button();
            button_manageScore = new Button();
            button_newScore = new Button();
            button_score = new Button();
            panel_courseSubmenu = new Panel();
            button_coursePrint = new Button();
            button_manageCourse = new Button();
            button_newCourse = new Button();
            button_course = new Button();
            panel_stdSubmenu = new Panel();
            button_stdPrint = new Button();
            button_status = new Button();
            button_manageStd = new Button();
            button_registration = new Button();
            button_std = new Button();
            panel_logo = new Panel();
            label3 = new Label();
            label1 = new Label();
            panel_cover = new Panel();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            label10 = new Label();
            label8 = new Label();
            label9 = new Label();
            comboBox1 = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label_role = new Label();
            label_user = new Label();
            label4 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label11 = new Label();
            panel_slide.SuspendLayout();
            panel_scoreSubmenu.SuspendLayout();
            panel_courseSubmenu.SuspendLayout();
            panel_stdSubmenu.SuspendLayout();
            panel_logo.SuspendLayout();
            panel_cover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel_slide
            // 
            panel_slide.AutoScroll = true;
            panel_slide.BackColor = SystemColors.MenuHighlight;
            panel_slide.Controls.Add(button_exit);
            panel_slide.Controls.Add(panel_scoreSubmenu);
            panel_slide.Controls.Add(button_score);
            panel_slide.Controls.Add(panel_courseSubmenu);
            panel_slide.Controls.Add(button_course);
            panel_slide.Controls.Add(panel_stdSubmenu);
            panel_slide.Controls.Add(button_std);
            panel_slide.Controls.Add(panel_logo);
            panel_slide.Dock = DockStyle.Left;
            panel_slide.Location = new Point(0, 0);
            panel_slide.Margin = new Padding(4, 3, 4, 3);
            panel_slide.Name = "panel_slide";
            panel_slide.Size = new Size(288, 603);
            panel_slide.TabIndex = 0;
            // 
            // button_exit
            // 
            button_exit.Dock = DockStyle.Top;
            button_exit.FlatAppearance.BorderSize = 0;
            button_exit.FlatStyle = FlatStyle.Flat;
            button_exit.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_exit.Location = new Point(0, 749);
            button_exit.Margin = new Padding(4, 3, 4, 3);
            button_exit.Name = "button_exit";
            button_exit.Padding = new Padding(20, 0, 0, 0);
            button_exit.Size = new Size(267, 50);
            button_exit.TabIndex = 6;
            button_exit.Text = "Exit";
            button_exit.TextAlign = ContentAlignment.MiddleLeft;
            button_exit.UseVisualStyleBackColor = true;
            // 
            // panel_scoreSubmenu
            // 
            panel_scoreSubmenu.BackColor = SystemColors.HotTrack;
            panel_scoreSubmenu.Controls.Add(button_scorePrint);
            panel_scoreSubmenu.Controls.Add(button_manageScore);
            panel_scoreSubmenu.Controls.Add(button_newScore);
            panel_scoreSubmenu.Dock = DockStyle.Top;
            panel_scoreSubmenu.Location = new Point(0, 603);
            panel_scoreSubmenu.Margin = new Padding(4, 3, 4, 3);
            panel_scoreSubmenu.Name = "panel_scoreSubmenu";
            panel_scoreSubmenu.Size = new Size(267, 146);
            panel_scoreSubmenu.TabIndex = 5;
            // 
            // button_scorePrint
            // 
            button_scorePrint.Dock = DockStyle.Top;
            button_scorePrint.FlatAppearance.BorderSize = 0;
            button_scorePrint.FlatStyle = FlatStyle.Flat;
            button_scorePrint.Font = new Font("Century Gothic", 12F);
            button_scorePrint.Location = new Point(0, 92);
            button_scorePrint.Margin = new Padding(4, 3, 4, 3);
            button_scorePrint.Name = "button_scorePrint";
            button_scorePrint.Padding = new Padding(50, 0, 0, 0);
            button_scorePrint.Size = new Size(267, 46);
            button_scorePrint.TabIndex = 4;
            button_scorePrint.Text = "Print";
            button_scorePrint.TextAlign = ContentAlignment.MiddleLeft;
            button_scorePrint.UseVisualStyleBackColor = true;
            button_scorePrint.Click += button_scorePrint_Click;
            // 
            // button_manageScore
            // 
            button_manageScore.Dock = DockStyle.Top;
            button_manageScore.FlatAppearance.BorderSize = 0;
            button_manageScore.FlatStyle = FlatStyle.Flat;
            button_manageScore.Font = new Font("Century Gothic", 12F);
            button_manageScore.Location = new Point(0, 46);
            button_manageScore.Margin = new Padding(4, 3, 4, 3);
            button_manageScore.Name = "button_manageScore";
            button_manageScore.Padding = new Padding(50, 0, 0, 0);
            button_manageScore.Size = new Size(267, 46);
            button_manageScore.TabIndex = 2;
            button_manageScore.Text = "Manage Score";
            button_manageScore.TextAlign = ContentAlignment.MiddleLeft;
            button_manageScore.UseVisualStyleBackColor = true;
            button_manageScore.Click += button_manageScore_Click;
            // 
            // button_newScore
            // 
            button_newScore.Dock = DockStyle.Top;
            button_newScore.FlatAppearance.BorderSize = 0;
            button_newScore.FlatStyle = FlatStyle.Flat;
            button_newScore.Font = new Font("Century Gothic", 12F);
            button_newScore.Location = new Point(0, 0);
            button_newScore.Margin = new Padding(4, 3, 4, 3);
            button_newScore.Name = "button_newScore";
            button_newScore.Padding = new Padding(50, 0, 0, 0);
            button_newScore.Size = new Size(267, 46);
            button_newScore.TabIndex = 1;
            button_newScore.Text = "New Socre";
            button_newScore.TextAlign = ContentAlignment.MiddleLeft;
            button_newScore.UseVisualStyleBackColor = true;
            button_newScore.Click += button_newScore_Click;
            // 
            // button_score
            // 
            button_score.Dock = DockStyle.Top;
            button_score.FlatAppearance.BorderSize = 0;
            button_score.FlatStyle = FlatStyle.Flat;
            button_score.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_score.Location = new Point(0, 553);
            button_score.Margin = new Padding(4, 3, 4, 3);
            button_score.Name = "button_score";
            button_score.Padding = new Padding(20, 0, 0, 0);
            button_score.Size = new Size(267, 50);
            button_score.TabIndex = 4;
            button_score.Text = "Score";
            button_score.TextAlign = ContentAlignment.MiddleLeft;
            button_score.UseVisualStyleBackColor = true;
            button_score.Click += button_score_Click;
            // 
            // panel_courseSubmenu
            // 
            panel_courseSubmenu.BackColor = SystemColors.HotTrack;
            panel_courseSubmenu.Controls.Add(button_coursePrint);
            panel_courseSubmenu.Controls.Add(button_manageCourse);
            panel_courseSubmenu.Controls.Add(button_newCourse);
            panel_courseSubmenu.Dock = DockStyle.Top;
            panel_courseSubmenu.Location = new Point(0, 403);
            panel_courseSubmenu.Margin = new Padding(4, 3, 4, 3);
            panel_courseSubmenu.Name = "panel_courseSubmenu";
            panel_courseSubmenu.Size = new Size(267, 150);
            panel_courseSubmenu.TabIndex = 3;
            // 
            // button_coursePrint
            // 
            button_coursePrint.Dock = DockStyle.Top;
            button_coursePrint.FlatAppearance.BorderSize = 0;
            button_coursePrint.FlatStyle = FlatStyle.Flat;
            button_coursePrint.Font = new Font("Century Gothic", 12F);
            button_coursePrint.Location = new Point(0, 92);
            button_coursePrint.Margin = new Padding(4, 3, 4, 3);
            button_coursePrint.Name = "button_coursePrint";
            button_coursePrint.Padding = new Padding(50, 0, 0, 0);
            button_coursePrint.Size = new Size(267, 46);
            button_coursePrint.TabIndex = 4;
            button_coursePrint.Text = "Print";
            button_coursePrint.TextAlign = ContentAlignment.MiddleLeft;
            button_coursePrint.UseVisualStyleBackColor = true;
            button_coursePrint.Click += button_coursePrint_Click;
            // 
            // button_manageCourse
            // 
            button_manageCourse.Dock = DockStyle.Top;
            button_manageCourse.FlatAppearance.BorderSize = 0;
            button_manageCourse.FlatStyle = FlatStyle.Flat;
            button_manageCourse.Font = new Font("Century Gothic", 12F);
            button_manageCourse.Location = new Point(0, 46);
            button_manageCourse.Margin = new Padding(4, 3, 4, 3);
            button_manageCourse.Name = "button_manageCourse";
            button_manageCourse.Padding = new Padding(50, 0, 0, 0);
            button_manageCourse.Size = new Size(267, 46);
            button_manageCourse.TabIndex = 2;
            button_manageCourse.Text = "Manage Course";
            button_manageCourse.TextAlign = ContentAlignment.MiddleLeft;
            button_manageCourse.UseVisualStyleBackColor = true;
            button_manageCourse.Click += button_manageCourse_Click;
            // 
            // button_newCourse
            // 
            button_newCourse.Dock = DockStyle.Top;
            button_newCourse.FlatAppearance.BorderSize = 0;
            button_newCourse.FlatStyle = FlatStyle.Flat;
            button_newCourse.Font = new Font("Century Gothic", 12F);
            button_newCourse.Location = new Point(0, 0);
            button_newCourse.Margin = new Padding(4, 3, 4, 3);
            button_newCourse.Name = "button_newCourse";
            button_newCourse.Padding = new Padding(50, 0, 0, 0);
            button_newCourse.Size = new Size(267, 46);
            button_newCourse.TabIndex = 1;
            button_newCourse.Text = "New Course";
            button_newCourse.TextAlign = ContentAlignment.MiddleLeft;
            button_newCourse.UseVisualStyleBackColor = true;
            button_newCourse.Click += button_newCourse_Click;
            // 
            // button_course
            // 
            button_course.Dock = DockStyle.Top;
            button_course.FlatAppearance.BorderSize = 0;
            button_course.FlatStyle = FlatStyle.Flat;
            button_course.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_course.Location = new Point(0, 353);
            button_course.Margin = new Padding(4, 3, 4, 3);
            button_course.Name = "button_course";
            button_course.Padding = new Padding(20, 0, 0, 0);
            button_course.Size = new Size(267, 50);
            button_course.TabIndex = 2;
            button_course.Text = "Course";
            button_course.TextAlign = ContentAlignment.MiddleLeft;
            button_course.UseVisualStyleBackColor = true;
            button_course.Click += button_course_Click;
            // 
            // panel_stdSubmenu
            // 
            panel_stdSubmenu.BackColor = SystemColors.Highlight;
            panel_stdSubmenu.Controls.Add(button_stdPrint);
            panel_stdSubmenu.Controls.Add(button_status);
            panel_stdSubmenu.Controls.Add(button_manageStd);
            panel_stdSubmenu.Controls.Add(button_registration);
            panel_stdSubmenu.Dock = DockStyle.Top;
            panel_stdSubmenu.Location = new Point(0, 165);
            panel_stdSubmenu.Margin = new Padding(4, 3, 4, 3);
            panel_stdSubmenu.Name = "panel_stdSubmenu";
            panel_stdSubmenu.Size = new Size(267, 188);
            panel_stdSubmenu.TabIndex = 1;
            // 
            // button_stdPrint
            // 
            button_stdPrint.Dock = DockStyle.Top;
            button_stdPrint.FlatAppearance.BorderSize = 0;
            button_stdPrint.FlatStyle = FlatStyle.Flat;
            button_stdPrint.Font = new Font("Century Gothic", 12F);
            button_stdPrint.Location = new Point(0, 138);
            button_stdPrint.Margin = new Padding(4, 3, 4, 3);
            button_stdPrint.Name = "button_stdPrint";
            button_stdPrint.Padding = new Padding(50, 0, 0, 0);
            button_stdPrint.Size = new Size(267, 46);
            button_stdPrint.TabIndex = 4;
            button_stdPrint.Text = "Print";
            button_stdPrint.TextAlign = ContentAlignment.MiddleLeft;
            button_stdPrint.UseVisualStyleBackColor = true;
            button_stdPrint.Click += button_stdPrint_Click;
            // 
            // button_status
            // 
            button_status.Dock = DockStyle.Top;
            button_status.FlatAppearance.BorderSize = 0;
            button_status.FlatStyle = FlatStyle.Flat;
            button_status.Font = new Font("Century Gothic", 12F);
            button_status.Location = new Point(0, 92);
            button_status.Margin = new Padding(4, 3, 4, 3);
            button_status.Name = "button_status";
            button_status.Padding = new Padding(50, 0, 0, 0);
            button_status.Size = new Size(267, 46);
            button_status.TabIndex = 3;
            button_status.Text = "Status";
            button_status.TextAlign = ContentAlignment.MiddleLeft;
            button_status.UseVisualStyleBackColor = true;
            button_status.Click += button_status_Click;
            // 
            // button_manageStd
            // 
            button_manageStd.Dock = DockStyle.Top;
            button_manageStd.FlatAppearance.BorderSize = 0;
            button_manageStd.FlatStyle = FlatStyle.Flat;
            button_manageStd.Font = new Font("Century Gothic", 12F);
            button_manageStd.Location = new Point(0, 46);
            button_manageStd.Margin = new Padding(4, 3, 4, 3);
            button_manageStd.Name = "button_manageStd";
            button_manageStd.Padding = new Padding(50, 0, 0, 0);
            button_manageStd.Size = new Size(267, 46);
            button_manageStd.TabIndex = 2;
            button_manageStd.Text = "Manage Student";
            button_manageStd.TextAlign = ContentAlignment.MiddleLeft;
            button_manageStd.UseVisualStyleBackColor = true;
            button_manageStd.Click += button_manageStd_Click;
            // 
            // button_registration
            // 
            button_registration.Dock = DockStyle.Top;
            button_registration.FlatAppearance.BorderSize = 0;
            button_registration.FlatStyle = FlatStyle.Flat;
            button_registration.Font = new Font("Century Gothic", 12F);
            button_registration.Location = new Point(0, 0);
            button_registration.Margin = new Padding(4, 3, 4, 3);
            button_registration.Name = "button_registration";
            button_registration.Padding = new Padding(50, 0, 0, 0);
            button_registration.Size = new Size(267, 46);
            button_registration.TabIndex = 1;
            button_registration.Text = "Registration";
            button_registration.TextAlign = ContentAlignment.MiddleLeft;
            button_registration.UseVisualStyleBackColor = true;
            button_registration.Click += button_registration_Click;
            // 
            // button_std
            // 
            button_std.Dock = DockStyle.Top;
            button_std.FlatAppearance.BorderSize = 0;
            button_std.FlatStyle = FlatStyle.Flat;
            button_std.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_std.Location = new Point(0, 115);
            button_std.Margin = new Padding(4, 3, 4, 3);
            button_std.Name = "button_std";
            button_std.Padding = new Padding(20, 0, 0, 0);
            button_std.Size = new Size(267, 50);
            button_std.TabIndex = 1;
            button_std.Text = "Student";
            button_std.TextAlign = ContentAlignment.MiddleLeft;
            button_std.UseVisualStyleBackColor = true;
            button_std.Click += button_std_Click;
            // 
            // panel_logo
            // 
            panel_logo.Controls.Add(label3);
            panel_logo.Controls.Add(label1);
            panel_logo.Dock = DockStyle.Top;
            panel_logo.Location = new Point(0, 0);
            panel_logo.Margin = new Padding(4, 3, 4, 3);
            panel_logo.Name = "panel_logo";
            panel_logo.Size = new Size(267, 115);
            panel_logo.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Broadway", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(105, 22);
            label3.Name = "label3";
            label3.Size = new Size(58, 46);
            label3.TabIndex = 5;
            label3.Text = "M";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 73);
            label1.Name = "label1";
            label1.Size = new Size(200, 26);
            label1.TabIndex = 3;
            label1.Text = "Welcome to School";
            // 
            // panel_cover
            // 
            panel_cover.Controls.Add(pictureBox2);
            panel_cover.Controls.Add(panel3);
            panel_cover.Controls.Add(panel2);
            panel_cover.Controls.Add(panel1);
            panel_cover.Dock = DockStyle.Fill;
            panel_cover.Location = new Point(288, 0);
            panel_cover.Name = "panel_cover";
            panel_cover.Size = new Size(894, 603);
            panel_cover.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = Properties.Resources.close_up_blurred_books;
            pictureBox2.Location = new Point(0, 118);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(894, 402);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.MenuHighlight;
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 526);
            panel3.Name = "panel3";
            panel3.Size = new Size(894, 77);
            panel3.TabIndex = 2;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new Point(462, 14);
            label10.Name = "label10";
            label10.Size = new Size(145, 23);
            label10.TabIndex = 9;
            label10.Text = "Select Class : ";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(727, 45);
            label8.Name = "label8";
            label8.Size = new Size(101, 23);
            label8.TabIndex = 8;
            label8.Text = "Female : ";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(613, 45);
            label9.Name = "label9";
            label9.Size = new Size(76, 23);
            label9.TabIndex = 7;
            label9.Text = "Male : ";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(613, 6);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(241, 31);
            comboBox1.TabIndex = 3;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(124, 45);
            label7.Name = "label7";
            label7.Size = new Size(101, 23);
            label7.TabIndex = 6;
            label7.Text = "Female : ";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(17, 45);
            label6.Name = "label6";
            label6.Size = new Size(76, 23);
            label6.TabIndex = 5;
            label6.Text = "Male : ";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(17, 14);
            label5.Name = "label5";
            label5.Size = new Size(163, 23);
            label5.TabIndex = 4;
            label5.Text = "Total Students : ";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.MenuHighlight;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label_role);
            panel2.Controls.Add(label_user);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 44);
            panel2.Name = "panel2";
            panel2.Size = new Size(894, 68);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.artbreeder_portraits_sg2_2025_03_22T17_02_52_793Z;
            pictureBox1.Location = new Point(825, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label_role
            // 
            label_role.AutoSize = true;
            label_role.Location = new Point(137, 36);
            label_role.Name = "label_role";
            label_role.Size = new Size(73, 23);
            label_role.TabIndex = 6;
            label_role.Text = "Admin";
            // 
            // label_user
            // 
            label_user.AutoSize = true;
            label_user.Location = new Point(137, 3);
            label_user.Name = "label_user";
            label_user.Size = new Size(67, 23);
            label_user.TabIndex = 5;
            label_user.Text = "Thilina";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 36);
            label4.Name = "label4";
            label4.Size = new Size(64, 23);
            label4.TabIndex = 4;
            label4.Text = "Role :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 3);
            label2.Name = "label2";
            label2.Size = new Size(114, 23);
            label2.TabIndex = 3;
            label2.Text = "Welcome :";
            // 
            // panel1
            // 
            panel1.Controls.Add(label11);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(894, 44);
            panel1.TabIndex = 0;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.HotTrack;
            label11.Location = new Point(17, 9);
            label11.Name = "label11";
            label11.Size = new Size(347, 27);
            label11.TabIndex = 4;
            label11.Text = "Mday interanational School";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 603);
            Controls.Add(panel_cover);
            Controls.Add(panel_slide);
            Font = new Font("Century Gothic", 12F);
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(1200, 650);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel_slide.ResumeLayout(false);
            panel_scoreSubmenu.ResumeLayout(false);
            panel_courseSubmenu.ResumeLayout(false);
            panel_stdSubmenu.ResumeLayout(false);
            panel_logo.ResumeLayout(false);
            panel_logo.PerformLayout();
            panel_cover.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_slide;
        private Button button_std;
        private Panel panel_logo;
        private Panel panel_stdSubmenu;
        private Button button_stdPrint;
        private Button button_status;
        private Button button_manageStd;
        private Button button_registration;
        private Panel panel_scoreSubmenu;
        private Button button_scorePrint;
        private Button button_manageScore;
        private Button button_newScore;
        private Button button_score;
        private Panel panel_courseSubmenu;
        private Button button_coursePrint;
        private Button button_manageCourse;
        private Button button_newCourse;
        private Button button_course;
        private Button button_exit;
        private Panel panel_cover;
        private Label label1;
        private Label label3;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label_role;
        private Label label_user;
        private Label label7;
        private Label label6;
        private Label label10;
        private Label label8;
        private Label label9;
        private ComboBox comboBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label11;
    }
}
