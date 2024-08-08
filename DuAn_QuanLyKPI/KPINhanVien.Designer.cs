
namespace DuAn_QuanLyKPI
{
    partial class KPINhanVien
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TongQuanNhanVien = new System.Windows.Forms.TabPage();
            this.ThongKeNhanVien = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.HieuSuatKhachHang = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.TongQuanNhanVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TongQuanNhanVien);
            this.tabControl1.Controls.Add(this.ThongKeNhanVien);
            this.tabControl1.Controls.Add(this.HieuSuatKhachHang);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1200, 658);
            this.tabControl1.TabIndex = 0;
            // 
            // TongQuanNhanVien
            // 
            this.TongQuanNhanVien.Controls.Add(this.panel3);
            this.TongQuanNhanVien.Controls.Add(this.panel2);
            this.TongQuanNhanVien.Controls.Add(this.panel1);
            this.TongQuanNhanVien.Location = new System.Drawing.Point(4, 28);
            this.TongQuanNhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TongQuanNhanVien.Name = "TongQuanNhanVien";
            this.TongQuanNhanVien.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TongQuanNhanVien.Size = new System.Drawing.Size(1192, 626);
            this.TongQuanNhanVien.TabIndex = 0;
            this.TongQuanNhanVien.Text = "Tổng quan nhân viên";
            this.TongQuanNhanVien.UseVisualStyleBackColor = true;
            // 
            // ThongKeNhanVien
            // 
            this.ThongKeNhanVien.Location = new System.Drawing.Point(4, 28);
            this.ThongKeNhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ThongKeNhanVien.Name = "ThongKeNhanVien";
            this.ThongKeNhanVien.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ThongKeNhanVien.Size = new System.Drawing.Size(1192, 626);
            this.ThongKeNhanVien.TabIndex = 1;
            this.ThongKeNhanVien.Text = "Thống Kê Nhân Viên";
            this.ThongKeNhanVien.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 69);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(4, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1184, 170);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(4, 243);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1184, 379);
            this.panel3.TabIndex = 2;
            // 
            // HieuSuatKhachHang
            // 
            this.HieuSuatKhachHang.Location = new System.Drawing.Point(4, 28);
            this.HieuSuatKhachHang.Name = "HieuSuatKhachHang";
            this.HieuSuatKhachHang.Size = new System.Drawing.Size(1192, 626);
            this.HieuSuatKhachHang.TabIndex = 2;
            this.HieuSuatKhachHang.Text = "Hiệu suất khách hàng ";
            this.HieuSuatKhachHang.UseVisualStyleBackColor = true;
            // 
            // KPINhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "KPINhanVien";
            this.Text = "KPINhanVien";
            this.tabControl1.ResumeLayout(false);
            this.TongQuanNhanVien.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TongQuanNhanVien;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage ThongKeNhanVien;
        private System.Windows.Forms.TabPage HieuSuatKhachHang;
    }
}