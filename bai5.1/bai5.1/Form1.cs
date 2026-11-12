using System;
using System.Drawing;
using System.Windows.Forms;

namespace bai5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ResetForm();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            epCheck.Clear();
            bool isValid = true;

            // 1. Kiểm tra Tên đăng nhập
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                epCheck.SetError(txtUsername, "Tên đăng nhập không được để trống!");
                isValid = false;
            }

            // 2. Kiểm tra Mật khẩu
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                epCheck.SetError(txtPassword, "Mật khẩu không được để trống!");
                isValid = false;
            }

            // 3. Kiểm tra Xác nhận mật khẩu
            if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                epCheck.SetError(txtConfirmPassword, "Vui lòng nhập lại mật khẩu để xác nhận!");
                isValid = false;
            }
            else if (txtPassword.Text != txtConfirmPassword.Text)
            {
                epCheck.SetError(txtConfirmPassword, "Mật khẩu nhập lại không khớp với mật khẩu ban đầu!");
                isValid = false;
            }

            // 4. Kiểm tra Độ tuổi (>= 18)
            DateTime birthDate = dtpBirthDate.Value.Date;
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;
            if (birthDate > today.AddYears(-age)) age--;

            if (age < 18)
            {
                epCheck.SetError(dtpBirthDate, $"Bạn hiện tại {age} tuổi. Độ tuổi đăng ký hợp lệ phải từ 18 tuổi trở lên!");
                isValid = false;
            }

            // 5. Kiểm tra Điều khoản dịch vụ
            if (!chkTerms.Checked)
            {
                epCheck.SetError(chkTerms, "Bạn phải đồng ý với Điều khoản dịch vụ trước khi tiếp tục!");
                isValid = false;
            }

            // Đánh giá kết quả
            if (!isValid)
            {
                MessageBox.Show(
                    "Thông tin đăng ký chưa hợp lệ! Vui lòng kiểm tra lại các trường có biểu tượng cảnh báo lỗi.",
                    "Lỗi dữ liệu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string gender = rdoMale.Checked ? "Nam" : "Nữ";
            string successMsg = $"Chúc mừng!\nTài khoản [{txtUsername.Text.Trim()}] đã được đăng ký thành công vào hệ thống.\n\n"
                              + $"Thông tin chi tiết:\n"
                              + $"• Giới tính: {gender}\n"
                              + $"• Ngày sinh: {dtpBirthDate.Value:dd/MM/yyyy} ({age} tuổi)\n"
                              + $"• Điều khoản: Đã chấp thuận";

            MessageBox.Show(
                successMsg,
                "Đăng ký thành công",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            epCheck.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            dtpBirthDate.Value = DateTime.Today.AddYears(-20);
            rdoMale.Checked = true;
            chkTerms.Checked = false;
            txtUsername.Focus();
        }
    }
}
