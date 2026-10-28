using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ndkhoaabai2
{
    public partial class Form1 : Form
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QuanLyKhoaHoc;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadComboBoxCourses();
        }

        private void LoadComboBoxCourses()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT MaKhoaHoc, TenKhoaHoc FROM KhoaHoc";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cboCourse.DataSource = dt;
                    cboCourse.DisplayMember = "TenKhoaHoc";
                    cboCourse.ValueMember = "MaKhoaHoc";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim(); // Lấy họ tên từ TextBox txtHoTen
            string phone = mtxtPhone.Text;
            DateTime ngaySinh = dtpBirthDate.Value;
            string maKhoaHoc = cboCourse.SelectedValue != null ? cboCourse.SelectedValue.ToString() : "";

            if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(maKhoaHoc))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ họ tên và chọn khóa học!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO DangKy (HoTen, SoDienThoai, NgaySinh, MaKhoaHoc) VALUES (@HoTen, @Phone, @NgaySinh, @MaKhoaHoc)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@HoTen", hoTen);
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                        cmd.Parameters.AddWithValue("@MaKhoaHoc", maKhoaHoc);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Đăng ký thành công và đã lưu vào CSDL!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}