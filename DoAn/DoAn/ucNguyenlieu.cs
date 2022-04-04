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
    public partial class ucNguyenlieu : UserControl
    {
        private static ucNguyenlieu instance;
        public static ucNguyenlieu Instance
        {
            get
            {
                if (instance == null)
                    instance = new ucNguyenlieu();
                return instance;
            }
        }

        Models.DATABASE data;
        public ucNguyenlieu()
        {
            InitializeComponent();
            data = new Models.DATABASE();
            //---NCC---//
            loadlistNCC();
            setautowrNCC();
            setlockbuttonNCC(true);
            setlocktextNCC(true);
            setnulltextNCC();
            //---------//

            //---LNL---//
            loadlistLNL();
            loadnccLNL();
            setautowrLNL();
            setlockbuttonLNL(true);
            setlocktextLNL(true);
            setnulltextLNL();
            //---------//

            //---NL---//
            //---------//
        }
        //--------------------Nhà cung cấp-----------------------------------//

        bool addnewNCC;//kiểm tra có phải thêm mới không 
        bool addnewLNL;//kiểm tra có phải thêm mới không 


        private void setnulltextNCC()//set trống các textbox nhà cung cấp
        {
            tbxMancc.ResetText();
            tbxTenncc.ResetText();
            tbxDiachincc.ResetText();
            tbxSdtncc.ResetText();
        }

        private void setlocktextNCC(bool locktext)//set khóa các textbox nhà cung cấp
        {
            tbxMancc.ReadOnly = true;
            tbxTenncc.ReadOnly = locktext;
            tbxSdtncc.ReadOnly = locktext;
            tbxDiachincc.ReadOnly = locktext;
        }

        private void setlockbuttonNCC(bool lockbutton)// set khóa các button nhà cung cấp
        {
            btnThemncc.Enabled = lockbutton;
            btnSuancc.Enabled = lockbutton;
            btnXoancc.Enabled = lockbutton;
            btnLuuncc.Enabled = !lockbutton;
            btnKluuncc.Enabled = !lockbutton;
            btnThoatncc.Enabled = true;
        }

        private void NCCbinding()// show dữ liệu có trong list view khi chọn nhà cung cấp
        {
            if (ltvNcc.SelectedItems.Count > 0)
            {
                tbxMancc.Text = ltvNcc.SelectedItems[0].SubItems[1].Text;
                tbxTenncc.Text = ltvNcc.SelectedItems[0].SubItems[2].Text;
                tbxSdtncc.Text = ltvNcc.SelectedItems[0].SubItems[3].Text;
                tbxDiachincc.Text = ltvNcc.SelectedItems[0].SubItems[4].Text;
            }
        }

        private void setautowrNCC()//Tự động điền thông tin trong ô tìm kiếm nhà cung cấp
        {
            List<NHACUNGCAP> listncc = data.NHACUNGCAP.ToList();
            foreach (NHACUNGCAP item in listncc)
            {
                if (item.NCCSTT == true)
                {
                    tbxTimkiemncc.AutoCompleteCustomSource.Add(item.MANCC);
                    tbxTimkiemncc.AutoCompleteCustomSource.Add(item.TENNCC);
                    tbxTimkiemncc.AutoCompleteCustomSource.Add(item.DCHI);
                    tbxTimkiemncc.AutoCompleteCustomSource.Add(item.SDT);
                }
            }
        }

        private void findNCC()//Tìm kiến nhà cung cấp
        {
            List<NHACUNGCAP> listncc = data.NHACUNGCAP.ToList();
            ListViewItem ltv;
            int stt = 0;
            if (tbxTimkiemncc.Text != "")
            {
                string info = tbxTimkiemncc.Text;
                foreach (NHACUNGCAP ncc in listncc)
                {
                    if (string.Compare(info, ncc.MANCC, true) == 0 || string.Compare(info, ncc.TENNCC, true) == 0 || string.Compare(info, ncc.DCHI, true) == 0 || string.Compare(info, ncc.SDT, true) == 0)
                    {
                        ltvNcc.Items.Clear();

                        if (ncc.NCCSTT == true)
                        {
                            stt++;
                            string[] ds = { stt.ToString(), ncc.MANCC, ncc.TENNCC,ncc.DCHI,ncc.SDT, ncc.DCHI };
                            ltv = new ListViewItem(ds);
                            ltvNcc.Items.Add(ltv);
                        }
                    }
                }
            }
            else
            {
                ltvNcc.Items.Clear();
                loadlistNCC();
            }
        }

        private void loadlistNCC()// load thông tin nhà cung cấp vào list view 
        {
            ltvNcc.Items.Clear();
            List<NHACUNGCAP> listncc = data.NHACUNGCAP.ToList();
            ListViewItem ltv;
            int stt = 0;
            foreach (NHACUNGCAP ncc in listncc)
            {

                if (ncc.NCCSTT == true)
                {
                    stt++;
                    string[] ds = { stt.ToString(), ncc.MANCC, ncc.TENNCC,ncc.SDT, ncc.DCHI, ncc.DCHI };
                    ltv = new ListViewItem(ds);
                    ltvNcc.Items.Add(ltv);
                }
            }
        }

        private void addNCC()//Thêm nhà cung cấp
        {
            setnulltextNCC();
            setlocktextNCC(false);
            setlockbuttonNCC(false);
            tbxMancc.ReadOnly = false;
            ltvNcc.Enabled = false;
            addnewNCC = true;
        }

        private void editNCC()//Sửa nhà cung cấp
        {
            setlocktextNCC(false);
            setlockbuttonNCC(false);
            addnewNCC = false;
        }

        private void delNCC()//Xóa nhà cung cấp
        {
            bool remove = false;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                if (ltvNcc.SelectedItems.Count > 0)
                {
                    string mancc = ltvNcc.SelectedItems[0].SubItems[1].Text;
                    NHACUNGCAP ncc = data.NHACUNGCAP.FirstOrDefault(c => c.MANCC == mancc);
                    ncc.NCCSTT = false;
                    remove = true;
                    setnulltextNCC();
                    data.SaveChanges();
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
            loadlistNCC();
        }

        private void saveNCC()//lưu chỉnh sửa nhà cung cấp
        {
            bool save = false;//trạng thái lưu
            bool exist = false;//tồn tại
            bool textnull = true;//kiểm tra rỗng
            NHACUNGCAP newncc = new NHACUNGCAP();
            List<NHACUNGCAP> listncc = data.NHACUNGCAP.ToList();
            if (tbxMancc.Text != "" && tbxTenncc.Text != "" && tbxSdtncc.Text != "" && tbxDiachincc.Text != "" )
            {
                textnull = false;
                foreach (NHACUNGCAP item in listncc)
                {
                    if (tbxMancc.Text == item.MANCC)
                    {
                        exist = true;
                    }
                }
            }
            if (textnull == false)
            {
                if (addnewNCC == true)
                {
                    if (exist == false)
                    {
                        newncc.MANCC = tbxMancc.Text;
                        newncc.TENNCC = tbxTenncc.Text;
                        newncc.SDT = tbxSdtncc.Text;
                        newncc.DCHI = tbxDiachincc.Text;
                        newncc.NCCSTT = true;
                        data.NHACUNGCAP.Add(newncc);
                        save = true;
                    }
                }
                else
                {
                    string mancc = tbxMancc.Text;
                    NHACUNGCAP editncc = data.NHACUNGCAP.FirstOrDefault(c => c.MANCC == mancc );
                    editncc.TENNCC = tbxTenncc.Text;
                    editncc.SDT = tbxSdtncc.Text;
                    editncc.DCHI =tbxDiachincc.Text;
                    save = true;
                    exist = false;
                }
            }
            if (save == true)
            {
                data.SaveChanges();
                MessageBox.Show("Hoàn tất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                setnulltextNCC();
                setlocktextNCC(true);
                setlockbuttonNCC(true);
                ltvNcc.Enabled = true;
                loadlistNCC();
            }
            if (textnull == true)
            {
                MessageBox.Show("Bạn phải điền đủ và đúng thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            if (exist == true)
            {
                MessageBox.Show("Mã nhà cung cấp đang tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

          
        }

        private void nonsaveNCC(bool nonsave)//Không lưu nhà cung cấp
        {
            if (nonsave == true)
            {
                setnulltextNCC();
                setlocktextNCC(true);
                setlockbuttonNCC(true);
                ltvNcc.Enabled = true;
                MessageBox.Show("Đã hủy thao tác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                setnulltextNCC();
                setlocktextNCC(true);
                setlockbuttonNCC(true);
                ltvNcc.Enabled = true;
            }

        }

        //Sự kiện NCC

        private void btnThemncc_Click(object sender, EventArgs e)
        {
            addNCC();
        }

        private void btnSuancc_Click(object sender, EventArgs e)
        {
            editNCC();
        }

        private void btnXoancc_Click(object sender, EventArgs e)
        {
            delNCC();
        }

        private void btnLuuncc_Click(object sender, EventArgs e)
        {
            saveNCC();
        }

        private void btnKluuncc_Click(object sender, EventArgs e)
        {
            nonsaveNCC(true);
        }

        private void ltvNcc_SelectedIndexChanged(object sender, EventArgs e)
        {
            NCCbinding();
        }

        private void btnThoatncc_Click(object sender, EventArgs e)
        {
            nonsaveNCC(false);
            this.Visible = false;
        }

        private void tbxTimkiemncc_TextChanged(object sender, EventArgs e)
        {
            findNCC();
        }
        //-------------------------------------------------------------------//

        //--------------------Loại nguyên liệu-------------------------------//
        private void setnulltextLNL()//set trống các textbox loại nguyên liệu
        {
            tbxIdlnl.ResetText();
            tbxTenlnl.ResetText();
            cbxNCClnl.ResetText();
        }

        private void setlocktextLNL(bool locktext)//set khóa các textbox loại nguyên liệu
        {
            tbxIdlnl.ReadOnly = true;
            tbxTenlnl.ReadOnly = locktext;
            cbxNCClnl.Enabled = !locktext;
        }

        private void setlockbuttonLNL(bool lockbutton)// set khóa các button loại nguyên liệu
        {
            btnThemlnl.Enabled = lockbutton;
            btnSualnl.Enabled = lockbutton;
            btnXoalnl.Enabled = lockbutton;
            btnLuulnl.Enabled = !lockbutton;
            btnKluulnl.Enabled = !lockbutton;
            btnThoatlnl.Enabled = true;
        }

        private void loadnccLNL()//load ds ncc trong combobox
        {
            List<NHACUNGCAP> listncc = data.NHACUNGCAP.ToList();
            foreach (NHACUNGCAP item in listncc)
            {
                if (item.NCCSTT==true)
                {
                    cbxNCClnl.DataSource = listncc;
                    cbxNCClnl.DisplayMember = "MANCC";
                }
            }
        }

        private void LNLbinding()// show dữ liệu có trong list view khi chọn loại nguyên liệu
        {
            if (ltvLoainl.SelectedItems.Count > 0)
            {
                tbxIdlnl.Text = ltvLoainl.SelectedItems[0].SubItems[1].Text;
                tbxTenlnl.Text = ltvLoainl.SelectedItems[0].SubItems[2].Text;
                cbxNCClnl.Text = ltvLoainl.SelectedItems[0].SubItems[3].Text;
            }
        }

        private void setautowrLNL()//Tự động điền thông tin trong ô tìm kiếm loại nguyên liệu
        {
            List<LOAINGUYENLIEU> listlnl = data.LOAINGUYENLIEU.ToList();
            foreach (LOAINGUYENLIEU item in listlnl)
            {
                if (item.LNLSTT == true)
                {
                    tbxTimkiemlnl.AutoCompleteCustomSource.Add(item.MANCC);
                    tbxTimkiemlnl.AutoCompleteCustomSource.Add(item.MALOAINL.ToString());
                    tbxTimkiemlnl.AutoCompleteCustomSource.Add(item.TENLOAINL);
                }
            }
        }

        private void findLNL()//Tìm kiến loại nguyên liệu
        {
            List<LOAINGUYENLIEU> listlnl = data.LOAINGUYENLIEU.ToList();
            ListViewItem ltv;
            int stt = 0;
            if (tbxTimkiemncc.Text != "")
            {
                string info = tbxTimkiemncc.Text;
                foreach (LOAINGUYENLIEU lnl in listlnl)
                {
                    if (string.Compare(info, lnl.MANCC, true) == 0 || string.Compare(info, lnl.MALOAINL.ToString(), true) == 0 || string.Compare(info, lnl.TENLOAINL, true) == 0 )
                    {
                        ltvLoainl.Items.Clear();

                        if (lnl.LNLSTT == true)
                        {
                            stt++;
                            string[] ds = { stt.ToString(), lnl.MALOAINL.ToString(), lnl.TENLOAINL, lnl.MANCC };
                            ltv = new ListViewItem(ds);
                            ltvLoainl.Items.Add(ltv);
                        }
                    }
                }
            }
            else
            {
                ltvNcc.Items.Clear();
                loadlistLNL();
            }
        }

        private void loadlistLNL()// load thông tin loại nguyên liệu vào list view 
        {
            ltvLoainl.Items.Clear();
            List<LOAINGUYENLIEU> listlnl = data.LOAINGUYENLIEU.ToList();
            ListViewItem ltv;
            int stt = 0;
            foreach (LOAINGUYENLIEU lnl in listlnl)
            {
                ltvLoainl.Items.Clear();

                if (lnl.LNLSTT == true)
                {
                    stt++;
                    string[] ds = { stt.ToString(), lnl.MALOAINL.ToString(), lnl.TENLOAINL, lnl.MANCC };
                    ltv = new ListViewItem(ds);
                    ltvLoainl.Items.Add(ltv);
                }
            }
        }

        private void addLNL()//Thêm loại nguyên liệu
        {
            setnulltextLNL();
            setlocktextLNL(false);
            setlockbuttonLNL(false);
            ltvLoainl.Enabled = false;
            addnewLNL = true;
        }

        private void editLNL()//Sửa loại nguyên liệu
        {
            setlocktextLNL(false);
            setlockbuttonLNL(false);
            addnewLNL = false;
        }

        private void delLNL()//Xóa loại nguyên liệu
        {
            bool remove = false;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                if (ltvLoainl.SelectedItems.Count > 0)
                {
                    int manlnl = Convert.ToInt32(ltvNcc.SelectedItems[0].SubItems[1].Text);
                    LOAINGUYENLIEU lnl = data.LOAINGUYENLIEU.FirstOrDefault(c => c.MALOAINL == manlnl);
                    lnl.LNLSTT = false;
                    remove = true;
                    setnulltextLNL();
                }
                data.SaveChanges();
            }
 
            if (remove == false)
            {
                MessageBox.Show("Xóa không thành công!\nVui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Hoàn tất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            loadlistNCC();
        }

        private void saveLNL()//lưu chỉnh sửa loại nguyên liệu
        {
            bool save = false;//trạng thái lưu
            bool textnull = true;//kiểm tra rỗng
            LOAINGUYENLIEU newlnl = new LOAINGUYENLIEU();
            List<LOAINGUYENLIEU> listlnl = data.LOAINGUYENLIEU.ToList();
            NHACUNGCAP ncc = cbxNCClnl.SelectedValue as NHACUNGCAP;

            if (tbxTenlnl.Text != "" && cbxLoainl.SelectedValue==null)
            {
                textnull = false;
            }
            if (textnull == false)
            {
               
                if (addnewLNL == true)
                {
                        newlnl.TENLOAINL = tbxTenlnl.Text;
                        newlnl.MANCC = ncc.MANCC;
                        newlnl.LNLSTT = true;
                        data.LOAINGUYENLIEU.Add(newlnl);
                        save = true;
                }
                else
                {
                    int id = Convert.ToInt32(tbxIdlnl.Text);
                    LOAINGUYENLIEU editlnl = data.LOAINGUYENLIEU.FirstOrDefault(c => c.MALOAINL == id);
                    editlnl.TENLOAINL = tbxTenlnl.Text;
                    editlnl.MANCC = ncc.MANCC;
                    save = true;
                }
            }
            if (save == true)
            {
                data.SaveChanges();
                MessageBox.Show("Hoàn tất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                setnulltextLNL();
                setlocktextLNL(true);
                setlockbuttonLNL(true);
                ltvLoainl.Enabled = true;
                loadlistLNL();
            }
            if (textnull == true)
            {
                MessageBox.Show("Bạn phải điền đủ và đúng thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

      
        }

        private void nonsaveLNL(bool nonsave)//Không lưu loại nguyên liệu
        {
            if (nonsave == true)
            {
                setnulltextLNL();
                setlocktextLNL(true);
                setlockbuttonLNL(true);
                ltvLoainl.Enabled = true;
                MessageBox.Show("Đã hủy thao tác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                setnulltextLNL();
                setlocktextLNL(true);
                setlockbuttonLNL(true);
                ltvLoainl.Enabled = true;
            }

        }

        //Sự kiện LNL

        private void btnThemlnl_Click(object sender, EventArgs e)
        {
            addLNL();
        }

        private void btnSualnl_Click(object sender, EventArgs e)
        {
            editLNL();
        }

        private void btnXoalnl_Click(object sender, EventArgs e)
        {
            delLNL();
        }

        private void btnLuulnl_Click(object sender, EventArgs e)
        {
            saveLNL();
        }

        private void btnKluulnl_Click(object sender, EventArgs e)
        {
            nonsaveLNL(true);
        }

        private void btnThoatlnl_Click(object sender, EventArgs e)
        {
            nonsaveLNL(false);
        }

        private void tbxTimkiemlnl_TextChanged(object sender, EventArgs e)
        {
            findLNL();
        }

        private void ltvLoainl_SelectedIndexChanged(object sender, EventArgs e)
        {
            LNLbinding();
        }

        //-------------------------------------------------------------------//

        //--------------------Nguyên liệu------------------------------------//
        //-------------------------------------------------------------------//



    }
}
