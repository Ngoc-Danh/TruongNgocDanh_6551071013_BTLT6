namespace Cau_6
{
    partial class FormGhiChu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTieuDeForm = new Label();
            lblTieuDe = new Label();
            txtTieuDe = new TextBox();
            lblNoiDung = new Label();
            txtNoiDung = new TextBox();
            lblPriority = new Label();
            cboMucDoUuTien = new ComboBox();
            btnLuuGhiChu = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTieuDeForm
            // 
            lblTieuDeForm.AutoSize = true;
            lblTieuDeForm.Location = new Point(38, 18);
            lblTieuDeForm.Name = "lblTieuDeForm";
            lblTieuDeForm.Size = new Size(110, 25);
            lblTieuDeForm.TabIndex = 0;
            lblTieuDeForm.Text = "Ghi Chú Mới";
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Location = new Point(107, 60);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(73, 25);
            lblTieuDe.TabIndex = 1;
            lblTieuDe.Text = "Tiêu đề:";
            lblTieuDe.MouseDoubleClick += lblTieuDeForm_MouseDoubleClick;
            // 
            // txtTieuDe
            // 
            txtTieuDe.Location = new Point(201, 60);
            txtTieuDe.Name = "txtTieuDe";
            txtTieuDe.Size = new Size(248, 31);
            txtTieuDe.TabIndex = 2;
            txtTieuDe.Validating += txtTieuDe_Validating;
            txtTieuDe.Validated += txtTieuDe_Validated;
            // 
            // lblNoiDung
            // 
            lblNoiDung.AutoSize = true;
            lblNoiDung.Location = new Point(107, 120);
            lblNoiDung.Name = "lblNoiDung";
            lblNoiDung.Size = new Size(96, 25);
            lblNoiDung.TabIndex = 3;
            lblNoiDung.Text = "Nội dung :";
            // 
            // txtNoiDung
            // 
            txtNoiDung.Location = new Point(107, 148);
            txtNoiDung.Multiline = true;
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.ScrollBars = ScrollBars.Vertical;
            txtNoiDung.Size = new Size(594, 157);
            txtNoiDung.TabIndex = 4;
            txtNoiDung.TextChanged += txtNoiDung_TextChanged;
            txtNoiDung.KeyPress += txtNoiDung_KeyPress;
            // 
            // lblPriority
            // 
            lblPriority.AutoSize = true;
            lblPriority.Location = new Point(53, 351);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(72, 25);
            lblPriority.TabIndex = 5;
            lblPriority.Text = "Priority:";
            // 
            // cboMucDoUuTien
            // 
            cboMucDoUuTien.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMucDoUuTien.FormattingEnabled = true;
            cboMucDoUuTien.Items.AddRange(new object[] { "Thấp ", "Trung bình", "Cao" });
            cboMucDoUuTien.Location = new Point(53, 379);
            cboMucDoUuTien.Name = "cboMucDoUuTien";
            cboMucDoUuTien.Size = new Size(141, 33);
            cboMucDoUuTien.TabIndex = 6;
            // 
            // btnLuuGhiChu
            // 
            btnLuuGhiChu.Location = new Point(631, 379);
            btnLuuGhiChu.Name = "btnLuuGhiChu";
            btnLuuGhiChu.Size = new Size(112, 34);
            btnLuuGhiChu.TabIndex = 7;
            btnLuuGhiChu.Text = "Lưu";
            btnLuuGhiChu.UseVisualStyleBackColor = true;
            btnLuuGhiChu.Click += btnLuuGhiChu_Click;
            btnLuuGhiChu.MouseEnter += btnLuuGhiChu_MouseEnter;
            btnLuuGhiChu.MouseLeave += btnLuuGhiChu_MouseLeave;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormGhiChu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLuuGhiChu);
            Controls.Add(cboMucDoUuTien);
            Controls.Add(lblPriority);
            Controls.Add(txtNoiDung);
            Controls.Add(lblNoiDung);
            Controls.Add(txtTieuDe);
            Controls.Add(lblTieuDe);
            Controls.Add(lblTieuDeForm);
            Name = "FormGhiChu";
            Text = "FormGhiChu";
            KeyDown += FormGhiChu_KeyDown;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDeForm;
        private Label lblTieuDe;
        private TextBox txtTieuDe;
        private Label lblNoiDung;
        private TextBox txtNoiDung;
        private Label lblPriority;
        private ComboBox cboMucDoUuTien;
        private Button btnLuuGhiChu;
        private ErrorProvider errorProvider1;
    }
}