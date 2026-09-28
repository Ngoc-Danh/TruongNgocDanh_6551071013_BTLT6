namespace Cau_6
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
            menuStrip1 = new MenuStrip();
            tệpToolStripMenuItem = new ToolStripMenuItem();
            mởGhiChúMớiToolStripMenuItem = new ToolStripMenuItem();
            tHoátToolStripMenuItem1 = new ToolStripMenuItem();
            mởGhiChúMớiToolStripMenuItem1 = new ToolStripMenuItem();
            xếpTầngToolStripMenuItem = new ToolStripMenuItem();
            xếpNgangToolStripMenuItem = new ToolStripMenuItem();
            xếpDọcToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblSoLuongGhiChu = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tệpToolStripMenuItem, mởGhiChúMớiToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // tệpToolStripMenuItem
            // 
            tệpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mởGhiChúMớiToolStripMenuItem, tHoátToolStripMenuItem1 });
            tệpToolStripMenuItem.Name = "tệpToolStripMenuItem";
            tệpToolStripMenuItem.Size = new Size(57, 29);
            tệpToolStripMenuItem.Text = "Tệp";
            // 
            // mởGhiChúMớiToolStripMenuItem
            // 
            mởGhiChúMớiToolStripMenuItem.Name = "mởGhiChúMớiToolStripMenuItem";
            mởGhiChúMớiToolStripMenuItem.Size = new Size(270, 34);
            mởGhiChúMớiToolStripMenuItem.Text = "Mở ghi chú mới";
            mởGhiChúMớiToolStripMenuItem.Click += menuMoGhiChuMoi_Click;
            // 
            // tHoátToolStripMenuItem1
            // 
            tHoátToolStripMenuItem1.Name = "tHoátToolStripMenuItem1";
            tHoátToolStripMenuItem1.Size = new Size(270, 34);
            tHoátToolStripMenuItem1.Text = "Thoát";
            tHoátToolStripMenuItem1.Click += menuThoat_Click;
            // 
            // mởGhiChúMớiToolStripMenuItem1
            // 
            mởGhiChúMớiToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { xếpTầngToolStripMenuItem, xếpNgangToolStripMenuItem, xếpDọcToolStripMenuItem });
            mởGhiChúMớiToolStripMenuItem1.Name = "mởGhiChúMớiToolStripMenuItem1";
            mởGhiChúMớiToolStripMenuItem1.Size = new Size(85, 29);
            mởGhiChúMớiToolStripMenuItem1.Text = "Cửa Sổ";
            // 
            // xếpTầngToolStripMenuItem
            // 
            xếpTầngToolStripMenuItem.Name = "xếpTầngToolStripMenuItem";
            xếpTầngToolStripMenuItem.Size = new Size(270, 34);
            xếpTầngToolStripMenuItem.Text = "Xếp tầng";
            xếpTầngToolStripMenuItem.Click += menuXepTang_Click;
            // 
            // xếpNgangToolStripMenuItem
            // 
            xếpNgangToolStripMenuItem.Name = "xếpNgangToolStripMenuItem";
            xếpNgangToolStripMenuItem.Size = new Size(270, 34);
            xếpNgangToolStripMenuItem.Text = "Xếp ngang";
            xếpNgangToolStripMenuItem.Click += menuXepNgang_Click;
            // 
            // xếpDọcToolStripMenuItem
            // 
            xếpDọcToolStripMenuItem.Name = "xếpDọcToolStripMenuItem";
            xếpDọcToolStripMenuItem.Size = new Size(270, 34);
            xếpDọcToolStripMenuItem.Text = "Xếp dọc";
            xếpDọcToolStripMenuItem.Click += menuXepDoc_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblSoLuongGhiChu });
            statusStrip1.Location = new Point(0, 418);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 32);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblSoLuongGhiChu
            // 
            lblSoLuongGhiChu.Name = "lblSoLuongGhiChu";
            lblSoLuongGhiChu.Size = new Size(193, 25);
            lblSoLuongGhiChu.Text = "Số ghi chú đang mở: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ứng dụng Quản lý Ghi chú công việc";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tệpToolStripMenuItem;
        private ToolStripMenuItem mởGhiChúMớiToolStripMenuItem;
        private ToolStripMenuItem mởGhiChúMớiToolStripMenuItem1;
        private ToolStripMenuItem tHoátToolStripMenuItem1;
        private ToolStripMenuItem xếpTầngToolStripMenuItem;
        private ToolStripMenuItem xếpNgangToolStripMenuItem;
        private ToolStripMenuItem xếpDọcToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblSoLuongGhiChu;
    }
}
