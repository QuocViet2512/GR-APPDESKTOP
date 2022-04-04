using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DoAn.Models;
namespace DoAn
{
    public partial class ucMonan : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucMonan instance;
        public static ucMonan Instance
        {
            get
            {
                if (instance == null)
                    instance = new ucMonan();
                return instance;
            }
        }
        Models.DATABASE db;
        Models.LOAIMON LoaiMon;
        Models.MONAN MenuMon;
        public ucMonan()
        {
            InitializeComponent();
            db = new Models.DATABASE();
            LoaiMon = new Models.LOAIMON();
            MenuMon = new Models.MONAN();

            loadLoaiMon();
            loadMenu();
            setNullLoai();
            setNullMenu();
            setButtonLoai(true);
            setButtonMenu(true);
            autoLoai();
            autoMenu();
        }
        bool addnewLNL; //kiểm tra loại nguyên liệu
        bool addnewMenu; // kiểm tra món ăn

        private void showLoai() // show loại món lên txt
        {
            if (lsvLoaiMon.SelectedItems.Count > 0)
            {
                txtMaLoaiMon.Text = lsvLoaiMon.SelectedItems[0].Text;
                txtTenLoaiMon.Text = lsvLoaiMon.SelectedItems[0].SubItems[1].Text;
            }
        }

        private void showMenu() // show món lên text
        {
            if (lsvMenuMon.SelectedItems.Count > 0)
            {
                txtMaMon.Text = lsvMenuMon.SelectedItems[0].Text;
                txtTenMon.Text = lsvMenuMon.SelectedItems[0].SubItems[1].Text;
                cbLoaiMon.DisplayMember = lsvMenuMon.SelectedItems[0].SubItems[2].Text;
                txtGiaMon.Text = lsvMenuMon.SelectedItems[0].SubItems[3].Text;

            }
        }

        private void loadMenu() // load loại món
        {
            lsvMenuMon.Items.Clear();
            List<Models.MONAN> listMenu = db.MONAN.ToList();
            foreach (Models.MONAN menu in listMenu)
            {
                if (menu.MAstatus == true)
                {
                    string[] row = { menu.MaMon, menu.TenMon, menu.MaLoaiMon.ToString(), menu.Gia.ToString() };
                    ListViewItem item = new ListViewItem(row);
                    lsvMenuMon.Items.Add(item);
                }
            }
        }
        private void loadLoaiMon() // load món ăn
        {
            lsvLoaiMon.Items.Clear();
            List<Models.LOAIMON> listLoai = db.LOAIMON.ToList();
            foreach (Models.LOAIMON loai in listLoai)
            {
                if (loai.LMstatus == true)
                {
                    string[] row = { loai.MaLoaiMon.ToString(), loai.TenLoaiMon };
                    ListViewItem item = new ListViewItem(row);
                    lsvLoaiMon.Items.Add(item);
                }
            }
        }

        private void setNullLoai()
        {
            txtMaLoaiMon.Text = "";
            txtTenLoaiMon.Text = "";
        }
        private void setNullMenu()
        {
            txtMaMon.Text = "";
            txtTenMon.Text = "";
            txtGiaMon.Text = "";
        }

        private void setButtonLoai(bool val)
        {
            btnThemLoai.Enabled = val;
            btnSuaLoai.Enabled = val;
            btnXoaLoai.Enabled = val;
            btnSaveLoai.Enabled = !val;
            btnNotSaveLoai.Enabled = !val;
        }
        private void setButtonMenu(bool val)
        {
            btnThemMon.Enabled = val;
            btnSuaMon.Enabled = val;
            btnXoaMon.Enabled = val;
            btnLuuMon.Enabled = !val;
            btnKoLuuMon.Enabled = !val;
        }

        private void ThemLoai()
        {
            setNullLoai();
            setButtonLoai(false);
            addnewLNL = true;
        }
        private void SuaLoai()
        {
            setNullLoai();
            setButtonLoai(false);
            addnewLNL = false;
        }

        private void xoaLoai()
        {
            bool delete = false;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                if (lsvLoaiMon.SelectedItems.Count > 0)
                {
                    int ID = Convert.ToInt32(lsvLoaiMon.SelectedItems[0].SubItems[1].Text);
                    Models.LOAIMON loai = db.LOAIMON.FirstOrDefault(c => c.MaLoaiMon == ID);

                    loai.LMstatus = false;
                    delete = true;
                    setNullLoai();
                }
                db.SaveChanges();
            }
            if (delete == false)
            {
                MessageBox.Show("Xóa không thành công! Vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Hoàn tất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            loadLoaiMon();
        }
        private void SaveLoai()
        {
            bool save = false;
            bool exist = false;
            bool textNull = true;

            List<Models.LOAIMON> lstLoai = db.LOAIMON.ToList();
            if (txtMaLoaiMon.Text != "" && txtTenLoaiMon.Text != "")
            {
                textNull = false;
                foreach (Models.LOAIMON item in lstLoai)
                {
                    if (txtMaLoaiMon.Text == item.MaLoaiMon.ToString())
                    {
                        exist = true;
                    }
                }

            }

            if (textNull == false)
            {
                if (addnewLNL == true)
                {
                    if (exist == false)
                    {
                        LoaiMon.MaLoaiMon = Int32.Parse(txtMaLoaiMon.Text);
                        LoaiMon.TenLoaiMon = txtTenLoaiMon.Text;
                        LoaiMon.LMstatus = true;
                        db.LOAIMON.Add(LoaiMon);
                        save = true;
                    }
                }
                else
                {
                    //int ID = Convert.ToInt32(txtMaLoaiMon.Text);
                    //LoaiMon = db.LOAIMON.FirstOrDefault(c => c.MaLoaiMon == ID);
                    string ID = lsvLoaiMon.SelectedItems[0].SubItems[0].Text;
                    LoaiMon = db.LOAIMON.FirstOrDefault(c => string.Compare(c.MaLoaiMon.ToString(), ID) == 0);
                    LoaiMon.TenLoaiMon = txtTenLoaiMon.Text;
                    save = true;
                    exist = false;

                }
            }
            if (save == true)
            {
                db.SaveChanges();
                MessageBox.Show("Hoàn tất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                setNullLoai();
                setButtonLoai(true);
            }
            if (textNull == true)
            {
                MessageBox.Show("Bạn phải điền đủ và đúng thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            if (exist == true)
            {
                MessageBox.Show("Mã đang tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            loadLoaiMon();
        }

        private void noSaveLoai(bool nonsave)
        {
            if (nonsave == true)
            {
                setNullLoai();
                setButtonLoai(true);
                MessageBox.Show("Đã hủy thao tác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                setNullLoai();
                setButtonLoai(true);
            }
        }

        private void btnThemLoai_Click(object sender, EventArgs e)
        {
            ThemLoai();
        }

        private void btnSuaLoai_Click(object sender, EventArgs e)
        {
            SuaLoai();
        }

        private void btnXoaLoai_Click(object sender, EventArgs e)
        {
            xoaLoai();
        }

        private void btnSaveLoai_Click(object sender, EventArgs e)
        {
            SaveLoai();
        }

        private void btnNotSaveLoai_Click(object sender, EventArgs e)
        {
            noSaveLoai(false);
        }

        private void lsvLoaiMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            showLoai();
        }

        private void comboLoai()
        {
            List<LOAIMON> listLoai = db.LOAIMON.ToList();        
             cbLoaiMon.DataSource = listLoai;
             cbLoaiMon.DisplayMember ="TenLoaiMon";
            cbLoaiMon.ValueMember = "MaLoaiMon";
             
        }

        private  void themMon()
        {
            setNullMenu();
            setButtonMenu(false);
            addnewMenu = true;
        }
        private void suaMon()
        {
            setNullMenu();
            setButtonMenu(false);
            addnewMenu = false;
        }
        private void xoaMon()
        {
            bool delete = false;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                if (lsvMenuMon.SelectedItems.Count > 0)
                {
                    string ID = lsvMenuMon.SelectedItems[0].SubItems[0].Text;
                    Models.MONAN loai = db.MONAN.FirstOrDefault(c =>string.Compare(c.MaMon,ID)==0);

                    loai.MAstatus = false;
                    delete = true;
                    setNullLoai();
                }
                db.SaveChanges();
            }
            if (delete == false)
            {
                MessageBox.Show("Xóa không thành công! Vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Hoàn tất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            loadLoaiMon();
        }

        private void saveMonAn()
        {
            bool save = false;
            bool exist = false;
            bool textNull = true;

            LOAIMON loaimon = cbLoaiMon.SelectedValue as LOAIMON;
            List<MONAN> listMenu = db.MONAN.ToList();
            if(txtMaMon.Text !="" && txtTenMon.Text !="" && txtGiaMon.Text !="" && cbLoaiMon.SelectedValue != null)
            {
                textNull = false;
                foreach(MONAN item in listMenu)
                {
                    if(txtMaMon.Text== item.MaMon)
                    {
                        exist = true;
                    }
                }
            }
            if (textNull == false)
            {
                if(addnewMenu == true)
                {
                    if(exist== false)
                    {
                        MenuMon.MaMon = txtMaMon.Text;
                        MenuMon.TenMon = txtTenMon.Text;
                        MenuMon.MaLoaiMon = loaimon.MaLoaiMon;
                        MenuMon.Gia = Decimal.Parse(txtGiaMon.Text);
                        MenuMon.MAstatus = true;
                        db.MONAN.Add(MenuMon);
                        save = true;
                    }
                }
                else
                {
                    MONAN edit = db.MONAN.FirstOrDefault(c => c.MaMon == txtMaMon.Text);
                    edit.TenMon = txtTenMon.Text;
                    edit.Gia = decimal.Parse(txtGiaMon.Text);
                    edit.MaLoaiMon = loaimon.MaLoaiMon;
                    save = true;
                    exist = false;
                }
            }
            if(save== true)
            {
                db.SaveChanges();
                MessageBox.Show("Hoàn tất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                setNullMenu();
                setButtonMenu(true);
            }
            if (textNull == true)
            {
                MessageBox.Show("Bạn phải điền đủ và đúng thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            if (exist == true)
            {
                MessageBox.Show("Mã  đang tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            loadMenu();
        }
        private void noSaveM(bool nosave)
        {
            if (nosave == true)
            {
                setNullMenu();            
                setButtonMenu(true);
                MessageBox.Show("Đã hủy thao tác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                setNullMenu();
                setButtonMenu(true);
            }
        }
        private void autoLoai()
        {
            List<LOAIMON> listLoai = db.LOAIMON.ToList();
            foreach(LOAIMON item in listLoai)
            {
                if(item.LMstatus== true)
                {
                    txtFindLoaiMon.AutoCompleteCustomSource.Add(item.MaLoaiMon.ToString());
                    txtFindLoaiMon.AutoCompleteCustomSource.Add(item.TenLoaiMon);

                }
            }
        }
        private void autoMenu()
        {
            List<MONAN> listMenu = db.MONAN.ToList();
            foreach(MONAN item in listMenu)
            {
                if(item.MAstatus== true)
                {
                    txtFindMenu.AutoCompleteCustomSource.Add(item.MaMon);
                    txtFindMenu.AutoCompleteCustomSource.Add(item.TenMon);
                    txtFindMenu.AutoCompleteCustomSource.Add(item.Gia.ToString());
                }
            }
        }
        private void btnThemMon_Click(object sender, EventArgs e)
        {
            themMon();
        }

        private void btnSuaMon_Click(object sender, EventArgs e)
        {
            suaMon();
        }

        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            xoaMon();
        }

        private void btnLuuMon_Click(object sender, EventArgs e)
        {
            saveMonAn();
        }

        private void btnKoLuuMon_Click(object sender, EventArgs e)
        {
            noSaveM(false);
        }
        private void findLoai()
        {
            List<LOAIMON> listlm = db.LOAIMON.ToList();
            if (txtFindLoaiMon.Text != "")
            {
                string info = txtFindLoaiMon.Text;
                foreach (LOAIMON lnl in listlm)
                {
                    if (string.Compare(info, lnl.MaLoaiMon.ToString(), true) == 0 || string.Compare(info, lnl.TenLoaiMon, true) == 0)
                    {
                        lsvLoaiMon.Items.Clear();

                        if (lnl.LMstatus == true)
                        {
                            string[] ds = { lnl.MaLoaiMon.ToString(), lnl.TenLoaiMon };
                            ListViewItem item = new ListViewItem(ds);
                            lsvLoaiMon.Items.Add(item);
                        }
                    }
                }
            }
            else
            {
                lsvLoaiMon.Items.Clear();
                loadLoaiMon();
            }
        }
        private void findMon()
        {
            List<MONAN> listlm = db.MONAN.ToList();
            if (txtFindMenu.Text != "")
            {
                string info = txtFindMenu.Text;
                foreach (MONAN lnl in listlm)
                {
                    if (string.Compare(info, lnl.MaMon.ToString(), true) == 0 || string.Compare(info, lnl.TenMon, true) == 0 || string.Compare(info,lnl.Gia.ToString(),true)==0)
                    {
                        lsvMenuMon.Items.Clear();

                        if (lnl.MAstatus == true)
                        {
                            string[] ds = {lnl.MaMon,lnl.TenMon,lnl.LOAIMON.ToString(),lnl.Gia.ToString()};
                            ListViewItem item = new ListViewItem(ds);
                            lsvMenuMon.Items.Add(item);
                        }
                    }
                }
            }
            else
            {
                lsvMenuMon.Items.Clear();
                loadMenu();
            }
        }

        private void txtFindMenu_TextChanged(object sender, EventArgs e)
        {
            findMon();
        }

        private void txtFindLoaiMon_TextChanged(object sender, EventArgs e)
        {
            findLoai();
        }

        private void lsvMenuMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            showMenu();
        }
    }

}

