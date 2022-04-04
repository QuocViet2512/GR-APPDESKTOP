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
    public partial class ucNhanvien : UserControl
    {
        private static ucNhanvien instance;
        public static ucNhanvien Instance
        {
            get
            {
                if (instance == null)
                    instance = new ucNhanvien();
                return instance;
            }
        }

        Models.DATABASE data;
        public ucNhanvien()
        {
            InitializeComponent();
            data = new Models.DATABASE();
            loadlistNV();
            loadcv();
            setautowr();
            setlockbutton(true);
            setlocktext(true);
            setnulltext();
        }

 

        bool addnewnv;//kiểm tra có phải thêm mới không 
        bool deletenv;//kiểm tra xóa hẳn hay ẩn

        private void loadcv()//load chức vụ trong conbobox
        {
            List<CHUCVU> listcv = data.CHUCVU.ToList();
            cbChucVu.DataSource = listcv;
            cbChucVu.DisplayMember = "TENCV";
        }

        private void setnulltext()//set trống các textbox
        {
            txtMaNv.ResetText();
            txtHotenNV.ResetText();
            txtSDT.ResetText();
            tbxCMND.ResetText();
            dtpNgaySinh.Value = DateTime.Now;
            cbChucVu.ResetText();
        }

        private void setlocktext(bool locktext)//set khóa các textbox
        {
            txtMaNv.ReadOnly = true;
            txtHotenNV.ReadOnly = locktext;
            txtSDT.ReadOnly = locktext;
            tbxCMND.ReadOnly = locktext;
            dtpNgaySinh.Enabled = !locktext;
            cbChucVu.Enabled = !locktext;
        }

        private void setlockbutton(bool lockbutton)// set khóa các button
        {
            btnThemnv.Enabled = lockbutton;
            btnSuanv.Enabled = lockbutton;
            btnXoanv.Enabled = lockbutton;
            btnLuunv.Enabled = !lockbutton;
            btnKluunv.Enabled = !lockbutton;
            btnThoatnv.Enabled = true ;
        }

        private void NVbinding()// show dữ liệu có trong list view khi chọn
        {
            if (ltvNhanvien.SelectedItems.Count > 0)
            {
                txtMaNv.Text = ltvNhanvien.SelectedItems[0].SubItems[1].Text;
                txtHotenNV.Text = ltvNhanvien.SelectedItems[0].SubItems[2].Text;
                cbChucVu.DisplayMember = ltvNhanvien.SelectedItems[0].SubItems[3].Text;
                txtSDT.Text = ltvNhanvien.SelectedItems[0].SubItems[4].Text;
                tbxCMND.Text = ltvNhanvien.SelectedItems[0].SubItems[5].Text;
                dtpNgaySinh.Text = ltvNhanvien.SelectedItems[0].SubItems[6].Text;

            }
        }

        private void setautowr()//Tự động điền thông tin trong ô tìm kiếm 
        {
            List<NHANVIEN> listnv = data.NHANVIEN.ToList();
            foreach (NHANVIEN item in listnv)
            {
                if (item.NVSTT == true)
                {
                    tbxTimkiemnv.AutoCompleteCustomSource.Add(item.MANV);
                    tbxTimkiemnv.AutoCompleteCustomSource.Add(item.TENNV);
                    tbxTimkiemnv.AutoCompleteCustomSource.Add(item.CMND);
                    tbxTimkiemnv.AutoCompleteCustomSource.Add(item.SDT);
                }
            }
        }

        private void findnv()//Tìm kiến nhân viên
        {
            List<NHANVIEN> listnv = data.NHANVIEN.ToList();
            List<CHUCVU> listcv = data.CHUCVU.ToList();
            ListViewItem ltv;
            int stt = 0;
            if (tbxTimkiemnv.Text != "")
            {
                string info = tbxTimkiemnv.Text;
                foreach (NHANVIEN nv in listnv)
                {
                    if (string.Compare(info, nv.MANV, true) == 0 || string.Compare(info, nv.TENNV, true) == 0 || string.Compare(info, nv.CMND, true) == 0 || string.Compare(info, nv.SDT, true) == 0)
                    {
                        ltvNhanvien.Items.Clear();
                      
                         if (nv.NVSTT == true)
                         {
                                stt++;

                                foreach (CHUCVU cv in listcv)
                                {
                                    if (nv.MACV == cv.MACV)
                                    {
                                        string[] ds = { stt.ToString(), nv.MANV, nv.TENNV, cv.TENCV, nv.SDT, nv.CMND, nv.NSINH.Value.ToShortDateString() };
                                        ltv = new ListViewItem(ds);
                                        ltvNhanvien.Items.Add(ltv);
                                    }

                                }
                         }

                        
                    }
                }
            }
            else
            {
                ltvNhanvien.Items.Clear();
                loadlistNV();
            }
        }

        private void loadlistNV()// load thông tin nhân viên vào list view 
        {
            ltvNhanvien.Items.Clear();
            List<NHANVIEN> listnv = data.NHANVIEN.ToList();
            List<CHUCVU> listcv = data.CHUCVU.ToList();

            ListViewItem ltv;
            int stt = 0;
            foreach (NHANVIEN nv in listnv)
            {
                if (nv.NVSTT == true)
                {
                    stt++;

                    foreach (CHUCVU cv in listcv)
                    {
                        if (nv.MACV == cv.MACV)
                        {
                            string[] ds = { stt.ToString(), nv.MANV, nv.TENNV, cv.TENCV, nv.SDT, nv.CMND, nv.NSINH.Value.ToShortDateString() };
                            ltv = new ListViewItem(ds);
                            ltvNhanvien.Items.Add(ltv);
                        }

                    }
                }
            
            }
           
            
        }

        private void addnv()//Thêm nhân viên
        {
            setnulltext();
            setlocktext(false);
            setlockbutton(false);
            txtMaNv.ReadOnly = false;
            ltvNhanvien.Enabled = false;
            addnewnv = true;
        }

        private void editnv()//Sửa nhân viên
        {
            setlocktext(false);
            setlockbutton(false);
            addnewnv = false;
        }

        private void delnv()//Xóa nhân viên
        {
            bool remove = false;

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                if (ltvNhanvien.SelectedItems.Count > 0)
                {
                    string manv = ltvNhanvien.SelectedItems[0].SubItems[1].Text;
                    NHANVIEN nv = data.NHANVIEN.FirstOrDefault(c => c.MANV == manv);
                    nv.NVSTT = false;
                    remove = true;
                }
                data.SaveChanges();
            }

            if (remove == false)
            {
                MessageBox.Show("Xóa không thành công!\nVui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Hoàn tất!", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            loadlistNV();
        }

        private void savenv()//lưu chỉnh sửa
        {
            bool save = false;//trạng thái lưu
            bool exist = false;//tồn tại
            bool textnull = true;//kiểm tra rỗng
            NHANVIEN newnv = new NHANVIEN();
            CHUCVU chucvu = cbChucVu.SelectedValue as CHUCVU;
            List<NHANVIEN> listnv = data.NHANVIEN.ToList();
            if (txtMaNv.Text != "" && txtHotenNV.Text != "" && txtSDT.Text != "" && dtpNgaySinh.Value != null && tbxCMND.Text != "" && cbChucVu.SelectedValue != null && dtpNgaySinh.Value < DateTime.Now.Date)
            {
                textnull = false;
                foreach (NHANVIEN item in listnv)
                {
                    if (txtMaNv.Text == item.MANV)
                    {
                        exist = true;
                    }
                }
            }
            if (textnull == false) 
            {
                if (addnewnv == true)
                {
                    if (exist == false)
                    {
                        newnv.MANV = txtMaNv.Text;
                        newnv.TENNV = txtHotenNV.Text;
                        newnv.SDT = txtSDT.Text;
                        newnv.NSINH = dtpNgaySinh.Value;
                        newnv.CMND = tbxCMND.Text;
                        newnv.MACV = chucvu.MACV;
                        newnv.NVSTT = true;
                        data.NHANVIEN.Add(newnv);
                        save = true;
                    }
                }
                else
                {
                    NHANVIEN editnv = data.NHANVIEN.FirstOrDefault(c => c.MANV == txtMaNv.Text);
                    editnv.TENNV = txtHotenNV.Text;
                    editnv.SDT = txtSDT.Text;
                    editnv.NSINH = dtpNgaySinh.Value;
                    editnv.CMND = tbxCMND.Text;
                    editnv.MACV = chucvu.MACV;
                    save = true;
                    exist = false;
                }
            }
            if(save == true)
            {
                data.SaveChanges();
                MessageBox.Show("Hoàn tất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                setnulltext();
                setlocktext(true);
                setlockbutton(true);
                ltvNhanvien.Enabled = true;
            }
            if(textnull== true)
            {
                MessageBox.Show("Bạn phải điền đủ và đúng thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            if(exist == true)
            {
                 MessageBox.Show("Mã nhân viên đang tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);   
            }

            loadlistNV();
        }

        private void nonsave(bool nonsave)//Không lưu
        {
            if (nonsave == true)
            {
                setnulltext();
                setlocktext(true);
                setlockbutton(true);
                ltvNhanvien.Enabled = true;
                MessageBox.Show("Đã hủy thao tác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                setnulltext();
                setlocktext(true);
                setlockbutton(true);
                ltvNhanvien.Enabled = true;
            }
        }




        private void btnThoatnv_Click(object sender, EventArgs e)
        {
            nonsave(false);
            this.Visible = false;
        }

        private void tbxTimkiemnv_TextChanged(object sender, EventArgs e)
        {
            findnv();
        }

        private void btnThemnv_Click(object sender, EventArgs e)
        {
            addnv();
        }

        private void btnSuanv_Click(object sender, EventArgs e)
        {
            editnv();
        }

        private void btnXoanv_Click(object sender, EventArgs e)
        {
            delnv();
        }

        private void btnLuunv_Click(object sender, EventArgs e)
        {
            savenv();
        }

        private void btnKluunv_Click(object sender, EventArgs e)
        {
            nonsave(true);
        }

        private void ltvNhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            NVbinding();
        }
    }
}
