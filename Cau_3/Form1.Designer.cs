namespace Cau_3
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
            components = new System.ComponentModel.Container();
            txtMaHS = new TextBox();
            txtHoTen = new TextBox();
            txtToan = new TextBox();
            txtVan = new TextBox();
            txtAnh = new TextBox();
            btnLuu = new Button();
            btnXoaTrang = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lstDanhSach = new ListBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtMaHS
            // 
            txtMaHS.Location = new Point(39, 41);
            txtMaHS.Name = "txtMaHS";
            txtMaHS.Size = new Size(101, 27);
            txtMaHS.TabIndex = 0;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(175, 41);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(182, 27);
            txtHoTen.TabIndex = 1;
            txtHoTen.TextChanged += textBox2_TextChanged;
            // 
            // txtToan
            // 
            txtToan.Location = new Point(383, 41);
            txtToan.Name = "txtToan";
            txtToan.Size = new Size(99, 27);
            txtToan.TabIndex = 2;
            // 
            // txtVan
            // 
            txtVan.Location = new Point(524, 41);
            txtVan.Name = "txtVan";
            txtVan.Size = new Size(101, 27);
            txtVan.TabIndex = 3;
            // 
            // txtAnh
            // 
            txtAnh.Location = new Point(668, 42);
            txtAnh.Name = "txtAnh";
            txtAnh.Size = new Size(91, 27);
            txtAnh.TabIndex = 4;
            txtAnh.TextChanged += textBox5_TextChanged;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.Lime;
            btnLuu.ForeColor = Color.Black;
            btnLuu.Location = new Point(76, 104);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 5;
            btnLuu.TabStop = false;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoaTrang
            // 
            btnXoaTrang.BackColor = SystemColors.ButtonShadow;
            btnXoaTrang.Location = new Point(218, 104);
            btnXoaTrang.Name = "btnXoaTrang";
            btnXoaTrang.Size = new Size(94, 29);
            btnXoaTrang.TabIndex = 6;
            btnXoaTrang.TabStop = false;
            btnXoaTrang.Text = "Xóa Trắng";
            btnXoaTrang.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(39, 9);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 7;
            label1.Text = "Mã HS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(175, 9);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 8;
            label2.Text = "Họ Tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(383, 9);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 9;
            label3.Text = "Điểm Toán";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.Location = new Point(524, 10);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 10;
            label4.Text = "Điểm Văn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label5.Location = new Point(668, 9);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 11;
            label5.Text = "Điểm Anh";
            // 
            // lstDanhSach
            // 
            lstDanhSach.FormattingEnabled = true;
            lstDanhSach.Location = new Point(39, 161);
            lstDanhSach.Name = "lstDanhSach";
            lstDanhSach.Size = new Size(598, 244);
            lstDanhSach.TabIndex = 12;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstDanhSach);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnXoaTrang);
            Controls.Add(btnLuu);
            Controls.Add(txtAnh);
            Controls.Add(txtVan);
            Controls.Add(txtToan);
            Controls.Add(txtHoTen);
            Controls.Add(txtMaHS);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TextBox txtMaHS;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtToan;
        private System.Windows.Forms.TextBox txtVan;

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox txtAnh;
        private Button btnLuu;
        private Button btnXoaTrang;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ListBox lstDanhSach;
        private ErrorProvider errorProvider1;
    }
}
