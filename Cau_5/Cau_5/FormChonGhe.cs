using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cau_5
{
    public partial class FormChonGhe : Form
    {
        
    
    public string GheChon { get; private set; }
        public FormChonGhe(string gheHienTai)
        {
            InitializeComponent();

            
            if (!string.IsNullOrEmpty(gheHienTai))
            {
                lstGhe.SelectedItem = gheHienTai;
            }
        }

        private void lstGhe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstGhe.SelectedItem != null)
            {
                lblGheDaChon.Text = "Đã chọn: " + lstGhe.SelectedItem.ToString();
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (lstGhe.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một ghế!", "Thông báo");
            }
            else
            {
                GheChon = lstGhe.SelectedItem.ToString(); 
                this.DialogResult = DialogResult.OK;      
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; 
        }
    }
}
