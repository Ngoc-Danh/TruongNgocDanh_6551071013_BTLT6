using System;
using System.Windows.Forms;

namespace Cau_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true; // ① Đặt Form1 làm MDI Container
        }

        // Cập nhật số lượng form con hiển thị trên StatusStrip
        public void CapNhatSoLuongGhiChu()
        {
            if (lblSoLuongGhiChu != null)
            {
                lblSoLuongGhiChu.Text = $"Số ghi chú đang mở: {this.MdiChildren.Length}";
            }
        }

        #region HÀM XỬ LÝ SỰ KIỆN MENU
        // ① & ② Mở ghi chú mới
        private void menuMoGhiChuMoi_Click(object sender, EventArgs e)
        {
            FormGhiChu formChild = new FormGhiChu();
            formChild.MdiParent = this;
            formChild.FormClosed += (s, args) => CapNhatSoLuongGhiChu();
            formChild.Show();
            CapNhatSoLuongGhiChu();
        }

        // ② Các lệnh sắp xếp cửa sổ con
        private void menuXepTang_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void menuXepNgang_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void menuXepDoc_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        // Thoát chương trình
        private void menuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region CÁC HÀM DỰ PHÒNG GIÚP TRÁNH LỖI DESIGNER (Nếu lỡ double-click trên Menu)
        private void tệpToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void cửaSổToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void mởGhiChúMớiToolStripMenuItem_Click(object sender, EventArgs e) => menuMoGhiChuMoi_Click(sender, e);
        private void xếpTầngToolStripMenuItem_Click(object sender, EventArgs e) => menuXepTang_Click(sender, e);
        private void xếpNgangToolStripMenuItem_Click(object sender, EventArgs e) => menuXepNgang_Click(sender, e);
        private void xếpDọcToolStripMenuItem_Click(object sender, EventArgs e) => menuXepDoc_Click(sender, e);
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e) => menuThoat_Click(sender, e);
        #endregion
    }
}