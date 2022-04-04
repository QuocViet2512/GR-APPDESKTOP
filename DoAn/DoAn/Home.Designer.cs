namespace DoAn
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            this.Container = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.acDatMon = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement5 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acThongKe = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acAdmin = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acMonan = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acTaikhoan = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acNguyenlieu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acNhanvien = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Kho = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acKho = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acNhapnguyenlieu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Taikhoan = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acThongtincanhan = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.username = new DevExpress.XtraBars.BarHeaderItem();
            this.Time = new DevExpress.XtraBars.BarHeaderItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // Container
            // 
            this.Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Container.Location = new System.Drawing.Point(258, 39);
            this.Container.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(1240, 960);
            this.Container.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.acDatMon,
            this.acThongKe,
            this.acAdmin,
            this.Kho,
            this.Taikhoan,
            this.accordionControlElement1});
            this.accordionControl1.Location = new System.Drawing.Point(0, 39);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Auto;
            this.accordionControl1.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Always;
            this.accordionControl1.Size = new System.Drawing.Size(258, 960);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // acDatMon
            // 
            this.acDatMon.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement2,
            this.accordionControlElement3,
            this.accordionControlElement4,
            this.accordionControlElement5});
            this.acDatMon.Name = "acDatMon";
            this.acDatMon.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acDatMon.Text = "Đặt món";
            this.acDatMon.Click += new System.EventHandler(this.acDatMon_Click);
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement2.Text = "Đặt món";
            this.accordionControlElement2.Visible = false;
            // 
            // accordionControlElement3
            // 
            this.accordionControlElement3.Name = "accordionControlElement3";
            this.accordionControlElement3.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement3.Text = "Tài khoản";
            this.accordionControlElement3.Visible = false;
            // 
            // accordionControlElement4
            // 
            this.accordionControlElement4.Name = "accordionControlElement4";
            this.accordionControlElement4.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement4.Text = "Admin";
            this.accordionControlElement4.Visible = false;
            // 
            // accordionControlElement5
            // 
            this.accordionControlElement5.Name = "accordionControlElement5";
            this.accordionControlElement5.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement5.Text = "Kho";
            this.accordionControlElement5.Visible = false;
            // 
            // acThongKe
            // 
            this.acThongKe.Name = "acThongKe";
            this.acThongKe.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acThongKe.Text = "Thống kê";
            this.acThongKe.Click += new System.EventHandler(this.acThongKe_Click);
            // 
            // acAdmin
            // 
            this.acAdmin.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.acMonan,
            this.acTaikhoan,
            this.acNguyenlieu,
            this.acNhanvien});
            this.acAdmin.Name = "acAdmin";
            this.acAdmin.Text = "Admin";
            // 
            // acMonan
            // 
            this.acMonan.Name = "acMonan";
            this.acMonan.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acMonan.Text = "Món ăn ";
            this.acMonan.Click += new System.EventHandler(this.acMonan_Click);
            // 
            // acTaikhoan
            // 
            this.acTaikhoan.Name = "acTaikhoan";
            this.acTaikhoan.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acTaikhoan.Text = "Tài khoản ";
            this.acTaikhoan.Click += new System.EventHandler(this.acTaikhoan_Click_1);
            // 
            // acNguyenlieu
            // 
            this.acNguyenlieu.Name = "acNguyenlieu";
            this.acNguyenlieu.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acNguyenlieu.Text = "Nguyên liệu";
            this.acNguyenlieu.Click += new System.EventHandler(this.acNguyenlieu_Click);
            // 
            // acNhanvien
            // 
            this.acNhanvien.Name = "acNhanvien";
            this.acNhanvien.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acNhanvien.Text = "Nhân viên";
            this.acNhanvien.Click += new System.EventHandler(this.acNhanvien_Click);
            // 
            // Kho
            // 
            this.Kho.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.acKho,
            this.acNhapnguyenlieu});
            this.Kho.Name = "Kho";
            this.Kho.Text = "Kho";
            // 
            // acKho
            // 
            this.acKho.Name = "acKho";
            this.acKho.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acKho.Text = "Kho";
            this.acKho.Click += new System.EventHandler(this.acKho_Click);
            // 
            // acNhapnguyenlieu
            // 
            this.acNhapnguyenlieu.Name = "acNhapnguyenlieu";
            this.acNhapnguyenlieu.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acNhapnguyenlieu.Text = "Nhập nguyên liệu";
            // 
            // Taikhoan
            // 
            this.Taikhoan.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.acThongtincanhan});
            this.Taikhoan.Name = "Taikhoan";
            this.Taikhoan.Text = "Tài khoản";
            // 
            // acThongtincanhan
            // 
            this.acThongtincanhan.Name = "acThongtincanhan";
            this.acThongtincanhan.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acThongtincanhan.Text = "Thông tin cá nhân ";
            this.acThongtincanhan.Click += new System.EventHandler(this.acTaiKhoan_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.username,
            this.Time});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1498, 39);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.username);
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.Time);
            // 
            // username
            // 
            this.username.Caption = "Username";
            this.username.Id = 0;
            this.username.Name = "username";
            // 
            // Time
            // 
            this.Time.Caption = "Time";
            this.Time.Id = 0;
            this.Time.Name = "Time";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement1.Text = "Element1";
            this.accordionControlElement1.Click += new System.EventHandler(this.accordionControlElement1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1498, 999);
            this.ControlContainer = this.Container;
            this.Controls.Add(this.Container);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Home";
            this.NavigationControl = this.accordionControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer Container;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acDatMon;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement4;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement5;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acThongtincanhan;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acAdmin;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acKho;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acThongKe;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Kho;
        private DevExpress.XtraBars.BarHeaderItem username;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Taikhoan;
        private DevExpress.XtraBars.BarHeaderItem Time;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acMonan;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acTaikhoan;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acNguyenlieu;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acNhapnguyenlieu;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acNhanvien;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
    }
}

