namespace DoAn
{
    partial class ucNhanvien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.grbtimkiem = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbxTimkiemnv = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ltvNhanvien = new System.Windows.Forms.ListView();
            this.stt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.manv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hoten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chucvu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sdt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmnd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nsinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXoanv = new System.Windows.Forms.Button();
            this.btnSuanv = new System.Windows.Forms.Button();
            this.btnThemnv = new System.Windows.Forms.Button();
            this.btnLuunv = new System.Windows.Forms.Button();
            this.btnKluunv = new System.Windows.Forms.Button();
            this.tbxCMND = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbChucVu = new System.Windows.Forms.ComboBox();
            this.txtMaNv = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtHotenNV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnThoatnv = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.grbtimkiem.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.grbtimkiem);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1168, 793);
            this.panel1.TabIndex = 0;
            // 
            // grbtimkiem
            // 
            this.grbtimkiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbtimkiem.Controls.Add(this.label13);
            this.grbtimkiem.Controls.Add(this.tbxTimkiemnv);
            this.grbtimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbtimkiem.Location = new System.Drawing.Point(6, 10);
            this.grbtimkiem.Name = "grbtimkiem";
            this.grbtimkiem.Size = new System.Drawing.Size(661, 71);
            this.grbtimkiem.TabIndex = 2;
            this.grbtimkiem.TabStop = false;
            this.grbtimkiem.Text = "Tìm kiếm";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(94, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 21);
            this.label13.TabIndex = 16;
            this.label13.Text = "Tìm kiếm";
            // 
            // tbxTimkiemnv
            // 
            this.tbxTimkiemnv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxTimkiemnv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbxTimkiemnv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxTimkiemnv.ForeColor = System.Drawing.Color.Black;
            this.tbxTimkiemnv.Location = new System.Drawing.Point(187, 28);
            this.tbxTimkiemnv.Name = "tbxTimkiemnv";
            this.tbxTimkiemnv.Size = new System.Drawing.Size(350, 22);
            this.tbxTimkiemnv.TabIndex = 15;
            this.tbxTimkiemnv.TextChanged += new System.EventHandler(this.tbxTimkiemnv_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.ltvNhanvien);
            this.panel3.Location = new System.Drawing.Point(3, 90);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(664, 700);
            this.panel3.TabIndex = 1;
            // 
            // ltvNhanvien
            // 
            this.ltvNhanvien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ltvNhanvien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stt,
            this.manv,
            this.hoten,
            this.chucvu,
            this.sdt,
            this.cmnd,
            this.nsinh});
            this.ltvNhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltvNhanvien.FullRowSelect = true;
            this.ltvNhanvien.GridLines = true;
            this.ltvNhanvien.HideSelection = false;
            this.ltvNhanvien.Location = new System.Drawing.Point(3, 0);
            this.ltvNhanvien.Name = "ltvNhanvien";
            this.ltvNhanvien.Size = new System.Drawing.Size(661, 697);
            this.ltvNhanvien.TabIndex = 0;
            this.ltvNhanvien.UseCompatibleStateImageBehavior = false;
            this.ltvNhanvien.View = System.Windows.Forms.View.Details;
            this.ltvNhanvien.SelectedIndexChanged += new System.EventHandler(this.ltvNhanvien_SelectedIndexChanged);
            // 
            // stt
            // 
            this.stt.Text = "STT";
            // 
            // manv
            // 
            this.manv.Text = "Mã NV";
            this.manv.Width = 86;
            // 
            // hoten
            // 
            this.hoten.Text = "Họ tên";
            this.hoten.Width = 131;
            // 
            // chucvu
            // 
            this.chucvu.Text = "Chức Vụ";
            this.chucvu.Width = 145;
            // 
            // sdt
            // 
            this.sdt.Text = "SDT";
            this.sdt.Width = 138;
            // 
            // cmnd
            // 
            this.cmnd.Text = "Số CMND";
            this.cmnd.Width = 155;
            // 
            // nsinh
            // 
            this.nsinh.Text = "N.Sinh";
            this.nsinh.Width = 135;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnXoanv);
            this.panel2.Controls.Add(this.btnSuanv);
            this.panel2.Controls.Add(this.btnThemnv);
            this.panel2.Controls.Add(this.btnLuunv);
            this.panel2.Controls.Add(this.btnKluunv);
            this.panel2.Controls.Add(this.tbxCMND);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.cbChucVu);
            this.panel2.Controls.Add(this.txtMaNv);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtSDT);
            this.panel2.Controls.Add(this.dtpNgaySinh);
            this.panel2.Controls.Add(this.txtHotenNV);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.btnThoatnv);
            this.panel2.Location = new System.Drawing.Point(673, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(490, 787);
            this.panel2.TabIndex = 0;
            // 
            // btnXoanv
            // 
            this.btnXoanv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoanv.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnXoanv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoanv.Location = new System.Drawing.Point(346, 458);
            this.btnXoanv.Name = "btnXoanv";
            this.btnXoanv.Size = new System.Drawing.Size(132, 47);
            this.btnXoanv.TabIndex = 61;
            this.btnXoanv.Text = "Xóa";
            this.btnXoanv.UseVisualStyleBackColor = false;
            this.btnXoanv.Click += new System.EventHandler(this.btnXoanv_Click);
            // 
            // btnSuanv
            // 
            this.btnSuanv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuanv.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSuanv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuanv.Location = new System.Drawing.Point(190, 458);
            this.btnSuanv.Name = "btnSuanv";
            this.btnSuanv.Size = new System.Drawing.Size(132, 47);
            this.btnSuanv.TabIndex = 60;
            this.btnSuanv.Text = "Sửa";
            this.btnSuanv.UseVisualStyleBackColor = false;
            this.btnSuanv.Click += new System.EventHandler(this.btnSuanv_Click);
            // 
            // btnThemnv
            // 
            this.btnThemnv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemnv.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnThemnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemnv.Location = new System.Drawing.Point(26, 458);
            this.btnThemnv.Name = "btnThemnv";
            this.btnThemnv.Size = new System.Drawing.Size(132, 47);
            this.btnThemnv.TabIndex = 59;
            this.btnThemnv.Text = "Thêm";
            this.btnThemnv.UseVisualStyleBackColor = false;
            this.btnThemnv.Click += new System.EventHandler(this.btnThemnv_Click);
            // 
            // btnLuunv
            // 
            this.btnLuunv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuunv.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnLuunv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuunv.Location = new System.Drawing.Point(26, 551);
            this.btnLuunv.Name = "btnLuunv";
            this.btnLuunv.Size = new System.Drawing.Size(455, 47);
            this.btnLuunv.TabIndex = 58;
            this.btnLuunv.Text = "Lưu";
            this.btnLuunv.UseVisualStyleBackColor = false;
            this.btnLuunv.Click += new System.EventHandler(this.btnLuunv_Click);
            // 
            // btnKluunv
            // 
            this.btnKluunv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKluunv.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnKluunv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKluunv.Location = new System.Drawing.Point(26, 620);
            this.btnKluunv.Name = "btnKluunv";
            this.btnKluunv.Size = new System.Drawing.Size(455, 47);
            this.btnKluunv.TabIndex = 57;
            this.btnKluunv.Text = "Không lưu";
            this.btnKluunv.UseVisualStyleBackColor = false;
            this.btnKluunv.Click += new System.EventHandler(this.btnKluunv_Click);
            // 
            // tbxCMND
            // 
            this.tbxCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCMND.Location = new System.Drawing.Point(161, 187);
            this.tbxCMND.Name = "tbxCMND";
            this.tbxCMND.Size = new System.Drawing.Size(294, 27);
            this.tbxCMND.TabIndex = 56;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(22, 190);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 20);
            this.label12.TabIndex = 55;
            this.label12.Text = "CMND";
            // 
            // cbChucVu
            // 
            this.cbChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChucVu.FormattingEnabled = true;
            this.cbChucVu.Items.AddRange(new object[] {
            "Tạp vụ",
            "Đầu bếp",
            "Thu ngân",
            "Bán thời gian"});
            this.cbChucVu.Location = new System.Drawing.Point(161, 309);
            this.cbChucVu.Name = "cbChucVu";
            this.cbChucVu.Size = new System.Drawing.Size(294, 28);
            this.cbChucVu.TabIndex = 51;
            // 
            // txtMaNv
            // 
            this.txtMaNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNv.Location = new System.Drawing.Point(161, 35);
            this.txtMaNv.Name = "txtMaNv";
            this.txtMaNv.Size = new System.Drawing.Size(294, 27);
            this.txtMaNv.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(22, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 20);
            this.label7.TabIndex = 53;
            this.label7.Text = "Mã nhân viên";
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(161, 137);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(294, 27);
            this.txtSDT.TabIndex = 46;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(161, 247);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(294, 27);
            this.dtpNgaySinh.TabIndex = 49;
            // 
            // txtHotenNV
            // 
            this.txtHotenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHotenNV.Location = new System.Drawing.Point(161, 87);
            this.txtHotenNV.Name = "txtHotenNV";
            this.txtHotenNV.Size = new System.Drawing.Size(294, 27);
            this.txtHotenNV.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(23, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 52;
            this.label6.Text = "Chức vụ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(23, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 50;
            this.label5.Text = "Ngày sinh";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(18, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 20);
            this.label10.TabIndex = 47;
            this.label10.Text = "Số điện thoại";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(23, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 20);
            this.label11.TabIndex = 45;
            this.label11.Text = "Họ tên";
            // 
            // btnThoatnv
            // 
            this.btnThoatnv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoatnv.BackColor = System.Drawing.Color.Tomato;
            this.btnThoatnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatnv.Location = new System.Drawing.Point(23, 737);
            this.btnThoatnv.Name = "btnThoatnv";
            this.btnThoatnv.Size = new System.Drawing.Size(455, 47);
            this.btnThoatnv.TabIndex = 42;
            this.btnThoatnv.Text = "Thoát";
            this.btnThoatnv.UseVisualStyleBackColor = false;
            this.btnThoatnv.Click += new System.EventHandler(this.btnThoatnv_Click);
            // 
            // ucNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.Controls.Add(this.panel1);
            this.Name = "ucNhanvien";
            this.Size = new System.Drawing.Size(1174, 799);
            this.panel1.ResumeLayout(false);
            this.grbtimkiem.ResumeLayout(false);
            this.grbtimkiem.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox grbtimkiem;
        private System.Windows.Forms.Button btnThoatnv;
        private System.Windows.Forms.TextBox tbxCMND;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbChucVu;
        private System.Windows.Forms.TextBox txtMaNv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtHotenNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbxTimkiemnv;
        private System.Windows.Forms.ListView ltvNhanvien;
        private System.Windows.Forms.ColumnHeader manv;
        private System.Windows.Forms.ColumnHeader hoten;
        private System.Windows.Forms.ColumnHeader chucvu;
        private System.Windows.Forms.ColumnHeader sdt;
        private System.Windows.Forms.ColumnHeader cmnd;
        private System.Windows.Forms.ColumnHeader nsinh;
        private System.Windows.Forms.ColumnHeader stt;
        private System.Windows.Forms.Button btnXoanv;
        private System.Windows.Forms.Button btnSuanv;
        private System.Windows.Forms.Button btnThemnv;
        private System.Windows.Forms.Button btnLuunv;
        private System.Windows.Forms.Button btnKluunv;
    }
}
