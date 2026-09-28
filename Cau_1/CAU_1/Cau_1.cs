using System.Text.RegularExpressions;

namespace Cau_1
{
    public partial class Cau_1 : Form
    {
        public Cau_1()
        {
            InitializeComponent();
        }

        private bool KiemTraHopLe()
        {
            bool hopLe = true;

     
            string hoTen = txtHoTen.Text.Trim();
            if (hoTen.Length == 0)
            {
                errorProvider1.SetError(txtHoTen, "Họ tên không được để trống");
                hopLe = false;
            }
            else if (hoTen.Length < 3)
            {
                errorProvider1.SetError(txtHoTen, "Họ tên phải có tối thiểu 3 ký tự");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtHoTen, "");
            }

            // (2) SĐT: đúng 10 chữ số, bắt đầu bằng 0
            if (!Regex.IsMatch(txtSDT.Text.Trim(), @"^0[0-9]{9}$"))
            {
                errorProvider1.SetError(txtSDT, "Số điện thoại phải gồm đúng 10 chữ số và bắt đầu bằng 0");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtSDT, "");
            }

            
            string email = txtEmail.Text.Trim();
            int viTriAt = email.IndexOf('@');
            if (viTriAt <= 0 || email.IndexOf('.', viTriAt + 1) < 0)
            {
                errorProvider1.SetError(txtEmail, "Email phải chứa '@' và có dấu '.' phía sau '@'");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
            }

            if (txtMatKhau.Text.Length < 6)
            {
                errorProvider1.SetError(txtMatKhau, "Mật khẩu phải có tối thiểu 6 ký tự");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtMatKhau, "");
            }

            
            if (txtXacNhanMK.Text != txtMatKhau.Text)
            {
                errorProvider1.SetError(txtXacNhanMK, "Mật khẩu xác nhận không khớp");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtXacNhanMK, "");
            }

            return hopLe;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (!KiemTraHopLe())
                return;

            MessageBox.Show("Đăng ký thành công! Chào mừng " + txtHoTen.Text,
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnHuy.CausesValidation = false;
            errorProvider1.Clear();
            Close();
        }
        private void btnHienMK_Click(object sender, EventArgs e)
        {
            bool dangHien = txtMatKhau.PasswordChar == '\0';

            if (dangHien)
            {
               
                txtMatKhau.PasswordChar = '*';
                txtXacNhanMK.PasswordChar = '*';
                btnHienMK.Text = "\U0001F441";   
            }
            else
            {
                
                txtMatKhau.PasswordChar = '\0';
                txtXacNhanMK.PasswordChar = '\0';
                btnHienMK.Text = "\U0001F648";   
            }
        }

      
        private void label1_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
    }
}