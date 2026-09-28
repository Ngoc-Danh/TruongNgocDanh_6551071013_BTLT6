using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Cau_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            txtHoten.Validated += Field_Validated;
            txtCCCD.Validated += Field_Validated;
            textBox3.Validated += Field_Validated;
            textBox4.Validated += Field_Validated;
            txtSLngLon.Validated += Field_Validated;
            txtSLngTre.Validated += Field_Validated;


            button1.Click += btnDatPhong_Click;
        }


        private void txtHoten_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoten.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtHoten, "Họ tên không được để trống");
                txtHoten.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(txtHoten, "");
            }
        }

        private void txtCCCD_Validating(object sender, CancelEventArgs e)
        {
            string cccd = txtCCCD.Text.Trim();

            bool hopLe = cccd.Length == 12 && long.TryParse(cccd, out _);

            if (!hopLe)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCCCD, "Số CCCD phải đúng 12 chữ số");
                txtCCCD.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(txtCCCD, "");
            }
        }


        private void txtNgayNhan_Validating(object sender, CancelEventArgs e)
        {
            bool parseThanhCong = DateTime.TryParseExact(
                textBox3.Text.Trim(),
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out DateTime ngayNhan
            );

            if (!parseThanhCong || ngayNhan.Date < DateTime.Today)
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox3, "Ngày nhận phải đúng định dạng dd/MM/yyyy và từ hôm nay trở đi");
                textBox3.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(textBox3, "");
            }
        }


        private void txtNgayTra_Validating(object sender, CancelEventArgs e)
        {
            bool parseTraOk = DateTime.TryParseExact(
                textBox4.Text.Trim(),
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out DateTime ngayTra
            );

            bool parseNhanOk = DateTime.TryParseExact(
                textBox3.Text.Trim(),
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out DateTime ngayNhan
            );

            if (!parseTraOk || (parseNhanOk && ngayTra.Date <= ngayNhan.Date))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox4, "Ngày trả phải sau ngày nhận");
                textBox4.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(textBox4, "");
            }
        }


        private void txtSLngLon_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(txtSLngLon.Text.Trim(), out int sl) || sl < 1 || sl > 4)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtSLngLon, "Số người lớn phải là số nguyên từ 1 đến 4");
                txtSLngLon.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(txtSLngLon, "");
            }
        }


        private void txtSLngTre_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(txtSLngTre.Text.Trim(), out int sl) || sl < 0 || sl > 3)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtSLngTre, "Số trẻ em phải là số nguyên từ 0 đến 3");
                txtSLngTre.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(txtSLngTre, "");
            }
        }

        private void Field_Validated(object sender, EventArgs e)
        {
            if (sender is TextBox txt)
            {
                txt.BackColor = Color.Honeydew;
            }
        }



        private void btnDatPhong_Click(object sender, EventArgs e)
        {

            if (!ValidateChildren())
            {
                return;
            }

            DateTime ngayNhan = DateTime.ParseExact(textBox3.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime ngayTra = DateTime.ParseExact(textBox4.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            int soDem = (ngayTra - ngayNhan).Days;

            string thongBao = $"Đặt phòng thành công!\n\n" +
                              $"- Tên khách: {txtHoten.Text.Trim()}\n" +
                              $"- Số đêm: {soDem}\n" +
                              $"- Số người lớn: {txtSLngLon.Text.Trim()}\n" +
                              $"- Số trẻ em: {txtSLngTre.Text.Trim()}";

            MessageBox.Show(thongBao, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

     
    }
}