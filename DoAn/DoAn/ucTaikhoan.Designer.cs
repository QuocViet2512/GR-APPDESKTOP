namespace DoAn
{
    partial class ucTaikhoan
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.ltvTaikhoan = new System.Windows.Forms.ListView();
            this.stt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.manvv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tentk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tenhienthi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pass = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbtimkiem = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbxTimkiemtk = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbxTenhienthi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoatk = new System.Windows.Forms.Button();
            this.btnSuatk = new System.Windows.Forms.Button();
            this.btnThemtk = new System.Windows.Forms.Button();
            this.btnLuutk = new System.Windows.Forms.Button();
            this.btnKluutk = new System.Windows.Forms.Button();
            this.cbxNhanvien = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxMatkhau = new System.Windows.Forms.TextBox();
            this.tbxTentk = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnThoattk = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.grbtimkiem.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.grbtimkiem);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1169, 793);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.ltvTaikhoan);
            this.panel3.Location = new System.Drawing.Point(3, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(686, 713);
            this.panel3.TabIndex = 4;
            // 
            // ltvTaikhoan
            // 
            this.ltvTaikhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ltvTaikhoan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stt,
            this.id,
            this.manvv,
            this.tentk,
            this.tenhienthi,
            this.pass});
            this.ltvTaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltvTaikhoan.FullRowSelect = true;
            this.ltvTaikhoan.GridLines = true;
            this.ltvTaikhoan.HideSelection = false;
            this.ltvTaikhoan.Location = new System.Drawing.Point(0, 3);
            this.ltvTaikhoan.Name = "ltvTaikhoan";
            this.ltvTaikhoan.Size = new System.Drawing.Size(683, 704);
            this.ltvTaikhoan.TabIndex = 0;
            this.ltvTaikhoan.UseCompatibleStateImageBehavior = false;
            this.ltvTaikhoan.View = System.Windows.Forms.View.Details;
            this.ltvTaikhoan.SelectedIndexChanged += new System.EventHandler(this.ltvTaikhoan_SelectedIndexChanged);
            // 
            // stt
            // 
            this.stt.Text = "STT";
            this.stt.Width = 69;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 59;
            // 
            // manvv
            // 
            this.manvv.Text = "Mã NV";
            this.manvv.Width = 74;
            // 
            // tentk
            // 
            this.tentk.Text = "Tên tài khoản";
            this.tentk.Width = 142;
            // 
            // tenhienthi
            // 
            this.tenhienthi.Text = "Tên hiển thị";
            this.tenhienthi.Width = 167;
            // 
            // pass
            // 
            this.pass.Text = "Mật khẩu";
            this.pass.Width = 234;
            // 
            // grbtimkiem
            // 
            this.grbtimkiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbtimkiem.Controls.Add(this.label13);
            this.grbtimkiem.Controls.Add(this.tbxTimkiemtk);
            this.grbtimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbtimkiem.Location = new System.Drawing.Point(3, 3);
            this.grbtimkiem.Name = "grbtimkiem";
            this.grbtimkiem.Size = new System.Drawing.Size(683, 71);
            this.grbtimkiem.TabIndex = 3;
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
            // tbxTimkiemtk
            // 
            this.tbxTimkiemtk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxTimkiemtk.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbxTimkiemtk.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxTimkiemtk.ForeColor = System.Drawing.Color.Black;
            this.tbxTimkiemtk.Location = new System.Drawing.Point(187, 28);
            this.tbxTimkiemtk.Name = "tbxTimkiemtk";
            this.tbxTimkiemtk.Size = new System.Drawing.Size(372, 22);
            this.tbxTimkiemtk.TabIndex = 15;
            this.tbxTimkiemtk.TextChanged += new System.EventHandler(this.tbxTimkiemtk_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.tbxTenhienthi);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnXoatk);
            this.panel2.Controls.Add(this.btnSuatk);
            this.panel2.Controls.Add(this.btnThemtk);
            this.panel2.Controls.Add(this.btnLuutk);
            this.panel2.Controls.Add(this.btnKluutk);
            this.panel2.Controls.Add(this.cbxNhanvien);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.tbxId);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.tbxMatkhau);
            this.panel2.Controls.Add(this.tbxTentk);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.btnThoattk);
            this.panel2.Location = new System.Drawing.Point(698, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(468, 787);
            this.panel2.TabIndex = 1;
            // 
            // tbxTenhienthi
            // 
            this.tbxTenhienthi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxTenhienthi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTenhienthi.Location = new System.Drawing.Point(146, 190);
            this.tbxTenhienthi.Name = "tbxTenhienthi";
            this.tbxTenhienthi.Size = new System.Drawing.Size(297, 27);
            this.tbxTenhienthi.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(4, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 62;
            this.label1.Text = "Tên hiển thị";
            // 
            // btnXoatk
            // 
            this.btnXoatk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoatk.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnXoatk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoatk.Location = new System.Drawing.Point(331, 472);
            this.btnXoatk.Name = "btnXoatk";
            this.btnXoatk.Size = new System.Drawing.Size(124, 47);
            this.btnXoatk.TabIndex = 60;
            this.btnXoatk.Text = "Xóa";
            this.btnXoatk.UseVisualStyleBackColor = false;
            this.btnXoatk.Click += new System.EventHandler(this.btnXoatk_Click);
            // 
            // btnSuatk
            // 
            this.btnSuatk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuatk.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSuatk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuatk.Location = new System.Drawing.Point(180, 472);
            this.btnSuatk.Name = "btnSuatk";
            this.btnSuatk.Size = new System.Drawing.Size(124, 47);
            this.btnSuatk.TabIndex = 59;
            this.btnSuatk.Text = "Sửa";
            this.btnSuatk.UseVisualStyleBackColor = false;
            this.btnSuatk.Click += new System.EventHandler(this.btnSuatk_Click);
            // 
            // btnThemtk
            // 
            this.btnThemtk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemtk.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnThemtk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemtk.Location = new System.Drawing.Point(22, 472);
            this.btnThemtk.Name = "btnThemtk";
            this.btnThemtk.Size = new System.Drawing.Size(124, 47);
            this.btnThemtk.TabIndex = 58;
            this.btnThemtk.Text = "Thêm";
            this.btnThemtk.UseVisualStyleBackColor = false;
            this.btnThemtk.Click += new System.EventHandler(this.btnThemtk_Click);
            // 
            // btnLuutk
            // 
            this.btnLuutk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuutk.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnLuutk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuutk.Location = new System.Drawing.Point(23, 559);
            this.btnLuutk.Name = "btnLuutk";
            this.btnLuutk.Size = new System.Drawing.Size(433, 47);
            this.btnLuutk.TabIndex = 57;
            this.btnLuutk.Text = "Lưu";
            this.btnLuutk.UseVisualStyleBackColor = false;
            this.btnLuutk.Click += new System.EventHandler(this.btnLuutk_Click);
            // 
            // btnKluutk
            // 
            this.btnKluutk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKluutk.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnKluutk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKluutk.Location = new System.Drawing.Point(22, 623);
            this.btnKluutk.Name = "btnKluutk";
            this.btnKluutk.Size = new System.Drawing.Size(433, 47);
            this.btnKluutk.TabIndex = 56;
            this.btnKluutk.Text = "Không lưu";
            this.btnKluutk.UseVisualStyleBackColor = false;
            this.btnKluutk.Click += new System.EventHandler(this.btnKluutk_Click);
            // 
            // cbxNhanvien
            // 
            this.cbxNhanvien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxNhanvien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNhanvien.FormattingEnabled = true;
            this.cbxNhanvien.Items.AddRange(new object[] {
            "Tạp vụ",
            "Đầu bếp",
            "Thu ngân",
            "Bán thời gian"});
            this.cbxNhanvien.Location = new System.Drawing.Point(146, 332);
            this.cbxNhanvien.Name = "cbxNhanvien";
            this.cbxNhanvien.Size = new System.Drawing.Size(297, 28);
            this.cbxNhanvien.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(4, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 55;
            this.label6.Text = "Nhân viên";
            // 
            // tbxId
            // 
            this.tbxId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxId.Location = new System.Drawing.Point(146, 44);
            this.tbxId.Name = "tbxId";
            this.tbxId.Size = new System.Drawing.Size(297, 27);
            this.tbxId.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(3, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 53;
            this.label7.Text = "ID(Tự động)";
            // 
            // tbxMatkhau
            // 
            this.tbxMatkhau.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxMatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMatkhau.Location = new System.Drawing.Point(146, 263);
            this.tbxMatkhau.Name = "tbxMatkhau";
            this.tbxMatkhau.Size = new System.Drawing.Size(297, 27);
            this.tbxMatkhau.TabIndex = 46;
            // 
            // tbxTentk
            // 
            this.tbxTentk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxTentk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTentk.Location = new System.Drawing.Point(146, 115);
            this.tbxTentk.Name = "tbxTentk";
            this.tbxTentk.Size = new System.Drawing.Size(297, 27);
            this.tbxTentk.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(4, 266);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 20);
            this.label10.TabIndex = 47;
            this.label10.Text = "Mật khẩu ";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(4, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 20);
            this.label11.TabIndex = 45;
            this.label11.Text = "Tên tài khoản ";
            // 
            // btnThoattk
            // 
            this.btnThoattk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoattk.BackColor = System.Drawing.Color.Tomato;
            this.btnThoattk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoattk.Location = new System.Drawing.Point(23, 737);
            this.btnThoattk.Name = "btnThoattk";
            this.btnThoattk.Size = new System.Drawing.Size(433, 47);
            this.btnThoattk.TabIndex = 42;
            this.btnThoattk.Text = "Thoát";
            this.btnThoattk.UseVisualStyleBackColor = false;
            this.btnThoattk.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // ucTaikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ucTaikhoan";
            this.Size = new System.Drawing.Size(1174, 799);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.grbtimkiem.ResumeLayout(false);
            this.grbtimkiem.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxMatkhau;
        private System.Windows.Forms.TextBox tbxTentk;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnThoattk;
        private System.Windows.Forms.GroupBox grbtimkiem;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbxTimkiemtk;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView ltvTaikhoan;
        private System.Windows.Forms.ComboBox cbxNhanvien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnXoatk;
        private System.Windows.Forms.Button btnSuatk;
        private System.Windows.Forms.Button btnThemtk;
        private System.Windows.Forms.Button btnLuutk;
        private System.Windows.Forms.Button btnKluutk;
        private System.Windows.Forms.ColumnHeader stt;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader manvv;
        private System.Windows.Forms.ColumnHeader tentk;
        private System.Windows.Forms.ColumnHeader pass;
        private System.Windows.Forms.TextBox tbxTenhienthi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader tenhienthi;
    }
}
