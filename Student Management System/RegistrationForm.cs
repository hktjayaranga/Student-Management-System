using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class RegistrationForm : Form
    {
        StudentClass student = new StudentClass();
        public RegistrationForm()
        {
            InitializeComponent();
        }

        //create a function to verify
        bool verify()
        {
            return
              !string.IsNullOrWhiteSpace(textBox_Fname.Text) &&
              !string.IsNullOrWhiteSpace(textBox_Lname.Text) &&
              !string.IsNullOrWhiteSpace(textBox_phone.Text) &&
              !string.IsNullOrWhiteSpace(textBox_address.Text) &&
              pictureBox_student.Image != null;
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            DataGridView_student.DataError += DataGridView_student_DataError;
            showTable();
        }

        private void DataGridView_student_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Context.HasFlag(DataGridViewDataErrorContexts.Formatting))
                e.ThrowException = false;
            else
                e.ThrowException = true;
        }


        //to show student list in DatagridView
        public void showTable()
        {
            DataGridView_student.DataSource = student.getStudentlist();
            DataGridView_student.RowTemplate.Height = 80;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridView_student.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Select Photo(*.jpg;*.png;*.gif) | *.jpg;*png;*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox_student.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            //add new student
            string fname = textBox_Fname.Text;
            string lname = textBox_Lname.Text;
            DateTime bdate = dateTimePicker1.Value;
            string phone = textBox_phone.Text;
            string address = textBox_address.Text;
            string gender = radioButton_male.Checked ? "Male" : "Female";



            //we need to check student age between 10 and 100
            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;
            if ((this_year - born_year) < 10 || (this_year - born_year) > 100)
            {
                MessageBox.Show("The student age must be between 10 and 100", "Invalid Birthdate", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verify())
            {
                try
                {
                    //to get photo from picture box
                    MemoryStream ms = new MemoryStream();
                    pictureBox_student.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    byte[] img = ms.ToArray();
                    if (student.insertStudent(fname, lname, bdate, gender, phone, address, img))
                    {
                        showTable();
                        MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {

                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Empty Field", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_Fname.Clear();
            textBox_Lname.Clear();
            textBox_address.Clear();
            textBox_phone.Clear();
            radioButton_male.Checked = true;
            dateTimePicker1.Value = DateTime.Now;
            pictureBox_student.Image = null;
        }
    }
}
