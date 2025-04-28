
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
            button_dashboard = new Button();
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
            panel_main = new Panel();
            pictureBox2 = new PictureBox();
            panel4 = new Panel();
            label9 = new Label();
            label10 = new Label();
            comboBox1 = new ComboBox();
            label_femaleStd = new Label();
            label7 = new Label();
            label_totalStd = new Label();
            label_maleStd = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            label_user = new Label();
            label_role = new Label();
            label2 = new Label();
            panel_cover = new Panel();
            panel1 = new Panel();
            label11 = new Label();
            panel_slide.SuspendLayout();
            panel_scoreSubmenu.SuspendLayout();
            panel_courseSubmenu.SuspendLayout();
            panel_stdSubmenu.SuspendLayout();
            panel_logo.SuspendLayout();
            panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel_cover.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel_slide
            // 
            panel_slide.AutoScroll = true;
            panel_slide.BackColor = SystemColors.MenuHighlight;
            panel_slide.Controls.Add(button_exit);
            panel_slide.Controls.Add(button_dashboard);
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
            button_exit.Location = new Point(0, 799);
            button_exit.Margin = new Padding(4, 3, 4, 3);
            button_exit.Name = "button_exit";
            button_exit.Padding = new Padding(20, 0, 0, 0);
            button_exit.Size = new Size(267, 50);
            button_exit.TabIndex = 7;
            button_exit.Text = "Exit";
            button_exit.TextAlign = ContentAlignment.MiddleLeft;
            button_exit.UseVisualStyleBackColor = true;
            button_exit.Click += button1_Click;
            // 
            // button_dashboard
            // 
            button_dashboard.Dock = DockStyle.Top;
            button_dashboard.FlatAppearance.BorderSize = 0;
            button_dashboard.FlatStyle = FlatStyle.Flat;
            button_dashboard.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_dashboard.Location = new Point(0, 749);
            button_dashboard.Margin = new Padding(4, 3, 4, 3);
            button_dashboard.Name = "button_dashboard";
            button_dashboard.Padding = new Padding(20, 0, 0, 0);
            button_dashboard.Size = new Size(267, 50);
            button_dashboard.TabIndex = 6;
            button_dashboard.Text = "Dashboard";
            button_dashboard.TextAlign = ContentAlignment.MiddleLeft;
            button_dashboard.UseVisualStyleBackColor = true;
            button_dashboard.Click += button_exit_Click;
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
            // panel_main
            // 
            panel_main.Controls.Add(pictureBox2);
            panel_main.Controls.Add(panel4);
            panel_main.Controls.Add(panel2);
            panel_main.Controls.Add(panel_cover);
            panel_main.Cursor = Cursors.Cross;
            panel_main.Dock = DockStyle.Fill;
            panel_main.Location = new Point(288, 0);
            panel_main.Name = "panel_main";
            panel_main.Size = new Size(894, 603);
            panel_main.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.close_up_blurred_books;
            pictureBox2.Location = new Point(0, 130);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(894, 390);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.MenuHighlight;
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(comboBox1);
            panel4.Controls.Add(label_femaleStd);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label_totalStd);
            panel4.Controls.Add(label_maleStd);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 526);
            panel4.Name = "panel4";
            panel4.Size = new Size(894, 77);
            panel4.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(746, 45);
            label9.Name = "label9";
            label9.Size = new Size(101, 23);
            label9.TabIndex = 8;
            label9.Text = "Female : ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(629, 45);
            label10.Name = "label10";
            label10.Size = new Size(76, 23);
            label10.TabIndex = 7;
            label10.Text = "Male : ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(664, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(203, 31);
            comboBox1.TabIndex = 6;
            // 
            // label_femaleStd
            // 
            label_femaleStd.AutoSize = true;
            label_femaleStd.ForeColor = SystemColors.ButtonHighlight;
            label_femaleStd.Location = new Point(215, 41);
            label_femaleStd.Name = "label_femaleStd";
            label_femaleStd.Size = new Size(101, 23);
            label_femaleStd.TabIndex = 5;
            label_femaleStd.Text = "Female : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(503, 7);
            label7.Name = "label7";
            label7.Size = new Size(155, 23);
            label7.TabIndex = 4;
            label7.Text = "Total Student : ";
            // 
            // label_totalStd
            // 
            label_totalStd.AutoSize = true;
            label_totalStd.ForeColor = SystemColors.ButtonHighlight;
            label_totalStd.Location = new Point(19, 4);
            label_totalStd.Name = "label_totalStd";
            label_totalStd.Size = new Size(155, 23);
            label_totalStd.TabIndex = 3;
            label_totalStd.Text = "Total Student : ";
            label_totalStd.Click += label5_Click;
            // 
            // label_maleStd
            // 
            label_maleStd.AutoSize = true;
            label_maleStd.ForeColor = SystemColors.ButtonHighlight;
            label_maleStd.Location = new Point(98, 41);
            label_maleStd.Name = "label_maleStd";
            label_maleStd.Size = new Size(76, 23);
            label_maleStd.TabIndex = 2;
            label_maleStd.Text = "Male : ";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.MenuHighlight;
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(894, 66);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.MenuHighlight;
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label_user);
            panel3.Controls.Add(label_role);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(894, 66);
            panel3.TabIndex = 3;
            panel3.Paint += panel3_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.artbreeder_portraits_sg2_2025_03_22T17_02_52_793Z;
            pictureBox1.Location = new Point(809, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(69, 34);
            label6.Name = "label6";
            label6.Size = new Size(64, 23);
            label6.TabIndex = 3;
            label6.Text = "Role :";
            // 
            // label_user
            // 
            label_user.AutoSize = true;
            label_user.ForeColor = SystemColors.ButtonHighlight;
            label_user.Location = new Point(139, 3);
            label_user.Name = "label_user";
            label_user.Size = new Size(67, 23);
            label_user.TabIndex = 2;
            label_user.Text = "Thilina";
            // 
            // label_role
            // 
            label_role.AutoSize = true;
            label_role.ForeColor = SystemColors.ButtonHighlight;
            label_role.Location = new Point(139, 34);
            label_role.Name = "label_role";
            label_role.Size = new Size(73, 23);
            label_role.TabIndex = 1;
            label_role.Text = "Admin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(19, 3);
            label2.Name = "label2";
            label2.Size = new Size(114, 23);
            label2.TabIndex = 0;
            label2.Text = "Welcome :";
            // 
            // panel_cover
            // 
            panel_cover.Controls.Add(panel1);
            panel_cover.Dock = DockStyle.Top;
            panel_cover.Location = new Point(0, 0);
            panel_cover.Name = "panel_cover";
            panel_cover.Size = new Size(894, 58);
            panel_cover.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label11);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(894, 58);
            panel1.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.HotTrack;
            label11.Location = new Point(19, 9);
            label11.Name = "label11";
            label11.Size = new Size(344, 40);
            label11.TabIndex = 1;
            label11.Text = "International School";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 603);
            Controls.Add(panel_main);
            Controls.Add(panel_slide);
            Font = new Font("Century Gothic", 12F);
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(1200, 650);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += MainForm_Load;
            panel_slide.ResumeLayout(false);
            panel_scoreSubmenu.ResumeLayout(false);
            panel_courseSubmenu.ResumeLayout(false);
            panel_stdSubmenu.ResumeLayout(false);
            panel_logo.ResumeLayout(false);
            panel_logo.PerformLayout();
            panel_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel_cover.ResumeLayout(false);
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
        private Button button_dashboard;
        private Label label1;
        private Label label3;
        private Panel panel_main;
        private Panel panel4;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private Panel panel_cover;
        private Panel panel1;
        private Label label6;
        private Label label_user;
        private Label label_role;
        private Label label_totalStd;
        private Label label_maleStd;
        private Label label9;
        private Label label10;
        private ComboBox comboBox1;
        private Label label_femaleStd;
        private Label label7;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label11;
        private Button button_exit;
    }
}
