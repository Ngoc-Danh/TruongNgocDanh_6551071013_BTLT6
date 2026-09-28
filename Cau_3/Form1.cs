namespace Cau_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DangKyEnterChuyenField();

            txtToan.Enter += txtDiem_Enter;
            txtVan.Enter += txtDiem_Enter;
            txtAnh.Enter += txtDiem_Enter;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void DangKyEnterChuyenField()
        {
            DangKyEnterChoControl(this);
        }

        private void DangKyEnterChoControl(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox txt)
                {
                    txt.KeyPress += TextBox_KeyPress;
                }

                if (c.HasChildren)
                {
                    DangKyEnterChoControl(c);
                }
            }
        }
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                if (sender == txtAnh)
                {
                    btnLuu.PerformClick();
                }
                else
                {
                    SelectNextControl(
                        (Control)sender,
                        true,
                        true,
                        true,
                        true
                    );
                }
            }
        }
        private void txtDiem_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            decimal toan, van, anh;

            bool hopLe = true;

            if (!decimal.TryParse(txtToan.Text, out toan) || toan < 0 || toan > 10)
            {
                errorProvider1.SetError(txtToan, "Điểm Toán phải từ 0.0 đến 10.0");
                hopLe = false;
            }

            if (!decimal.TryParse(txtVan.Text, out van) || van < 0 || van > 10)
            {
                errorProvider1.SetError(txtVan, "Điểm Văn phải từ 0.0 đến 10.0");
                hopLe = false;
            }

            if (!decimal.TryParse(txtAnh.Text, out anh) || anh < 0 || anh > 10)
            {
                errorProvider1.SetError(txtAnh, "Điểm Anh phải từ 0.0 đến 10.0");
                hopLe = false;
            }

            if (!hopLe)
            {
                return;
            }

            string dong = $"{txtMaHS.Text} | {txtHoTen.Text} | T:{toan} V:{van} A:{anh}";

           lstDanhSach.Items.Add(dong);

            txtMaHS.Clear();
            txtHoTen.Clear();
            txtToan.Clear();
            txtVan.Clear();
            txtAnh.Clear();

            txtMaHS.Focus();
        }
    }

}
