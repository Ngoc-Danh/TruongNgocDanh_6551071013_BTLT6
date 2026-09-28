namespace Cau_5
{
    partial class FormChonGhe
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
            lstGhe = new ListBox();
            lblGheDaChon = new Label();
            btnXacNhan = new Button();
            btnBoQua = new Button();
            SuspendLayout();
            // 
            // lstGhe
            // 
            lstGhe.ColumnWidth = 40;
            lstGhe.FormattingEnabled = true;
            lstGhe.Items.AddRange(new object[] { "A1", "B1", "C1", "A2", "B2", "C2", "A3", "B3", "C3", "A4", "B4", "C4", "A5", "B5", "C5" });
            lstGhe.Location = new Point(266, 139);
            lstGhe.MultiColumn = true;
            lstGhe.Name = "lstGhe";
            lstGhe.Size = new Size(213, 79);
            lstGhe.TabIndex = 0;
            lstGhe.SelectedIndexChanged += lstGhe_SelectedIndexChanged;
            // 
            // lblGheDaChon
            // 
            lblGheDaChon.AutoSize = true;
            lblGheDaChon.Location = new Point(266, 232);
            lblGheDaChon.Name = "lblGheDaChon";
            lblGheDaChon.Size = new Size(87, 25);
            lblGheDaChon.TabIndex = 1;
            lblGheDaChon.Text = "Đã chọn: ";
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(256, 260);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(112, 34);
            btnXacNhan.TabIndex = 2;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // btnBoQua
            // 
            btnBoQua.Location = new Point(384, 260);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(112, 34);
            btnBoQua.TabIndex = 3;
            btnBoQua.Text = "Bỏ qua";
            btnBoQua.UseVisualStyleBackColor = true;
            btnBoQua.Click += btnBoQua_Click;
            // 
            // FormChonGhe
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBoQua);
            Controls.Add(btnXacNhan);
            Controls.Add(lblGheDaChon);
            Controls.Add(lstGhe);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormChonGhe";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Chọn Ghế";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstGhe;
        private Label lblGheDaChon;
        private Button btnXacNhan;
        private Button btnBoQua;
    }
}