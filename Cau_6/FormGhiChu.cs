using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Cau_6 
{
    public partial class FormGhiChu : Form
    {
        private bool isDataChanged = false; 

        public FormGhiChu()
        {
            InitializeComponent();

          
            this.KeyPreview = true;

            
            if (cboMucDoUuTien.Items.Count > 0)
                cboMucDoUuTien.SelectedIndex = 0;
        }

      
        private void txtNoiDung_TextChanged(object sender, EventArgs e)
        {
            isDataChanged = true;
        }

        #region ③ KEYBOARD & MOUSE EVENT

        // Xử lý phím tắt Ctrl+S và Escape
        private void FormGhiChu_KeyDown(object sender, KeyEventArgs e)
        {
            // Ctrl + S -> Lưu
            if (e.Control && e.KeyCode == Keys.S)
            {
                btnLuuGhiChu.PerformClick();
                e.SuppressKeyPress = true; // Chặn tiếng beep của Windows
            }
            // Escape -> Đóng form (hỏi xác nhận nếu nội dung thay đổi)
            else if (e.KeyCode == Keys.Escape)
            {
                if (isDataChanged)
                {
                    DialogResult result = MessageBox.Show(
                        "Nội dung đã thay đổi. Bạn có chắc chắn muốn đóng?",
                        "Xác nhận",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                else
                {
                    this.Close();
                }
            }
        }

        // Giới hạn tối đa 500 ký tự trong txtNoiDung bằng KeyPress
        private void txtNoiDung_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Cho phép các phím điều khiển như Backspace, Delete...
            if (!char.IsControl(e.KeyChar))
            {
                if (txtNoiDung.Text.Length >= 500)
                {
                    e.Handled = true; // Chặn không cho nhập thêm ký tự
                }
            }
        }

        // MouseDoubleClick trên label tiêu đề (lblTieuDeForm) để phóng to / thu nhỏ
        private void lblTieuDeForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        // Hiệu ứng rê chuột MouseEnter / MouseLeave cho btnLuuGhiChu
        private void btnLuuGhiChu_MouseEnter(object sender, EventArgs e)
        {
            btnLuuGhiChu.BackColor = Color.LightSkyBlue;
        }

        private void btnLuuGhiChu_MouseLeave(object sender, EventArgs e)
        {
            btnLuuGhiChu.BackColor = SystemColors.Control;
        }

        #endregion

        #region ④ VALIDATING & VALIDATED & BẮT LỖI

        // Sự kiện Validating cho txtTieuDe: Không trống, tối đa 50 ký tự
        private void txtTieuDe_Validating(object sender, CancelEventArgs e)
        {
            string tieuDe = txtTieuDe.Text.Trim();

            if (string.IsNullOrEmpty(tieuDe))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTieuDe, "Tiêu đề không được để trống!");
                txtTieuDe.BackColor = Color.MistyRose;
            }
            else if (tieuDe.Length > 50)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTieuDe, "Tiêu đề tối đa 50 ký tự!");
                txtTieuDe.BackColor = Color.MistyRose;
            }
        }

        // Sự kiện Validated cho txtTieuDe khi dữ liệu hợp lệ
        private void txtTieuDe_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtTieuDe, ""); // Xóa lỗi
            txtTieuDe.BackColor = Color.White;      // Trả màu nền về trắng
        }

        // Xử lý nút Lưu Ghi Chú
        private void btnLuuGhiChu_Click(object sender, EventArgs e)
        {
            // Trigger toàn bộ Validating trên Form
            if (this.ValidateChildren())
            {
                this.Text = txtTieuDe.Text.Trim(); // Đổi tiêu đề cửa sổ con
                isDataChanged = false;

                MessageBox.Show("Đã lưu ghi chú", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion
    }
}