namespace Cau_1
{
    partial class Cau_1
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtHoTen = new TextBox();
            txtMatKhau = new TextBox();
            txtEmail = new TextBox();
            txtSDT = new TextBox();
            txtXacNhanMK = new TextBox();
            btnDangKy = new Button();
            btnHuy = new Button();
            btnHienMK = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(368, 46);
            label1.TabIndex = 0;
            label1.Text = "Đăng ký tài khoản mới";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 55);
            label2.Name = "label2";
            label2.Size = new Size(290, 28);
            label2.TabIndex = 1;
            label2.Text = "Vui lòng nhập đầy đủ thông tin ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(168, 108);
            label3.Name = "label3";
            label3.Size = new Size(62, 23);
            label3.TabIndex = 2;
            label3.Text = "Họ tên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(119, 151);
            label4.Name = "label4";
            label4.Size = new Size(111, 23);
            label4.TabIndex = 3;
            label4.Text = "Số điện thoại";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(179, 194);
            label5.Name = "label5";
            label5.Size = new Size(51, 23);
            label5.TabIndex = 4;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(148, 240);
            label6.Name = "label6";
            label6.Size = new Size(82, 23);
            label6.TabIndex = 5;
            label6.Text = "Mật khẩu";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(72, 287);
            label7.Name = "label7";
            label7.Size = new Size(158, 23);
            label7.TabIndex = 6;
            label7.Text = "Xác nhận mật khẩu";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(168, 338);
            label8.Name = "label8";
            label8.Size = new Size(0, 23);
            label8.TabIndex = 7;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(278, 108);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(273, 30);
            txtHoTen.TabIndex = 8;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(278, 237);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(273, 30);
            txtMatKhau.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(278, 194);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(273, 30);
            txtEmail.TabIndex = 10;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(278, 148);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(273, 30);
            txtSDT.TabIndex = 11;
            // 
            // txtXacNhanMK
            // 
            txtXacNhanMK.Location = new Point(278, 280);
            txtXacNhanMK.Name = "txtXacNhanMK";
            txtXacNhanMK.PasswordChar = '*';
            txtXacNhanMK.Size = new Size(273, 30);
            txtXacNhanMK.TabIndex = 12;
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = SystemColors.Highlight;
            btnDangKy.ForeColor = SystemColors.ButtonFace;
            btnDangKy.Location = new Point(278, 357);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Padding = new Padding(5);
            btnDangKy.Size = new Size(102, 42);
            btnDangKy.TabIndex = 13;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(457, 357);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 42);
            btnHuy.TabIndex = 14;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnHienMK
            // 
            btnHienMK.Font = new Font("Segoe UI Emoji", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHienMK.Location = new Point(557, 253);
            btnHienMK.Name = "btnHienMK";
            btnHienMK.Size = new Size(47, 39);
            btnHienMK.TabIndex = 15;
            btnHienMK.Text = "👁";
            btnHienMK.UseVisualStyleBackColor = true;
            btnHienMK.Click += btnHienMK_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Cau_1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 427);
            Controls.Add(btnHienMK);
            Controls.Add(btnHuy);
            Controls.Add(btnDangKy);
            Controls.Add(txtXacNhanMK);
            Controls.Add(txtSDT);
            Controls.Add(txtEmail);
            Controls.Add(txtMatKhau);
            Controls.Add(txtHoTen);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Cau_1";
            Text = "Đăng ký tài khoản";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtHoTen;
        private TextBox txtMatKhau;
        private TextBox txtEmail;
        private TextBox txtSDT;
        private TextBox txtXacNhanMK;
        private Button btnDangKy;
        private Button btnHuy;
        private Button btnHienMK;
        private ErrorProvider errorProvider1;
    }
}