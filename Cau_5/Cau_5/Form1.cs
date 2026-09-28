namespace Cau_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnChonGhe_Click(object sender, EventArgs e)
        {
            
            using (FormChonGhe frm = new FormChonGhe(txtGheDaChon.Text))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    txtGheDaChon.Text = frm.GheChon;
                }
            }
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtTenKhach.Text) ||
                string.IsNullOrWhiteSpace(cboPhim.Text) ||
                string.IsNullOrWhiteSpace(cboSuatChieu.Text) ||
                string.IsNullOrWhiteSpace(txtGheDaChon.Text))
            {
                MessageBox.Show("Vui lòng nhập và chọn đầy đủ thông tin!", "Cảnh báo");
            }
            else
            {
                
                string thongBao = $"Xác nhận đặt vé:\n" +
                                  $"- Tên khách: {txtTenKhach.Text}\n" +
                                  $"- Phim: {cboPhim.Text}\n" +
                                  $"- Suất chiếu: {cboSuatChieu.Text}\n" +
                                  $"- Ghế: {txtGheDaChon.Text}\n" +
                                  $"- Giá vé: 75.000đ/vé";

                MessageBox.Show(thongBao, "Xác nhận đặt vé");
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
