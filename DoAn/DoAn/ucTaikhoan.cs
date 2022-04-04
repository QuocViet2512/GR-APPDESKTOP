using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn.Models;

namespace DoAn
{
    public partial class ucTaikhoan : UserControl
    {
        private static ucTaikhoan instance;
        public static ucTaikhoan Instance
        {
            get
            {
                if (instance == null)
                    instance = new ucTaikhoan();
                return instance;
            }
        }

        Models.DATABASE data;
        public ucTaikhoan()
        {
            InitializeComponent();
            data = new Models.DATABASE();
            loadlistTK();
            loadnv();
            setautowr();
            setlockbutton(true);
            setlocktext(true);
            setnulltext();
        }


        bool addnewTK;

        private void loadnv()//load ds nhân viên trong conbobox
        {
            List<NHANVIEN> listnv = data.NHANVIEN.ToList();
            foreach (NHANVIEN item in listnv)
            {
                if (item.NVSTT == true)
                {
                    cbxNhanvien.DataSource = listnv;
                    cbxNhanvien.DisplayMember = "MANV";
                }
            }
        }

        private void setnulltext()//set trống các textbox
        {
            tbxId.ResetText();
            tbxTentk.ResetText();
            tbxMatkhau.ResetText();
            tbxTenhienthi.ResetText();
            cbxNhanvien.ResetText();
        }

        private void setlocktext(bool locktext)//set khóa các textbox
        {
            tbxId.ReadOnly = true;
            tbxTentk.ReadOnly = locktext;
            tbxTenhienthi.ReadOnly = locktext;
            tbxMatkhau.ReadOnly = locktext;
            cbxNhanvien.Enabled = !locktext;
        }

        private void setlockbutton(bool lockbutton)// set khóa các button
        {
            btnThemtk.Enabled = lockbutton;
            btnSuatk.Enabled = lockbutton;
            btnXoatk.Enabled = lockbutton;
            btnLuutk.Enabled = !lockbutton;
            btnKluutk.Enabled = !lockbutton;
            btnThoattk.Enabled = true;
        }

        private void TKbinding()// show dữ liệu có trong list view khi chọn
        {
            if (ltvTaikhoan.SelectedItems.Count > 0)
            {
                tbxId.Text = ltvTaikhoan.SelectedItems[0].SubItems[1].Text;
                cbxNhanvien.DisplayMember = ltvTaikhoan.SelectedItems[0].SubItems[2].Text;
                tbxTentk.Text = ltvTaikhoan.SelectedItems[0].SubItems[3].Text;
                tbxTenhienthi.Text = ltvTaikhoan.SelectedItems[0].SubItems[4].Text;
                tbxMatkhau.Text = ltvTaikhoan.SelectedItems[0].SubItems[5].Text;

            }
        }

        private void setautowr()//Tự động điền thông tin trong ô tìm kiếm 
        {
            List<TAIKHOAN> listtk = data.TAIKHOAN.ToList();
            foreach (TAIKHOAN item in listtk)
            {
                if (item.TKSTT == true)
                {
                    tbxTimkiemtk.AutoCompleteCustomSource.Add(item.ID.ToString());
                    tbxTimkiemtk.AutoCompleteCustomSource.Add(item.MANV);
                    tbxTimkiemtk.AutoCompleteCustomSource.Add(item.TENHIENTHI);
                    tbxTimkiemtk.AutoCompleteCustomSource.Add(item.TENTK);
                }
            }
        }

        private void findtk()//Tìm kiến tài khoản
        { 
            List<TAIKHOAN> listtk = data.TAIKHOAN.ToList();
            ListViewItem ltv;
            int stt = 0;
            if (tbxTimkiemtk.Text != "")
            {
                string info = tbxTimkiemtk.Text;
                foreach (TAIKHOAN tk in listtk)
                {
                    if (string.Compare(info, tk.ID.ToString(), true) == 0 || string.Compare(info, tk.MANV, true) == 0 || string.Compare(info, tk.TENTK, true) == 0 || string.Compare(info, tk.TENHIENTHI, true) == 0)
                    {
                        ltvTaikhoan.Items.Clear();

                        if (tk.TKSTT == true)
                        {
                            stt++;
                            string[] ds = { stt.ToString(),tk.ID.ToString(), tk.MANV, tk.TENTK, tk.TENHIENTHI, tk.MATKHAU };
                            ltv = new ListViewItem(ds);
                            ltvTaikhoan.Items.Add(ltv);

                        }


                    }
                }
            }
            else
            {
                ltvTaikhoan.Items.Clear();
                loadlistTK();
            }
        }

        private void loadlistTK()// load thông tin tài khoản vào list view 
        {
            ltvTaikhoan.Items.Clear();
            List<TAIKHOAN> listtk = data.TAIKHOAN.ToList();
            ListViewItem ltv;
            int stt = 0;
            foreach (TAIKHOAN tk in listtk)
            {
                if (tk.TKSTT == true)
                {
                    stt++;
                    string[] ds = { stt.ToString(), tk.ID.ToString(), tk.MANV, tk.TENTK, tk.TENHIENTHI, tk.MATKHAU };
                    ltv = new ListViewItem(ds);
                    ltvTaikhoan.Items.Add(ltv);

                }

            }


        }

        private void addtk()//Thêm tài khoản
        {
            setnulltext();
            setlocktext(false);
            setlockbutton(false);
            ltvTaikhoan.Enabled = false;
            addnewTK = true;
        }

        private void edittk()//Sửa tài khoản
        {
            setlocktext(false);
            setlockbutton(false);
            addnewTK = false;
        }
        private void deltk()//Xóa tài khoản
        {
            bool remove = false;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                if (ltvTaikhoan.SelectedItems.Count > 0)
                {
                    int id = Convert.ToInt32(ltvTaikhoan.SelectedItems[0].SubItems[1].Text);
                    TAIKHOAN tk = data.TAIKHOAN.FirstOrDefault(c => c.ID == id);
                    tk.TKSTT = false;
                    remove = true;
                    data.SaveChanges();
                    setnulltext();
                    if (Login.move.ID == id)
                    {
                        Form tmp = this.FindForm();
                        tmp.Close();
                    }
                }
            }
            if (remove == false)
            {
                MessageBox.Show("Xóa không thành công!\nVui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Hoàn tất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            loadlistTK();
        }

        private void savetk()//lưu chỉnh sửa
        {
            bool save = false;//trạng thái lưu
            bool textnull = true;//kiểm tra rỗng
            TAIKHOAN newtk = new TAIKHOAN();
            NHANVIEN nv = cbxNhanvien.SelectedValue as NHANVIEN;
            List<TAIKHOAN> listtk = data.TAIKHOAN.ToList();
            if (tbxTentk.Text != "" && tbxTenhienthi.Text != "" && tbxMatkhau.Text != "" && cbxNhanvien.SelectedValue != null )
            {
                textnull = false;
            }
            if (textnull == false)
            {
                if (addnewTK == true)
                {

                    newtk.TENTK = tbxTentk.Text;
                    newtk.TENHIENTHI = tbxTenhienthi.Text;
                    newtk.MATKHAU = tbxMatkhau.Text;
                    newtk.MANV = nv.MANV;
                    newtk.TKSTT = true;
                    data.TAIKHOAN.Add(newtk);
                    save = true;
                }
                else
                {
                    int id = Convert.ToInt32(tbxId.Text);
                    TAIKHOAN edittk = data.TAIKHOAN.FirstOrDefault(c => c.ID ==id );
                    edittk.ID = id;
                    edittk.TENTK = tbxTentk.Text;
                    edittk.TENHIENTHI = tbxTenhienthi.Text;
                    edittk.MATKHAU = tbxMatkhau.Text;
                    edittk.MANV = nv.MANV;
                    save = true;
                }
            }
            if (save == true)
            {
                data.SaveChanges();
                MessageBox.Show("Hoàn tất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                setnulltext();
                setlocktext(true);
                setlockbutton(true);
                ltvTaikhoan.Enabled = true;
            }
            if (textnull == true)
            {
                MessageBox.Show("Bạn phải điền đủ và đúng thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
   
            loadlistTK();
        }

        private void nonsave(bool nonsave )//Không lưu
        {
            if (nonsave == true)
            {
                setnulltext();
                setlocktext(true);
                setlockbutton(true);
                ltvTaikhoan.Enabled = true;
                MessageBox.Show("Đã hủy thao tác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                setnulltext();
                setlocktext(true);
                setlockbutton(true);
                ltvTaikhoan.Enabled = true;
            }

        }





        private void btnThoat_Click(object sender, EventArgs e)
        {
            nonsave(false);
            this.Visible = false;
        }

        private void btnThemtk_Click(object sender, EventArgs e)
        {
            addtk();
        }

        private void btnSuatk_Click(object sender, EventArgs e)
        {
            edittk();
        }

        private void btnXoatk_Click(object sender, EventArgs e)
        {
            deltk();
        }

        private void btnLuutk_Click(object sender, EventArgs e)
        {
            savetk();
        }

        private void btnKluutk_Click(object sender, EventArgs e)
        {
            nonsave(true);
        }

        private void ltvTaikhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            TKbinding();
        }

        private void tbxTimkiemtk_TextChanged(object sender, EventArgs e)
        {
            findtk();
        }
    }
}
