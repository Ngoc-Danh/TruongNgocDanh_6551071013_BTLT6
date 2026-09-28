namespace Cau_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            txtHoten = new TextBox();
            label2 = new Label();
            txtCCCD = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            txtSLngTre = new TextBox();
            txtSLngLon = new TextBox();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            errorProvider1 = new ErrorProvider(components);
            errorProviderTrue = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderTrue).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(140, 9);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ Tên";
            // 
            // txtHoten
            // 
            txtHoten.Location = new Point(135, 32);
            txtHoten.Name = "txtHoten";
            txtHoten.Size = new Size(432, 27);
            txtHoten.TabIndex = 1;
            txtHoten.Validating += txtHoten_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(140, 71);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 2;
            label2.Text = "Số CCCD";
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(135, 100);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(432, 27);
            txtCCCD.TabIndex = 3;
            txtCCCD.Validating += txtCCCD_Validating;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(135, 163);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(432, 27);
            textBox3.TabIndex = 4;
            textBox3.Validating += txtNgayNhan_Validating;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(135, 231);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(432, 27);
            textBox4.TabIndex = 5;
            textBox4.Validating += txtNgayTra_Validating;
            // 
            // txtSLngTre
            // 
            txtSLngTre.Location = new Point(135, 372);
            txtSLngTre.Name = "txtSLngTre";
            txtSLngTre.Size = new Size(432, 27);
            txtSLngTre.TabIndex = 6;
            txtSLngTre.Validating += txtSLngTre_Validating;
            // 
            // txtSLngLon
            // 
            txtSLngLon.Location = new Point(135, 302);
            txtSLngLon.Name = "txtSLngLon";
            txtSLngLon.Size = new Size(432, 27);
            txtSLngLon.TabIndex = 7;
            txtSLngLon.Validating += txtSLngLon_Validating;
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.Location = new Point(135, 409);
            button1.Name = "button1";
            button1.Size = new Size(432, 39);
            button1.TabIndex = 8;
            button1.Text = "Đặt Phòng";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnDatPhong_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(135, 134);
            label3.Name = "label3";
            label3.Size = new Size(129, 20);
            label3.TabIndex = 9;
            label3.Text = "Ngày Nhận Phòng\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(135, 204);
            label4.Name = "label4";
            label4.Size = new Size(114, 20);
            label4.TabIndex = 10;
            label4.Text = "Ngày Trả Phòng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(139, 274);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 11;
            label5.Text = "Số người lớn";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(140, 346);
            label6.Name = "label6";
            label6.Size = new Size(91, 20);
            label6.TabIndex = 12;
            label6.Text = "Số người trẻ";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProviderTrue
            // 
            errorProviderTrue.ContainerControl = this;
            errorProviderTrue.Icon = (Icon)resources.GetObject("errorProviderTrue.Icon");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(txtSLngLon);
            Controls.Add(txtSLngTre);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(txtCCCD);
            Controls.Add(label2);
            Controls.Add(txtHoten);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Đặt phòng khách sạn";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderTrue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtHoten;
        private Label label2;
        private TextBox txtCCCD;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox txtSLngTre;
        private TextBox txtSLngLon;
        private Button button1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProviderTrue;
    }
}
