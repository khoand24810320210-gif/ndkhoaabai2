using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ndkhoaabai2
{
    public partial class Form1 : Form
    {
        // Lớp chứa thông tin Khóa học
        public class Course
        {
            public string CourseId { get; set; } = "";
            public string CourseName { get; set; } = "";
        }

        public Form1()
        {
            InitializeComponent();
        }

        // Nạp danh sách Khóa học vào ComboBox khi Form tải lên
        private void Form1_Load(object sender, EventArgs e)
        {
            List<Course> listCourses = new List<Course>
            {
                new Course { CourseId = "CS01", CourseName = "Lập trình C# WinForms" },
                new Course { CourseId = "CS02", CourseName = "Lập trình Web ASP.NET" },
                new Course { CourseId = "CS03", CourseName = "Phân tích & Thiết kế CSDL" }
            };

            // Thiết lập Binding Data
            cboCourse.DataSource = listCourses;
            cboCourse.DisplayMember = "CourseName";
            cboCourse.ValueMember = "CourseId";
        }

        // Sự kiện khi bấm nút Đăng ký
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string phone = mtxtPhone.Text;
            string birthDate = dtpBirthDate.Value.ToString("dd/MM/yyyy");
            string courseName = cboCourse.Text;
            string courseId = cboCourse.SelectedValue != null ? cboCourse.SelectedValue.ToString() : "";

            string message = $"THÔNG TIN ĐĂNG KÝ HỌC VIÊN:\n\n" +
                             $"• SĐT: {phone}\n" +
                             $"• Ngày sinh: {birthDate}\n" +
                             $"• Khóa học: {courseName} (Mã: {courseId})";

            MessageBox.Show(message, "Kết quả đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
