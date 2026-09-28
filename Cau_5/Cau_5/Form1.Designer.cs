namespace Cau_5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtTenKhach = new TextBox();
            cboPhim = new ComboBox();
            cboSuatChieu = new ComboBox();
            txtGheDaChon = new TextBox();
            btnChonGhe = new Button();
            btnDatVe = new Button();
            btnHuy = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 24);
            label1.Name = "label1";
            label1.Size = new Size(93, 25);
            label1.TabIndex = 0;
            label1.Text = "Tên khách:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 104);
            label2.Name = "label2";
            label2.Size = new Size(56, 25);
            label2.TabIndex = 1;
            label2.Text = "Phim:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 187);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 2;
            label3.Text = "Suất chiếu:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(93, 275);
            label4.Name = "label4";
            label4.Size = new Size(116, 25);
            label4.TabIndex = 3;
            label4.Text = "Ghế đã chọn:";
            // 
            // txtTenKhach
            // 
            txtTenKhach.Location = new Point(93, 58);
            txtTenKhach.Name = "txtTenKhach";
            txtTenKhach.Size = new Size(277, 31);
            txtTenKhach.TabIndex = 4;
            // 
            // cboPhim
            // 
            cboPhim.FormattingEnabled = true;
            cboPhim.Items.AddRange(new object[] { "Chiến binh cuối cùng", "Lật mật 7", "Mai" });
            cboPhim.Location = new Point(93, 142);
            cboPhim.Name = "cboPhim";
            cboPhim.Size = new Size(182, 33);
            cboPhim.TabIndex = 5;
            // 
            // cboSuatChieu
            // 
            cboSuatChieu.FormattingEnabled = true;
            cboSuatChieu.Items.AddRange(new object[] { "9:00", "14:00", "19:00" });
            cboSuatChieu.Location = new Point(93, 229);
            cboSuatChieu.Name = "cboSuatChieu";
            cboSuatChieu.Size = new Size(182, 33);
            cboSuatChieu.TabIndex = 6;
            // 
            // txtGheDaChon
            // 
            txtGheDaChon.Location = new Point(93, 316);
            txtGheDaChon.Name = "txtGheDaChon";
            txtGheDaChon.ReadOnly = true;
            txtGheDaChon.Size = new Size(150, 31);
            txtGheDaChon.TabIndex = 7;
            // 
            // btnChonGhe
            // 
            btnChonGhe.Location = new Point(188, 371);
            btnChonGhe.Name = "btnChonGhe";
            btnChonGhe.Size = new Size(112, 34);
            btnChonGhe.TabIndex = 8;
            btnChonGhe.Text = "Chọn Ghế";
            btnChonGhe.UseVisualStyleBackColor = true;
            btnChonGhe.Click += btnChonGhe_Click;
            // 
            // btnDatVe
            // 
            btnDatVe.Location = new Point(335, 371);
            btnDatVe.Name = "btnDatVe";
            btnDatVe.Size = new Size(112, 34);
            btnDatVe.TabIndex = 9;
            btnDatVe.Text = "Đặt Vé";
            btnDatVe.UseVisualStyleBackColor = true;
            btnDatVe.Click += btnDatVe_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(483, 371);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(112, 34);
            btnHuy.TabIndex = 10;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHuy);
            Controls.Add(btnDatVe);
            Controls.Add(btnChonGhe);
            Controls.Add(txtGheDaChon);
            Controls.Add(cboSuatChieu);
            Controls.Add(cboPhim);
            Controls.Add(txtTenKhach);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bán vé xem phim";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtTenKhach;
        private ComboBox cboPhim;
        private ComboBox cboSuatChieu;
        private TextBox txtGheDaChon;
        private Button btnChonGhe;
        private Button btnDatVe;
        private Button btnHuy;
    }
}
