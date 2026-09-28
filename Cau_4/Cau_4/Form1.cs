using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cau_4
{
    public partial class Form1 : Form
    {
        private int _indexDangSua = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void lstLienHe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblTen_Click(object sender, EventArgs e)
        {

        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSDT_Click(object sender, EventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten=txtTen.Text.Trim();
            string sdt=txtSDT.Text.Trim();

            if(string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string itemText= $"{ten} - {sdt}";

            if(_indexDangSua== -1)
            {
                lstLienHe.Items.Add(itemText);
                MessageBox.Show("Thêm liên hệ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else { 
                lstLienHe.Items[_indexDangSua] = itemText;
                MessageBox.Show("Sửa liên hệ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _indexDangSua = -1;
                btnThem.Text = "Thêm";
            }
            XoaForm();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(lstLienHe.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn liên hệ để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _indexDangSua = lstLienHe.SelectedIndex;
            string selectedItem = lstLienHe.SelectedItem.ToString();

            string[] parts = selectedItem.Split(new string[] { " - " }, StringSplitOptions.None);

            if(parts.Length == 2)
            {
                MessageBox.Show("Dữ liệu liên hệ không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTen.Text = parts[0];
                txtSDT.Text = parts[1];
            }
            
            btnThem.Text = "Cập nhật";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(lstLienHe.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn liên hệ để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string selectedItem = lstLienHe.SelectedItem.ToString();
            string ten = selectedItem.Split(new string[] { " - " }, StringSplitOptions.None)[0];

            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa liên hệ '{ten}' không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if(result == DialogResult.Yes)
            {
                lstLienHe.Items.RemoveAt(lstLienHe.SelectedIndex);
                MessageBox.Show("Xóa liên hệ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (_indexDangSua == -1)
                {
                    _indexDangSua = -1;
                    btnThem.Text = "Thêm";
                }

                XoaForm();

            }



        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void XoaForm()
        {
            txtTen.Clear();
            txtSDT.Clear();
            txtTen.Focus();
        }

        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTen.Text.Trim()) || !string.IsNullOrEmpty(txtSDT.Text.Trim()))
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có dữ liệu chưa được lưu. Bạn muốn thoát không?",
                    "Cảnh báo",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                { 
                }
                else if (result == DialogResult.No)
                {
              
                    XoaForm();
                }
                else if (result == DialogResult.Cancel)
                {
   
                    e.Cancel = true;
                }
            }
        }
    }
}
